using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioWebGalaxy
{
    public partial class Form1 : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=PruebaTecnicaGalaxy; Uid=root; Pwd=mysql.2020JALC83");
        public Form1()
        {
            InitializeComponent();
        }
        private void btnconexion_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("En Linea");
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error, Fuera de Línea");
            }
        }
    }
}
