using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Курсова__Щоденик_.Model
{
    public class Event
    {
        public bool IsDone { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime DateTimeTill { get; set; }
        public string Place { get; set; }

        public Event(bool isDone, string name, DateTime dateTime, DateTime dateTimeTill, string place)
        {
            this.IsDone = isDone;
            this.Name = name;
            this.DateTime = dateTime;
            this.DateTimeTill = dateTimeTill;
            this.Place = place;
        }
    }

}
