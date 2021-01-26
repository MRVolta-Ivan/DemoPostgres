using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPostgres
{
    class TypeDocumnetRepository
    {
        DBConnection connection = DBConnection.instance;

        public List<TypeDocument> GetAll()
        {
            List<List<string>> data = connection.ExecuteSQL("select * from gettypedocument()");

            List<TypeDocument> result = new List<TypeDocument>();

            foreach (List<string> i in data)
            {
                result.Add(
                    new TypeDocument(
                       Convert.ToInt64(i[0]),
                       i[1]));
            }

            return result;
        }
    }

    class TypeDocument
    {
        public long id;
        public string name;

        public TypeDocument(long id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
