using GeraEstoque.Models;
namespace GeraEstoque.Repositories;

public class ProdutoRepository
{
  public IList<string> Produtos;

  public ProdutoRepository()
  {
    Produtos = new List<string>();
  }
}