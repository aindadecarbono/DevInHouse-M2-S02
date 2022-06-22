using GeraEstoque.Models;
namespace GeraEstoque.Repositories;

public class ProdutoRepository
{
  IList<string> Produtos;

  public ProdutoRepository()
  {
    Produtos = new List<string>();
  }
}