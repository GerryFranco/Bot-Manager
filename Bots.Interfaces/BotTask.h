//BotTask.h - Specifies bot tasks.
#pragma once

#ifndef BOTTASK_H
#define BOTTASK_H TRUE

namespace Bots
{
	namespace Interfaces
	{
		/// <summary>
		/// Specifies bot tasks.
		/// </summary>
		public enum class BotTask
		{
			DoTheDishes = 0,
			SweepTheHouse = 1,
			DoTheLaundry = 2,
			TakeOutTheRecycling = 3,
			MakeASammich = 4,
			MowTheLawn = 5,
			RakeTheLeaves = 6,
			GiveTheDogABath = 7,
			BakeSomeCookies = 8,
			WashTheCar = 9
		};
	}
}
#endif