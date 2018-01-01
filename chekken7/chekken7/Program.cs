
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Media;
namespace chekken7
{
    class Program

    {
        static void Main(string[] args)
        {
            //Copyright, all rights reservedd
            //Gilo94 - Lightning Artwork
            //cf     - Chicken art
            //Bamco  - Music (Selection Screens)
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(@"                       Default Installation Path: C:\Chekken");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n CHEKKEN: Ang Elemental Sabungan is designed to run on the default window mode.");
            Console.WriteLine("        To ensure optimal experience, do not maximize/resize the window.\n");
            Console.WriteLine("                           Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            SoundPlayer introandselect = new SoundPlayer(@"C:\chekken7\chekken7\GameData\introandselect.wav");
            introandselect.Play();
            Console.WriteLine("\n\n\n\n\n                             )         )     )        )   ");
            Thread.Sleep(100);
            Console.WriteLine(@"                       (   ( /(      ( /(  ( /(     ( /(  ");
            Thread.Sleep(100);
            Console.WriteLine(@"                       )\  )\())(    )\()) )\())(   )\())");
            Thread.Sleep(100);
            Console.WriteLine(@"                     (((_)((_)\ )\ |((_)\|((_)\ )\ ((_)\  ");
            Thread.Sleep(100);
            Console.WriteLine(@"                     )\___ _((_((_)|_ ((_|_ ((_((_) _((_) ");
            Thread.Sleep(100);
            Console.WriteLine(@"                    ((/ __| || | __| |/ /| |/ /| __| \| | ");
            Thread.Sleep(100);
            Console.WriteLine(@"                     | (__| __ | _|  ' <   ' < | _|| .` | ");
            Thread.Sleep(100);
            Console.WriteLine(@"                      \___|_||_|___|_|\_\ _|\_\|___|_|\_| ");
            Thread.Sleep(1500);
            Console.WriteLine("\n                  A N G  E L E M E N T A L  S A B U N G A N");
            Thread.Sleep(900);
            Console.WriteLine("\n             Press any key to continue to alpha build of gameplay");
            Console.ReadKey();

            //Elements

            int electric;
            int fire;
            int earth;
            int water;

            electric = 1;
            fire = 2;
            earth = 3;
            water = 4;

            int character1, character2;
            string p1char, p2char;

            //P1 Character Select

            Console.Clear();
            Console.WriteLine("Chekken v0.1b");
            Console.WriteLine("PLAYER 1, please enter your name.");
            string player1name;
            player1name = Console.ReadLine();
            Console.WriteLine("Player 1's name is " + player1name + ". Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Welcome to the King of Chicken Fist Tournament");
            Console.WriteLine("     __//");
            Console.WriteLine(@"    /.__.\");
            Console.WriteLine(@"    \ \/ /");
            Console.WriteLine(@" '__/    \");
            Console.WriteLine(@"  \-      )");
            Console.WriteLine(@"   \_____/");
            Console.WriteLine("_____|_|____");
            Console.WriteLine(@"''  '''' ");
            Console.WriteLine("Select a chicken");
            Console.WriteLine("1: Electric");
            Console.WriteLine("2: Fire");
            Console.WriteLine("3: Earth");
            Console.WriteLine("4: Water");
            p1char = Console.ReadLine();

            if (p1char.Equals("1"))
            {
                character1 = electric;
                Console.WriteLine("Player 1's character is the Electric Chicken.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();

            }
            else if (p1char.Equals("2"))
            {
                character1 = fire;
                Console.WriteLine("Player 1's character is the Fire Chicken");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            else if (p1char.Equals("3"))
            {
                character1 = earth;
                Console.WriteLine("Player 1's chacter is the Earth Chicken");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            else if (p1char.Equals("4"))
            {
                character1 = water;
                Console.WriteLine("Player 1's character is the Water Chicken");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            Console.Clear();

            //P2 Character Select

            Console.Clear();
            Console.WriteLine("PLAYER 2, please enter your name.");
            string player2name;
            player2name = Console.ReadLine();
            Console.WriteLine("Player 2's name is " + player2name + ". Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Welcome to the King of Chicken Fist Tournament");
                      Console.WriteLine("     __//");
            Console.WriteLine(@"    /.__.\");
            Console.WriteLine(@"    \ \/ /");
            Console.WriteLine(@" '__/    \");
            Console.WriteLine(@"  \-      )");
            Console.WriteLine(@"   \_____/");
            Console.WriteLine("_____|_|____");
            Console.WriteLine(@"''  '''' ");
            Console.WriteLine("Select a chicken");
            Console.WriteLine("1: Electric");
            Console.WriteLine("2: Fire");
            Console.WriteLine("3: Earth");
            Console.WriteLine("4: Water");
            p2char = Console.ReadLine();



            if (p2char.Equals("1"))
            {
                character2 = electric;
                Console.WriteLine("Player 2's character is the Electric Chicken");


                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            else if (p2char.Equals("2"))
            {
                character2 = fire;
                Console.WriteLine("Player 2's character is the Fire Chicken");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            else if (p2char.Equals("3"))
            {
                character2 = earth;
                Console.WriteLine("Player 2's chacter is the Earth Chicken");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            else if (p2char.Equals("4"))
            {
                character2 = water;
                Console.WriteLine("Player 2's character is the Water Chicken");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }

            Console.Clear();
            {

                Console.WriteLine("\n\n\n██████╗ ███████╗ █████╗ ██████╗ ██╗   ██╗");
                Console.WriteLine("██╔══██╗██╔════╝██╔══██╗██╔══██╗╚██╗ ██╔╝");
                Console.WriteLine("██████╔╝█████╗  ███████║██║  ██║ ╚████╔╝ ");
                Console.WriteLine("██╔══██╗██╔══╝  ██╔══██║██║  ██║  ╚██╔╝  ");
                Console.WriteLine("██║  ██║███████╗██║  ██║██████╔╝   ██║   ");
                Console.WriteLine("╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═════╝    ╚═╝   ");
                Thread.Sleep(500);
                Console.WriteLine(player1name + ", press any key to ready up.");
                Console.ReadKey();
                Console.WriteLine("\n" + player2name + ", press any key to ready up.");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("\n\n\n██████╗ ███████╗ █████╗ ██████╗ ██╗   ██╗");
                Console.WriteLine("██╔══██╗██╔════╝██╔══██╗██╔══██╗╚██╗ ██╔╝");
                Console.WriteLine("██████╔╝█████╗  ███████║██║  ██║ ╚████╔╝ ");
                Console.WriteLine("██╔══██╗██╔══╝  ██╔══██║██║  ██║  ╚██╔╝  ");
                Console.WriteLine("██║  ██║███████╗██║  ██║██████╔╝   ██║   ");
                Console.WriteLine("╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═════╝    ╚═╝   ");
                Thread.Sleep(1000);

                Console.WriteLine("\n\n\n\n\n\n\n\n███████╗██╗ ██████╗ ██╗  ██╗████████╗");
                Console.WriteLine("██╔════╝██║██╔════╝ ██║  ██║╚══██╔══╝");
                Console.WriteLine("█████╗  ██║██║  ███╗███████║   ██║   ");
                Console.WriteLine("██╔══╝  ██║██║   ██║██╔══██║   ██║   ");
                Console.WriteLine("██║     ██║╚██████╔╝██║  ██║   ██║   ");
                Console.WriteLine("╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═╝   ╚═╝   ");
                Thread.Sleep(900);
                Console.Clear();

            }


            //MOVE SELECTION AND MOVE LIST

            int command11, command12, command13, command21, command22, command23;
            int Potion1, Potion2;
            double P1HP, P2HP, P1MP, P2MP, damage1, damage2;

            //Starting Variable Numbers
            Potion1 = 5;
            Potion2 = 5;
            P1HP = 1000;
            P2HP = 1000;
            P1MP = 1000;
            P2MP = 1000;
            damage1 = 100;
            damage2 = 100;

            while (P1HP != 0)
            while (P2HP != 0)
                {
                    //FIRST PLAYER COMMAND SCREEN

                    Console.WriteLine("PLAYER 1 HP: {0}", P1HP);
                    Console.WriteLine("PLAYER 2 HP: {0}", P2HP);

                    Console.WriteLine("\nPLAYER 1 MP: {0}", P1MP);
                    Console.WriteLine("Player 2 MP: {0}", P2MP);

                    Console.WriteLine("\nPlayer 1's Potion Count: {0}", Potion1);
                    Console.WriteLine("Player 2's Potion Count: {0}\n", Potion2);

                    Console.WriteLine("MOVE LIST:\n1:Basic Attack!\n2:Heal\n3:Special!\n4:Pass\n");

                    Console.WriteLine("PLAYER 1, Please enter your first attack");
                    command11 = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("PLAYER 1 HP: {0}", P1HP);
                    Console.WriteLine("PLAYER 2 HP: {0}", P2HP);

                    Console.WriteLine("\nPLAYER 1 MP: {0}", P1MP);
                    Console.WriteLine("Player 2 MP: {0}", P2MP);

                    Console.WriteLine("\nPlayer 1's Potion Count: {0}", Potion1);
                    Console.WriteLine("Player 2's Potion Count: {0}\n", Potion2);

                    Console.WriteLine("MOVE LIST:\n1:Basic Attack!\n2:Heal\n3:Special!\n4:Pass\n");

                    Console.WriteLine("Your second?");
                    command12 = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("PLAYER 1 HP: {0}", P1HP);
                    Console.WriteLine("PLAYER 2 HP: {0}", P2HP);

                    Console.WriteLine("\nPLAYER 1 MP: {0}", P1MP);
                    Console.WriteLine("Player 2 MP: {0}", P2MP);

                    Console.WriteLine("\nPlayer 1's Potion Count: {0}", Potion1);
                    Console.WriteLine("Player 2's Potion Count: {0}\n", Potion2);

                    Console.WriteLine("MOVE LIST:\n1:Basic Attack!\n2:Heal\n3:Special!\n4:Pass\n");

                    Console.WriteLine("...and your third?");
                    command13 = int.Parse(Console.ReadLine());
                    Console.Clear();


                    //SECOND PLAYER COMMAND SCREEN

                    Console.WriteLine("PLAYER 1 HP: {0}", P1HP);
                    Console.WriteLine("PLAYER 2 HP: {0}", P2HP);

                    Console.WriteLine("\nPLAYER 1 MP: {0}", P1MP);
                    Console.WriteLine("Player 2 MP: {0}", P2MP);

                    Console.WriteLine("\nPlayer 1's Potion Count: {0}", Potion1);
                    Console.WriteLine("Player 2's Potion Count: {0}\n", Potion2);

                    Console.WriteLine("MOVE LIST:\n1:Basic Attack!\n2:Heal\n3:Special!\n4:Pass\n");

                    Console.WriteLine("PLAYER 2, Please enter your first attack");
                    command21 = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("PLAYER 1 HP: {0}", P1HP);
                    Console.WriteLine("PLAYER 2 HP: {0}", P2HP);

                    Console.WriteLine("\nPLAYER 1 MP: {0}", P1MP);
                    Console.WriteLine("Player 2 MP: {0}", P2MP);

                    Console.WriteLine("\nPlayer 1's Potion Count: {0}", Potion1);
                    Console.WriteLine("Player 2's Potion Count: {0}\n", Potion2);

                    Console.WriteLine("MOVE LIST:\n1:Basic Attack!\n2:Heal\n3:Special!\n4:Pass\n");

                    Console.WriteLine("Your second?");
                    command22 = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("PLAYER 1 HP: {0}", P1HP);
                    Console.WriteLine("PLAYER 2 HP: {0}", P2HP);

                    Console.WriteLine("\nPLAYER 1 MP: {0}", P1MP);
                    Console.WriteLine("Player 2 MP: {0}", P2MP);

                    Console.WriteLine("\nPlayer 1's Potion Count: {0}", Potion1);
                    Console.WriteLine("Player 2's Potion Count: {0}\n", Potion2);

                    Console.WriteLine("MOVE LIST:\n1:Basic Attack!\n2:Heal\n3:Special!\n4:Pass\n");

                    Console.WriteLine("...and your third?");
                    command23 = int.Parse(Console.ReadLine());
                    Console.Clear();

                    //ALOT OF IF STATEMENTS
                    //FIRST PLAYER'S COMMAND CALCULATION 1
                    if (p1char == "1")
                    {
                        if (command11 == 1)
                        {
                            P2HP = P2HP - damage1;
                            P1MP = P1MP - 50;
                        }
                        else if (command11 == 2)
                        {
                            P1HP = P1HP + 300;
                            Potion1 = Potion1 - 1;
                        }
                        else if (command11 == 3)
                        {
                            if (P1HP < 400)
                            {
                                P2HP = P2HP - 500;
                                P1MP = P1MP - 400;
                            }
                            else
                            {
                                P2HP = P2HP - 0;
                            }
                        }
                        else if (command11 == 4)
                        {
                            P1MP = P1MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    }
                    else if (p1char == "2")
                        if (command11 == 1)
                        {
                            P2HP = P2HP - damage1;
                            P1MP = P1MP - 50;
                        }
                        else if (command11 == 2)
                        {
                            P1HP = P1HP + 300;
                            Potion1 = Potion1 - 1;
                        }
                        else if (command11 == 3)
                        {
                            if (P1HP < 750)
                            {
                                damage1 = damage1 + 50;
                                P2HP = P2HP - damage1;
                                P1MP = P1MP - 300;
                            }
                            else
                            {
                                P1HP = P1HP + 0;
                            }
                        }
                        else if (command11 == 4)
                        {
                            P1MP = P1MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else if (p1char == "3")
                        if (command11 == 1)
                        {
                            P2HP = P2HP - damage1;
                            P2MP = P2MP - 50;
                        }
                        else if (command11 == 2)
                        {
                            P1HP = P1HP + 300;
                            Potion1 = Potion1 - 1;
                        }
                        else if (command11 == 3)
                        {
                            if (P1HP < 400)
                            {
                                P1HP = P1HP + 400;
                                P1MP = P1MP + 200;
                            }
                            else
                            {
                                P1HP = P1HP + 0;
                            }
                        }
                        else if (command11 == 4)
                        {
                            P1MP = P1MP + 150;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else if (p1char == "4")
                        if (command11 == 1)
                        {
                            P1HP = P1HP - damage1;
                            P1MP = P2MP - 50;
                        }
                        else if (command11 == 2)
                        {
                            P1HP = P1HP + 300;
                            Potion1 = Potion1 - 1;
                        }
                        else if (command11 == 3)
                        {
                            if (P1HP < 500)
                            {
                                damage2 = damage2 - 25;
                                P2HP = P2HP - damage1;
                                P1MP = P1MP - 150;
                            }
                        }
                        else if (command11 == 4)
                        {
                            P1MP = P1MP + 150;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else
                    {
                        Console.WriteLine("void");
                    }
                    //SECOND PLAYER'S COMMAND CALCULATION 1
                    if (p2char == "1")
                    {
                        if (command21 == 1)
                        {
                            P1HP = P1HP - damage2;
                            P2MP = P2MP - 50;
                        }
                        else if (command21 == 2)
                        {
                            P2HP = P2HP + 300;
                            Potion2 = Potion2 - 1;
                        }
                        else if (command21 == 3)
                        {
                            if (P2HP < 400)
                            {
                                P1HP = P1HP - 500;
                                P2MP = P2MP - 400;
                            }
                            else
                            {
                                P1HP = P1HP - 0;
                            }
                        }
                        else if (command21 == 4)
                        {
                            P2MP = P2MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    }
                    else if (p2char == "2")
                        if (command21 == 1)
                        {
                            P1HP = P1HP - damage2;
                            P2MP = P2MP - 50;
                        }
                        else if (command21 == 2)
                        {
                            P2HP = P2HP + 300;
                            Potion2 = Potion2 - 1;
                        }
                        else if (command21 == 3)
                        {
                            if (P2HP < 750)
                            {
                                damage2 = damage2 + 50;
                                P1HP = P1HP - damage2;
                                P2MP = P2MP - 300;
                            }
                            else
                            {
                                P2HP = P2HP + 0;
                            }
                        }
                        else if (command21 == 4)
                        {
                            P2MP = P2MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else if (p2char == "3")
                        if (command21 == 1)
                        {
                            P1HP = P1HP - damage2;
                            P2MP = P2MP - 50;
                        }
                        else if (command21 == 2)
                        {
                            P2HP = P2HP + 300;
                            Potion2 = Potion2 - 1;
                        }
                        else if (command21 == 3)
                        {
                            if (P2HP < 400)
                            {
                                P2HP = P2HP + 400;
                                P2MP = P2MP + 200;
                            }
                            else
                            {
                                P2HP = P2HP + 0;
                            }
                        }
                        else if (command21 == 4)
                        {
                            P2MP = P2MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else if (p2char == "4")
                        if (command21 == 1)
                        {
                            P1HP = P1HP - damage2;
                            P2MP = P2MP - 50;
                        }
                        else if (command11 == 2)
                        {
                            P2HP = P2HP + 300;
                            Potion2 = Potion2 - 1;
                        }
                        else if (command21 == 3)
                        {
                            if (P2HP < 500)
                            {
                                damage1 = damage1 - 25;
                                P1HP = P1HP - damage1;
                                P2MP = P2MP - 150;
                            }
                        }
                        else if (command21 == 4)
                        {
                            P2MP = P2MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else
                    {
                        Console.WriteLine("void");
                    }
                    //FIRST PLAYER'S COMMAND CALCULATION 2
                    if (p1char == "1")
                    {
                        if (command12 == 1)
                        {
                            P2HP = P2HP - damage1;
                            P1MP = P1MP - 50;
                        }
                        else if (command12 == 2)
                        {
                            P1HP = P1HP + 300;
                            Potion1 = Potion1 - 1;
                        }
                        else if (command12 == 3)
                        {
                            if (P1HP < 400)
                            {
                                P2HP = P2HP - 500;
                                P1MP = P1MP - 400;
                            }
                            else
                            {
                                P2HP = P2HP - 0;
                            }
                        }
                        else if (command12 == 4)
                        {
                            P1MP = P1MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    }
                    else if (p1char == "2")
                        if (command12 == 1)
                        {
                            P2HP = P2HP - damage1;
                            P1MP = P1MP - 50;
                        }
                        else if (command12 == 2)
                        {
                            P1HP = P1HP + 300;
                            Potion1 = Potion1 - 1;
                        }
                        else if (command12 == 3)
                        {
                            if (P1HP < 750)
                            {
                                damage1 = damage1 + 50;
                                P2HP = P2HP - damage1;
                                P1MP = P1MP - 300;
                            }
                            else
                            {
                                P1HP = P1HP + 0;
                            }
                        }
                        else if (command12 == 4)
                        {
                            P1MP = P1MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else if (p1char == "3")
                        if (command12 == 1)
                        {
                            P2HP = P2HP - damage1;
                            P2MP = P2MP - 50;
                        }
                        else if (command12 == 2)
                        {
                            P1HP = P1HP + 300;
                            Potion1 = Potion1 - 1;
                        }
                        else if (command12 == 3)
                        {
                            if (P1HP < 400)
                            {
                                P1HP = P1HP + 400;
                                P1MP = P1MP + 200;
                            }
                            else
                            {
                                P1HP = P1HP + 0;
                            }
                        }
                        else if (command12 == 4)
                        {
                            P1MP = P1MP + 150;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else if (p1char == "4")
                        if (command12 == 1)
                        {
                            P1HP = P1HP - damage1;
                            P1MP = P2MP - 50;
                        }
                        else if (command12 == 2)
                        {
                            P1HP = P1HP + 300;
                            Potion1 = Potion1 - 1;
                        }
                        else if (command12 == 3)
                        {
                            if (P1HP < 500)
                            {
                                damage2 = damage2 - 25;
                                P2HP = P2HP - damage1;
                                P1MP = P1MP - 150;
                            }
                        }
                        else if (command12 == 4)
                        {
                            P1MP = P1MP + 150;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else
                    {
                        Console.WriteLine("void");
                    }
                    //SECOND PLAYER'S COMMAND CALCULATION 2
                    if (p1char == "1")
                    {
                        if (command22 == 1)
                        {
                            P1HP = P1HP - damage2;
                            P2MP = P2MP - 50;
                        }
                        else if (command22 == 2)
                        {
                            P2HP = P2HP + 300;
                            Potion2 = Potion2 - 1;
                        }
                        else if (command22 == 3)
                        {
                            if (P2HP < 400)
                            {
                                P1HP = P1HP - 500;
                                P2MP = P2MP - 400;
                            }
                            else
                            {
                                P1HP = P1HP - 0;
                            }
                        }
                        else if (command22 == 4)
                        {
                            P2MP = P2MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    }
                    else if (p1char == "2")
                        if (command22 == 1)
                        {
                            P1HP = P1HP - damage2;
                            P2MP = P2MP - 50;
                        }
                        else if (command22 == 2)
                        {
                            P2HP = P2HP + 300;
                            Potion2 = Potion2 - 1;
                        }
                        else if (command22 == 3)
                        {
                            if (P2HP < 750)
                            {
                                damage2 = damage2 + 50;
                                P1HP = P1HP - damage2;
                                P2MP = P2MP - 300;
                            }
                            else
                            {
                                P2HP = P2HP + 0;
                            }
                        }
                        else if (command22 == 4)
                        {
                            P2MP = P2MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else if (p1char == "3")
                        if (command22 == 1)
                        {
                            P1HP = P1HP - damage2;
                            P2MP = P2MP - 50;
                        }
                        else if (command22 == 2)
                        {
                            P2HP = P2HP + 300;
                            Potion2 = Potion2 - 1;
                        }
                        else if (command22 == 3)
                        {
                            if (P2HP < 400)
                            {
                                P2HP = P2HP + 400;
                                P2MP = P2MP + 200;
                            }
                            else
                            {
                                P2HP = P2HP + 0;
                            }
                        }
                        else if (command22 == 4)
                        {
                            P2MP = P2MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else if (p1char == "4")
                        if (command22 == 1)
                        {
                            P1HP = P1HP - damage2;
                            P2MP = P2MP - 50;
                        }
                        else if (command22 == 2)
                        {
                            P2HP = P2HP + 300;
                            Potion2 = Potion2 - 1;
                        }
                        else if (command22 == 3)
                        {
                            if (P2HP < 500)
                            {
                                damage1 = damage1 - 25;
                                P1HP = P1HP - damage1;
                                P2MP = P2MP - 150;
                            }
                        }
                        else if (command22 == 4)
                        {
                            P2MP = P2MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else
                    {
                        Console.WriteLine("void");
                    }
                    //FIRST PLAYER'S COMMAND CALCULATION 3
                    if (p1char == "1")
                    {
                        if (command13 == 1)
                        {
                            P2HP = P2HP - damage1;
                            P1MP = P1MP - 50;
                        }
                        else if (command13 == 2)
                        {
                            P1HP = P1HP + 300;
                            Potion1 = Potion1 - 1;
                        }
                        else if (command13 == 3)
                        {
                            if (P1HP < 400)
                            {
                                P2HP = P2HP - 500;
                                P1MP = P1MP - 400;
                            }
                            else
                            {
                                P2HP = P2HP - 0;
                            }
                        }
                        else if (command13 == 4)
                        {
                            P1MP = P1MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    }
                    else if (p1char == "2")
                        if (command13 == 1)
                        {
                            P2HP = P2HP - damage1;
                            P1MP = P1MP - 50;
                        }
                        else if (command13 == 2)
                        {
                            P1HP = P1HP + 300;
                            Potion1 = Potion1 - 1;
                        }
                        else if (command13 == 3)
                        {
                            if (P1HP < 750)
                            {
                                damage1 = damage1 + 50;
                                P2HP = P2HP - damage1;
                                P1MP = P1MP - 300;
                            }
                            else
                            {
                                P1HP = P1HP + 0;
                            }
                        }
                        else if (command13 == 4)
                        {
                            P1MP = P1MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else if (p1char == "3")
                        if (command13 == 1)
                        {
                            P2HP = P2HP - damage1;
                            P2MP = P2MP - 50;
                        }
                        else if (command13 == 2)
                        {
                            P1HP = P1HP + 300;
                            Potion1 = Potion1 - 1;
                        }
                        else if (command13 == 3)
                        {
                            if (P1HP < 400)
                            {
                                P1HP = P1HP + 400;
                                P1MP = P1MP + 200;
                            }
                            else
                            {
                                P1HP = P1HP + 0;
                            }
                        }
                        else if (command13 == 4)
                        {
                            P1MP = P1MP + 150;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else if (p1char == "4")
                        if (command13 == 1)
                        {
                            P1HP = P1HP - damage1;
                            P1MP = P2MP - 50;
                        }
                        else if (command13 == 2)
                        {
                            P1HP = P1HP + 300;
                            Potion1 = Potion1 - 1;
                        }
                        else if (command13 == 3)
                        {
                            if (P1HP < 500)
                            {
                                damage2 = damage2 - 25;
                                P2HP = P2HP - damage1;
                                P1MP = P1MP - 150;
                            }
                        }
                        else if (command13 == 4)
                        {
                            P1MP = P1MP + 150;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else
                    {
                        Console.WriteLine("void");
                    }
                    //SECOND PLAYER'S COMMAND CALCULATION 3
                    if (p1char == "1")
                    {
                        if (command23 == 1)
                        {
                            P1HP = P1HP - damage2;
                            P2MP = P2MP - 50;
                        }
                        else if (command23 == 2)
                        {
                            P2HP = P2HP + 300;
                            Potion2 = Potion2 - 1;
                        }
                        else if (command23 == 3)
                        {
                            if (P2HP < 400)
                            {
                                P1HP = P1HP - 500;
                                P2MP = P2MP - 400;
                            }
                            else
                            {
                                P1HP = P1HP - 0;
                            }
                        }
                        else if (command23 == 4)
                        {
                            P2MP = P2MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    }
                    else if (p1char == "2")
                        if (command23 == 1)
                        {
                            P1HP = P1HP - damage2;
                            P2MP = P2MP - 50;
                        }
                        else if (command23 == 2)
                        {
                            P2HP = P2HP + 300;
                            Potion2 = Potion2 - 1;
                        }
                        else if (command23 == 3)
                        {
                            if (P2HP < 750)
                            {
                                damage2 = damage2 + 50;
                                P1HP = P1HP - damage2;
                                P2MP = P2MP - 300;
                            }
                            else
                            {
                                P2HP = P2HP + 0;
                            }
                        }
                        else if (command23 == 4)
                        {
                            P2MP = P2MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else if (p1char == "3")
                        if (command23 == 1)
                        {
                            P1HP = P1HP - damage2;
                            P2MP = P2MP - 50;
                        }
                        else if (command23 == 2)
                        {
                            P2HP = P2HP + 300;
                            Potion2 = Potion2 - 1;
                        }
                        else if (command23 == 3)
                        {
                            if (P2HP < 400)
                            {
                                P2HP = P2HP + 400;
                                P2MP = P2MP + 200;
                            }
                            else
                            {
                                P2HP = P2HP + 0;
                            }
                        }
                        else if (command23 == 4)
                        {
                            P2MP = P2MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else if (p1char == "4")
                        if (command23 == 1)
                        {
                            P1HP = P1HP - damage2;
                            P2MP = P2MP - 50;
                        }
                        else if (command23 == 2)
                        {
                            P2HP = P2HP + 300;
                            Potion2 = Potion2 - 1;
                        }
                        else if (command23 == 3)
                        {
                            if (P2HP < 500)
                            {
                                damage1 = damage1 - 25;
                                P1HP = P1HP - damage1;
                                P2MP = P2MP - 150;
                            }
                        }
                        else if (command23 == 4)
                        {
                            P2MP = P2MP + 300;
                        }
                        else
                        {
                            Console.WriteLine("void");
                        }
                    else
                    {
                        Console.WriteLine("void");
                    }


                  
                    }
            //POST CALCULATION SCREEN

            if (P1HP <= 0)
            {

                Console.WriteLine("P2 WINS");
            }
            else if (P2HP <= 0)
            {
                Console.WriteLine("P1 WINS");
            }
            else
            { 
                Console.WriteLine("PLAYER 1 HP: {0}", P1HP);
                Console.WriteLine("PLAYER 2 HP: {0}", P2HP);

                    Console.WriteLine("\nPLAYER 1 MP: {0}", P1MP);
                    Console.WriteLine("Player 2 MP: {0}", P2MP);

                    Console.WriteLine("\nPlayer 1's Potion Count: {0}", Potion1);
                    Console.WriteLine("Player 2's Potion Count: {0}\n", Potion2);

                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
            }

        }
        } 

        
    }



internal class random
{
}


