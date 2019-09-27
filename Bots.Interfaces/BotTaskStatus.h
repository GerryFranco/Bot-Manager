//BotTaskStatus.h - Specifies bot task status.
#pragma once

#ifndef BOTTASKSTATUS_H
#define BOTTASKSTATUS_H TRUE

namespace Bots
{
	namespace Interfaces
	{
		/// <summary>
		/// Specifies bot task status.
		/// </summary>
		public enum class BotTaskStatus
		{
			Started = 0,
			Completed = 1
		};
	}
}
#endif