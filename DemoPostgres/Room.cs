using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPostgres
{
    class RoomRepository
    {
        DBConnection connection = DBConnection.instance;

        private List<Room> Mapper(List<List<string>> data)
        {
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

        public List<Room> GetAll()
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistroom()");

            return Mapper(data);
        }

        public List<Room> GetFreeRoomDormitory(long index)
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistfreeroomdormitory(" + index + ")");

            return Mapper(data);
        }

        public List<Room> GetRoomDormitory(long index)
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistroomofdormitory(" + index + ")");

            return Mapper(data);
        }

        public long AddRoom(string number, double cost, long idDormitory)
        {
            connection.ExecuteSQL("call addroom('" + number + "', " + cost.ToString().Replace(',', '.') + ", " + idDormitory + ")");
            List<Room> data = GetAll();

            long index = data[0].id;
            for (int i = 1; i < data.Count; i++)
                if (index < data[i].id)
                    index = data[i].id;

            return index;
        }

        public void Change(string number, double cost, long idroom)
        {
            connection.ExecuteSQL("call changeroom('"+number+"', "+ cost.ToString().Replace(',', '.') + ", "+idroom+")");
        }
    }

    public class Room
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
