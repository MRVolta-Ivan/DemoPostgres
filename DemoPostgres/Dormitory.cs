using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPostgres
{
    class DormitoryRepository
    {
        DBConnection connection = DBConnection.instance;

        private List<Dormitory> Mapper(List<List<string>> data)
        {
            List<Dormitory> result = new List<Dormitory>();

            foreach (List<string> i in data)
            {
                result.Add(
                    new Dormitory(
                       Convert.ToInt64(i[0]),
                       i[1],
                       Convert.ToInt64(i[2]),
                       i[3],
                       Convert.ToInt64(i[4])));
            }

            return result;
        }

        public List<Dormitory> GetListDormitory()
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistdormitory()");

            return Mapper(data);
        }

        public List<Dormitory> GetListCheck()
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistdormitorycheck()");

            return Mapper(data);
        }

        public List<Dormitory> getListFree()
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistfreedormitory()");

            return Mapper(data);
        }

        public long AddDormitory(string adress, long countRoom, string condition, long idTypeDormitory)
        {
            connection.ExecuteSQL("call adddormitory('"+ adress + "', " + countRoom + ", '" + condition + "', " + idTypeDormitory + ")");
            List<Dormitory> data = GetListDormitory();

            long index = data[0].id;
            for (int i = 1; i < data.Count; i++)
                if (index < data[i].id)
                    index = data[i].id;

            return index;
        }

        public void Change(string adress, long countRoom, string condition, long iddormitory)
        {
            connection.ExecuteSQL("call changedormitory('"+adress+"', "+countRoom+", '"+condition+"', "+iddormitory+")");
        }
    }


    public class Dormitory
    {
        public long id;
        public string adress;
        public long countRoom;
        public string condition;
        public long typeDormitory;

        public Dormitory(long id, string adress, long countRoom, string condition, long typeDormitory)
        {
            this.id = id;
            this.adress = adress;
            this.countRoom = countRoom;
            this.condition = condition;
            this.typeDormitory = typeDormitory;
        }
    }
}
