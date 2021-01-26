using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPostgres
{
    class EmployeeRepository
    {
        DBConnection connection = DBConnection.instance;

        public List<Employee> GetAll()
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistemployee()");

            List<Employee> result = new List<Employee>();

            foreach (List<string> i in data)
            {
                result.Add(
                    new Employee(
                       Convert.ToInt64(i[0]),
                       i[1],
                       i[2],
                       Convert.ToInt64(i[3])));
            }

            return result;
        }
    }

    class Employee
    {
        public long id;
        public string fio;
        public string numberTelephone;
        public long position;

        public Employee(long id, string fio, string numberTelephone, long position)
        {
            this.id = id;
            this.fio = fio;
            this.numberTelephone = numberTelephone;
            this.position = position;
        }
    }
}
