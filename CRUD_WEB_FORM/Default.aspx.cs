using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace CRUD_WEB_FORM
{
    public partial class Default : System.Web.UI.Page
    {
        public static string strconexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        public SqlConnection conexion = new SqlConnection(strconexion);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lbl_estado.Text = "";
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "sp_insertarUsuario";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre",txt_nombre.Text);
                cmd.Parameters.AddWithValue("@apellido", txt_apellido.Text);
                cmd.ExecuteNonQuery();
                lbl_estado.Text = "Creado con exito!";
                txt_nombre.Text = "";
                txt_apellido.Text = "";
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción : " + ex.Message);
            }
            finally
            {
                conexion.Close();
                
            }
        }

        protected void btn_mostrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "sp_listarUsuarios";
                SqlDataAdapter da = new SqlDataAdapter (cmd);
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción : " + ex.Message);
            }
            finally
            {
                conexion.Close();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}