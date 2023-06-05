using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Курсова__Щоденик_.Model
{
	public class Customer
	{
		public string? Name { get; set; }
		public string? Password { get; set; }
		public BindingList<Event>? Events { get; set; }
	}
}
