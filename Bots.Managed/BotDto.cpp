//BotDto.cpp - Implements the bot data transfer object used for storing to a file of for serialization.
#include "Stdafx.h"
#include "BotDto.h"


namespace Bots
{
	namespace Managed
	{
		/*
		CONSTRUCTOR PARAMETER-LESS
		*/
		BotDto::BotDto()
		{
		}
		
		/*
		CONSTRUCTOR
		*/
		BotDto::BotDto(System::String^ nameArg, Bots::Interfaces::BotType typeArg)
		{
			Name = nameArg;
			Type = typeArg;
		}
	}
}