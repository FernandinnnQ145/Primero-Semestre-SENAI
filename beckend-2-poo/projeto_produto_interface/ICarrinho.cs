using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produto_interface
{
    public interface ICarrinho
    {
        // Regras do "contrato"
        // metodos que deverao aqui ser declarados apenas

        // CRUD: Create, Read, Update, Delete

        // padrao de chamada de metodo
        // tipo nome(parametros)

        // Create
        void Adicionar(Produto _produto);

        // Read
        void Listar();

        // Update
        void Atualizar(int _codigo, Produto _novoProduto);

        // Delete
        void Remover(Produto _produto);
    }
}