using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.SqlClient;

namespace DataLayer
{
    public class CategoryService
    {
        public List<Category> kategorileriGetir()
        {
            SqlConnection con = Baglanti.Baglantim;
            SqlCommand cmd = new SqlCommand("select CategoryId,CategoryName from Categories", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Category cat;
            List<Category> kategoriListesi = new List<Category>();


            while (rdr.Read())
            { 
                cat=new Category()
                {
                    CategoryId=Convert.ToInt32(rdr[0]),
                    CategoryName=rdr.GetString(1)

                };
                kategoriListesi.Add(cat);
            }
            con.Close();
            return kategoriListesi;

            
        }
    }
}
