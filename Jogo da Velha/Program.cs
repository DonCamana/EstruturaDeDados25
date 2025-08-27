using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Velha
{
    internal class Program
    {
        static void Main(string[] args)
        {

                int[][] board = new int[3][];
                for (int i = 0; i < 3; i++)
                    board[i] = new int[3];

                bool playerOneWin = false;
                bool playerTwoWin = false;
                bool empate = false;
                int currentPlayer = 1; //começa com Player 1

                while (playerOneWin != true && playerTwoWin != true && empate != true)
                {
                    PrintBoard(board);

                    Console.WriteLine($"Player {(currentPlayer == 1 ? "X" : "O")}, enter row and column (0-2):");
                    Console.Write("Row: ");
                    int row = int.Parse(Console.ReadLine() ?? "0");
                    Console.Write("column: ");
                    int col = int.Parse(Console.ReadLine() ?? "0");

                    if (row < 0 || row > 2 || col < 0 || col > 2 || board[row][col] != 0)
                    {
                        Console.WriteLine("Invalid position, try again!");
                        continue;
                    }

                    //Marca jogada
                    board[row][col] = currentPlayer;

                    //Verifica ganhou
                    if (CheckWin(board, currentPlayer))
                    {
                        if (currentPlayer == 1)
                            playerOneWin = true;
                        else
                            playerTwoWin = true;

                        PrintBoard(board);
                        Console.WriteLine($"Player {(currentPlayer == 1 ? "X" : "O")} Win!");
                        break;
                    }

                    //Verifica empate
                    if (CheckEmpate(board))
                    {
                        empate = true;
                        PrintBoard(board);
                        Console.WriteLine("Draw!");
                        break;
                    }

                    //Troca jogador
                    currentPlayer = (currentPlayer == 1) ? 2 : 1;
                }
            }

        static bool CheckWin(int[][] board, int player)
            {
            //Horizontal
            for (int i = 0; i < 3; i++)
            {
                if (board[i][0] == player && board[i][1] == player && board[i][2] == player)
                return true;
            }

            //Vertical
            for (int j = 0; j < 3; j++)
            {
                if (board[0][j] == player && board[1][j] == player && board[2][j] == player)
                return true;
            }

            //Diagonal principal
            if (board[0][0] == player && board[1][1] == player && board[2][2] == player)
                return true;

            //Diagonal contraria
            if (board[0][2] == player && board[1][1] == player && board[2][0] == player)
                return true;

            return false;
        }

        static bool CheckEmpate(int[][] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i][j] == 0) //vê se tem espaço vazio
                    return false;
                }
            }
            return true;
        }

        static void PrintBoard(int[][] board)
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    char symbol = board[i][j] == 1 ? 'X' : board[i][j] == 2 ? 'O' : '.';
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }



}

    