//BotManagerImplementer.cpp - Implements IBotManager.
#include "stdafx.h"
#include "BotManagerImplementer.h"
#include "BotImplementer.h"
#include "BotDto.h"


namespace Bots
{
	namespace Managed
	{
		/*
		DEFAULT CONSTRUCTOR
		*/
		BotManagerImplementer::BotManagerImplementer()
		{
			//set the JSON file path and instantiate the JSON serializer
			botFilePath = gcnew System::String("BotsLog.json");
			jsonSerializer = gcnew System::Web::Script::Serialization::JavaScriptSerializer();

			//get the bot list from file
			System::Collections::Generic::List<BotDto^>^ dtoList = GetBotListFromFile();

			//create active bot interfaces from stored bot data
			botList = gcnew System::Collections::Generic::List<Bots::Interfaces::IBot^>();
			for (int i = 0; i < dtoList->Count; i++)
			{
				//create bot instance by "connecting to a bot"
				Bots::Interfaces::IBot^ bot = ConnectToBot(dtoList[i]->Name, dtoList[i]->Type);
				
				//assing any pending tasks
				for (int j = 0; j < dtoList[i]->PendingTasks->Length; j++)
				{
					bot->AssignTask(dtoList[i]->PendingTasks[j]);
				}
				
				//add the bot instance to list of active bots
				botList->Add(bot);
			}
		}


		/*
		DESTRUCTOR
		*/
		BotManagerImplementer::~BotManagerImplementer()
		{
			
		}


		/*
		INITIALIZEBOTFILE - Creates the JSON bot file if it doesn't exist.
		*/
		void BotManagerImplementer::IntializeBotFile()
		{
			//check if file exists, otherwise create it
			if (!System::IO::File::Exists(botFilePath))
			{
				System::Collections::Generic::List<BotDto^>^ emptyLog = gcnew System::Collections::Generic::List<BotDto^>();
				System::String^ json = jsonSerializer->Serialize(emptyLog);
				System::IO::File::WriteAllText(botFilePath, json);
			}
		}


		/*
		GETBOTLISTFROMFILE - Gets the bot list from the JSON file.
		*/
		System::Collections::Generic::List<BotDto^>^ BotManagerImplementer::GetBotListFromFile()
		{
			//init bot file
			IntializeBotFile();

			//parse the JSON file and deserialize into a list of DTOs 
			System::String^ jsonFilePath = System::IO::File::ReadAllText(botFilePath);
			System::Collections::Generic::List<BotDto^>^ dtoList = gcnew System::Collections::Generic::List<BotDto^>();
			dtoList = jsonSerializer->Deserialize<System::Collections::Generic::List<BotDto^>^>(jsonFilePath);

			return dtoList;
		}


		/*
		SAVEBOTLISTTOFILE - Saves the bot list to a JSON file.
		*/
		bool BotManagerImplementer::SaveBotListToFile()
		{
			//init bot file
			IntializeBotFile();

			//save active bots to file
			System::Collections::Generic::List<BotDto^>^ dtoList = gcnew System::Collections::Generic::List<BotDto^>();
			for (int i = 0; i < botList->Count; i++)
			{
				//convert IBot to BotDto
				BotDto^ botDto = gcnew BotDto(botList[i]->Name, botList[i]->Type);

				//save pending tasks
				System::Collections::Generic::Queue<Bots::Interfaces::BotTask>^ botTasks = botList[i]->GetTasks();
				botDto->PendingTasks = gcnew array<Bots::Interfaces::BotTask>(botTasks->Count);
				for (int j = 0; j < botDto->PendingTasks->Length; j++)
				{
					botDto->PendingTasks[j] = botTasks->Peek();
					botTasks->Dequeue();
				}

				//add the bot to the list
				dtoList->Add(botDto);
			}

			//serialize the updated list to JSON
			System::String^ json = jsonSerializer->Serialize(dtoList);

			//write to file
			try
			{
				System::IO::File::WriteAllText(botFilePath, json);
			}
			catch (System::Exception^ e)
			{
				return false;
			}

			return true;
		}


		/*
		CONNECTOBOT - Connects to a bot.
		*/
		Bots::Interfaces::IBot^ BotManagerImplementer::ConnectToBot(System::String^ nameArg, Bots::Interfaces::BotType typeArg)
		{
			return gcnew Bots::Managed::BotImplementer(nameArg, typeArg);
		}


		/*
		GETBOTLIST - Returns the list of active bots.
		*/
		System::Collections::Generic::List<Bots::Interfaces::IBot^>^ BotManagerImplementer::GetBotList()
		{
			return botList;
		}


		/*
		ADDBOTTOLIST - Adds a bot to the active bots list. A bot cannot have the same name.
		Returns true if successful, false otherwise.
		*/
		bool BotManagerImplementer::AddBotToList(Bots::Interfaces::IBot^ botArg)
		{
			//verify the bot doesn't already exist in the list
			bool exists = false;
			for (int i = 0; i < botList->Count; i++)
			{
				if (botList[i]->Name->Equals(botArg->Name))
				{
					return false;
				}
			}
			
			//add bot
			botList->Add(botArg);

			return true;
		}


		/*
		DELETEBOTFROMLIST - Deletes a bot from the list of bots.
		                    Returns true if successful, false otherwise.
		*/
		bool BotManagerImplementer::DeleteBotFromList(Bots::Interfaces::IBot^ botArg)
		{
			//verify bot exists in the list
			int botIndex = -1;
			bool exists = false;
			for (int i = 0; i < botList->Count; i++)
			{
				if (botList[i]->Name->Equals(botArg->Name))
				{
					botIndex = i;
					exists = true;
				}
			}

			//if it doesn't exists, return false
			if (!exists)
			{
				return false;
			}

			//remove the active bot
			botList->RemoveAt(botIndex);

			return true;
		}


		/*
		SAVEBOTLIST - Saves the current bot list.
		*/
		bool BotManagerImplementer::SaveBotList()
		{
			return SaveBotListToFile();
		}
	}
}

