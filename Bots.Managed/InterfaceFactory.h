//InterfaceFactory - Defines a factory for Bots interfaces and serves as the main entry point for the bots library
#pragma once

#ifndef MANAGEDINTERFACEFACTORY_H
#define MANAGEDINTERFACEFACTORY_H TRUE

namespace Bots
{
	public ref class InterfaceFactory
	{
	public:

		//constructor
		InterfaceFactory();
		
		//creates an interface for bots management
		Bots::Interfaces::IBotManager^ CreateIBotManager();
	};
}
#endif