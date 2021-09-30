using System;

namespace ProvaPoo
{
    class Program
    {
        //Programa que simula algumas operações simples de um Caixa Eletrônico.
        static void Main(string[] args)
        {
            string nomeCliente; //variavel utilizada para guardar o Nome do cliente que está utilizando o programa.
            double valorSaque; //variavel utilizada para guardar o valor que será retirado da conta do cliente.
            double valorDeposito; //variavel utilizada para guardar o valor que será depositado na conta do cliente.
            double saldoConta; //varialvel utilizada para guardar o valor total do saldo da conta do cliente.
            int numeroConta; // variavel utilizada para guardar o numero da conta criado pelo usuario.
            string escolha; //variavel utilizada para armazenar a opção escolhida pelo usuario.

            Console.WriteLine("=== Caixa Eletrônico ===");
            Console.WriteLine();

            Console.WriteLine("---Cadastrar Conta---");
            Console.WriteLine("Digite um número para sua conta:");
            numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do cliente:");
            nomeCliente = Console.ReadLine();
            Console.WriteLine("Deposite um saldo inicial:");
            saldoConta = double.Parse(Console.ReadLine());
            Console.WriteLine();

            do
            {
                Console.WriteLine("=== Caixa Eletrônico ===");
                Console.WriteLine();

                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine();

                Console.WriteLine("[1]-Acessar conta ");
                Console.WriteLine("[S]-Sair");
                escolha = Console.ReadLine();
                Console.WriteLine();

                switch (escolha)
                {
                    case "1":

                        escolha = "";
                        Console.WriteLine("=== Caixa Eletrônico ===");
                        Console.WriteLine();

                        Console.WriteLine("///Conta {0}///", numeroConta);
                        Console.WriteLine("Bem vindo {0} !", nomeCliente);
                        Console.WriteLine();

                        do
                        {

                            Console.WriteLine("Selecione uma das opções:");
                            Console.WriteLine();

                            Console.WriteLine("[1]-Realizar deposito");
                            Console.WriteLine("[2]-Realizar saque");
                            Console.WriteLine("[3]-Consultar saldo");
                            Console.WriteLine("[S]-Sair");
                            Console.WriteLine();

                            escolha = Console.ReadLine();

                            switch (escolha)
                            {
                                case "1":

                                    escolha = "";
                                    Console.WriteLine("Quanto deseja depositar?");
                                    valorDeposito = double.Parse(Console.ReadLine());
                                    Console.WriteLine("O valor depositado será R${0}, confirmar deposito?", valorDeposito);
                                    Console.WriteLine("[1]-Sim");
                                    Console.WriteLine("[2]-Não");
                                    escolha = Console.ReadLine();

                                    if (escolha == "1")
                                    {
                                        Console.WriteLine("[DEPOSITO FINALIZADO]");
                                        Console.WriteLine("---Saldo antigo R${0}---", saldoConta);
                                        saldoConta = valorDeposito + saldoConta;
                                        Console.WriteLine("---Saldo atualizado R${0}---", saldoConta);
                                        Console.WriteLine();
                                    }

                                    if (escolha == "2")
                                    {
                                        Console.WriteLine("[DEPOSITO CANCELADO]");
                                        Console.WriteLine();
                                    }

                                    break;

                                case "2":

                                    escolha = "";
                                    Console.WriteLine("Quanto deseja sacar?");
                                    valorSaque = double.Parse(Console.ReadLine());

                                    if (valorSaque > saldoConta)
                                    {
                                        Console.WriteLine("[ERRO] não é possivel sacar essa quantia.");
                                        Console.WriteLine(); break;
                                    }

                                    Console.WriteLine("Você deseja sacar R${0} ?", valorSaque);
                                    Console.WriteLine("[1]-Sim");
                                    Console.WriteLine("[2]-Não");
                                    escolha = Console.ReadLine();

                                    if (escolha == "1")
                                    {
                                        Console.WriteLine("[SAQUE FINALIZADO]");
                                        Console.WriteLine("---Saldo antigo R${0}---", saldoConta);
                                        saldoConta = saldoConta - valorSaque;
                                        Console.WriteLine("---Saldo atualizado R${0}---", saldoConta);
                                        Console.WriteLine();
                                    }

                                    if (escolha == "2")
                                    {
                                        Console.WriteLine("[SAQUE CANCELADO]");
                                        Console.WriteLine();
                                    }

                                    break;

                                case "3":
                                    Console.WriteLine("---Seu saldo atual é de R${0}---", saldoConta);
                                    Console.WriteLine();
                                    break;

                                default:
                                    Console.WriteLine("[ERRO] Opção inválida.");
                                    Console.WriteLine();
                                    break;

                            }
                        } while (escolha != "s" && escolha != "S");

                        break;
                }

            } while (escolha != "s" && escolha != "S");

        }
    }
}
