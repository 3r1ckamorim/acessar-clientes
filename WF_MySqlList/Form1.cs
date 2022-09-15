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

namespace WF_MySqlList
{
    public partial class Form1 : Form
    {
        MySqlConnection con;
        MySqlCommand command;
        MySqlDataReader reader;

        public Form1()
        {
            InitializeComponent();

            con = new MySqlConnection("Server=localhost;Database=pizzariadb;Uid=root;Pwd=;SslMode=none");
        }

        private void btnListarUsuario_Click(object sender, EventArgs e)
        {
            // buscar usuarios do banco de dados

            // pupular list box
            //listView1.Items.Add("");

            
            List<Cliente> listaClientes = new List<Cliente>();

                // popular a lista atraves do banco
            command = new MySqlCommand();
            // abre a conexao
            con.Open();
            // seta a conecxao para o comando
            command.Connection = con;
            command.CommandText = "SELECT * FROM cliente";
            // executa o comando
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Cliente cliente = new Cliente();

                cliente.nome = reader["nome_completo"].ToString();
                cliente.data_nascimento = reader["data_nascimento"].ToString();
                cliente.telefone = reader["telefone"].ToString();
                cliente.ddd = reader["ddd"].ToString();
                cliente.endereco = reader["endereco"].ToString();
                cliente.complemento = reader["complemento"].ToString();
                cliente.cep = reader["cep"].ToString();
                cliente.id = reader["id"].ToString();

                listaClientes.Add(cliente);
            }

            // adiciona no listBox os nomes da lista
            foreach (var cliente in listaClientes)
            {
                ListViewItem item = new ListViewItem(cliente.nome);
                item.SubItems.Add(cliente.data_nascimento);
                item.SubItems.Add(cliente.telefone);
                item.SubItems.Add(cliente.ddd);
                item.SubItems.Add(cliente.endereco);
                item.SubItems.Add(cliente.complemento);
                item.SubItems.Add(cliente.cep);
                item.SubItems.Add(cliente.id);


                listView1.Items.Add(item);
            }


            con.Close();
        }

        private void listBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    class Cliente {
    
        public string nome { get; set; }
        public string data_nascimento { get; set; }
        public string telefone { get; set; }
        public string ddd { get; set; }
        public string endereco { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string id { get; set; }
    }
}
