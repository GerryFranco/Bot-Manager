//BotManagerImplementer.h - Defines the implementation of IBotManager.
#pragma once

#ifndef MANAGEDBOTMANAGERIMPLEMENTER_H
#define MANAGEDBOTMANAGERIMPLEMENTER_H TRUE

#ifndef MANAGEDBOTDTO_H
#include "BotDto.h"
#endif

namespace Bots
{
	namespace Managed
	{
		ref class BotManagerImplementer : Bots::Interfaces::IBotManager
		{
		internal:

			/*
			DEFAULT CONSTRUCTOR
			*/
			BotManagerImplementer();


			/*
			DESTRUCTOR
			*/
			~BotManagerImplementer();

		private:

			System::Collections::Generic::List<Bots::Interfaces::IBot^>^ botList;
			System::String^ botFilePath;
			System::Web::Script::Serialization::JavaScriptSerializer^ jsonSerializer;

			/*
			INITIALIZEBOTFILE - Creates the JSON bot file if it doesn't exist.
			*/
			void IntializeBotFile();


			/*
			GETBOTLISTFROMFILE - Gets the bot list from a JSON file.
			*/
			System::Collections::Generic::List<BotDto^>^ GetBotListFromFile();


			/*
			SAVEBOTLISTTOFILE - Saves the bot list to a JSON file.
			*/
			bool SaveBotListToFile();

		public:

			/*
			CONNECTTOBOT - Connects to a bot.
			*/
			virtual Bots::Interfaces::IBot^ ConnectToBot(System::String^ nameArg, Bots::Interfaces::BotType typeArg);


			/*
			GETBOTLIST - Returns the list of active bots.
			*/
			virtual System::Collections::Generic::List<Bots::Interfaces::IBot^>^ GetBotList();


			/*
			ADDBOTTOLIST - Adds a bot to the list of active bots. A bot cannot have the same name as another active bot. 
						   Returns true if successful, false otherwise.
			*/
			virtual bool AddBotToList(Bots::Interfaces::IBot^ botArg);


			/*
			DELETEBOTFROMLIST - Deletes a bot from the list of active bots.
								Returns true if successful, false otherwise.
			*/
			virtual bool DeleteBotFromList(Bots::Interfaces::IBot^ botArg);


			/*
			SAVEBOTLIST - Saves the current bot list.
			*/
			virtual bool SaveBotList();
		};
	}
}
#endif