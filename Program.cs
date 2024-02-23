
using System.Runtime.CompilerServices;

class Program
{
    static string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    static void gridSetup()
    {   
        Console.WriteLine(" {0} | {1} | {2} | ", pos[1], pos[2], pos[3]);
        Console.WriteLine(" ------------ ");
        Console.WriteLine(" {0} | {1} | {2} | ", pos[4], pos[5], pos[6]);
        Console.WriteLine(" ------------ ");
        Console.WriteLine(" {0} | {1} | {2} | ", pos[7], pos[8], pos[9]);
        Console.WriteLine(" ------------ ");
    }
    static void Main(string[] args)
    {
        string player1 = "", player2 = "";
        int turn = 1, choice = 0;
        bool playing = true, won = false;

        Console.WriteLine("Player 1, what's your name: ");
        player1 = Console.ReadLine();
        Console.WriteLine("Player 2, what's your name: ");
        player2 = Console.ReadLine();
        Console.WriteLine("Good {0} is X, {1} is O", player1, player2);
        Console.WriteLine("{0} goes first.", player1);
        Console.ReadLine();
        Console.Clear();

        while (playing == true)
        {
            while (won == false)
            {
                gridSetup();
                Console.WriteLine("");

                if (turn == 1)
                {
                    Console.WriteLine("{0}'s (X) turn: ", player1);
                }
                if (turn == 2)
                {
                    Console.WriteLine("{0}'s (O) turn: ", player2);
                }
                Console.WriteLine("Which position will you take?");
                choice = int.Parse(Console.ReadLine());

                if (turn == 1)
                {
                    if (pos[choice] == "O")
                    {
                        Console.WriteLine("Nice try but no, try again: ");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        pos[choice] = "X";
                    }
                }
                if (turn == 2)
                {
                    if (pos[choice] == "X")
                    {
                        Console.WriteLine("Nice try but no, try again: ");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        pos[choice] = "O";
                    }
                }
                if (turn == 1)
                {
                    turn = 2;
                }
                else if (turn == 2)
                {
                    turn = 1;
                }
                Console.Clear();
            }
        }
        Console.Clear();

        gridSetup();
    }
    static bool checkWin()
    {
        if (pos[1] == "0" && pos[2] == "0" && pos[3] == "0") //--Horizontal--
        {
            return true;
        }
        else if (pos[4] == "0" && pos[5] == "0" && pos[6] == "0")
        {
            return true;
        }
        else if (pos[7] == "0" && pos[8] == "0" && pos[9] == "0")
        {
            return true;
        }
        else if (pos[1] == "0" && pos[5] == "0" && pos[9] == "0") //--Diagonal--
        {
            return true;
        }
        else if (pos[7] == "0" && pos[5] == "0" && pos[3] == "0")
        {
            return true;
        }
        else if (pos[1] == "0" && pos[4] == "0" && pos[7] == "0") //--Vertical--
        {
            return true;
        }
        else if (pos[2] == "0" && pos[5] == "0" && pos[8] == "0")
        {
            return true;
        }
        else if (pos[3] == "0" && pos[6] == "0" && pos[9] == "0")
        {
            return true;
        }
        if (pos[1] == "X" && pos[2] == "X" && pos[3] == "X") //--Horizontal--
        {
            return true;
        }
        else if (pos[4] == "X" && pos[5] == "X" && pos[6] == "X")
        {
            return true;
        }
        else if (pos[7] == "X" && pos[8] == "X" && pos[9] == "X")
        {
            return true;
        }
        else if (pos[1] == "X" && pos[5] == "X" && pos[9] == "X") //--Diagonal--
        {
            return true;
        }
        else if (pos[7] == "X" && pos[5] == "X" && pos[3] == "X")
        {
            return true;
        }
        else if (pos[1] == "X" && pos[4] == "X" && pos[7] == "X") //--Vertical--
        {
            return true;
        }
        else if (pos[2] == "X" && pos[5] == "X" && pos[8] == "X")
        {
            return true;
        }
        else if (pos[3] == "X" && pos[6] == "X" && pos[9] == "X")
        {
            return true;
        } else //--No Winner--
        {
            return false;
        }
    }
}
