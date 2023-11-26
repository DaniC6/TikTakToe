internal class Program
{
    // the playField for replace the number by user
    static char[,] playField =
    {
        {'1','2','3'}, // row 0
        {'4','5','6'}, // row 1
        {'7','8','9'}  // row 2

    };

    private static void Main(string[] args)
    {
        int player = 2;
        int input = 0;
        bool inputCorrect = true;

        

        do
        {
            

            if (player == 2)
            {
                player = 1;
                EnterXorO(player, input);
            }
            else if (player == 1)
            {
                player = 2;
                EnterXorO(player, input);
            }
            
            SetField();

            do
            {

                Console.WriteLine("\nPlayer {0}: Chose your field!!! ", player);
                input = Convert.ToInt32(Console.ReadLine());



            }while(!inputCorrect);



            switch (player)
            {
                case 1:// players 1 turn
                    {
                        switch (input)
                        {
                            case 1: playField[0, 0] = 'X'; break;
                            case 2: playField[0, 1] = 'X'; break;
                            case 3: playField[0, 2] = 'X'; break;
                            case 4: playField[1, 0] = 'X'; break;
                            case 5: playField[1, 1] = 'X'; break;
                            case 6: playField[1, 2] = 'X'; break;
                            case 7: playField[2, 0] = 'X'; break;
                            case 8: playField[2, 1] = 'X'; break;
                            case 9: playField[2, 2] = 'X'; break;
                        }
                        break;
                    }
                case 2:// players 1 turn
                    {
                        switch (input)
                        {
                            case 1: playField[0, 0] = 'X'; break;
                            case 2: playField[0, 1] = 'X'; break;
                            case 3: playField[0, 2] = 'X'; break;
                            case 4: playField[1, 0] = 'X'; break;
                            case 5: playField[1, 1] = 'X'; break;
                            case 6: playField[1, 2] = 'X'; break;
                            case 7: playField[2, 0] = 'X'; break;
                            case 8: playField[2, 1] = 'X'; break;
                            case 9: playField[2, 2] = 'X'; break;
                        }
                    }
                    break;
            }



        } while (true);

    }

    public static void SetField()
    {
        Console.WriteLine("     |     |     ");
        //TODO replace numbers with variables
        Console.WriteLine("  {0}  |  {1}  |  {2}", playField[0, 0], playField[0, 1], playField[0, 2]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        //TODO replace numbers with variables
        Console.WriteLine("  {0}  |  {1}  |  {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        //TODO replace numbers with variables
        Console.WriteLine("  {0}  |  {1}  |  {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
    }

    public static void EnterXorO(int player, int input)
    {
        char playerSign = ' ';

        if (player == 1)
            playerSign = 'X';
        else if (player == 2)
            playerSign = 'O';

        switch(input)
        {
            case 1: playField[0, 0] = playerSign; break;
            case 2: playField[0, 1] = playerSign; break;
            case 3: playField[0, 2] = playerSign; break;
            case 4: playField[1, 0] = playerSign; break;
            case 5: playField[1, 1] = playerSign; break;
            case 6: playField[1, 2] = playerSign; break;
            case 7: playField[2, 0] = playerSign; break;
            case 8: playField[2, 1] = playerSign; break;
            case 9: playField[2, 2] = playerSign; break;
        }
    }
}