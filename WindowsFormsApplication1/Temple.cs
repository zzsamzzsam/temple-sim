using System;
using System.Collections.Generic;

namespace PTS
{
    class Temple
    {
        private static readonly Random r = new Random();
        public List<Room> rooms { get; set; }
        public List<Room> remainingRooms { get; set; }
        private const string targetroom = "15";

        public Temple(int c)
        {
            this.remainingRooms = new List<Room>();
            this.rooms = new List<Room>();

            for (int i = 0; i < c; i++)
            {
                Room temp = new Room(i.ToString(), 1);
                this.remainingRooms.Add(temp);
            }

            for (int i = 0; i < 11; i++)
            {
                Room temp = new Room("e", 0);
                this.rooms.Add(temp);
            }
        }

        public void populateRandom(int c)
        {
            int i = 0;
            while (i < c)
            {
                int index = r.Next(this.remainingRooms.Count);

                int ri = r.Next(this.rooms.Count);
                if (this.rooms[ri].tier == 0)
                {
                    this.rooms[ri] = remainingRooms[index];
                    this.remainingRooms.RemoveAt(index);
                    i++;
                }
            }
        }

        public int runIncursion()
        {
            int rindex = r.Next(this.rooms.Count);

            if (this.rooms[rindex].name == "e")
            {
                int r1i = r.Next(this.remainingRooms.Count);
                Room r1 = this.remainingRooms[r1i];
                this.remainingRooms.RemoveAt(r1i);

                int r2i = r.Next(this.remainingRooms.Count);
                Room r2 = this.remainingRooms[r2i];
                this.remainingRooms.RemoveAt(r2i);

                if (r2.name == targetroom)
                    this.rooms[rindex] = r2;
                else
                    this.rooms[rindex] = r1;
            }
            else if (this.rooms[rindex].tier == 3)
            {
                return 0;
            }
            else
            {
                int r1i = r.Next(this.remainingRooms.Count);
                Room r1 = this.remainingRooms[r1i];
                this.remainingRooms.RemoveAt(r1i);

                if (r1.name == targetroom)
                    this.rooms[rindex] = r1;
                else
                    this.rooms[rindex].increaseTier();
            }

            return 1;
        }

        public bool hasRoom()
        {
            foreach (Room r in this.rooms)
            {
                if (r.name == targetroom && r.tier == 3)
                    return true;                    
            }
            return false;
        }
    }
}
