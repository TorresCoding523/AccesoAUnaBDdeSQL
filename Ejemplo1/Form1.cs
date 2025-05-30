using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btb_conexion_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFilename=C:\\Users\\Usuario\\Desktop\\Semestre Ene-Jun 2023\\Topicos Avanzados de Programacion\\U1\\Visual Estudio\\EjemplosU4\\Ejemplo1\\escuela.mdf;"+
                "Integrated Security=True"); 
            conexion.Open();
            MessageBox.Show("Conexion y seleccion de BD correctas");
            conexion.Close();
            MessageBox.Show("Se ha cerrado conexion");
        }

        private void btn_resgistrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
               "AttachDbFilename=C:\\Users\\Usuario\\Desktop\\Semestre Ene-Jun 2023\\Topicos Avanzados de Programacion\\U1\\Visual Estudio\\EjemplosU4\\Ejemplo1\\escuela.mdf;" +
               "Integrated Security=True");
                conexion.Open();
                int mat = int.Parse(matricula.Text);
                string nom = nombre.Text;
                String ap = ap_patern.Text;
                String am = ap_mater.Text;
                String fecha = fecha_naci.Text;
                int ed = int.Parse(edad.Text);

                String resgistrar = "insert into estudiantes values(" + mat + ",'" + nom + "','" + ap + "'" +
                    ",'" + am + "','" + fecha + "'," + ed + ")";
                SqlCommand comando = new SqlCommand(resgistrar, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente");
                conexion.Close();
                nombre.Text = "";
                ap_patern.Text = "";
                ap_mater.Text = "";
                fecha_naci.Text = "";
                edad.Text = "";
                matricula.Text = ""; 

            }
            catch (FormatException)
            {
                MessageBox.Show("No has ingresado algun dato");
            }
           

        }

        private void buscar_Click(object sender, EventArgs e)
        {
         //   SqlConnection conexion = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;"+ "AttachDbFilename = C:\\Users\\Usuario\\Desktop\\Semestre Ene-Jun 2023\\Topicos Avanzados de Programacion\\U1\\Visual Estudio\\EjemplosU4\\Ejemplo1\\escuela.mdf"+ 
            //"Integrated Security = True");
            SqlConnection conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
               "AttachDbFilename=C:\\Users\\Usuario\\Desktop\\Semestre Ene-Jun 2023\\Topicos Avanzados de Programacion\\U1\\Visual Estudio\\EjemplosU4\\Ejemplo1\\escuela.mdf;" +
               "Integrated Security=True");
            conexion.Open();
            string mat = busmatric.Text;
            string buscar = "select * from estudiantes where matricula= "+mat; 
            SqlCommand comand=new SqlCommand(buscar, conexion);
            SqlDataReader registro=comand.ExecuteReader();
            if (registro.Read())
            {
                busmatric.Text = registro["matricula"].ToString(); 
                matricula.Text= registro["matricula"].ToString();
                nombre.Text=registro["Nombre"].ToString();
                ap_patern.Text = registro["ap_paterno"].ToString();
                ap_mater.Text = registro["ap_materno"].ToString();
                fecha_naci.Text = registro["Fecha_Nacimiento"].ToString();
                edad.Text = registro["edad"].ToString();
                
                

                Actualizar.Enabled = true;
                eliminar.Enabled= true;
                MessageBox.Show("Estudiante encontrado");
            }
            else
            {
                MessageBox.Show("No existe un estudiante con la matricula ingreesada");
                conexion.Close();
            }

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            
            SqlConnection conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
               "AttachDbFilename=C:\\Users\\Usuario\\Desktop\\Semestre Ene-Jun 2023\\Topicos Avanzados de Programacion\\U1\\Visual Estudio\\EjemplosU4\\Ejemplo1\\escuela.mdf;" +
               "Integrated Security=True");
            conexion.Open();
            string mat = busmatric.Text;
            string eliminar = "delete from estudiantes where matricula= " + mat;
            SqlCommand comand = new SqlCommand(eliminar, conexion);
            SqlDataReader registro = comand.ExecuteReader();
            int cant=0;
            if (cant == 1)
            {
                busmatric.Text = "";
                MessageBox.Show("Se ha eliminado el estudiante...");
            }
            else
            {
                MessageBox.Show("No existe un estudiante con la matricula ingreesada");
                conexion.Close();
                

            }

        }

        private void btb_alum_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
               "AttachDbFilename=C:\\Users\\Usuario\\Desktop\\Semestre Ene-Jun 2023\\Topicos Avanzados de Programacion\\U1\\Visual Estudio\\EjemplosU4\\Ejemplo1\\escuela.mdf;" +
               "Integrated Security=True");
            conexion.Open();
            String consulta = "select matricula, nombre, ap_paterno, ap_materno," +
                "fecha_nacimiento,edad from estudiantes";
            SqlCommand comand=new SqlCommand(consulta, conexion);
            SqlDataReader registro = comand.ExecuteReader();
            while (registro.Read())
            {
                txt_listar.AppendText(registro["matricula"].ToString());
                txt_listar.AppendText("  _ ");
                txt_listar.AppendText(registro["nombre"].ToString());
                txt_listar.AppendText("  _ ");
                txt_listar.AppendText(registro["ap_paterno"].ToString());
                txt_listar.AppendText("  _ ");
                txt_listar.AppendText(registro["ap_materno"].ToString());
                txt_listar.AppendText("  _ ");
                txt_listar.AppendText(registro["fecha_nacimiento"].ToString());
                txt_listar.AppendText("  _ ");
                txt_listar.AppendText(registro["edad"].ToString());
                txt_listar.AppendText("  _ ");
                txt_listar.AppendText("  \t ");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
               "AttachDbFilename=C:\\Users\\Usuario\\Desktop\\Semestre Ene-Jun 2023\\Topicos Avanzados de Programacion\\U1\\Visual Estudio\\EjemplosU4\\Ejemplo1\\escuela.mdf;" +
               "Integrated Security=True");
            conexion.Open();
            string mat = busmatric.Text;
            string nom=nombre.Text;
            string ap = ap_patern.Text;
            string apM=ap_mater.Text;
            string fech=fecha_naci.Text;
            string eda = edad.Text;
            string actualizar = "update estudiantes set nombre= '" + nom+ "',ap_paterno='"+ap+ "',ap_materno='" + apM+"' ,edad= '" + eda + "',fecha_nacimiento='" + fech+"'where matricula=" +mat;
            SqlCommand comand = new SqlCommand(actualizar, conexion);
            int cant =comand.ExecuteNonQuery();
            if (cant == 1) {

                MessageBox.Show("Se modificaron los datos correctamente");
                matricula.Text = "";
                nombre.Text = "";
                ap_patern.Text = "";
                ap_mater.Text = "";
                fecha_naci.Text = "";
                edad.Text = "";
                
            }
            else
            {
                MessageBox.Show("No exite el estudiante con dicha matricula"); 
                conexion.Close();
            }

       
        }
    }
}
