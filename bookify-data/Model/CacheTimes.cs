﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookify_data.Model
{
	public enum CacheTimes
	{
		OneMinute = 60,
		OneHour = 3600,
		TwoHours = 7200,
		SixHours = 21600,
		TwelveHours = 43200,
		OneDay = 86400,
		OneWeek = 604800,
		OneMonth = 2592000,
		OneYear = 31104000,
		FiveMinute = 300
	}
}
