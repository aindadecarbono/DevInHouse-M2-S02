namespace GeraEstoque;

public class Cadastro
{
  public static void CadastrarProduto()
  {
    IniciaConsole();
    PreencherDados();
  }

  static void IniciaConsole()
  {
    Console.Clear();
    Console.WriteLine("Cadastro de produto");
    Console.WriteLine("===================");
    Console.WriteLine(string.Empty);
  }

  static void PreencherDados()
  {
    Console.Write("Digite o nome do produto: ");
    string nomeProduto = Console.ReadLine().ToString();
    Console.Write("Digite a quantidade em estoque: ");
    ushort quantidadeEstoque = Convert.ToUInt16(Console.ReadLine());
    Console.Write("Digite o valor de compra: ");
    uint valorCompra = Convert.ToUInt32(Console.ReadLine());
    Console.Write("Digite o valor de venda: ");
    uint valorVenda = Convert.ToUInt32(Console.ReadLine());
    Console.ReadLine();
    Console.Clear();
    Environment.Exit(0);
  }
}