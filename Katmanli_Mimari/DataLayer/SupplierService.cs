using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.SqlClient;

namespace DataLayer
{
    public class SupplierService
    {
        public List<Tedarikci> TedarikcileriGetir()
        { 
             //firmalar
            SqlConnection con = Baglanti.Baglantim;
            SqlCommand cmd = new SqlCommand("select SupplierId,CompanyName from Suppliers", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Tedarikci tedarikcim;
            List<Tedarikci> tedarikciListesi = new List<Tedarikci>();


            while (rdr.Read())
            { 
                tedarikcim=new Tedarikci()
                {
                    SupplierId=Convert.ToInt32(rdr[0]),
                    CompanyName=rdr.GetString(1)

                };
               tedarikciListesi.Add(tedarikcim);
            }
            con.Close();
            return tedarikciListesi;
        }




    }
}
