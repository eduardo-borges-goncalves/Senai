// Crie Menu (Adicionar uma cor para o texto do menu, valor inicial de saldo é 0)
// - operações: consulta saldo, depósito, saque, histórico, sair

// Crie método de consulta de saldo e implemente a lógica necessária e o 
// resultado esperado

// Crie método de histórico de operação - para armazenar em uma lista as 
// operações e valores da transação (como se fosse um extrato bancário)

using System.Globalization;

class Program {

  static void Main (string [] args) {
    var option = "0";
    float balance = 0;
    var historic = new List<string>();

    void Deposit (float value) {
      balance += value;
      var deposit = value.ToString("C", CultureInfo.CurrentCulture);
      Console.WriteLine($"Deposito de {deposit} realizado com sucesso!");
      historic.Add($"Depósito de {deposit}");
    };

    void Withdraw (float value) {
      balance -= value;
      var withdraw = value.ToString("C", CultureInfo.CurrentCulture);
      Console.WriteLine($"Saque de {withdraw} realizado com sucesso!");
      historic.Add($"Saque de {withdraw}");
    };

    void ShowBalance () {
      Console.WriteLine($"Saldo atual: {balance
        .ToString("C", CultureInfo.CurrentCulture)}");
    };

    void ShowHistoric () {
      Console.WriteLine("Histórico de Operações:");
      foreach (var item in historic) {
        Console.WriteLine(item);
      }
    };

    do {
      Console.WriteLine("\nDigite a opção desejada: ");
      Console.WriteLine("1 - Sacar");
      Console.WriteLine("2 - Depositar");
      Console.WriteLine("3 - Saldo");
      Console.WriteLine("4 - Histórico");
      Console.WriteLine("S - Sair \n");

      option = Console.ReadLine().ToUpper();
      switch (option) {
        case "1":
          Console.Write("Digite o valor do saque: ");
          var value = float.Parse(Console.ReadLine());
          Withdraw(value);
          break;
        case "2":
          Console.Write("Digite o valor do depósito: ");
          value = float.Parse(Console.ReadLine());
          Deposit(value);
          break;
        case "3": 
          ShowBalance();
          break;
        case "4":
          ShowHistoric();
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