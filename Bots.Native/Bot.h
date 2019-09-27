//Bot.h - Defines a native bot interface.
//Note: C++ tends to be unfriendly when it comes to abstraction, but it's possible to create clean and stable interfaces
//      and also hide all implementation details (secrets) by creating an "interface class" and "implementation class" where all public
//      methods are exposed and a single data member points to the implementation. This is known as the PIMPL idiom.
#pragma once

#ifndef BOTSNATIVE_BOT_H
#define BOTSNATIVE_BOT_H TRUE

#ifndef BOTSNATIVE_BOTTYPE_H
#include "BotType.h"
#endif

#ifndef BOTSNATIVE_BOTTASK_H
#include "BotTask.h"
#endif

#ifndef BOTSNATIVE_BOTTASKSTATUS_H
#include "BotTaskStatus.h"
#endif

#include <string>
#include <memory>
#include <queue>


namespace BotsNative
{
	//a Bot interface for native clients
	class __declspec(dllexport) Bot
	{
	public:

		//callback for task update
		typedef bool(__stdcall *TASKUPDATECALLBACK)(std::string nameArg, BotType typeArg, BotTask taskArg, BotTaskStatus taskStatusArg);
		TASKUPDATECALLBACK TaskUpdateCallback;

		//constructor
		Bot(std::string nameArg, BotType typeArg);
		
		//destructor
		~Bot();

		//get bot name
		std::string GetName();

		//get bot type
		BotType GetType();

		//assigns a bot task to a queue
		bool AssignTask(BotTask taskArg);

		//returns the active task list
		std::queue<BotTask> GetTaskList();

		//powers off the bot, the current task is allowed to complete before powering off, pending tasks discarded
		//note: XML could be used to store a pending task list, but for now, it's up to the library consumer to handle this
		bool PowerOff();

	private:

		//pimpl 
		class BotImpl;
		std::unique_ptr<BotImpl> impl;
	};
}
#endif
