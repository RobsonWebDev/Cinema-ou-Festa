/*
Exercicio proposto pelo professor Braga da faculdade VINCIT apenas para ler duas variaveis e retornar se seria possivel escolher entre o Cinema e a Balada, porem quis adicionar algumas petições ao usuario que fara o programa calcular com base no salário do mes e sinalizando para o usuário se será possivel desfrutar da festa ou do cinema ou os dois :). Quero trabalhar apenas com valores inteiros por equanto.
*/

int salarioBruto, contaLuz, contaAgua, contaNet, compraMercado, valorCinema, valorFesta, salarioLiq, valorLazer;

Console.WriteLine("Salário do Mês: ");
salarioBruto = int.Parse(Console.ReadLine());

Console.WriteLine("Valor da Conta de Luz: ");
contaLuz = int.Parse(Console.ReadLine());

Console.WriteLine("Valor da Conta de Água: ");
contaAgua = int.Parse(Console.ReadLine());

Console.WriteLine("Valor da Intenet: ");
contaNet = int.Parse(Console.ReadLine());

Console.WriteLine("Valor da Compra no Supermercado para o mês: ");
compraMercado = int.Parse(Console.ReadLine());

Console.WriteLine("De quanto você precisa para ir no Cinema? ");
valorCinema = int.Parse(Console.ReadLine());

Console.WriteLine("De quanto você precisa para ir a Festa? ");
valorFesta = int.Parse(Console.ReadLine());


salarioLiq = salarioBruto - (contaLuz + contaAgua + contaNet + compraMercado);
valorLazer = valorCinema + valorFesta;

Console.WriteLine("Seu Salario Liquido é: ");
Console.WriteLine(salarioLiq);
Console.WriteLine("Seu gasto com o Lazer é: ");
Console.WriteLine(valorLazer);

if(salarioLiq <= valorLazer) {
    Console.WriteLine("Nao será possivel ir aos dois eventos.");
    if (salarioLiq >= valorCinema && salarioLiq <= valorFesta) {
        Console.WriteLine("Ebaaa! Você Pode ir ao Cinema.");
    } else if (salarioLiq >= valorFesta && salarioLiq <= valorCinema) {
        Console.WriteLine("Uhuu! Você pode ir a festa.");
    } else {
        Console.WriteLine("Você pode escolher em qual poderá ir");
    }
} else {
    Console.WriteLine("Aeehh! Que Legal você conseguira curtir a Festa e o Cinema.");
}


Console.ReadKey();