using System;
using System.Threading;

namespace AULA14PROJETOUBER
{
    class Program
    {
        static void Main(string[] args)
        {
                       Usuario vinicius = new Usuario();
                        inicio:
                        Console.Clear();
                                           Console.WriteLine("deseja fazer login como: \n 1-Administrador \n 2-Passageiro \n 3-Motorista ");
                    int resposta  = int.Parse( Console.ReadLine() );

                    switch(resposta){

                        case 1:
                                    System.Console.WriteLine("Digite seu login:");
                                    string loginAdm = Console.ReadLine();

                                    System.Console.WriteLine("Digite sua senha:");
                                    string senhaAdm = Console.ReadLine();

                                    vinicius.LoginAdm( loginAdm, senhaAdm);

                                    if( vinicius.TokenLogin != "" && vinicius.TokenLogin != null ){
                                        
                                        System.Console.WriteLine("Login autorizado!");
                                    Console.WriteLine( "bem vindo administrador");

                                    }else{
                                        System.Console.WriteLine("Não é possível utilizar o app");
                                        Thread.Sleep(2000);
                                        goto inicio;
                                    }
                                    break;

                        case 2:
                                    System.Console.WriteLine("Digite seu login:");
                                    string loginPass = Console.ReadLine();

                                    System.Console.WriteLine("Digite sua senha:");
                                    string senhaPass = Console.ReadLine();

                                    vinicius.LoginPass( loginPass, senhaPass);

                                    if( vinicius.TokenLogin != "" && vinicius.TokenLogin != null ){
                                        Console.Clear();
                                        Thread.Sleep(1000);
                                        System.Console.WriteLine("Login autorizado!");
                                        passageiro:
                                    Console.WriteLine( "bem vindo passageiro");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        System.Console.WriteLine("O que deseja fazer ? \n Menu  : \n 1-Solicitar corrida \n 2-Cadastrar Cartão\n 3-Excluir Cartão \n 4-Logout");
                                        int menu = int.Parse(Console.ReadLine());
                                        switch(menu){
                                            case 1:
                                            Console.Clear();
                                            System.Console.WriteLine("Seu local de partida é:");
                                            System.Console.WriteLine(vinicius.LocalInicio);
                                            System.Console.WriteLine("Seu local de chegada é:");
                                            System.Console.WriteLine(vinicius.LocalChegada);
                                            System.Console.WriteLine(vinicius.SolicitarMotorista());
                                            Thread.Sleep(3000);
                                            Console.Clear();
                                            System.Console.WriteLine(vinicius.motorista());
                                            System.Console.WriteLine(vinicius.carro);
                                            System.Console.WriteLine(vinicius.placa);
                                            Thread.Sleep(5000);
                                            Console.Clear();
                                            System.Console.WriteLine("O motorista chegou, deseja entrar no carro?\n 1-Sim\n2-Não");
                                            int decidir = int.Parse(Console.ReadLine());
                                            Console.Clear();
                                                switch(decidir){
                                                    case 1:
                                                    System.Console.WriteLine("Viagem em andamento...");
                                                    Thread.Sleep(6000);
                                                    System.Console.WriteLine("chegamos");
                                                    break;
                                                    case 2:
                                                    System.Console.WriteLine("Robervaldo diz: A corrida irá ser cancelada e você vai arcar com os custos");
                                                    Thread.Sleep(5000);
                                                    System.Console.WriteLine(vinicius.corrida());
                                                    Thread.Sleep(5000);
                                                    goto passageiro;
                                                    break;
                                                    default:
                                                    System.Console.WriteLine(vinicius.corrida());
                                                    Thread.Sleep(5000);
                                                    goto passageiro;
                                                    break;
                                                }
                                            break;
                                            case 2:
                                                System.Console.WriteLine(vinicius.Cadastrar());
                                                Thread.Sleep(4000);
                                                Console.Clear();
                                                 System.Console.WriteLine("Cadastro efetuado \n Titular:");
                                                System.Console.WriteLine(vinicius.titular);
                                                System.Console.WriteLine("Bandeira:");
                                                System.Console.WriteLine(vinicius.bandeira);
                                                System.Console.WriteLine("Cvv: ");
                                                System.Console.WriteLine(vinicius.cvv);
                                                Thread.Sleep(5000);
                                                goto passageiro;
                                            break;
                                            case 3:
                                                System.Console.WriteLine(vinicius.ExcluirCartao());
                                                Thread.Sleep(5000);
                                                Console.Clear();
                                                goto passageiro;
                                            break;
                                            case 4:
                                                Console.Clear();
                                                System.Console.WriteLine(vinicius.Logout());
                                                Thread.Sleep(4000);
                                                goto inicio;
                                            default:
                                                System.Console.WriteLine("selecione uma opção válida");
                                            break;

                                        }

                                    }else{
                                        System.Console.WriteLine("Não é possível utilizar o app");
                                    }
                                    break;
                        case 3:
                                    System.Console.WriteLine("Digite seu login:");
                                    string loginMotorista = Console.ReadLine();

                                    System.Console.WriteLine("Digite sua senha:");
                                    string senhaMotorista = Console.ReadLine();

                                    vinicius.LoginMotorista( loginMotorista, senhaMotorista);

                                    if( vinicius.TokenLogin != "" && vinicius.TokenLogin != null ){
                                        Console.Clear();
                                        Thread.Sleep(1000);
                                        System.Console.WriteLine("Login autorizado!");
                                        motorista:
                                        Console.WriteLine( "bem vindo motorista\n");
                                        System.Console.WriteLine("Veículo cadastrado:");
                                        System.Console.WriteLine(vinicius.carro);
                                        System.Console.WriteLine("A placa do seu veículo é:");
                                        System.Console.WriteLine(vinicius.placa);
                                        Thread.Sleep(6000);
                                        Console.Clear();
                                        System.Console.WriteLine("O que deseja fazer ? \n Menu  : \n 1-Buscar Corrida \n 2-Cadastrar Conta \n 3-Excluir Conta \n 4-Logout");
                                        int motor = int.Parse(Console.ReadLine());
                                        switch(motor){
                                            case 1:
                                            break;
                                            case 2:
                                            System.Console.WriteLine(vinicius.CadastroConta());
                                                Thread.Sleep(4000);
                                                Console.Clear();
                                                 System.Console.WriteLine("Cadastro efetuado \n Conta:");
                                                System.Console.WriteLine(vinicius.conta);
                                                System.Console.WriteLine("Agência:");
                                                System.Console.WriteLine(vinicius.agencia);
                                                Thread.Sleep(5000);
                                                goto motorista;
                                            break;
                                            case 3:
                                                System.Console.WriteLine(vinicius.ExcluirConta());
                                                Thread.Sleep(5000);
                                                Console.Clear();
                                                goto motorista;
                                            break;
                                            case 4:
                                                Console.Clear();
                                                System.Console.WriteLine(vinicius.Logout());
                                                Thread.Sleep(4000);
                                                goto inicio;
                                                break;
                                            default:
                                            break;
                                        }
                                    }else{
                                        System.Console.WriteLine("Não é possível utilizar o app");
                                        goto inicio;
                                    }
                                    break;

                        default:
                        Console.WriteLine( "tente novamente" );
                        goto inicio;
                        break;
                    }    


        }
    }
}
