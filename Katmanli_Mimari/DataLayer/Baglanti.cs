using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DataLayer
{
    internal class Baglanti
    {
        public static string Baglantimiz
        {
            get
            {
                return "Server=.;Database=Katman;Trusted_Connection=true";
            }
        }


        public static SqlConnection Baglantim
        {
            get
            {
                return new SqlConnection("Server=.;Database=Katman;Trusted_Connection=true");
            }
        }


    }
}
