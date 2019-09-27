//InterfaceFactory.cpp - Implements a factory for creating Bots interfaces
#include "Stdafx.h"
#include "InterfaceFactory.h"
#include "BotManagerImplementer.h"


namespace Bots
{
	/*
	CONSTRUCTOR
	*/
	InterfaceFactory::InterfaceFactory()
	{

	}


	/*
	CREATEIBOTMANAGER - Creates an interface for bots management
	*/
	Bots::Interfaces::IBotManager^ InterfaceFactory::CreateIBotManager()
	{
		return gcnew Bots::Managed::BotManagerImplementer();
	}
}