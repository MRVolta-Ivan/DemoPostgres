using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPostgres
{

    class TypeDormitoryRepository
    {
        DBConnection connection = DBConnection.instance;

        public List<TypeDormitory> GetAll()
        {
            List<List<string>> data = connection.ExecuteSQL("select * from gettypedormitory()");

            List<TypeDormitory> result = new List<TypeDormitory>();

            foreach (List<string> i in data)
            {
                result.Add(
                    new TypeDormitory(
                       Convert.ToInt64(i[0]),
                       i[1]));
            }

            return result;
        }
    }

    class TypeDormitory
    {
        public long id;
        public string name;

        public TypeDormitory(long id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
