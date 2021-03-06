﻿using System;
using SQLite.Net.Attributes;

namespace TestDemo
{
	[Table("settings")]
	public class SettingsModel
	{
		public SettingsModel()
		{
		}

		[PrimaryKey]
		public string apikey { get; set; }
		public bool push_notifications { get; set; }
		public bool location { get; set; }
		public bool offline { get; set; }
	}
}
