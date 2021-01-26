using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPostgres
{

    class ApplicantRepository
    {
        DBConnection connection = DBConnection.instance;

        private List<Applicant> Mapper(List<List<string>> data)
        {
            List<Applicant> result = new List<Applicant>();

            foreach (List<string> i in data)
            {
                result.Add(
                    new Applicant(
                       Convert.ToInt64(i[0]),
                       i[1],
                       i[2],
                       i[3]));
            }

            return result;
        }

        public List<Applicant> GetListApplicant()
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistapplicant()");

            return Mapper(data);
        }

        public List<Applicant> GetListTenant()
        {

            List<List<string>> data = connection.ExecuteSQL("select * from getlistapplicanttenant()");

            return Mapper(data);
        }

        public List<Applicant> GetListNoTenant()
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistapplicantnotenant()");

            return Mapper(data);
        }

        public List<Applicant> GetListPayment()
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistapplicantpayment()");

            return Mapper(data);
        }

        public long AddApplicant(string fio, string numberPhone, string adress)
        {
            connection.ExecuteSQL("call addapplicant('" + fio + "', '" + numberPhone + "', '" + adress + "')");

            List<Applicant> data = GetListApplicant();

            long index = data[0].id;
            for (int i = 1; i < data.Count; i++)
                if (index < data[i].id)
                    index = data[i].id;

            return index;
        }
    }

    class Applicant
    {
        public long id;
        public string fio;
        public string nuberTelephone;
        public string adress;

        public Applicant(long id, string fio, string nuberTelephone, string adress)
        {
            this.id = id;
            this.fio = fio;
            this.nuberTelephone = nuberTelephone;
            this.adress = adress;
        }
    }
}