using BibliotecaCadastro;

string[] nome = new string[100];
string[] endereco = new string[100];
string[] telefone = new string[100];
int escolha = 1;
int contador = 0;
int Manter = 0;
int numerador = 0;


if (escolha == 1 || escolha == 2 || escolha == 3)
{
    while (Manter == 0)
    {
        Ferramentas.Menu();
        escolha = Convert.ToInt16(Console.ReadLine());
        switch (escolha)
        {
            case 1:
                {
                    for (int i = 0; i < nome.Length; i++)
                    {
                        Console.Write($"Informe o nome da {i + 1}° pessoa:");
                        nome[i] = Console.ReadLine();
                        Console.Write($"Informe o endereço da {i + 1}° pessoa:");
                        endereco[i] = Console.ReadLine();
                        Console.Write($"Informe  o telefone da {i + 1}° pessoa:");
                        telefone[i] = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Deseja continuar cadastrando? (0 -> Sim/1 -> Não)");
                        Console.Write("Escolha a opção (N°)...........:");
                        Manter = Convert.ToInt16(Console.ReadLine());
                        numerador++;
                        if (Manter != 0)
                        {
                            Manter = 0;
                            break;
                        }
                        else
                        {
                            Manter = 1;
                        }
                        
                    }
                    break;
                }
            case 2:
                {
                    Console.Clear();
                    for (int i = 0; i < numerador; i++)
                    {
                        Console.WriteLine($"{i + 1}° Nome:{nome[contador]}\n{i +1}° Endereço:{endereco[contador]}\n{i+1}° Telefone{telefone[contador]}\nCódigo De Cadastro[{contador}]\n");
                        contador++;
                        
                       
                    }
                    Console.WriteLine("Deseja retornar ? (1 -> Sim)");
                    Console.Write("Escolha a opção (N°)...........:");
                    Manter = Convert.ToInt16(Console.ReadLine());
                    if (Manter != 0)
                    {
                        Manter = 0;
                        break;
                    }
                    else
                    {

                        Manter = 1;
                    }


                    break;
                }
            case 3:
                {
                    Console.Clear();
                    for (int i = 0; i < nome.Length; i++)
                    {
                        Console.Clear();
                        Console.WriteLine("Informe o Código De Cadastro: ");
                        contador = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{contador + 1}° Nome:{nome[contador]}\n{contador + 1}° Endereço:{endereco[contador]}\n{contador + 1}° Telefone{telefone[contador]}\nCódigo De Cadastro[{contador}]\n");
                        Console.WriteLine("Deseja Consitinuar Consulta? ? (0 -> Sim/1 -> Não)");
                        Console.Write("Escolha a opção (N°)...........:");
                        Manter = Convert.ToInt16(Console.ReadLine());
                        if (Manter != 0)
                        {
                            Manter = 0;
                            break;
                        }
                        else
                        {

                            Manter = 1;
                        }
                        

                    }
                    break;
                   
                }
            default:
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Opção invalida");
                    Console.ReadKey();
                    break;
                }
        }



    }
}




