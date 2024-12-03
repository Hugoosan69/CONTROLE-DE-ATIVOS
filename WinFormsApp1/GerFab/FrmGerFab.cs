using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CATI; // Namespace onde está a classe ConnectionManager

namespace CATI.GerFab
{
    public partial class FrmGerFab : Form
    {
        private ConnectionManager connectionManager; // Instância para gerenciar conexões

        public FrmGerFab()
        {
            InitializeComponent();
            connectionManager = new ConnectionManager(); // Inicializa a classe de conexão
        }

        private void BtnFabCad_Click(object sender, EventArgs e)
        {
            //// Obtém uma conexão aberta
            //using (SqlConnection connection = connectionManager.GetOpenConnection())
            //{
            //    if (connection != null)
            //    {
            //        try
            //        {
            //            // Consulta SQL para obter os dados
            //            string query = "SELECT id_fabricante, nome_fabricante, situacao, data_cadastro FROM Fabricante";

            //            // Configura o comando SQL
            //            SqlCommand cmd = new SqlCommand(query, connection);

            //            // Cria um adaptador e preenche um DataTable com os resultados
            //            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //            DataTable dt = new DataTable();
            //            da.Fill(dt);

            //            // Exibe os dados no DataGridView
            //            GridFab.DataSource = dt;
            //        }
            //        catch (Exception ex)
            //        {
            //            // Exibe uma mensagem de erro
            //            MessageBox.Show($"Erro ao realizar a consulta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PesquisaFab_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = connectionManager.GetOpenConnection())
            {
                if (connection != null)
                {
                    try
                    {
                        // Consulta SQL para obter os dados
                        string query = "SELECT id_fabricante, nome_fabricante, situacao, data_cadastro FROM Fabricante";

                        // Configura o comando SQL
                        SqlCommand cmd = new SqlCommand(query, connection);

                        // Cria um adaptador e preenche um DataTable com os resultados
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Exibe os dados no DataGridView
                        GridFab.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        // Exibe uma mensagem de erro
                        MessageBox.Show($"Erro ao realizar a consulta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
