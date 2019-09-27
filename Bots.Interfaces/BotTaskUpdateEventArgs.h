//BotTaskUpdateEventArgs.h - defines the arguments for a bot task update event
#pragma once

#ifndef BOTTASKUPDATEEVENTARGS_H
#define BOTTASKUPDATEEVENTARGS_H TRUE

#ifndef BOTTYPE_H
#include "BotType.h"
#endif

#ifndef BOTTASK_H
#include "BotTask.h"
#endif

#ifndef BOTTASKSTATUS_H
#include "BotTaskStatus.h"
#endif

namespace Bots
{
	namespace Interfaces
	{
		public ref class BotTaskUpdateEventArgs : System::EventArgs
		{
		private:

			System::String^ _name;
			BotType _type;
			BotTask _task;
			BotTaskStatus _taskStatus;

		public:

			BotTaskUpdateEventArgs(System::String^ nameArg, BotType typeArg, BotTask taskArg, BotTaskStatus taskStatusArg);

			property System::String^ Name
			{
				System::String^ get()
				{
					return _name;
				}
			}

			property BotType Type
			{
				BotType get()
				{
					return _type;
				}
			}

			property BotTask Task
			{
				BotTask get()
				{
					return _task;
				}
			}

			property BotTaskStatus TaskStatus
			{
				BotTaskStatus get()
				{
					return _taskStatus;
				}
			}
		};
	}
}
#endif