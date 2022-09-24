 class Player
    {
        public string nome;
        public int vida = 100;
        public int dano = 30;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Player player01 = new Player();
            Player player02 = new Player();

            //Nomes

            for (int i = 1; i < 3; i++)
            {
                Console.Write("Qual seu nome player" +  i + ": ");
                if (i == 1)
                    player01.nome = Console.ReadLine();
               else
                    player02.nome = Console.ReadLine();
            }

            Console.WriteLine("\n");
            Console.WriteLine(player01.nome + " VS " + player02.nome + "\n\n");


            //Vida Extra ou Dano Extra


            Random rnd = new Random();
          
            for (int i = 1; i < 3; i++)
            {
                string davi = "";//Dano Vida
                int rand = rnd.Next(1, 3);

                if(rand == 1)//Dano
                {
                 int danoExtra = rnd.Next(1, 11);
                    if (i == 1)
                    {
                     player01.dano += danoExtra;

                    }else
                    {
                       player02.dano += danoExtra;
                    }
                    davi = "DanoExtra";
                }

                if (rand == 2)//Vida
                {
                    int vidaExtra = rnd.Next(1, 11);

                    if (i == 1)
                    {
                        player01.vida += vidaExtra;

                    }
                    else
                    {
                        player02.vida += vidaExtra;
                    }
                    davi = "VidaExtra";
                }

                //Output
                if (i == 1)
                {
                    Console.WriteLine(player01.nome + " Ganhou mais " + davi);
                }
                if (i == 2)
                {
                    Console.WriteLine(player02.nome + " Ganhou mais " + davi);
                }

                Console.WriteLine("");//spaceout
            }


            //Turno 
            do
            {
                //Turno Player 1
                Console.WriteLine("Turno do " + player01.nome);
                int dano1 = rnd.Next(5, player01.dano);
                player02.vida = DanoDado(dano1, player02.vida, player02.nome);

                Console.ReadKey();
                if (player01.vida <= 0)
                    break;

                //Turno Player 2
                Console.WriteLine("Turno do " + player02.nome);
                int dano2 = rnd.Next(5, player02.dano);
                player01.vida = DanoDado(dano2, player01.vida, player01.nome);

                Console.ReadKey();

            } while(player01.vida > 0 && player02.vida > 0);
          
            
            if(player01.vida < player02.vida)
            {
                Console.WriteLine(player02.nome + " Ganhou!!");
            }
            if (player01.vida > player02.vida)
            {
                Console.WriteLine(player01.nome + " Ganhou!!");
            }


            Console.ReadKey();
        }

       public static int DanoDado(int Dano, int Vida, string Nome)
        {
            int total = Vida - Dano;
            Console.WriteLine(Nome + "\n" + "Vida: " + Vida + "(" + "-"+Dano + ")" + "\n\n");
            return total;

        }