using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("" +
            "server=localhost;user id=root; pasword=;" +
            "database=escuela;sslMode=none");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        string sql;
        int result;
        string alumnoid;
        private void insertar_Click(object sender, EventArgs e)
        {
            guardardatos();
        }
        private void guardardatos() {
            try
            {
                sql = "insert into alumnos values('" + matricula.Text + "' , '" + nombre.Text + "' , '" +
                    ap_patern.Text + "' , '" + ap_mater.Text + "' , '" + Email.Text + "' , '" + telefono.Text + "' , '" +
                    edad.Text + "')";
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Datos GUardados con Exito", "G U A R D A D O");
                }
                else
                {
                    MessageBox.Show("Fallo la insercion", "E R R O R :(");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { con.Close(); }

        }
        private void cargarDatos()
        {
            try
            {
                sql = "select *" +
                "from alumnos";
                con.Open();

                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                tabla.DataSource = dt;
                Eliminar.Enabled = false;
                Actualizar.Enabled = false;
                insertar.Enabled = false;
                Mostrar.Enabled = true;    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { con.Close(); //da.Dispose(); 
            }
        }
        private void actualizarDatos() {
            try
            {
                sql = "update alumnos set matricula='"+matricula.Text
                    +"',nombre='"+nombre.Text
                    +"',ap_paternos='"+ap_patern.Text
                    +"',ap_materno='"+ap_mater.Text
                    +"',email='"+Email.Text
                    +"',telefono='"+telefono.Text
                    +"',edad='"+edad.Text + "' where "
                    +"matricula = " + alumnoid;
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Actualizacion Exitosa", "E X I T O S A");
                }
                else
                {
                    MessageBox.Show("Fallo la Actualizacion", "E R R O R :(");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { con.Close(); }


        }

            



       
        private void eliminardatos(){
            try
            {
                sql = "Delete from alumnos where matricula="+alumnoid;
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Datos Eliminados con Exito", "E L I M I N A D O");
                }
                else
                {
                    MessageBox.Show("Fallo la Eliminación :(", "E R R O R :(");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { con.Close(); }
            

        }
        private void dvgAlumnos_click(object sender, EventArgs e)
        {
            alumnoid = tabla.CurrentRow.Cells[0].Value.ToString();
            matricula.Text=alumnoid;
            nombre.Text=tabla.CurrentRow.Cells[1].Value.ToString();
            ap_patern.Text= tabla.CurrentRow.Cells[2].Value.ToString();
            ap_mater.Text=tabla.CurrentRow.Cells[3].Value.ToString();
            Email.Text= tabla.CurrentRow.Cells[4].Value.ToString();
            telefono.Text= tabla.CurrentRow.Cells[5].Value.ToString();
            edad.Text= tabla.CurrentRow.Cells[6].Value.ToString();
            Eliminar.Enabled = true;
            Actualizar.Enabled = true;
            insertar.Enabled = false;



        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            eliminardatos();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            actualizarDatos();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dvgAlumnos_click(sender, e);    
        }
    }
}
