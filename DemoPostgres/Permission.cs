using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPostgres
{
    class PermissionRepository
    {
        DBConnection connection = DBConnection.instance;

        public List<Permission> GetAll()
        {
            List<List<string>> data = connection.ExecuteSQL("select * from getlistpermission()");

            List<Permission> result = new List<Permission>();

            foreach (List<string> i in data)
            {
                result.Add(
                    new Permission(
                       Convert.ToInt64(i[0]),
                       i[1],
                       i[2],
                       Convert.ToInt64(i[3]),
                       Convert.ToInt64(i[4]),
                       Convert.ToInt64(i[5]),
                       Convert.ToInt64(i[6])));
            }

            return result;
        }

        public long Add(string number, string date, long idemployee, long idroom, long iddormitory, long idapplicant)
        {
            connection.ExecuteSQL("call addpermission('"+number+"', '"+date+"', "+idemployee+", "+idroom+", "+iddormitory+", "+idapplicant+")");

            List<Permission> data = GetAll();

            long index = data[0].id;
            for (int i = 1; i < data.Count; i++)
                if (index < data[i].id)
                    index = data[i].id;

            return index;
        }
    }

    class Permission
    {
        public long id;
        public string numberPermission;
        public string date;
        public long employee;
        public long room;
        public long dormitory;
        public long applicant;

        public Permission(long id, string numberPermission, string date, long employee, long room, long dormitory, long applicant)
        {
            this.id = id;
            this.numberPermission = numberPermission;
            this.date = date;
            this.employee = employee;
            this.room = room;
            this.dormitory = dormitory;
            this.applicant = applicant;
        }
    }
}
