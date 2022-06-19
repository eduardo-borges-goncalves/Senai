class Program {

  static void Main (string [] args) {
    var option = "1";

    static (double, double) InsertNumbers() {
      Console.Write("Digite o primeiro número: ");
      var num1 = double.Parse(Console.ReadLine());
      Console.Write("Digite o segundo número: ");
      var num2 = double.Parse(Console.ReadLine());
      return (num1, num2);
    }

    do {
      Console.WriteLine("\nDigite a opção desejada: ");
      Console.WriteLine("1 - Somar");
      Console.WriteLine("2 - Subtrair");
      Console.WriteLine("3 - Multiplicar");
      Console.WriteLine("4 - Dividir");
      Console.WriteLine("S - Sair");

      option = Console.ReadLine().ToUpper();

      switch (option) {
        case "1":
          var (num1, num2) = InsertNumbers();
          Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
          break;
        case "2":
          var (num3, num4) = InsertNumbers();
          Console.WriteLine($"{num3} - {num4} = {num3 - num4}");
          break;
        case "3": 
          var (num5, num6) = InsertNumbers();
          Console.WriteLine($"{num5} * {num6} = {num5 * num6}");
          break;
        case "4":
          var (num7, num8) = InsertNumbers();
          Console.WriteLine($"{num7} / {num8} = {num7 / num8}");
          break;
        case "S":
          Console.WriteLine("Saindo...");
          break;
        default:
          Console.WriteLine("Opção inválida!");
          break;
      };
    } while (option != "S");
  }
}