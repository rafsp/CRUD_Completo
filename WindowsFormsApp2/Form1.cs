using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection meuSQL = new MySqlConnection("server=localhost;database=Aula1909;uid=root;pwd=");
            meuSQL.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from Aluno",meuSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvAluno.DataSource = dt;
        }

    }
}
