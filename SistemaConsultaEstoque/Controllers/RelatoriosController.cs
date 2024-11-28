using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;

namespace SistemaConsultaEstoque.Controllers
{
    public class RelatoriosController : Controller
    {
        private readonly string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

        // Ação para carregar o relatório de vendas
        public IActionResult RelatorioVendas()
        {
            DataTable dt = CarregarRelatorioVendas();
            return View("RelatorioVendas", dt); // Confirme que o nome da View é "RelatorioVendas"
        }

        // Método que faz a consulta ao banco e retorna um DataTable
        private DataTable CarregarRelatorioVendas()
        {
            string query = @"
                SELECT 
                    V.venda_id, 
                    C.nome AS cliente, 
                    V.data_venda, 
                    P.nome AS produto, 
                    IV.quantidade, 
                    IV.preco_unitario, 
                    (IV.quantidade * IV.preco_unitario) AS preco_total
                FROM 
                    Vendas V
                INNER JOIN 
                    Clientes C ON V.cliente_id = C.cliente_id
                INNER JOIN 
                    ItensVenda IV ON V.venda_id = IV.venda_id
                INNER JOIN 
                    Produtos P ON IV.produto_id = P.produto_id
                ORDER BY 
                    V.venda_id";

            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dt); // Preenche o DataTable com os dados da consulta
            }

            return dt;
        }
    }
}
