using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPostgres
{
    class InspectorRepository
    {
        DBConnection connection = DBConnection.instance;

        public List<Inspector> GetAll()
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistinspector()");

            List<Inspector> result = new List<Inspector>();

            foreach (List<string> i in data)
            {
                result.Add(
                    new Inspector(
                       Convert.ToInt64(i[0]),
                       i[1],
                       i[2]));
            }

            return result;
        }
    }

    class Inspector
    {
        public long id;
        public string fio;
        public string numberTelephone;

        public Inspector(long id, string fio, string numberTelephone)
        {
            this.id = id;
            this.fio = fio;
            this.numberTelephone = numberTelephone;
        }
    }
}
