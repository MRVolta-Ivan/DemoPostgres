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
