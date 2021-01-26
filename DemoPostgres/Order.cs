using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPostgres
{
    class OrderRepository
    {
        DBConnection connection = DBConnection.instance;

        private List<Order> Mapper(List<List<string>> data)
        {
            List<Order> result = new List<Order>();

            foreach (List<string> i in data)
            {
                result.Add(
                    new Order(
                       Convert.ToInt64(i[0]),
                       i[1],
                       i[2],
                       Convert.ToInt64(i[3]),
                       Convert.ToInt64(i[4]),
                       Convert.ToInt64(i[5]),
                       Convert.ToInt64(i[6]),
                       Convert.ToInt64(i[7])));
            }

            return result;
        }

        public List<Order> GetAll()
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistorder()");

            return Mapper(data);
        }

        public List<Order> GetLastOrder(long applicantid)
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistlastapplicantorder(" + applicantid + ")");

            return Mapper(data);
        }

        public long Add(string number, string date, long idTypeDocument, long idEmployee, long idRoom, long idDormitory, long idApplicant)
        {
            connection.ExecuteSQL("call addorder('"+number+"','"+date+"', "+idTypeDocument+", "+idEmployee+","+idRoom+","+idDormitory+","+idApplicant+")");

            List<Order> data = GetAll();

            long index = data[0].id;
            for (int i = 1; i < data.Count; i++)
                if (index < data[i].id)
                    index = data[i].id;

            return index;
        }
    }

    class Order
    {
        public long id;
        public string number;
        public string date;
        public long typeDocument;
        public long employee;
        public long room;
        public long dormitory;
        public long applicant;

        public Order(long id, string number, string date, long typeDocument, long employee, long room, long dormitory, long applicant)
        {
            this.id = id;
            this.number = number;
            this.date = date;
            this.typeDocument = typeDocument;
            this.employee = employee;
            this.room = room;
            this.dormitory = dormitory;
            this.applicant = applicant;
        }
    }
}
