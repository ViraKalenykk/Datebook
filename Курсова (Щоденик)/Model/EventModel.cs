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

        public bool IsExpired
        {
            get { return DateTime.Now > DateTimeTill; }
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Event other = (Event)obj;

            // Порівняти значення полів подій для визначення рівності
            return Name == other.Name &&
                   DateTime == other.DateTime &&
                   DateTimeTill == other.DateTimeTill &&
                   Place == other.Place;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Name != null ? Name.GetHashCode() : 0);
                hash = hash * 23 + DateTime.GetHashCode();
                hash = hash * 23 + DateTimeTill.GetHashCode();
                hash = hash * 23 + (Place != null ? Place.GetHashCode() : 0);
                return hash;
            }
        }
    }

}
