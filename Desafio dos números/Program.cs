using System;

namespace Passagem_por_valor_e_referencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int desafiado, desafiador;
            int tent = 1;
            string acertou = "";
            string errou = "";
            int qtd_chances = 3;
            msgCorreta(ref acertou);
            msgErrada(ref errou);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Informe agora o seu valor: ");
            desafiador = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Você ainda tem {qtd_chances--} chances, qual número você acha que é?: ");
                desafiado = int.Parse(Console.ReadLine());


                if (desafiado == desafiador)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(acertou);
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errou);

                }
                tent++;

                if (tent > 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    string kkk = ("Acabou as suas chances!");
                    Console.Write(kkk);
                }


            }


        }

        static void msgErrada(ref string errado)
        {
            errado = "\nErro, tente novamente!";
        }

        static void msgCorreta(ref string correto)
        {
            correto = "\nParabéns, você acertou!";
        }


    }
}