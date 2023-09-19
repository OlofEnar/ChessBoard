//Labb 2 Chessboard
//Olof Maleki Nordin
//.NET23 OOP

namespace Labb2_ChessBoard;

internal class Program
{
    static void Main(string[] args)
    {
        //Loop for playing again
        while (true)
        {
            //unicode to show the squares, and setting a unicode standard output
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Välkommen till schackbräderiet!");

            // Init variables for the board size
            int rows, columns, boardSize;

            //Assigns character for the "black" and "white" square
            string blackSquare = "■";
            string whiteSquare = "□";

            //loop to check if input is correct
            while (true)
            {
                try
                {
                    //Get board size from user and convert to int
                    Console.WriteLine("Hur stort ska brädet vara? (3 - 20)");
                    string userInput = Console.ReadLine();
                    boardSize = int.Parse(userInput);

                    //Check if input is out of range
                    if (boardSize < 3) 
                    {
                        Console.Clear();
                        Console.WriteLine("Det blir för litet. Prova igen");

                    }
                    else if (boardSize > 20)
                    {
                        Console.Clear();
                        Console.WriteLine("Det blir för stort. Prova igen");
                    } else
                        break;
                }

                //Rerun loop if incorrect
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Skriv in ett tal.");
                }
            }

            //Loop to check if user wants to customize the board
            while (true)
            {
                Console.WriteLine("Vill du ändra shackbrädets utseende? [j]a / [n]ej");
                string customizeBoard = Console.ReadLine();

                if (customizeBoard.ToLower() == "j")
                {
                    Console.WriteLine("Vilket tecken ska vita rutor ha? (tex '1')");
                    whiteSquare = Console.ReadLine();

                    Console.WriteLine("Vilket tecken ska svarta rutor ha? (tex '2')");
                    blackSquare = Console.ReadLine();

                    break;

                }

                //If no, exit and to go to making the board
                else if (customizeBoard.ToLower() == "n")
                {
                    break;
                }

                //If input is incorrect print
                Console.Clear();
                Console.WriteLine("skriv in [j] för ja, [n] för nej");
            }


            //Time to make the board!

            //Tidy up screen
            Console.Clear();

            //Set rows & columns as board size
            rows = columns = boardSize;

            //Init variable for alternating the squares on the board
            int squareCheck = 1;

            //Loop for printing the rows
            for (int i = 0; i < rows; i++)
            {
                //Loop for printing the columns 
                for (int j = 0; j < columns; j++)
                {
                    //Alternate the squares
                    
                    //if the value of squareCheck is black, print white
                    if (squareCheck == 1)
                    {
                        Console.Write(whiteSquare);
                    }

                    //if not, print black
                    else
                    {
                        Console.Write(blackSquare);
                    }

                    //If squareCheck is 1, then multiply by -1 = -1
                    //If squareCheck is -1, then multiply by -1 = 1
                    squareCheck *= -1;

                }

                //Check if column is even
                if (columns % 2 == 0)
                {
                    squareCheck *= -1;
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n");

            //Set variable for user choice of playaing again
            string x = "";

            Console.WriteLine("skriv [j] för att göra ett nytt bräde,\n" +
            "annars tryck valfri tangent för att avsluta");
            
            x = Console.ReadLine();

            //If input is not "j", exit program
            if (x.ToLower() != "j")
            {
                break;
            }

            Console.Clear();
        }
    }
}
