﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miki.API.GameService
{
	class SlotsResponse : IGameResponse
	{
		public int Bet { get; set; }
		public int Gain { get; set; }

		public SlotsResponse()
		{

		}
	}
}