Console.WriteLine("#### CALCULADORA SIMPLES ####\n");

static void Menu(){
    Console.WriteLine("Operações que podem ser feitas:");
    Console.WriteLine("\t1 - Adição");
    Console.WriteLine("\t2 - Subtração");
    Console.WriteLine("\t3 - Multiplicação");
    Console.WriteLine("\t4 - Divisão");
}

static int recebeOperac(){
    dynamic ?op;
    
    do{
        Console.Write("Insira o número da operação desejada: ");
        op = Console.ReadLine();
        if(op == "") Console.WriteLine("Por favor insira uma opção válida");
    }while (op == "");
    
    int opInt = int.Parse(op);
    return opInt;
}

static float recebeNumero(){
    dynamic ?num;
    
    do{
        Console.Write("Insira um número: ");
        num = Console.ReadLine();
        if(num == "") Console.WriteLine("Por favor insira um número válida");
        
    }while(num == "");

    float numF = float.Parse(num);
    return numF;
}

do{
    Menu();
    int oper;

    do{ oper = recebeOperac(); } while(oper < 0 || oper > 4);

    float n1 = recebeNumero();
    float n2 = recebeNumero();

    switch (oper){
        case 1: 
            float soma = n1 + n2;
            Console.WriteLine("O resultado da sua soma é: " + soma);
            break;
        case 2:
            float sub = n1 - n2;
            Console.WriteLine("O resultado da sua subtração é: " + sub);
            break;
        case 3:
            float mult = n1 * n2;
            Console.WriteLine("O resultado da sua multiplicação é: " + mult);
            break;
        case 4:
            float div = n1 / n2;
            Console.WriteLine("O resultado da sua divisão é: " + div);
            break;
    }

    Console.Write("Deseja fazer mais operações simples:\n1-Sim\n2-Não\n");
    string ?cont = Console.ReadLine();
    if(cont != "1") break;
    else Console.WriteLine("Ok, vamos continuar então...");
}while(true);


Console.ReadLine();