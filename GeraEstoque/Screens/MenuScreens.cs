namespace GeraEstoque.Screens;

public static class MenuScreens
{
  public static void Iniciar()
  {
    Console.Clear();

    Console.WriteLine("Seja bem vindo ao GeraEstoque 1.0");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("1  Cadastrar produto");
    Console.WriteLine("2  Consultar produto");
    Console.WriteLine("3  Modificar produto");
    Console.WriteLine("4  Excluir produto");
    Console.WriteLine("0  Sair");

    Console.WriteLine(string.Empty);

    Console.Write("Digite a opção: ");

    switch (Console.ReadLine())
    {
      case "0": Console.Clear(); Environment.Exit(0); break;

      case "1": Cadastro.CadastrarProduto(); break;

      case "2": Iniciar(); break;

      case "3": Iniciar(); break;

      case "4": Iniciar(); break;

      default: Iniciar(); break;
    }
  }

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
    var id = Guid.NewGuid();

    Console.Clear();

    Console.WriteLine("Produto cadastrado com sucesso!");
    Console.WriteLine("======================");
    Console.WriteLine(string.Empty);

    Console.WriteLine($"ID: {id}");
    Console.WriteLine($"Nome: {nomeProduto}");
    Console.WriteLine($"Qtd: {quantidadeEstoque}");
    Console.WriteLine($"R$ Compra: R${valorCompra}");
    Console.WriteLine($"R$ Venda: R${valorVenda}");

    Console.WriteLine(string.Empty);
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    MenuScreens.Iniciar();
  }
}