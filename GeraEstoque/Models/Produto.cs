namespace GeraEstoque.Models;

public class Produto
{
  string NomeProduto;
  ushort QuantidadeEstoque;
  uint ValorCompra;
  uint ValorVenda;
  Guid Id;

  public Produto()
  {

  }

  public Produto(string nomeProduto, ushort quantidadeEstoque, uint valorCompra, uint valorVenda)
  {

    NomeProduto = nomeProduto;
    QuantidadeEstoque = quantidadeEstoque;
    ValorCompra = valorCompra;
    ValorVenda = valorVenda;
    Id = Guid.NewGuid();

  }

  public override string ToString()
  {
    return "Produto: Id: XXXX |  Nome: XXX | Qtd: XXX | R$ Compra: XXX | R$ Venda: XXX";
  }


}