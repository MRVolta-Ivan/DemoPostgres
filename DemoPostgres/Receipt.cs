using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPostgres
{
    class ReceiptRepository
    {
        DBConnection connection = DBConnection.instance;

        public List<Receipt> GetAll()
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistreceipt()");

            List<Receipt> result = new List<Receipt>();

            foreach (List<string> i in data)
            {
                result.Add(
                    new Receipt(
                       Convert.ToInt64(i[0]),
                       i[1],
                       i[2],
                       Convert.ToDouble(i[3]),
                       Convert.ToInt64(i[4]),
                       Convert.ToInt64(i[5]),
                       Convert.ToInt64(i[6]),
                       Convert.ToInt64(i[7])));
            }

            return result;
        }
    }

    class Receipt
    {
        public long id;
        public string number;
        public string date;
        public double summ;
        public long employee;
        public long room;
        public long dormitory;
        public long applicant;

        public Receipt(long id, string number, string date, double summ, long employee, long room, long dormitory, long applicant)
        {
            this.id = id;
            this.number = number;
            this.date = date;
            this.summ = summ;
            this.employee = employee;
            this.room = room;
            this.dormitory = dormitory;
            this.applicant = applicant;
        }
    }
}
