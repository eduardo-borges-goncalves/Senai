class Program {
  static void Main (string [] args ) {
    Console.Write("Digite o nome do funcionário: ");
    string name = Console.ReadLine();
    Console.Write("Digite o ano de nascimento: ");
    int year = int.Parse(Console.ReadLine());
    Console.Write("Digite o salário do funcionário: ");
    double salary = double.Parse(Console.ReadLine());
    Console.Write("Digite a porcentagem do reajuste: ");
    double readjustment = double.Parse(Console.ReadLine());

    Console.WriteLine(
      $"{name} têm {2022 - year} anos e ganha R$ {salary + ((salary * readjustment) / 100)}");





  }
}
