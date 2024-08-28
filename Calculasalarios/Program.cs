string[] historico = new string[10];
int indiceHistórico  = 0;

while(true){
    Console.Clear();
    Console.WriteLine("\n\n\n\t\t\t\t\tMENU");
    Console.WriteLine("Pressione F1 para calcular o salário líquido");
    Console.WriteLine("Pressione F2 para calcular o 13° salário");
    Console.WriteLine("Pressione F3 para exibir o histórico de cálculos");
    Console.WriteLine("Pressione DEL para sair");
    ConsoleKeyInfo tecla = Console.ReadKey(true);

    if (tecla.Key == ConsoleKey.Enter)
    {
        Console.WriteLine("Digite o valor da hora trabalhada");
        double valorHora = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o número de horas trabalhadas: ");
        double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o desconto total (em %):");
        double desconto = Convert.ToDouble(Console.ReadLine());

        double salarioBruto = valorHora * horasTrabalhadas;
        double salarioLiquido = salarioBruto * (1 - desconto / 100);

        Console.WriteLine($"O saláro bruto é: R${salarioBruto:F2}");
        Console.WriteLine($"O saláro bruto é: R${salarioLiquido:F2}");

        //armazena no vetor
        if (indiceHistórico < historico.Length)
        {
            historico[indiceHistórico] = $"Salário Líquido: R$ {salarioLiquido: F2}";
            indiceHistórico++;
        }
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    } // esta chave fecha o if do F1

    else if (tecla.Key != ConsoleKey.F2)
    {
        Console.Clear();
        Console.WriteLine("Digite o salário bruto: ");
        double salarioBruto = Convert.ToDouble(Console.ReadLine());
    }// esta chave fecha o if do F2
}