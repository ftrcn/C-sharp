using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            gridDoldur();
        }
        try
        {
            SqlConnection con = new SqlConnection("Server=.;Initial Catalog=ajax_sozluk;Trusted_Connection=True");
            SqlDataAdapter da1 = new SqlDataAdapter("select * from sozluk", con);
            DataSet ds1 = new DataSet();
            con.Open();
            da1.Fill(ds1, "sozluk");
            con.Close();
            Label1.Text = ds1.Tables[0].Rows[0]["ingilizce"].ToString();
            Label2.Text = ds1.Tables[0].Rows[1]["ingilizce"].ToString();
            Label3.Text = ds1.Tables[0].Rows[2]["ingilizce"].ToString();
            Label4.Text = ds1.Tables[0].Rows[3]["ingilizce"].ToString();
            Label5.Text = ds1.Tables[0].Rows[4]["ingilizce"].ToString();
            
        }
        catch
        {
        }
    
    }


    public void gridDoldur()
    {
    try
    {
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection("Server=.;Initial Catalog=ajax_sozluk;Trusted_Connection=True");
        string sqlStatement = "SELECT * FROM sozluk";
        SqlCommand cmd = new SqlCommand(sqlStatement, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        con.Open();
       
          da.Fill(dt);

               if (dt.Rows.Count > 0)
               {
                   GridView1.DataSource = dt;
                   GridView1.DataBind();
               }
         con.Close();
    }
    catch
    {
    }
        
   }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Server=.;Initial Catalog=ajax_sozluk;Trusted_Connection=True");
        SqlDataAdapter da = new SqlDataAdapter("select * from sozluk", con);
        DataSet ds1 = new DataSet();
        con.Open();
        da.Fill(ds1, "sozluk");
        con.Close();
        if (TextBox1.Text == ds1.Tables[0].Rows[0]["t1"].ToString() )
            {
                Response.Write("<script>alert('Doğruuuu !! :)')</script>");
                Image1.ImageUrl = "~/Resimler/CheckMark.png";
           
            }
         else
          {
            Response.Write("<script>alert('yanlış :((')</script>");
            Image1.ImageUrl = "~/Resimler/images.jpg";
           }


        if (TextBox2.Text == ds1.Tables[0].Rows[1]["t1"].ToString()) 
        {
            Response.Write("<script>alert('Doğruuuu !! :)')</script>");
            Image2.ImageUrl = "~/Resimler/CheckMark.png";
        }
        else
        {
            Response.Write("<script>alert('yanlış :((')</script>");
            Image2.ImageUrl = "~/Resimler/images.jpg";
        }



        if (TextBox3.Text == ds1.Tables[0].Rows[2]["t1"].ToString())
        {
            Response.Write("<script>alert('Doğruuuu !! :)')</script>");
            Image3.ImageUrl = "~/Resimler/CheckMark.png";
        }
         else
         {
             Response.Write("<script>alert('yanlış :((')</script>");
             Image3.ImageUrl = "~/Resimler/images.jpg";
         }


        if (TextBox4.Text == ds1.Tables[0].Rows[3]["t1"].ToString())
        {
            Response.Write("<script>alert('Doğruuuu !! :)')</script>");
            Image4.ImageUrl = "~/Resimler/CheckMark.png";
        }
        else
        {
            Response.Write("<script>alert('yanlış :((')</script>");
            Image4.ImageUrl = "~/Resimler/images.jpg";
        }


        if (TextBox5.Text == ds1.Tables[0].Rows[4]["t1"].ToString())
        {
            Response.Write("<script>alert('Doğruuuu !! :)')</script>");
            Image5.ImageUrl = "~/Resimler/CheckMark.png";
        }
        else
        {
            Response.Write("<script>alert('yanlış :((')</script>");
            Image5.ImageUrl = "~/Resimler/images.jpg";
        }


    }

   

    protected void Button2_Click(object sender, EventArgs e)
    {
 
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Label12.Text = "Yeni Kayıt";
        lb_id.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";

        ModalPopupExtender1.Show(); 
    }

    //silme işlemi  yapar
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = (int)GridView1.DataKeys[e.RowIndex].Value;
        SqlConnection con = new SqlConnection("Server=.;Initial Catalog=ajax_sozluk;Trusted_Connection=True");
        con.Open();
        string sorgu = "delete from sozluk where id =" + id;
        SqlCommand cmd = new SqlCommand(sorgu, con);
       
        cmd.ExecuteNonQuery();
        con.Close();
        gridDoldur();

    }

   
    
    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        gridDoldur();
    }

    //veritabanına veri kaydeder, veri düzenler.
    protected void btnClose_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.; Initial Catalog=ajax_sozluk; Integrated Security=true");
        if (Label12.Text == "Yeni Kayıt")
        {
           
            SqlCommand cmd = new SqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = " insert into sozluk(ingilizce,t1,t2,t3,t4) values ('" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "')";
            cmd.ExecuteNonQuery();
        }

        else
        {

            string sorgu = "update sozluk set ingilizce='" + TextBox6.Text + "',t1='" + TextBox7.Text + "',t2='" + TextBox8.Text + "',t3='" + TextBox9.Text + "',t4='" + TextBox10.Text + "' where id='" + lb_id.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            gridDoldur();

        }
    }
   
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Label12.Text = "Düzenle";
        GridViewRow satir = GridView1.Rows[e.NewEditIndex];
        string deger = satir.Cells[1].Text;
        //Bilgileri geçir
        lb_id.Text = satir.Cells[6].Text;
        TextBox6.Text = satir.Cells[1].Text;
        TextBox7.Text = satir.Cells[2].Text;
        TextBox8.Text = satir.Cells[3].Text;
        TextBox9.Text = satir.Cells[4].Text;
        TextBox10.Text = satir.Cells[5].Text;

        ModalPopupExtender1.Show();
    }

}
