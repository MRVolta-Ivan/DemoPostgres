﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPostgres
{
    class RoomRepository
    {
        DBConnection connection = DBConnection.instance;

        public List<Room> GetAll()
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistroom()");

            List<Room> result = new List<Room>();

            foreach (List<string> i in data)
            {
                result.Add(
                    new Room(
                       Convert.ToInt64(i[0]),
                       i[1],
                       Convert.ToDouble(i[2]),
                       Convert.ToInt64(i[3])));
            }

            return result;
        }
    }

    class Room
    {
        public long id;
        public string number;
        public double pay;
        public long dormitory;

        public Room(long id, string number, double pay, long dormitory)
        {
            this.id = id;
            this.number = number;
            this.pay = pay;
            this.dormitory = dormitory;
        }
    }
}