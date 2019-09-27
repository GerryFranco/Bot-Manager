//BotType.h - Specifies a bot type.
#pragma once

#ifndef BOTTYPE_H
#define BOTTYPE_H TRUE

namespace Bots
{
	namespace Interfaces
	{
		/// <summary>
		/// Specifies a bot type.
		/// </summary>
		public enum class BotType
		{
			/// <summary>
			/// Bot with 1 leg.
			/// </summary>
			Unipedal = 0,

			/// <summary>
			/// Bot with 2 legs.
			/// </summary>
			Bipedal = 1,

			/// <summary>
			/// Bot with 4 legs.
			/// </summary>
			Quadripedal = 2,

			/// <summary>
			/// Bot with 8 legs.
			/// </summary>
			Arachnid = 3,

			/// <summary>
			/// Bot with radial abilities.
			/// </summary>
			Radial = 4,

			/// <summary>
			/// Bot that can fly.
			/// </summary>
			Aeronautical = 5
		};
	}
}
#endif