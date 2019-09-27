//Bot.cpp : Implements a Bot interface using pimpl.
//Note: Ideally, we should split the impl class from the interface implementation as the business logic becomes large and complex,
//      but for this project, we can combine them in a single file for now.
#include "stdafx.h"
#include "Bot.h"
#include <thread>
#include <queue>


namespace BotsNative
{
	//PIMPL class
	class Bot::BotImpl
	{
	public:

		//IMPL CTOR
		BotImpl(std::string nameArg, BotType typeArg, Bot* botInstanceArg)
		{
			_name = nameArg;
			_type = typeArg;
			_botInstance = botInstanceArg;

			//set the task loop flag to true
			_taskLoop = true;

			//create the task thread
			std::thread taskThread(&BotImpl::TaskLoop, this);
			taskThread.detach();
		}

		//GETNAME
		std::string GetName()
		{
			return _name;
		}

		//GETTYPE
		BotType GetType()
		{
			return _type;
		}

		//ASSIGNTASK
		bool AssignTask(BotTask taskArg)
		{
			_taskQueue.push(taskArg);
			return true;
		}

		//GETTASKLIST
		std::queue<BotTask> GetTaskList()
		{
			return _taskQueue;
		}

		//POWEROFF
		bool PowerOff()
		{
			_taskLoop = false;
			return true;
		}


	private:

		Bot* _botInstance;
		std::string _name;
		BotType _type;
		bool _taskLoop;
		std::queue<BotTask> _taskQueue;

		//TASKLOOP
		void TaskLoop()
		{
			while (_taskLoop)
			{
				if (!_taskQueue.empty())
				{
					//fire started event
					_botInstance->TaskUpdateCallback(_name, _type, _taskQueue.front(), BotTaskStatus::Started);
					
					//do task waiting in queue
					DoTask(_taskQueue.front());

					//store temp value before popping
					BotTask completedTask = _taskQueue.front();

					//remove task from task list
					_taskQueue.pop();

					//fire completed event
					_botInstance->TaskUpdateCallback(_name, _type, completedTask, BotTaskStatus::Completed);

					
				}

				Sleep(100);
			}
		}

		//DOTASK
		bool DoTask(BotTask taskArg)
		{
			//Sse a switch statement instead of if statements as the number of if branches
			//possible has a limit in C++. More complex programs can have hundreds of if scenarios.
			switch (taskArg)
			{
			case BotTask::DoTheDishes:

				return DoTheDishes();

			case BotTask::SweepTheHouse:

				return SweepTheHouse();

			case BotTask::DoTheLaundry:

				return DoTheLaundry();

			case BotTask::TakeOutTheRecycling:

				return TakeOutTheRecycling();

			case BotTask::MakeASammich:

				return MakeASammich();

			case BotTask::MowTheLawn:

				return MowTheLawn();

			case BotTask::RakeTheLeaves:

				return RakeTheLeaves();

			case BotTask::GiveTheDogABath:

				return GiveTheDogABath();

			case BotTask::BakeSomeCookies:

				return BakeSomeCookies();

			case BotTask::WashTheCar:

				return WashTheCar();

			default:
				return false;
			}
		}

		//DO DISHES
		bool DoTheDishes()
		{
			Sleep(1000);
			return true;
		}

		//SWEEPTHEHOUSE
		bool SweepTheHouse()
		{
			Sleep(3000);
			return true;
		}

		//DOTHELAUNDRY
		bool DoTheLaundry()
		{
			Sleep(10000);
			return true;
		}

		//TAKEOUTTHERECYCLING
		bool TakeOutTheRecycling()
		{
			Sleep(4000);
			return true;
		}

		//MAKEASAMMICH
		bool MakeASammich()
		{
			Sleep(7000);
			return true;
		}

		//MOWTHELAWN
		bool MowTheLawn()
		{
			Sleep(20000);
			return true;
		}

		//RAKETHELEAVES
		bool RakeTheLeaves()
		{
			Sleep(18000);
			return true;
		}

		//GIVETHEDOGABATH
		bool GiveTheDogABath()
		{
			Sleep(14500);
			return true;
		}

		//BAKESOMECOOKIES
		bool BakeSomeCookies()
		{
			Sleep(8000);
			return true;
		}

		//WASHTHECAR
		bool WashTheCar()
		{
			Sleep(20000);
			return true;
		}
	};


	/*
	CONSTRUCTOR
	*/
	Bot::Bot(std::string nameArg, BotType typeArg)
	{
		impl = std::make_unique<BotImpl>(nameArg, typeArg, this);
	}


	/*
	DESTRUCTOR
	*/
	Bot::~Bot()
	{
		//no need to cleanup implementation object as we're using a smart pointer
	}


	/*
	GETNAME
	*/
	std::string Bot::GetName()
	{
		return impl->GetName();
	}


	/*
	GETTYPE
	*/
	BotType Bot::GetType()
	{
		return impl->GetType();
	}


	/*
	ASSIGNTASK - Assigns a complex bot task to a queue
	*/
	bool Bot::AssignTask(BotTask taskArg)
	{
		return impl->AssignTask(taskArg);
	}


	/*
	GETTASKLIST - Returns the active task list
	*/
	std::queue<BotTask> Bot::GetTaskList()
	{
		return impl->GetTaskList();
	}


	/*
	POWEROFF - Powers off the bot, the current task is allowed to complete and pending tasks discarded
	           note: XML could be used to store a pending task list, but for now, it's up to the library consumer to handle this
	*/
	bool Bot::PowerOff()
	{
		return impl->PowerOff();
	}
}


