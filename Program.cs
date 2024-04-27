using System.Runtime.ConstrainedExecution;

int escolha = 0;
float multiplicador_euro = 0;
float multiplicador_iene = 0;
int multiplicador_dolar = 1;
float multiplicador_real = 0;
float dolar = 0;
float final = 0;
do {

    Console.WriteLine("Qual a opção desejada?");
    Console.WriteLine(" 1 - Inserir valor das moedas \n 2 - Realizar conversão \n 3 - Sair");
    escolha = int.Parse(Console.ReadLine());

    if (escolha == 1)
    {
        Console.WriteLine("Digite o valor do euro em relação ao Dolar ");
        multiplicador_euro = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor iene em relação ao Dolar ");
        multiplicador_iene = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor real em relação ao Dolar ");
        multiplicador_real = float.Parse(Console.ReadLine());

        multiplicador_dolar = 1;
        Console.ReadKey();
        Console.Clear();

    }
    if (escolha == 2)
    {
        Console.WriteLine("Selecione a moeda de origem: ");
        Console.WriteLine(" 1 - Euro \n 2 - Dolar \n 3 - Real \n 4 - Iene");
        int moeda_origem = int.Parse(Console.ReadLine());
        Console.WriteLine("Agora escolha a moeda destino ");
        int moeda_destino = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira a quantidade da moeda origem a ser convertida:");
        float quantidade = int.Parse(Console.ReadLine());

        float geral = 0;
        if(moeda_origem == 2) 
        {
            geral = 1;
        }
        if(moeda_origem == 1)
        {
            geral = multiplicador_euro;
        }
        if(moeda_origem == 3)
        {
            geral = multiplicador_real;
        }
        if(moeda_origem == 4)
        {
            geral = multiplicador_iene;
        }

        dolar = quantidade * geral;

        if(moeda_destino == 1)
            final = dolar * multiplicador_euro;
        if (moeda_destino == 2)
            final = dolar; 
        if (moeda_destino == 3)
            final = dolar * multiplicador_real;
        if (moeda_destino == 4)
            final = dolar * multiplicador_iene;
        

        Console.WriteLine($"{quantidade} moeda origem = {final} ");
    }
   
} while (escolha != 3);