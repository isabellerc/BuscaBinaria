using System; // Importa a biblioteca básica do C# que permite usar comandos como Console.ReadLine e Console.WriteLine

class Programa // Define a classe principal do programa
{
    // Método que executa a busca binária em um vetor de inteiros
    static int BuscaBinaria(int[] vetor, int valorProcurado)
    {
        int inicio = 0; // Define o início da busca como o primeiro índice do vetor
        int fim = vetor.Length - 1; // Define o fim da busca como o último índice do vetor

        // Enquanto o início for menor ou igual ao fim, continua buscando
        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2; // Calcula o índice do meio da parte do vetor que está sendo analisada

            // Mostra as posições analisadas no momento
            Console.WriteLine($"Verificando entre as posições {inicio} e {fim}. Meio: {meio}");

            if (vetor[meio] == valorProcurado) // Se o valor no meio for o valor procurado
            {
                return meio; // Retorna a posição onde o valor foi encontrado
            }
            else if (vetor[meio] < valorProcurado) // Se o valor no meio for menor que o procurado
            {
                inicio = meio + 1; // Atualiza o início para a posição seguinte ao meio
            }
            else // Se o valor no meio for maior que o procurado
            {
                fim = meio - 1; // Atualiza o fim para a posição anterior ao meio
            }
        }

        return -1; // Se sair do loop, significa que o valor não foi encontrado
    }

    static void Main(string[] args) // Função principal que roda o programa
    {
        // Pede ao usuário para digitar os elementos do vetor
        Console.WriteLine("Digite os elementos do vetor em ordem crescente, separados por espaço:");
        string[] entrada = Console.ReadLine().Split(' '); // Lê a linha digitada e separa os números em um array de strings

        // Cria um vetor de inteiros com o mesmo tamanho do array de strings
        int[] vetor = new int[entrada.Length];

        // Converte cada elemento da string em inteiro, manualmente
        for (int i = 0; i < entrada.Length; i++)
        {
            vetor[i] = int.Parse(entrada[i]); // Converte cada string para inteiro e armazena no vetor
        }

        // Pede ao usuário para digitar o número que deseja buscar
        Console.WriteLine("Digite o valor que deseja buscar:");
        int valorProcurado = int.Parse(Console.ReadLine()); // Lê o número a ser buscado e converte para inteiro

        // Chama a função de busca binária e armazena o resultado
        int resultado = BuscaBinaria(vetor, valorProcurado);

        // Verifica o resultado da busca e mostra a mensagem apropriada
        if (resultado != -1)
        {
            Console.WriteLine($"Valor encontrado na posição {resultado}."); // Se encontrou, mostra a posição
        }
        else
        {
            Console.WriteLine("Valor não encontrado no vetor."); // Se não encontrou, mostra mensagem de erro
        }
    }
}
