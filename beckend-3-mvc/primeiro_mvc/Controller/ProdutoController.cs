using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using primeiro_mvc.Model;
using primeiro_mvc.View;
namespace primeiro_mvc.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();


        // Metodo controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos);
        }

        public void CadastarProduto(){
            Produto novoProduto = produtoView.Cadastar();
            produto.Inserir(novoProduto);
        }


    }
}