using GeraEstoque.Screens;
using GeraEstoque.Repositories;
namespace GeraEstoque;

public class Program
{
  static void Main(string[] args)
  {

    ProdutoRepository produtoRepository = new ProdutoRepository();
    MenuScreens.Iniciar(produtoRepository);

  }

}

