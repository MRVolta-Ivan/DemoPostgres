using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPostgres
{
    class ApplicationRepository
    {
        DBConnection connection = DBConnection.instance;

        public List<ApplicationDoc> GetAll()
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistapplication()");

            List<ApplicationDoc> result = new List<ApplicationDoc>();

            foreach (List<string> i in data)
            {
                result.Add(
                    new ApplicationDoc(
                       Convert.ToInt64(i[0]),
                       i[1],
                       i[2],
                       Convert.ToInt64(i[3]),
                       Convert.ToInt64(i[4]),
                       Convert.ToInt64(i[5])));
            }

            return result;
        }

        public long AddApplication(string numberApplication, string date, long typeDoc, long employee, long applicant)
        {
            connection.ExecuteSQL("call addapplication('" + numberApplication + "', '" + date + "', " + typeDoc + ", " + employee + ", " + applicant + ")");

            List<ApplicationDoc> data = GetAll();

            long index = data[0].id;
            for (int i = 1; i < data.Count; i++)
                if (index < data[i].id)
                    index = data[i].id;

            return index;
        }
    }

    class ApplicationDoc
    {
        public long id;
        public string numberApplication;
        public string date;
        public long typeDocument;
        public long employee;
        public long applicant;

        public ApplicationDoc(long id, string numberApplication, string date, long typeDocument, long employee, long applicant)
        {
            this.id = id;
            this.numberApplication = numberApplication;
            this.date = date;
            this.typeDocument = typeDocument;
            this.employee = employee;
            this.applicant = applicant;
        }
    }
}