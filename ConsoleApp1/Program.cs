// Entrada da calculadora
Console.WriteLine("BEM-VINDO(A) A CALCULADORA 4 FUNÇÕES!");
Console.WriteLine("Ela faz (Adição / Subtração / Multiplicação / Divisão)\nVamos começar?\n");

// Variável
int opcao = 0;

// Loop até usuário escolher sair
// Enquanto a opção for diferente de 5
while (opcao != 5)
{
    // Exibe o menu de escolha para usuário
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Sair");

    // Pega a opção do usuário  
    opcao = int.Parse(Console.ReadLine()); // Lendo a linha

    // Se a opção for válida (entre 1 e 5), prossegue
    if (opcao >= 1 && opcao <= 5)
    {
        // Se a opção for sair, o loop termina
        if (opcao == 5)
        {
            Console.WriteLine("Saindo da calculadora...");
            Console.WriteLine("Obrigada por utilizar! Criado e desenvolvido por: Heloísa Real - 554535");
            break;
        }

        // Solicita os dois números ao usuário
        Console.WriteLine("Digite o primeiro número:");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        double numero2 = double.Parse(Console.ReadLine());

        // Variável para armazenar o resultado
        double resultado = 0;

        // Estrutura de controle switch para verificar a operação escolhida, vendo os casos
        switch (opcao)
        {
            case 1: // Adição
                resultado = numero1 + numero2;
                Console.WriteLine($"Resultado da Adição: {numero1} + {numero2} = {resultado}\n");
                break;

            case 2: // Subtração
                resultado = numero1 - numero2;
                Console.WriteLine($"Resultado da Subtração: {numero1} - {numero2} = {resultado}\n");
                break;

            case 3: // Multiplicação
                resultado = numero1 * numero2;
                Console.WriteLine($"Resultado da Multiplicação: {numero1} * {numero2} = {resultado}\n");
                break;

            case 4: // Divisão
                    // Verifica se o segundo número não é zero para evitar divisão por zero
                if (numero2 == 0)
                {
                    Console.WriteLine("Erro: Não é possível dividir por zero.\n");
                }
                else
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine($"Resultado da Divisão: {numero1} / {numero2} = {resultado}\n");
                }
                break;
        }
    }
    else
    {
        // Se a opção for inválida, exibe uma mensagem de erro
        Console.WriteLine("Opção inválida! Por favor, escolha uma opção entre 1 e 5.\n");
    }
}