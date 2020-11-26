using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionApprenantsDATA
{
    class Declaration
    {
        public static SqlConnection cn;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        public static void connecte()
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-DIO6PLJ\SQLEXPRESS; Initial Catalog=GestionApprenant; Integrated Security=True");
            cn.Open();
        }

        public static void deconnecte()
        {
            cn.Close();
        }
        public static SqlDataReader select(string req)
        {
            cmd = new SqlCommand(req, cn);
            return dr = cmd.ExecuteReader();
        }
    }
}
