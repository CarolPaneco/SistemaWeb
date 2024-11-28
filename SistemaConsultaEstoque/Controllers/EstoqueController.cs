using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace SistemaFazenda2.Controllers
{
    public class EstoqueController : Controller
    {
        private string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

        // Método para carregar os dados de estoque
        public IActionResult Index()
        {
            string query = "SELECT e.produto_id AS id_produto, p.nome AS nome, e.quantidade AS quantidade " +
                           "FROM Estoque e " +
                           "JOIN Produtos p ON e.produto_id = p.produto_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open(); // Assegura que a conexão está aberta
                    adapter.Fill(dt); // Preenche o DataTable

                    // Limpa o DataGridView antes de atribuir um novo DataSource
                    return View("Estoque", dt); // Renderiza a view "Estoque"
                }
                catch (Exception ex)
                {
                    // Exibe um erro se ocorrer algum problema na conexão
                    ViewBag.ErrorMessage = "Erro ao carregar estoque: " + ex.Message;
                    return View();
                }
            }
        }
    }
}
