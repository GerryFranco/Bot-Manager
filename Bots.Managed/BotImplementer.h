//BotImplementer.h - Defines the implementation of a bot.
#pragma once

#ifndef MANAGEDBOTIMPLEMENTER_H
#define MANAGEDBOTIMPLEMENTER_H TRUE

#include "Bots.Native\Bot.h"
#include <memory>

namespace Bots 
{
	namespace Managed
	{
		ref class BotImplementer : Bots::Interfaces::IBot
		{
		private:

			//callback native
			delegate void TaskUpdateCallback(std::string nameArg, BotsNative::BotType typeArg, 
				BotsNative::BotTask taskArg, BotsNative::BotTaskStatus taskStatusArg);

		internal:

			//pointer to native bot object
			BotsNative::Bot* _nativeBot = nullptr;
			
			//internal variables
			System::String^ _name;
			Bots::Interfaces::BotType _type;
			System::Collections::Generic::Queue<Bots::Interfaces::BotTask>^ _tasks;

			/*
			DEFAULT CONSTRUCTOR
			*/
			BotImplementer();

			/*
			CONSTRUCTOR
			*/
			BotImplementer(System::String^ nameArg, Bots::Interfaces::BotType typeArg);

			/*
			DESTRUCTOR
			*/
			~BotImplementer();

			/*
			SETUPEVENTS - Sets up cross-thread events.
			*/
			void SetupEvents();

			/*
			FIREONTASKUPDATE - Raises an event for bot task updates.
			*/
			void FireOnTaskUpdate(std::string nameArg, BotsNative::BotType typeArg, 
				BotsNative::BotTask taskArg, BotsNative::BotTaskStatus taskStatusArg);
			
		public:

			/*
			NAME
			*/
			property System::String^ Name
			{
				virtual System::String^ get()
				{
					return _name;
				}
			}


			/*
			BOTTYPE
			*/
			property Bots::Interfaces::BotType Type
			{
				virtual Bots::Interfaces::BotType get()
				{
					return _type;
				}
			}


			/*
			GETTASKS - Get's the bot's task queue.
			*/
			virtual System::Collections::Generic::Queue<Bots::Interfaces::BotTask>^ GetTasks();
			

			/*
			ASSIGNTASK - Assigns a bot task to a queue. Return true if successful, false otherwise.        
			*/
			virtual bool AssignTask(Bots::Interfaces::BotTask taskArg);


			/*
			POWEROFF - Powers off the bot. The current task is aborted, pending tasks get stored until next time. 
			           Return true if successful, false otherwise.
			*/
			virtual bool PowerOff();


			/*
			TASKUPDATE - An event that fires for bot task updates.
			*/
			virtual event System::EventHandler<Bots::Interfaces::BotTaskUpdateEventArgs^>^ TaskUpdate;
		};
	}
}
#endif