using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPostgres
{
    class ReportRepository
    {
        DBConnection connection = DBConnection.instance;

        public List<Report> GetAll()
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistreportaboutinspection()");

            List<Report> result = new List<Report>();

            foreach (List<string> i in data)
            {
                result.Add(
                    new Report(
                       Convert.ToInt64(i[0]),
                       i[1],
                       i[2],
                       i[3],
                       i[4],
                       i[5],
                       Convert.ToInt64(i[6]),
                       Convert.ToInt64(i[7])));
            }

            return result;
        }

        public long Add(string number, string date, string fire, string system, string general, long idinspector, long iddormitory)
        {
            connection.ExecuteSQL("call addreport_about_inspection('"+number+"', '"+date+"', '"+fire+"', '"+system+"', '"+general+"', "+idinspector+", "+iddormitory+")");

            List<Report> data = GetAll();

            long index = data[0].id;
            for (int i = 1; i < data.Count; i++)
                if (index < data[i].id)
                    index = data[i].id;

            return index;
        }
    }

    class Report
    {
        public long id;
        public string number;
        public string date;
        public string fire;
        public string system;
        public string condition;
        public long inspector;
        public long dormitory;

        public Report(long id, string number, string date, string fire, string system, string condition, long inspector, long dormitory)
        {
            this.id = id;
            this.number = number;
            this.date = date;
            this.fire = fire;
            this.system = system;
            this.condition = condition;
            this.inspector = inspector;
            this.dormitory = dormitory;
        }
    }
}
