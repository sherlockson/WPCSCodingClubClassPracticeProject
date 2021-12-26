public class ClassPractice
{
    public static void Main(string[] args)
    {
        BasketballPlayer player1;
        BasketballPlayer player2;
        BasketballPlayer player3;
        BasketballPlayer player4;
        BasketballPlayer player5;
        List<BasketballPlayer> playerList = new List<BasketballPlayer>();

        try
        {
            string[] names = new string[] { "Aaron", "Bradley", "Chris", "David", "Ethan" };
            playerList.Add(player1 = new BasketballPlayer(names[0], "Guard"));
            playerList.Add(player2 = new BasketballPlayer(names[1], "Guard"));
            playerList.Add(player3 = new BasketballPlayer(names[2], "Forward"));
            playerList.Add(player4 = new BasketballPlayer(names[3], "Forward"));
            playerList.Add(player5 = new BasketballPlayer(names[4], "Center"));

            int count = 0;

            foreach (var p in playerList)
            {
                if (p.name.Equals(names[count]))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Player Name: " + p.name + ". I expected it to be: " + names[count] + ". Correct!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Uh oh. This player isn't right... Their name is wrong");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (p.points == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("This player's points should be 0. They currently have: " + p.points + ". Correct!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Uh oh. This player isn't right... Their points are not zero");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                count++;
            }

            Console.WriteLine("Make sure there is no red! If it's all green, move on!");
        }
        catch
        {
            Console.WriteLine("Error in creation of basketball players. Make sure your constructors are correct and have the required variables listed in the right order!");
        }

        try
        {
            Console.WriteLine("First game of the season!");
            foreach (var p in playerList)
            {
                p.PlayGame(10, 5, 5, 1);

                if (p.points == 10 && p.assists == 5 && p.rebounds == 5 && p.blocks == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Player " + p.name + " has the correct statistics!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Uh oh. This players statistics are wrong. Check your PlayGame function!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        catch
        {
            Console.WriteLine("Uh oh, something went wrong. Make sure you initialized all of the fields in your constructor!");
        }

        try
        {
            Random rand = new Random();
            Console.WriteLine("Simulating a full season!");
            foreach (var p in playerList)
            {
                int totalPoints = 10;
                int totalAssists = 5;
                int totalRebounds = 5;
                int totalBlocks = 1;

                for (int i = 0; i < 81; i++)
                {
                    int tempPoints = rand.Next(50);
                    totalPoints += tempPoints;
                    int tempAssists = rand.Next(15);
                    totalAssists += tempAssists;
                    int tempRebounds = rand.Next(15);
                    totalRebounds += tempRebounds;
                    int tempBlocks = rand.Next(5);
                    totalBlocks += tempBlocks;

                    p.PlayGame(tempPoints, tempAssists, tempRebounds, tempBlocks);
                }

                if (p.points != totalPoints)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(p.name + " does not have the correct amount of points! Expected: " + totalPoints + " but he has " + p.points);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (p.assists != totalAssists)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(p.name + " does not have the correct amount of assists! Expected: " + totalAssists + " but he has " + p.assists);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (p.rebounds != totalRebounds)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(p.name + " does not have the correct amount of rebounds! Expected: " + totalRebounds + " but he has " + p.rebounds);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (p.blocks != totalBlocks)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(p.name + " does not have the correct amount of blocks! Expected: " + totalBlocks + " but he has " + p.blocks);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Yes! All statistics are correct. Player " + p.name + " finished the season with the following statistics: \n" +
                        "Points: " + p.points + "\n" +
                        "Assists: " + p.assists + "\n" +
                        "Rebounds: " + p.rebounds + "\n" +
                        "Blocks: " + p.blocks);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        catch
        {
            Console.WriteLine("Something went wrong! Check and make sure you are summing the totals correctly. Also make sure you have the correct data types for the information you are storing!");
        }
    }
}