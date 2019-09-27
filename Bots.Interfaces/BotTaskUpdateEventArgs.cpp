//BotTaskUpdateEventArgs.cpp - Implements event args for bot task update events
#include "Stdafx.h"
#include "BotTaskUpdateEventArgs.h"


namespace Bots
{
	namespace Interfaces
	{
		BotTaskUpdateEventArgs::BotTaskUpdateEventArgs(System::String^ nameArg, BotType typeArg, BotTask taskArg, BotTaskStatus taskStatusArg)
		{
			_name = nameArg;
			_type = typeArg;
			_task = taskArg;
			_taskStatus = taskStatusArg;
		}
	}
}