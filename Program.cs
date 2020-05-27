using System;
//facilitar na escrita
using static System.Console;
namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            //interação simples
            Console.WriteLine("\n------------Hello World! It's a nice day, today - Codsworth----------\n");

            //classe e obj
            Celular celular = new Celular();
            WriteLine("Qual cor do aparelho: ");
            celular.cor = ReadLine();

            WriteLine("\nDigite o modelo: ");
            celular.modelo = ReadLine();

            WriteLine("\nDigite o tamanho do aparelho (numerico): ");
            celular.tamanho = float.Parse(Console.ReadLine());

            WriteLine("\nDeseja ligar o telefone? S/N ");
            celular.ligado = celular.Ligar(Console.ReadLine());

            //tratativa de decisões
            WriteLine("\n O que deseja fazer agora: (d)Desligar,(c)chamar,(m)mensagem");
            string resposta = ReadLine();
            //inicio swt
            switch(resposta){
                case "d":
                    WriteLine("Telefone desligado com sucesso");
                break;
                case "c":
                    if(celular.ligado == true){
                        string nome;
                        WriteLine("Para quem você deseja ligar? ");
                        nome = ReadLine();
                        WriteLine("\nLigando para "+nome+"...");
                        WriteLine("Ligação Feita com sucesso.");
                    }else{
                        WriteLine("Ligue seu telefone");
                    }
                break;
                case "m":
                    if(celular.ligado == true){
                        string nomeMsg;
                        
                        WriteLine("Para quem você deseja mandar msg? ");
                        nomeMsg = ReadLine();

                        WriteLine("\nEscreva sua msg: ");
                        ReadLine();

                        WriteLine("\nSua msg foi enviada com sucesso.");
                    }else{
                        WriteLine("Ligue seu telefone");
                    }
                break;
                default:
                    WriteLine("Opção não encontrada");
                break;
            }
            //fim swt
        }
    }
}
