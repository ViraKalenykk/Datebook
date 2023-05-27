using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Курсова__Щоденик_.Model
{
    public class Event
    {
        public bool isDone { get; set; }
        public string name { get; set; }
        public DateTime datetime { get; set; }
        public DateTime datetimetill { get; set; }
        public string place { get; set; }

        public Event(bool isDone, string name, DateTime datetime, DateTime datetimetill, string place)
        {
            this.isDone = isDone;
            this.name = name;
            this.datetime = datetime;
            this.datetimetill = datetimetill;
            this.place = place;
        }
    }

}
