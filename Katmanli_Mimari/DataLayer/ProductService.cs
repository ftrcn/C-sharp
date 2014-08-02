using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using DataLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    //Ürünler
    public class ProductService
    {
        public bool UrunEkle(Urun eklenecekUrun)
        {
            
                SqlConnection con = new SqlConnection(Baglanti.Baglantimiz);

                SqlCommand cmd = new SqlCommand("Insert Into Products(ProductName,CategoryID,SupplierId) values(@UrunAdi,@KategoriId,@TedarikciId)",con);
                SqlParameter param1 = new SqlParameter("@UrunAdi", eklenecekUrun.ProductName);
                cmd.Parameters.AddWithValue("@KategoriId", eklenecekUrun.CategoryID);
                cmd.Parameters.AddWithValue("@TedarikciId", eklenecekUrun.SupplierId);
                cmd.Parameters.Add(param1);
                con.Open();

                int EtkilenenSatirSayisi = cmd.ExecuteNonQuery();
                con.Close();
                return EtkilenenSatirSayisi > 0;
           


        }
    }
}
