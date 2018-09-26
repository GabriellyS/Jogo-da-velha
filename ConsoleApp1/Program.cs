using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("\n     1 - Numero sorteado");
            Console.WriteLine("     2 - Jogo da velha");
            Console.WriteLine("     3 - Descobrir numero menor");
            Console.WriteLine("\n \n Qual opção?");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    NumeroSorteado();
                    break;

                case 2:
                    Console.Clear();
                    int[,] jogo = new int[3, 3];
                    int turno = 1;
                    while (true)
                    {
                        jogoTabuleiro(jogo);
                        Jogar(jogo, turno);
                        turno = turno == 1 ? 2 : 1;
                        Console.Clear();
                    }
                    break;
                case 3:
                    Exercicio();
                    break;
            }
        }
        static void NumeroSorteado()
        {
            int valorSorteado = (new Random()).Next(100);
            int valorEscolhido = int.MinValue;
            do
            {
                Console.Clear();
                Console.WriteLine("Qual o valor sorteado?");

                int x = int.Parse(Console.ReadLine());
                if (x > valorSorteado)
                {
                    Console.WriteLine("O numero que foi sorteado é menor");
               
                }
                else if (x < valorSorteado)
                {
                    Console.WriteLine("O numero que foi sorteado é maior");
                }

                Console.WriteLine("O valo sorteado é: " + valorSorteado + "\n");
                Console.ReadKey();
            } while (valorEscolhido != valorSorteado);

            Main();
        }

        static void jogoTabuleiro(int[,] jogo)
        {
            for(int i = 0; i<3; i++)
            {
                ImprimirLinha(new int[] { jogo[i, 0], jogo[i, 1], jogo[i, 2] });
                if (i < 2)
                {
                    Console.WriteLine("--------------------");
                   
                }
            }

        }

        static void ImprimirLinha(int[] linha)
        {
            string pos0, pos1, pos2;
            if (linha[0] == 1)
            {
                pos0 = "X";
            }else if (linha[0] == 2)
            {
                pos0 = "O";
            }
            else
            {
                pos0 = " ";
            }

            //---------------------------------------------------------

            if (linha[1] == 1)
            {
                pos1 = "X";
            }
            else if (linha[1] == 2)
            {
                pos1 = "O";
            }
            else
            {
                pos1 = " ";
            }

            //---------------------------------------------------------

            if (linha[2] == 1)
            {
                pos2 = "X";
            }
            else if (linha[2] == 2)
            {
                pos2 = "O";
            }
            else
            {
                pos2 = " ";
            }
            Console.WriteLine("   {0}  |  {1}  |   {2}", pos0, pos1, pos2);
        }

        public static void Jogar(int[,] jogo , int turno)
        {
            Console.WriteLine("\n Qual coluna voce quer jogar?");
            int col = int.Parse(Console.ReadLine())-1;
            Console.WriteLine("Qual linha voce quer jogar?");
            int lin = int.Parse(Console.ReadLine())-1;
            jogo[lin, col] = turno;
        }
        
        public static int Acabou(int[,] jogo)
        {
            for (int linha = 0; linha < 2; linha++)
            {
                if (jogo[0, linha] != 0 && jogo[1, linha] == jogo[0, linha] && jogo[2, linha] == jogo[1, linha])
                {
                    return jogo[0, linha];
                }
            }
            //----------------------------------------------------------------
            for (int coluna = 0; coluna < 2; coluna++)
            {
                if(jogo[0,coluna] != 0 && jogo[1,coluna] == jogo[0,coluna] && jogo[2,coluna] == jogo[1, coluna])
                {
                    return jogo[0, coluna];
                }
            }
            
            return 0;
        }

        public static int Exercicio()
        {
           
            return 0;
        }

        
    }
}
