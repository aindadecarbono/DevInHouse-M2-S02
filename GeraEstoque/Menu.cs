namespace GeraEstoque;

public class Menu
{
  public static void Show()
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

    switch (int.Parse(Console.ReadLine()))
    {
      case 1: Cadastro.CadastrarProduto(); break;

      default: Show(); break;
    }

  }
}
