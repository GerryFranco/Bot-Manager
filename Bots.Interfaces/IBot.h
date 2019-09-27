//IBot.h - Defines a bot interface.
#pragma once

#ifndef IBOT_H
#define IBOT_H TRUE

#ifndef BOTTYPE_H
#include "BotType.h"
#endif

#ifndef BOTTASK_H
#include "BotTask.h"
#endif

#ifndef BOTTASKUPDATEEVENTARGS_H
#include "BotTaskUpdateEventArgs.h"
#endif

namespace Bots
{
	namespace Interfaces
	{
		/// <summary>
		/// Main bot interface.
		/// </summary>
		public interface class IBot
		{
			/// <summary>
			/// The bot's name.
			/// </summary>
			property System::String^ Name { System::String^ get(); };

			/// <summary>
			/// The bot's type.
			/// </summary>
			property BotType Type { BotType get(); };

			/// <summary>
			/// Gets the bot's task queue
			/// </summary>
			/// <returns>
			/// Returns a queue
			/// </returns>
			System::Collections::Generic::Queue<BotTask>^ GetTasks();

			/// <summary>
			/// Assigns a bot task to a queue. 
			/// </summary>
			/// <returns>
			/// True if successful, false otherwise.
			/// </returns>
			bool AssignTask(BotTask taskArg);

			/// <summary>
			/// Powers off the bot. The current task is allowed to complete and pending tasks saved for next time.
			/// </summary>
			/// <returns>
			/// True if successful, false otherwise.
			/// </returns>
			bool PowerOff();

			/// <summary>
			/// Fires an event for task updates
			/// </summary>
			event System::EventHandler<BotTaskUpdateEventArgs^>^ TaskUpdate;
		};
	}
}
#endif