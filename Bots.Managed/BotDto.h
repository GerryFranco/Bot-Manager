//BotDto.h - Defines the bot data transfer object used for storing to a file or for serialization.
#pragma once

#ifndef MANAGEDBOTDTO_H
#define MANAGEDBOTDTO_H TRUE

namespace Bots
{
	namespace Managed
	{
		ref struct BotDto
		{
		public:

			System::String^ Name;
			Bots::Interfaces::BotType Type;
			array<Bots::Interfaces::BotTask>^ PendingTasks;

			//parameter-less constructor
			BotDto::BotDto();

			//constructor
			BotDto::BotDto(System::String^ nameArg, Bots::Interfaces::BotType typeArg);
		};
	}
}
#endif
