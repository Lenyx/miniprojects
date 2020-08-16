using System;
using System.Globalization;
using System.Threading;

namespace CrestikiNoliki
{
    class OXGame
    {
        
        static void PrintingGameField(char[,] playArray)
        {
            Console.WriteLine("-----КРЕСТИКИ-НОЛИКИ v1.0-----\n");
            Console.WriteLine("   A" + "\t" + "   B" + "\t" + "   C" + "\n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i+1}  ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{playArray[i, j]}" + "\t" + "   ");
                }
                Console.WriteLine("\n\n");
            }

        }
        static void mainLogics()
        {
            char[,] playArray = { { '*', '*', '*' }, { '*', '*', '*' }, { '*', '*', '*' } };

            PrintingGameField(playArray);

            string charWin = "";
            int posPlayer = 0;
            int breakValue = 0;

            do
            {
                posPlayer++;

                if (posPlayer % 2 == 0)
                    Console.WriteLine("Введи поле, X-игрок");
                else
                    Console.WriteLine("Введи поле, O-игрок");

                charWin = Console.ReadLine();
                charWin = charWin.ToLower();

                //---заполнение полей(начало)
                if (charWin == "1a" || charWin == "a1")
                {
                    if (playArray[0, 0] != 'X' && playArray[0, 0] != 'O')
                    {
                        if (posPlayer % 2 == 0)
                            playArray[0, 0] = 'X';
                        else
                            playArray[0, 0] = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Данное поле уже занято!");
                        posPlayer--;
                    }
                }
                else if (charWin == "a2" || charWin == "2a")
                {
                    if (playArray[1, 0] != 'X' && playArray[1, 0] != 'O')
                    {
                        if (posPlayer % 2 == 0)
                            playArray[1, 0] = 'X';
                        else
                            playArray[1, 0] = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Данное поле уже занято!");
                        posPlayer--;
                    }
                }
                else if (charWin == "a3" || charWin == "3a")
                {
                    if (playArray[2, 0] != 'X' && playArray[2, 0] != 'O')
                    {
                        if (posPlayer % 2 == 0)
                            playArray[2, 0] = 'X';
                        else
                            playArray[2, 0] = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Данное поле уже занято!");
                        posPlayer--;
                    }
                }
                else if (charWin == "b1" || charWin == "1b")
                {
                    if (playArray[0, 1] != 'X' && playArray[0, 1] != 'O')
                    {
                        if (posPlayer % 2 == 0)
                            playArray[0, 1] = 'X';
                        else
                            playArray[0, 1] = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Данное поле уже занято!");
                        posPlayer--;
                    }
                }
                else if (charWin == "b2" || charWin == "2b")
                {
                    if (playArray[1, 1] != 'X' && playArray[1, 1] != 'O')
                    {
                        if (posPlayer % 2 == 0)
                            playArray[1, 1] = 'X';
                        else
                            playArray[1, 1] = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Данное поле уже занято!");
                        posPlayer--;
                    }
                }
                else if (charWin == "b3" || charWin == "3b")
                {
                    if (playArray[2, 1] != 'X' && playArray[2, 1] != 'O')
                    {
                        if (posPlayer % 2 == 0)
                            playArray[2, 1] = 'X';
                        else
                            playArray[2, 1] = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Данное поле уже занято!");
                        posPlayer--;
                    }
                }
                else if (charWin == "c1" || charWin == "1c")
                {
                    if (playArray[0, 2] != 'X' && playArray[0, 2] != 'O')
                    {
                        if (posPlayer % 2 == 0)
                            playArray[0, 2] = 'X';
                        else
                            playArray[0, 2] = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Данное поле уже занято!");
                        posPlayer--;
                    }
                }
                else if (charWin == "c2" || charWin == "2c")
                {
                    if (playArray[1, 2] != 'X' && playArray[1, 2] != 'O')
                    {
                        if (posPlayer % 2 == 0)
                            playArray[1, 2] = 'X';
                        else
                            playArray[1, 2] = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Данное поле уже занято!");
                        posPlayer--;
                    }
                }
                else if (charWin == "c3" || charWin == "3c")
                {
                    if (playArray[2, 2] != 'X' && playArray[2, 2] != 'O')
                    {
                        if (posPlayer % 2 == 0)
                            playArray[2, 2] = 'X';
                        else
                            playArray[2, 2] = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Данное поле уже занято!");
                        posPlayer--;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid point, try again");
                    breakValue = 1;
                    posPlayer--;
                }
                //---заполнение полей(конец)
                if (breakValue == 0)
                {
                    Console.WriteLine();
                    PrintingGameField(playArray);
                    Console.WriteLine();

                    //---логика проверки полей по диагонали для победы(начало).
                    if ((playArray[0, 0] == 'O' && playArray[1, 1] == 'O' && playArray[2, 2] == 'O') || (playArray[2, 0] == 'O' && playArray[1, 1] == 'O' && playArray[0, 2] == 'O'))
                    {
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("| Победа по диагонали O-игрока! |");
                        Console.WriteLine("--------------------------------");
                        break;
                    }
                    else if ((playArray[0, 0] == 'X' && playArray[1, 1] == 'X' && playArray[2, 2] == 'X') || (playArray[2, 0] == 'X' && playArray[1, 1] == 'X' && playArray[0, 2] == 'X'))
                    {
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("|Победа по диагонали X-игрока |");
                        Console.WriteLine("-------------------------------");
                        break;
                    }
                    //---логика проверки полей по диагонали для победы(конец).

                    //--логика проверки полей по горизонтали(start)
                    for (int i = 0; i < 3; i++)
                    {
                        if (playArray[i, 0] == 'O' && playArray[i, 1] == 'O' && playArray[i, 2] == 'O')
                        {
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("|Победа О-игрока по горизонтали|");
                            Console.WriteLine("--------------------------------");
                            charWin = "stop";
                        }
                        else if (playArray[i, 0] == 'X' && playArray[i, 1] == 'X' && playArray[i, 2] == 'X')
                        {
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("|Победа Х-игрока по горизонтали|");
                            Console.WriteLine("--------------------------------");
                            charWin = "stop";
                        }
                    }
                    //--логика проверки полей по горизонтали(end)

                    //--логика проверки полей по вертикали(start)
                    for (int j = 0; j < 3; j++)
                    {
                        if (playArray[0, j] == 'O' && playArray[1, j] == 'O' && playArray[2, j] == 'O')
                        {
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("|Победа О-игрока по вертикали|");
                            Console.WriteLine("------------------------------");
                            charWin = "stop";
                        }
                        else if (playArray[0, j] == 'X' && playArray[1, j] == 'X' && playArray[2, j] == 'X')
                        {
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("|Победа Х-игрока по вертикали|");
                            Console.WriteLine("------------------------------");
                            charWin = "stop";
                        }
                    }
                    //--логика проверки полей по вертикали(end)
                } //костыль для invalid point :)
                else
                    breakValue = 0;

                Console.WriteLine();

            } while (charWin != "stop");

                
        }
        static void Main(string[] args)
        {
       
            Console.WriteLine("Welcome to X-O game!");
            Console.WriteLine("You want to start new game? Yes/No");
            string str = "";
            do
            {
                str = Console.ReadLine();
                str = str.ToLower();

                if (str == "no")
                {
                    Console.WriteLine("Bye-bye, c u next time!");
                    break;
                }
                else if (str != "yes")
                {
                    Console.WriteLine("Incorrect command, try again!");
                }
                else if (str == "yes")
                {
                    do
                    {
                        mainLogics();
                        Console.WriteLine("You want to start new game? Yes/No");
                       
                        str = Console.ReadLine();
                        str = str.ToLower();
                        Console.Clear();

                    } while (str == "yes");
                    
                }
                
            } while (str == "yes");
        }
    }
}
