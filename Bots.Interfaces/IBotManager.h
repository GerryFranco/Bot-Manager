//IBotManager.h - Defines a bot manager interface.
#pragma once

#ifndef IBOTMANAGER_H
#define IBOTMANAGER_H TRUE

#ifndef IBOT_H
#include "IBot.h"
#endif

namespace Bots
{
	namespace Interfaces
	{
		/// <summary>
		/// Main bot manager interface.
		/// </summary>
		public interface class IBotManager
		{
			/// <summary>
			///  Connects to a bot.
			/// </summary>
			/// <returns>
			/// Returns a bot interface IBot.
			/// </returns>
			IBot^ ConnectToBot(System::String^ nameArg, BotType typeArg);

			/// <summary>
			/// Gets a list of actively connected bots to manage.
			/// </summary>
			/// <returns>
			/// Returns a List of IBot.
			/// </returns>
			System::Collections::Generic::List<IBot^>^ GetBotList();

			/// <summary>
			/// Adds a bot to the list of bots to manage. Bots cannot have the same name.
			/// </summary>
			/// <returns>
			/// True if successful, false otherwise.
			/// </returns>
			bool AddBotToList(IBot^ botArg);

			/// <summary>
			/// Deletes a bot from the list of bots being managed.
			/// </summary>
			/// <returns>
			/// True if successful, false otherwise.
			/// </returns>
			bool DeleteBotFromList(IBot^ botArg);

			/// <summary>
			/// Saves the current list of bots being managed.
			/// </summary>
			/// <returns>
			/// True if successful, false otherwise.
			/// </returns>
			bool SaveBotList();
		};
	}
}
#endif