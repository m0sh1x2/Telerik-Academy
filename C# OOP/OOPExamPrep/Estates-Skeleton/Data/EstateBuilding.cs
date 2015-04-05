using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    public abstract class EstateBuilding : Estate, IApartment, IOffice
    {
        private const int minRooms = 0;
        private const int maxRooms = 20;

        private int numberOfRooms;
        private bool havesElevator;

        public int Rooms
        {
            get
            {
                return this.numberOfRooms;
            }
            set
            {
                if (value < minRooms || value > maxRooms)
                {
                    throw new IndexOutOfRangeException("Apartment or Office cannot have more than 20 rooms or less than 20 !");
                }
                this.numberOfRooms = value;
            }
        }

        public bool HasElevator
        {
            get { return this.havesElevator; }
            set
            {
                this.havesElevator = value;
            }
        }
        public override string ToString()
        {
            return String.Format("{0}: Name = {1}, Area = {2}, Location = {3}, Furnitured = {4}, Rooms: {5}, Elevator: {6}",
                this.Type, this.Name, this.Area, this.Location, this.IsFurnished ? "Yes" : "No", this.Rooms, this.HasElevator ? "Yes" : "No");
        }
    }
}
