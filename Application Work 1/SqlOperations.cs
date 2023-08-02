using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Application_Work_1
{
    public class SqlOperations
    {

        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D04O2F6;Initial Catalog=StokDB;Integrated Security=True");
        
        public static void CheckConnection(SqlConnection temp)
        {
            if (temp.State == ConnectionState.Closed)
            {
                temp.Open();
            }
            

        }
            
            
    }
}
