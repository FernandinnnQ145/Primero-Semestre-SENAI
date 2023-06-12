using projeto_produto_interface;

Carrinho carrinho = new Carrinho();


// Instaciar objetos da classe produto
Produto p1 = new Produto(1, "GTA 5", 52.90f);
Produto p2 = new Produto(2, "Detroid Become Human", 120.50f);
Produto p3 = new Produto(3, "Forza", 100f);

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

carrinho.Listar();

Console.WriteLine(@$"

");

carrinho.TotalCarrinho();
Console.WriteLine(@$"

");






Console.WriteLine($"Apos a remoção do codigo 2");

carrinho.Remover(p2);

Console.WriteLine($"");
carrinho.Listar();

Console.WriteLine(@$"

");

carrinho.TotalCarrinho();





Console.WriteLine(@$"

");
Console.WriteLine($"Vamos atualizar um objeto");
// Criar um objeto com os dados atualizados
Produto _novoProduto = new Produto();
_novoProduto.Nome = "Fifa 23";
_novoProduto.Preco = 300f;

carrinho.Atualizar(1, _novoProduto);
Console.WriteLine($"");
carrinho.Listar();
Console.WriteLine(@$"

");

carrinho.TotalCarrinho();




