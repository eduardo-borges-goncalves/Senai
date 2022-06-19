// Entrada: notas de 6 alunos e mostre como.
// Saída: deve mostrar a média da nota da prova 
// e o total de quantos tiveram nota maior que 7;
// nota menor que 7 e maior que 0 e notas igual a 0.

class Program {
  static void Main (string [] args) {

    List<float> notas = new List<float>(){
      0,0,0,0,0,0,
    };
    float media = 0;
    float total = 0;
    var biggerThanSeven = 0;
    var smallerThanSeven = 0;
    var equalToZero = 0;
  
    for (int i = 0; i < notas.Count; i++) {
      Console.Write("Digite a nota do aluno: ");
      notas[i] = float.Parse(Console.ReadLine());

      total += notas[i];
      media = total / notas.Count;

      switch (notas[i]) {
        case 0:
          equalToZero++;
          break;
        case > 7:
          biggerThanSeven++;
          break;
        case < 7:
          smallerThanSeven++;
          break;
      }
    }

    Console.Write(
      $" A média da turma foi {Math.Round(media, 2)};\n {biggerThanSeven} tiraram mais que 7;\n {smallerThanSeven} tiraram mais que 0 e menos que 7;\n {equalToZero} alunos tiraram 0.");
  }
}