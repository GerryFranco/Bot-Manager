//BotImplementer.cpp - Implements a bot.
#include "stdafx.h"
#include <msclr/marshal_cppstd.h>
#include "BotImplementer.h"


namespace Bots
{
	namespace Managed
	{
		/*
		DEFAULT CONSTRUCTOR
		*/
		BotImplementer::BotImplementer()
		{

		}


		/*
		CONSTRUCTOR
		*/
		BotImplementer::BotImplementer(System::String^ nameArg, Bots::Interfaces::BotType typeArg)
		{
			//marshal managed string to native string
			msclr::interop::marshal_context ctx;
			std::string nativeName = ctx.marshal_as<std::string>(nameArg);

			//create the native bot 
			_nativeBot = new BotsNative::Bot(nativeName, static_cast<BotsNative::BotType>(typeArg));

			//set managed properties from the new native bot
			_name = gcnew System::String(_nativeBot->GetName().c_str());
			_type = static_cast<Bots::Interfaces::BotType>(_nativeBot->GetType());

			//setup events
			SetupEvents();
		}


		/*
		DESTRUCTOR
		*/
		BotImplementer::~BotImplementer()
		{
			if (_nativeBot != nullptr)
			{
				delete _nativeBot;
				_nativeBot = nullptr;
			}
		}


		/*
		GETTASKS - Get's the bot's task queue.
		*/
		System::Collections::Generic::Queue<Bots::Interfaces::BotTask>^ BotImplementer::GetTasks()
		{
			std::queue<BotsNative::BotTask> nativeTasks = _nativeBot->GetTaskList();
			int taskCount = nativeTasks.size();
			
			//convert the native queue to managed
			System::Collections::Generic::Queue<Bots::Interfaces::BotTask>^ tasks = gcnew System::Collections::Generic::Queue<Bots::Interfaces::BotTask>();
			for (int i = 0; i < taskCount; i++)
			{
				tasks->Enqueue(static_cast<Bots::Interfaces::BotTask>(nativeTasks.front()));
				nativeTasks.pop();
			}

			return tasks;
		}


		/*
		ASSIGNTASK - Assigns a bot task to a queue. Return true if successful, false otherwise.
		*/
		bool BotImplementer::AssignTask(Bots::Interfaces::BotTask taskArg)
		{
			return _nativeBot->AssignTask(static_cast<BotsNative::BotTask>(taskArg));
		}


		/*
		POWEROFF - Powers off the bot. The current task is allowed to complete, pending tasks get stored until next time.
				   Return true if successful, false otherwise.
		*/
		bool BotImplementer::PowerOff()
		{
			return _nativeBot->PowerOff();
		}


		/*
		SETUPEVENTS - Sets up cross-thread events.
		*/
		void BotImplementer::SetupEvents()
		{
			//marshal delegate to native event source by converting it into a function pointer
			TaskUpdateCallback^ functionPointer = gcnew TaskUpdateCallback(this, &BotImplementer::FireOnTaskUpdate);
			System::Runtime::InteropServices::GCHandle gch = System::Runtime::InteropServices::GCHandle::Alloc(functionPointer);
			System::IntPtr ip = System::Runtime::InteropServices::Marshal::GetFunctionPointerForDelegate(functionPointer);

			//provide the native instance with function pointer to trigger the managed delegate
			_nativeBot->TaskUpdateCallback = static_cast<BotsNative::Bot::TASKUPDATECALLBACK>(ip.ToPointer());
		}


		/*
		FIREONTASKUPDATE - Raises an event for bot task updates.
		*/
		void BotImplementer::FireOnTaskUpdate(std::string nameArg, BotsNative::BotType typeArg, BotsNative::BotTask taskArg, BotsNative::BotTaskStatus taskStatusArg)
		{
			System::String^ mString = gcnew System::String(nameArg.c_str());
			TaskUpdate(this, gcnew Bots::Interfaces::BotTaskUpdateEventArgs(mString, static_cast<Bots::Interfaces::BotType>(typeArg), 
				static_cast<Bots::Interfaces::BotTask>(taskArg), static_cast<Bots::Interfaces::BotTaskStatus>(taskStatusArg)));
		}
	}
}

