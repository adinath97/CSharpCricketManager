using System;
using System.Collections.Generic;
using System.Numerics;

namespace All_Star_Cricket_Game_1
{
    class MainClass
    {
        //still need to include possibility of run out; allow 2 batsmen at a time/strik rotation
        //allow player to choose next batter/bowler. Show bowler stats and overs left for them (assuming we're playing limited overs)

        public static List<string> playerPoolBatsmen = new List<string>();
        public static List<string> playerPoolKeepers = new List<string>();
        public static List<string> playerPoolBowlers = new List<string>();
        public static List<string> playerPoolAllrounders = new List<string>();

        public static List<string> playerTeam = new List<string>();
        public static List<string> computerTeam = new List<string>();

        public static List<int> playerBatsmenScores = new List<int>();
        public static List<int> playerBatsmenDeliveriesPlayed = new List<int>();

        public static List<int> computerBatsmenScores = new List<int>();
        public static List<int> computerBatsmenDeliveriesPlayed = new List<int>();

        public static List<string> playerBowlers = new List<string>();
        public static List<string> computerBowlers = new List<string>();

        public static List<int> playerBowlerRuns = new List<int>();
        public static List<int> playerBowlerWickets = new List<int>();
        public static List<int> playerBowlerOvers = new List<int>();

        public static List<int> computerBowlerRuns = new List<int>();
        public static List<int> computerBowlerWickets = new List<int>();
        public static List<int> computerBowlerOvers = new List<int>();

        public static int computerBowler1Runs = 0;
        public static int computerBowler1Wickets = 0;
        public static int computerBowler1Overs = 0;

        public static int computerBowler2Runs = 0;
        public static int computerBowler2Wickets = 0;
        public static int computerBowler2Overs = 0;

        public static int computerBowler3Runs = 0;
        public static int computerBowler3Wickets = 0;
        public static int computerBowler3Overs = 0;

        public static int computerBowler4Runs = 0;
        public static int computerBowler4Wickets = 0;
        public static int computerBowler4Overs = 0;

        public static int playerBowler1Runs = 0;
        public static int playerBowler1Wickets = 0;
        public static int playerBowler1Overs = 0;

        public static int playerBowler2Runs = 0;
        public static int playerBowler2Wickets = 0;
        public static int playerBowler2Overs = 0;

        public static int playerBowler3Runs = 0;
        public static int playerBowler3Wickets = 0;
        public static int playerBowler3Overs = 0;

        public static int playerBowler4Runs = 0;
        public static int playerBowler4Wickets = 0;
        public static int playerBowler4Overs = 0;

        public static string playerBowler1;
        public static string playerBowler2;
        public static string playerBowler3;
        public static string playerBowler4;

        public static string computerBowler1;
        public static string computerBowler2;
        public static string computerBowler3;
        public static string computerBowler4;

        public static string ultimateWicketTaker;
        public static string wicketTaker;
        public static string sidePicked;
        public static string sideNotPicked;
        public static string playerSelection;
        public static string currentBowler;
        public static string tossOne;
        public static string tossPlayerDecision;

        public static BigInteger numberOfCompBowlers;
        public static BigInteger numberOfPlayerBowlers;
        public static int waitWhoBatting;
        public static int tossDecision;
        public static int toss1;
        public static int index;
        public static int numberOfBalls;
        public static int numberOfOvers;
        public static int battingWicketsLost = 0;
        public static int tossResult;
        public static int currentBatsmanScore = 0;
        public static int currentBatsmanDeliveriesPlayed = 0;
        public static int chasingWicketLost = 0;
        public static int firstInningsTotal;

        public static bool gameOver = false;
        public static bool secondInningsComplete = false;
        public static bool firstInningsComplete = false;
        public static bool overIncomplete = false;
        public static bool playerNotOut = false;

        public static void Main(string[] args)
        {
            CreateTeams();
            Toss();
            LetTheGamesBegin();
        }

        public static void CreateTeams()
        {
            //batsmen and keepers
            playerPoolBatsmen.Add("Virat Kohli");
            playerPoolBatsmen.Add("Saurav Ganguly");
            playerPoolBatsmen.Add("Sachin Tendulkar");
            playerPoolBatsmen.Add("Rahul Dravid");
            playerPoolBatsmen.Add("Steven Smith");
            playerPoolBatsmen.Add("Ricky Ponting");
            playerPoolBatsmen.Add("Mahela Jayawardene");
            playerPoolBatsmen.Add("Alistair Cook");
            playerPoolBatsmen.Add("Jonathan Trott");
            playerPoolBatsmen.Add("Viv Richards");
            playerPoolBatsmen.Add("Brian Lara");
            playerPoolBatsmen.Add("Kane Williamson");
            playerPoolBatsmen.Add("VVS Laxman");
            playerPoolBatsmen.Add("Damian Flemming");
            playerPoolBatsmen.Add("Joe Root");
            playerPoolBatsmen.Add("TM Dilshan");
            playerPoolBatsmen.Add("Mohammad Ashraful");
            playerPoolBatsmen.Add("Tamim Iqbal");
            playerPoolBatsmen.Add("Ross Taylor");
            playerPoolBatsmen.Add("R.G. Sharma");

            //keepers
            playerPoolKeepers.Add("M.S. Dhoni");
            playerPoolKeepers.Add("Kumar Sangakkara");
            playerPoolKeepers.Add("Adam Gilchrist");
            playerPoolKeepers.Add("Brendan McCullum");


            //bowlers
            playerPoolBowlers.Add("Shane Warne");
            playerPoolBowlers.Add("Glen McGrath");
            playerPoolBowlers.Add("James Anderson");
            playerPoolBowlers.Add("Curtly Ambrose");
            playerPoolBowlers.Add("Muttiah Muralidharan");
            playerPoolBowlers.Add("Malcolm Marshall");
            playerPoolBowlers.Add("Stuart Broad");
            playerPoolBowlers.Add("Dale Steyn");
            playerPoolBowlers.Add("Anil Kumble");
            playerPoolBowlers.Add("Dennis Lillee");
            playerPoolBowlers.Add("Brett Lee");
            playerPoolBowlers.Add("Wasim Akram");
            playerPoolBowlers.Add("Waqar Younis");
            playerPoolBowlers.Add("Zaheer Khan");

            //allrounders
            playerPoolAllrounders.Add("Jacques Kallis");
            playerPoolAllrounders.Add("Shakib Al Hasan");
            playerPoolAllrounders.Add("Andrew Flintoff");
            playerPoolAllrounders.Add("Imran Khan");
            playerPoolAllrounders.Add("Kapil Dev");

            //choosing teams/captains
            Console.WriteLine("Welcome to the Cricket All-Star game. It's your team versus the computer's. " +
                "You both will now pick your teams. Choose wisely!");

            Console.WriteLine("------------");

            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("------------");

            Console.Write("Team Kohli vs Team Smith. Which team would you like to build? Enter 'Kohli' for " +
                "Team Kohli or enter 'Smith' for Team Smith: ");
            sidePicked = Console.ReadLine();

            Console.WriteLine("------------");

            Console.WriteLine("You have chosen Team " + sidePicked + ". Good choice!");

            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("------------");

            if (sidePicked == "Kohli")
            {
                playerTeam.Add("Virat Kohli");
                playerPoolBatsmen.Remove("Virat Kohli");
                sideNotPicked = "Steven Smith";
                computerTeam.Add(sideNotPicked);
                Console.WriteLine("The computer will be Team Smith");
                playerPoolBatsmen.Remove("Steven Smith");
            }
            else if(sidePicked == "Smith")
            {
                playerTeam.Add("Steven Smith");
                playerPoolBatsmen.Remove("Steven Smith");
                sideNotPicked = "Virat Kohli";
                computerTeam.Add(sideNotPicked);
                Console.WriteLine("The computer will be Team Kohli");
                playerPoolBatsmen.Remove("Virat Kohli");
            }

            Console.WriteLine("------------");

            Console.WriteLine("You and the computer will take turns picking players. You shall go first.");

            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("------------");

            Console.WriteLine("When creating your team, keep in mind that the order in which you choose your players" +
                " will also be your batting order.");

            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("------------");

            //picking batsmen
            Console.WriteLine("Your team must contain 5 batsmen. You need 4 more to complete your top and middle" +
                "order. You can select from the following pool of players:");

            Console.WriteLine("------------");

            while (playerTeam.Count < 5)
            {
                foreach(string x in playerPoolBatsmen)
                {
                    Console.Write(x + ", ");
                }
                Console.WriteLine(".");
                Console.Write("You have " + (5 - playerTeam.Count) + " spots for batsmen left. Pick a batsman. Please enter " +
                    "their name as expressed in the list above: ");
                playerSelection = Console.ReadLine();
                playerTeam.Add(playerSelection);
                playerPoolBatsmen.Remove(playerSelection);
                Console.WriteLine("------------");

                Random playerC = new Random();
                int playerSC = playerC.Next(0, playerPoolBatsmen.Count);
                string playerSelectionComp = playerPoolBatsmen[playerSC];
                computerTeam.Add(playerSelectionComp);
                playerPoolBatsmen.Remove(playerSelectionComp);
                Console.WriteLine("The computer has chosen " + playerSelectionComp);

                Console.Write("Press Enter to continue!");
                Console.ReadLine();

                Console.WriteLine("------------");
            }

            Console.WriteLine("------------");

            //picking keepers
            Console.WriteLine("Now you must select 1 wicketkeeper (and then the computer shall). Choose one from the following options. As always" +
                " please write out the name of the player as expressed in the list provided: ");

            Console.WriteLine("------------");

            foreach (string x in playerPoolKeepers)
            {
                Console.Write(x + ", ");
            }
            Console.WriteLine(".");
            Console.Write("Who would you like as the wicketkeeper for your team? : ");
            playerSelection = Console.ReadLine();
            playerTeam.Add(playerSelection);
            playerPoolKeepers.Remove(playerSelection);

            Console.WriteLine("------------");

            Random playerC1 = new Random();
            int playerSC1 = playerC1.Next(0, playerPoolKeepers.Count);
            string playerSelectionComp1 = playerPoolKeepers[playerSC1];
            computerTeam.Add(playerSelectionComp1);
            playerPoolKeepers.Remove(playerSelectionComp1);
            Console.WriteLine("The computer has chosen " + playerSelectionComp1);

            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("------------");

            //picking allrounders
            Console.WriteLine("Now you must select 1 allrounder (and then the computer shall). Choose one from the following options. As always" +
                " please write out the name of the player as expressed in the list provided: ");

            Console.WriteLine("------------");

            foreach (string x in playerPoolAllrounders)
            {
                Console.Write(x + ", ");
            }
            Console.WriteLine(".");
            Console.Write("Who would you like as the allrounder for your team? : ");
            playerSelection = Console.ReadLine();
            playerTeam.Add(playerSelection);
            playerPoolAllrounders.Remove(playerSelection);

            Console.WriteLine("------------");


            Random playerC2 = new Random();
            int playerSC2 = playerC1.Next(0, playerPoolAllrounders.Count);
            string playerSelectionComp2 = playerPoolAllrounders[playerSC2];
            computerTeam.Add(playerSelectionComp2);
            playerPoolAllrounders.Remove(playerSelectionComp2);
            Console.WriteLine("The computer has chosen " + playerSelectionComp2);

            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("------------");

            //picking bowlers
            Console.WriteLine("Now you must select 3 bowlers (you will pick, then the comp" +
                "upter will, until each has 3 bowlers). Choose from the following options. As always" +
                " please write out the name of the player as expressed in the list provided: ");

            Console.WriteLine("------------");

            while (playerTeam.Count < 10)
            {
                foreach (string x in playerPoolBowlers)
                {
                    Console.Write(x + ", ");
                }
                Console.WriteLine(".");
                Console.Write("You have " + (10 - playerTeam.Count) + " spots for bowlers left. Pick a bowler. Please enter " +
                    "their name as expressed in the list above: ");
                playerSelection = Console.ReadLine();
                playerTeam.Add(playerSelection);
                playerPoolBowlers.Remove(playerSelection);
                Console.WriteLine("------------");

                Random playerC3 = new Random();
                int playerSC3 = playerC1.Next(0, playerPoolBowlers.Count);
                string playerSelectionComp3 = playerPoolBowlers[playerSC3];
                computerTeam.Add(playerSelectionComp3);
                playerPoolBowlers.Remove(playerSelectionComp3);
                Console.WriteLine("The computer has chosen " + playerSelectionComp3);

                Console.Write("Press Enter to continue!");
                Console.ReadLine();

                Console.WriteLine("------------");
            }

            Console.WriteLine("------------");

            Console.Write("Your team consists of: ");

            foreach(string x in playerTeam)
            {
                Console.Write(x + ",");
            }
            Console.WriteLine(".");

            Console.WriteLine("------------");

            Console.Write("Computer's team consists of: ");

            foreach (string x in computerTeam)
            {
                Console.Write(x + ",");
            }
            Console.WriteLine(".");

            Console.Write("Press Enter to continue!");
            Console.ReadLine();
        }

        public static BigInteger Toss()
        {
            Console.WriteLine("------------");

            Console.WriteLine("Time for the toss. Please enter 'Heads' or 'Tails': ");
            tossOne = Console.ReadLine();

            if(tossOne == "Heads")
            {
                toss1 = 0;
            }
            else if(tossOne == "Tails")
            {
                toss1 = 1;
            }

            Random tossresult = new Random();
            tossResult = tossresult.Next(0, 2);

            if (toss1 == tossResult)
            {
                Console.WriteLine("------------");

                Console.WriteLine("Your team has won the toss. Would you like to bat or bowl?" +
                    " Please enter 'Bat' or 'Bowl': ");
                tossPlayerDecision = Console.ReadLine();

                Console.WriteLine("------------");

                if (tossPlayerDecision == "Bat")
                {
                    Console.WriteLine("Your team, Team " + sidePicked + " will bat first");
                    waitWhoBatting = 1;
                }
                else if(tossPlayerDecision == "Bowl")
                {
                    Console.WriteLine("Your team, Team " + sidePicked + " will bowl first");
                    waitWhoBatting = 2;
                }
            }

            else
            {
                Console.WriteLine("Team " + sideNotPicked + " won the toss");

                Random tossdecision = new Random();
                tossDecision = tossdecision.Next(0, 2);

                if (tossDecision == 1)
                {
                    Console.WriteLine("Team " + sideNotPicked + " will bat first.");
                    waitWhoBatting = 3;
                    /* Team B bats first, Team A bats second. */

                }
                else
                {
                    Console.WriteLine("Team " + sideNotPicked + " will bowl first.");
                    waitWhoBatting = 4;
                    /* Team A bats first, Team B bats second. */
                }
            }

            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            return waitWhoBatting;
        }

        public static void LetTheGamesBegin()
        {
            if (waitWhoBatting == 1 || waitWhoBatting == 4)
            {
                /*
                //player bowlers
                int i2 = 6;
                numberOfPlayerBowlers = 0;
                while (numberOfPlayerBowlers < 4)
                {
                    string wicketTaker = playerTeam[i2];
                    playerBowlers.Add(wicketTaker);
                    i2 += 1;
                    numberOfPlayerBowlers += 1;
                }

                playerBowler1 = playerBowlers[0];
                playerBowler2 = playerBowlers[1];
                playerBowler3 = playerBowlers[2];
                playerBowler4 = playerBowlers[3];

                FirstInningscomputerTeamBats();

                //computer bowlers
                int i3 = 6;
                numberOfCompBowlers = 0;
                while (numberOfCompBowlers < 4)
                {
                    string wicketTaker = computerTeam[i3];
                    computerBowlers.Add(wicketTaker);
                    i3 += 1;
                    numberOfCompBowlers += 1;
                }

                computerBowler1 = computerBowlers[0];
                computerBowler2 = computerBowlers[1];
                computerBowler3 = computerBowlers[2];
                computerBowler4 = computerBowlers[3];

                SecondInningsplayerTeamBats(firstInningsTotal);*/

                
                //computer bowlers
                int i = 6;
                numberOfCompBowlers = 0;
                while (numberOfCompBowlers < 4)
                {
                    string wicketTaker = computerTeam[i];
                    computerBowlers.Add(wicketTaker);
                    i += 1;
                    numberOfCompBowlers += 1;
                }

                computerBowler1 = computerBowlers[0];
                computerBowler2 = computerBowlers[1];
                computerBowler3 = computerBowlers[2];
                computerBowler4 = computerBowlers[3];

                FirstInningsplayerTeamBats();

                //player bowlers
                int i1 = 6;
                numberOfPlayerBowlers = 0;
                while (numberOfPlayerBowlers < 4)
                {
                    string wicketTaker = playerTeam[i1];
                    playerBowlers.Add(wicketTaker);
                    i1 += 1;
                    numberOfPlayerBowlers += 1;
                }

                playerBowler1 = playerBowlers[0];
                playerBowler2 = playerBowlers[1];
                playerBowler3 = playerBowlers[2];
                playerBowler4 = playerBowlers[3];

                SecondInningscomputerTeamBats(firstInningsTotal);
            }
            if (waitWhoBatting == 2 || waitWhoBatting == 3)
            {

                //player bowlers
                int i2 = 6;
                numberOfPlayerBowlers = 0;
                while (numberOfPlayerBowlers < 4)
                {
                    string wicketTaker = playerTeam[i2];
                    playerBowlers.Add(wicketTaker);
                    i2 += 1;
                    numberOfPlayerBowlers += 1;
                }

                playerBowler1 = playerBowlers[0];
                playerBowler2 = playerBowlers[1];
                playerBowler3 = playerBowlers[2];
                playerBowler4 = playerBowlers[3];

                FirstInningscomputerTeamBats();
                
                //computer bowlers
                int i3 = 6;
                numberOfCompBowlers = 0;
                while (numberOfCompBowlers < 4)
                {
                    string wicketTaker = computerTeam[i3];
                    computerBowlers.Add(wicketTaker);
                    i3 += 1;
                    numberOfCompBowlers += 1;
                }

                computerBowler1 = computerBowlers[0];
                computerBowler2 = computerBowlers[1];
                computerBowler3 = computerBowlers[2];
                computerBowler4 = computerBowlers[3];

                SecondInningsplayerTeamBats(firstInningsTotal);
            }
        }

        public static int FirstInningsplayerTeamBats()
        {
            int battingWicketsLost = 0;
            firstInningsTotal = 0;
            int currentBatsmanScore = 0;
            bool firstInningsComplete = false;
            int numberOfBalls = 0;
            int index = 0;
            numberOfOvers = 0;
            int currentBowlerRuns = 0;
            int currentBowlerWickets = 0;
            int currentBowlerOvers = 0;

            int whoopie1 = 0;
            int whoopie2 = 0;
            int whoopie3 = 0;
            int whoopie4 = 0;

            List<int> whoopie = new List<int>();
            List<object> economyRate = new List<object>();
            List<object> strikeRate = new List<object>();
            List<object> average = new List<object>();
            List<object> battingStrikeRate = new List<object>();

            while(firstInningsComplete == false)
            {
                //computer bowler #1
                
                    currentBowlerRuns = 0;
                    currentBowlerWickets = 0;
                    currentBowlerOvers = 0;
                    numberOfBalls = 0;
                    currentBowler = computerBowler1;
                
                //bowl over
                while (numberOfBalls < 6 && firstInningsComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 15);

                    if (!(battingScore == bowlingScore))
                    {
                        firstInningsTotal += battingScore;
                        currentBatsmanScore += battingScore;
                        currentBowlerRuns += battingScore;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = playerTeam[battingWicketsLost];
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : " +
                            battingScore + " runs.");

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();

                    }
                    else if (battingScore == bowlingScore)
                    {
                        battingWicketsLost += 1;
                        currentBatsmanDeliveriesPlayed += 1;
                        currentBowlerWickets += 1;
                        string player = playerTeam[battingWicketsLost - 1];
                        playerBatsmenScores.Add(currentBatsmanScore);
                        playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sidePicked + " : " + firstInningsTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {

                            firstInningsComplete = true;

                            //apply this sort of logic in the other spots.
                            if(numberOfBalls < 5)
                            {
                                whoopie1 = numberOfBalls + 1;
                            }
                            else if(numberOfBalls == 5)
                            {
                                whoopie1 = 0;
                            }
                            whoopie2 = 0;
                            whoopie3 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }
                        numberOfBalls += 1;

                    if(numberOfBalls == 6)
                    {
                        numberOfOvers += 1;
                        currentBowlerOvers += 1;
                    }

                    if(firstInningsComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                computerBowler1Runs += currentBowlerRuns;
                computerBowler1Wickets += currentBowlerWickets;
                computerBowler1Overs += currentBowlerOvers;

                if (firstInningsComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + computerBowler1Overs + ". Runs: " +
                        computerBowler1Runs + ". Wickets: " + computerBowler1Wickets);
                    Console.WriteLine("         ");
                    string player = playerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("-----------");

                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }

                //computer bowler #2
                
                    currentBowler = computerBowler2;
                    currentBowlerRuns = 0;
                    currentBowlerWickets = 0;
                    currentBowlerOvers = 0;
                    numberOfBalls = 0;
                

                //bowl over
                while (numberOfBalls < 6 && firstInningsComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        firstInningsTotal += battingScore;
                        currentBatsmanScore += battingScore;
                        currentBowlerRuns += battingScore;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = playerTeam[battingWicketsLost];
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : " +
                            battingScore + " runs.");

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }
                    else if (battingScore == bowlingScore)
                    {
                        battingWicketsLost += 1;
                        currentBowlerWickets += 1;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = playerTeam[battingWicketsLost - 1];
                        playerBatsmenScores.Add(currentBatsmanScore);
                        playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sidePicked + " : " + firstInningsTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            firstInningsComplete = true;
                            if (numberOfBalls < 5)
                            {
                                whoopie2 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie2 = 0;
                            }
                            whoopie1 = 0;
                            whoopie3 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }

                    numberOfBalls += 1;

                    if (numberOfBalls == 6)
                    {
                        numberOfOvers += 1;
                        currentBowlerOvers += 1;
                    }

                    if (firstInningsComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                computerBowler2Runs += currentBowlerRuns;
                computerBowler2Wickets += currentBowlerWickets;
                computerBowler2Overs += currentBowlerOvers;

                if (firstInningsComplete == false)
                {

                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine(currentBowler + ". Overs: " + computerBowler2Overs + ". Runs: " +
                        computerBowler2Runs + ". Wickets: " + computerBowler2Wickets);
                    Console.WriteLine("         ");
                    string player = playerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("-----------");


                    Console.WriteLine("        ");
                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }

                //computer bowler #3
                
                    currentBowler = computerBowler3;
                    currentBowlerRuns = 0;
                    currentBowlerWickets = 0;
                    currentBowlerOvers = 0;
                    numberOfBalls = 0;
                

                //bowl over
                while (numberOfBalls < 6 && firstInningsComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        firstInningsTotal += battingScore;
                        currentBatsmanScore += battingScore;
                        currentBowlerRuns += battingScore;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = playerTeam[battingWicketsLost];
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : " +
                            battingScore + " runs.");

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }
                    else if (battingScore == bowlingScore)
                    {
                        battingWicketsLost += 1;
                        currentBowlerWickets += 1;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = playerTeam[battingWicketsLost - 1];
                        playerBatsmenScores.Add(currentBatsmanScore);
                        playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sidePicked + " : " + firstInningsTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            firstInningsComplete = true;
                            if (numberOfBalls < 5)
                            {
                                whoopie3 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie3 = 0;
                            }
                            whoopie1 = 0;
                            whoopie2 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }

                    Console.WriteLine("        ");
                    numberOfBalls += 1;

                    if (numberOfBalls == 6)
                    {
                        numberOfOvers += 1;
                        currentBowlerOvers += 1;
                    }

                    if (firstInningsComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                computerBowler3Runs += currentBowlerRuns;
                computerBowler3Wickets += currentBowlerWickets;
                computerBowler3Overs += currentBowlerOvers;

                if (firstInningsComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine(currentBowler + ". Overs: " + computerBowler3Overs + ". Runs: " +
                        computerBowler3Runs + ". Wickets: " + computerBowler3Wickets);
                    Console.WriteLine("         ");
                    string player = playerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("-----------");
                    

                    Console.WriteLine("        ");
                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }

                //computer bowler #4
                
                    currentBowler = computerBowler4;
                    currentBowlerRuns = 0;
                    currentBowlerWickets = 0;
                    currentBowlerOvers = 0;
                    numberOfBalls = 0;
                

                //bowl over
                while (numberOfBalls < 6 && firstInningsComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        firstInningsTotal += battingScore;
                        currentBatsmanScore += battingScore;
                        currentBowlerRuns += battingScore;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = playerTeam[battingWicketsLost];
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : " +
                            battingScore + " runs.");

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }
                    else if (battingScore == bowlingScore)
                    {
                        battingWicketsLost += 1;
                        currentBowlerWickets += 1;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = playerTeam[battingWicketsLost - 1];
                        playerBatsmenScores.Add(currentBatsmanScore);
                        playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sidePicked + " : " + firstInningsTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            firstInningsComplete = true;
                            if (numberOfBalls < 5)
                            {
                                whoopie4 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie4 = 0;
                            }
                            whoopie2 = 0;
                            whoopie3 = 0;
                            whoopie1 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }

                    Console.WriteLine("        ");
                    numberOfBalls += 1;

                    if (numberOfBalls == 6)
                    {
                        numberOfOvers += 1;
                        currentBowlerOvers += 1;
                    }

                    if (firstInningsComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                computerBowler4Runs += currentBowlerRuns;
                computerBowler4Wickets += currentBowlerWickets;
                computerBowler4Overs += currentBowlerOvers;

                if (firstInningsComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine(currentBowler + ". Overs: " + computerBowler4Overs + ". Runs: " +
                        computerBowler4Runs + ". Wickets: " + computerBowler4Wickets);
                    Console.WriteLine("         ");
                    string player = playerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("-----------");

                    Console.WriteLine("        ");
                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }
            }

            computerBowlerRuns.Add(computerBowler1Runs);
            computerBowlerRuns.Add(computerBowler2Runs);
            computerBowlerRuns.Add(computerBowler3Runs);
            computerBowlerRuns.Add(computerBowler4Runs);

            computerBowlerOvers.Add(computerBowler1Overs);
            computerBowlerOvers.Add(computerBowler2Overs);
            computerBowlerOvers.Add(computerBowler3Overs);
            computerBowlerOvers.Add(computerBowler4Overs);

            computerBowlerWickets.Add(computerBowler1Wickets);
            computerBowlerWickets.Add(computerBowler2Wickets);
            computerBowlerWickets.Add(computerBowler3Wickets);
            computerBowlerWickets.Add(computerBowler4Wickets);

            int sumWhoopie = whoopie1 + whoopie2 + whoopie3 + whoopie4;

            Console.WriteLine("        ");
            Console.WriteLine("Team " + sidePicked + " has scored " + firstInningsTotal + " in " + numberOfOvers +
               "." + sumWhoopie + " overs.");

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();
            Console.WriteLine("        ");

            //batting strike rate
            index = 0;

            while (index < 10)
            {
                if (!(playerBatsmenDeliveriesPlayed[index] == 0))
                {
                    float factor = 100f;
                    float runsMade = playerBatsmenScores[index];
                    float ballsPlayed = playerBatsmenDeliveriesPlayed[index];
                    float battingStrikeRateW = (runsMade / ballsPlayed) * factor;
                    battingStrikeRate.Add(battingStrikeRateW);
                }
                else if(playerBatsmenDeliveriesPlayed[index] == 0)
                {
                    battingStrikeRate.Add("N/A");
                }
                index += 1;
            }

            //run rate
            float ballsOver = 6f;

            float numberOfBalls1 = numberOfOvers + (sumWhoopie/ballsOver);

            float runrate = firstInningsTotal / numberOfBalls1;

            int numberBatsmenPrinted = 0;
            index = 0;

            Console.WriteLine("Batting Scorecard: ");

            while (numberBatsmenPrinted < 10)
            {
                Console.WriteLine(playerTeam[index] + " : " + playerBatsmenScores[index] + " (" +
                    playerBatsmenDeliveriesPlayed[index] + ") . Strike Rate: " +
                    battingStrikeRate[index]);
                index += 1;
                numberBatsmenPrinted += 1;
            }

            Console.WriteLine("        ");

            //print runrate and total:

            Console.WriteLine("Innings Total: " + firstInningsTotal + " / " +
                battingWicketsLost + ". Run rate: " + runrate);
            Console.WriteLine("     ");

            //bowling economy
            float completeOver = 6f;
            index = 0;

            while(index < 4)
            {
                if(!(computerBowlerOvers[index] + whoopie[index] == 0))
                {
                    float economyRateW = computerBowlerRuns[index] / (computerBowlerOvers[index] + (whoopie[index] / completeOver));
                    economyRate.Add(economyRateW);
                }
                else if(computerBowlerOvers[index] + whoopie[index] == 0)
                { 
                    economyRate.Add("--");
                }
                index += 1;
            }

            //strike rate
            index = 0;

            while (index < 4)
            {
                if (!(computerBowlerWickets[index] == 0))
                {
                    float ballsPerOver = 6f;
                    float ballsIncOver = whoopie[index];
                    float ballsBowled = computerBowlerOvers[index] * ballsPerOver + ballsIncOver;
                    float wicketsTaken = computerBowlerWickets[index];
                    float strikeRateW = ballsBowled / wicketsTaken;
                    strikeRate.Add(strikeRateW);
                }
                else if (computerBowlerWickets[index] == 0)
                {
                    strikeRate.Add("--");
                }
                index += 1;
            }

            //bowling average
            index = 0;

            while(index < 4)
            {
                if(!(computerBowlerWickets[index] == 0))
                {
                    float runsGiven = computerBowlerRuns[index];
                    float wicketsTaken = computerBowlerWickets[index];
                    float averageW = runsGiven / wicketsTaken;
                    average.Add(averageW);
                }
                else if(computerBowlerWickets[index] == 0)
                {
                    average.Add("--");
                }
                index += 1; 
            }

            Console.WriteLine("Bowling Scorecard:");
            Console.WriteLine("        ");

            int numberBowlersPrinted = 0;
            index = 0;

            while (numberBowlersPrinted < 4)
            {
                Console.WriteLine(computerBowlers[index] + ". Overs:  " + computerBowlerOvers[index] + "."
                    + whoopie[index] + ".  Runs: " +
                    computerBowlerRuns[index] + ". Wickets: " + computerBowlerWickets[index] +
                    ". Economy: " + economyRate[index] + ". " /*"Strike Rate: " +
                    strikeRate[index] + ". Average: " + average[index]*/);
                index += 1;
                numberBowlersPrinted += 1;
                Console.WriteLine("     ");
            }

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            return firstInningsTotal;

        }

        public static int SecondInningscomputerTeamBats(int input)
        {
            int battingWicketsLost = 0;
            int secondInningsTotal = 0;
            int currentBatsmanScore = 0;
            secondInningsComplete = false;
            gameOver = false;

            numberOfBalls = 0;
            int index = 0;
            numberOfOvers = 0;
            int currentBowlerRuns = 0;
            int currentBowlerWickets = 0;
            int currentBowlerOvers = 0;

            int whoopie1 = 0;
            int whoopie2 = 0;
            int whoopie3 = 0;
            int whoopie4 = 0;

            List<int> whoopie = new List<int>();
            List<object> economyRate = new List<object>();
            List<object> strikeRate = new List<object>();
            List<object> average = new List<object>();
            List<object> battingStrikeRateC = new List<object>();

            while (secondInningsComplete == false && gameOver == false)
            {
                //player bowler #1
                
                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;
                currentBowler = playerBowler1;

                //bowl over
                while (numberOfBalls < 6 && secondInningsComplete == false && gameOver == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 15);

                    if (!(battingScore == bowlingScore))
                    {
                        secondInningsTotal += battingScore;
                        currentBatsmanScore += battingScore;
                        currentBowlerRuns += battingScore;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = computerTeam[battingWicketsLost];
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : " +
                            battingScore + " runs.");

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();

                        if (secondInningsTotal > input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine("       ");
                            gameOver = true;
                            secondInningsComplete = true;
                            playerNotOut = true;
                            string playerC = computerTeam[battingWicketsLost];
                            computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            computerBatsmenScores.Add(currentBatsmanScore);
                            Console.WriteLine(playerC + " is not out on " + currentBatsmanScore);
                            computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            computerBatsmenScores.Add(currentBatsmanScore);
                            // team2Wins += 1;
                            Console.WriteLine("       ");
                            Console.WriteLine("The second innings total is " + secondInningsTotal + " (for the loss of " + battingWicketsLost
                             + " wickets) and so Team " + sideNotPicked + " won the game.");
                            if (numberOfBalls < 5)
                            {
                                whoopie1 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie1 = 0;
                            }
                            whoopie2 = 0;
                            whoopie3 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                    }

                    else if (battingScore == bowlingScore)
                    {
                        currentBowlerWickets += 1;
                        battingWicketsLost += 1;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = computerTeam[battingWicketsLost - 1];
                        computerBatsmenScores.Add(currentBatsmanScore);
                        computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine("      ");
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sideNotPicked + " : " + secondInningsTotal + " / " + battingWicketsLost);

                        if (battingWicketsLost < 10)
                        {
                            Console.WriteLine(" Team " + sideNotPicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");
                           
                        }

                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10 && secondInningsTotal == input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            secondInningsComplete = true;
                            // ties += 1;
                            Console.WriteLine("Its a tie!");
                            if (numberOfBalls < 5)
                            {
                                whoopie1 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie1 = 0;
                            }
                            whoopie2 = 0;
                            whoopie3 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                        if (battingWicketsLost == 10 && secondInningsTotal < input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            secondInningsComplete = true;
                            // team1Wins += 1;
                            Console.WriteLine("Team " + sideNotPicked + " has only scored " + secondInningsTotal + " and has thus lost " +
                                " the game by " + (input - secondInningsTotal) + " runs.");
                            if (numberOfBalls < 5)
                            {
                                whoopie1 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie1 = 0;
                            }
                            whoopie2 = 0;
                            whoopie3 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }

                    numberOfBalls += 1;

                    if (numberOfBalls == 6)
                    {
                        currentBowlerOvers += 1;
                        numberOfOvers += 1;
                    }
                }

                playerBowler1Runs += currentBowlerRuns;
                playerBowler1Wickets += currentBowlerWickets;
                playerBowler1Overs += currentBowlerOvers;

                if (secondInningsComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sideNotPicked + " : " + secondInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + playerBowler1Overs + ". Runs: " +
                        playerBowler1Runs + ". Wickets: " + playerBowler1Wickets);
                    Console.WriteLine("         ");
                    string player = computerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("          ");
                    Console.WriteLine(" Team " + sideNotPicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");
                    Console.WriteLine("-----------");

                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }

                //player bowler #2
                
                    currentBowlerRuns = 0;
                    currentBowlerWickets = 0;
                    currentBowlerOvers = 0;
                    numberOfBalls = 0;
                    currentBowler = playerBowler2;
                

                //bowl over
                while (numberOfBalls < 6 && secondInningsComplete == false && gameOver == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        secondInningsTotal += battingScore;
                        currentBatsmanScore += battingScore;
                        currentBowlerRuns += battingScore;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = computerTeam[battingWicketsLost];
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : " +
                            battingScore + " runs.");

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();

                        if (secondInningsTotal > input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine("       ");
                            gameOver = true;
                            secondInningsComplete = true;
                            playerNotOut = true;
                            string playerC = computerTeam[battingWicketsLost];
                            computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            computerBatsmenScores.Add(currentBatsmanScore);
                            Console.WriteLine(playerC + " is not out on " + currentBatsmanScore);
                            // team2Wins += 1;
                            Console.WriteLine("       ");
                            Console.WriteLine("The second innings total is " + secondInningsTotal + " (for the loss of " + battingWicketsLost
                             + " wickets) and so Team " + sideNotPicked + " won the game.");

                            if(numberOfBalls < 5)
                            {
                                whoopie2 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie2 = 0;
                            }
                            whoopie1 = 0;
                            whoopie3 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                    }

                    else if (battingScore == bowlingScore)
                    {
                        currentBowlerWickets += 1;
                        battingWicketsLost += 1;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = computerTeam[battingWicketsLost - 1];
                        computerBatsmenScores.Add(currentBatsmanScore);
                        computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine("      ");
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sideNotPicked + " : " + secondInningsTotal + " / " + battingWicketsLost);

                        if (battingWicketsLost < 10)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine(" Team " + sideNotPicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");
                    
                        }

                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10 && secondInningsTotal == input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            secondInningsComplete = true;
                            // ties += 1;
                            Console.WriteLine("Its a tie!");

                            if (numberOfBalls < 5)
                            {
                                whoopie2 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie2 = 0;
                            }
                            whoopie1 = 0;
                            whoopie3 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                        if (battingWicketsLost == 10 && secondInningsTotal < input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            secondInningsComplete = true;
                            // team1Wins += 1;
                            Console.WriteLine("Team " + sideNotPicked + " has only scored " + secondInningsTotal + " and has thus lost " +
                                " the game by " + (input - secondInningsTotal) + " runs.");
                            if (numberOfBalls < 5)
                            {
                                whoopie2 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie2 = 0;
                            }
                            whoopie1 = 0;
                            whoopie3 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }


                    numberOfBalls += 1;

                    if (numberOfBalls == 6)
                    {
                        currentBowlerOvers += 1;
                        numberOfOvers += 1;
                    }
                }

                playerBowler2Runs += currentBowlerRuns;
                playerBowler2Wickets += currentBowlerWickets;
                playerBowler2Overs += currentBowlerOvers;

                if (secondInningsComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sideNotPicked + " : " + secondInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + playerBowler2Overs + ". Runs: " +
                        playerBowler2Runs + ". Wickets: " + playerBowler2Wickets);
                    Console.WriteLine("         ");
                    string player = computerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("          ");
                    Console.WriteLine(" Team " + sideNotPicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");
                    Console.WriteLine("-----------");
                    

                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }

                //player bowler #3
                
                    currentBowlerRuns = 0;
                    currentBowlerWickets = 0;
                    currentBowlerOvers = 0;
                    numberOfBalls = 0;
                    currentBowler = playerBowler3;
                

                //bowl over
                while (numberOfBalls < 6 && secondInningsComplete == false && gameOver == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        secondInningsTotal += battingScore;
                        currentBatsmanScore += battingScore;
                        currentBowlerRuns += battingScore;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = computerTeam[battingWicketsLost];
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : " +
                            battingScore + " runs.");

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();

                        if (secondInningsTotal > input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine("       ");
                            gameOver = true;
                            secondInningsComplete = true;
                            playerNotOut = true;
                            string playerC = computerTeam[battingWicketsLost];
                            computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            computerBatsmenScores.Add(currentBatsmanScore);
                            Console.WriteLine(playerC + " is not out on " + currentBatsmanScore);
                            // team2Wins += 1;
                            Console.WriteLine("       ");
                            Console.WriteLine("The second innings total is " + secondInningsTotal + " (for the loss of " + battingWicketsLost
                             + " wickets) and so Team " + sideNotPicked + " won the game.");

                            if (numberOfBalls < 5)
                            {
                                whoopie3 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie3 = 0;
                            }
                            whoopie1 = 0;
                            whoopie2 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                    }

                    else if (battingScore == bowlingScore)
                    {
                        currentBowlerWickets += 1;
                        battingWicketsLost += 1;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = computerTeam[battingWicketsLost - 1];
                        computerBatsmenScores.Add(currentBatsmanScore);
                        computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine("      ");
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sideNotPicked + " : " + secondInningsTotal + " / " + battingWicketsLost);

                        if (battingWicketsLost < 10)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine(" Team " + sideNotPicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");
                        }

                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10 && secondInningsTotal == input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            secondInningsComplete = true;
                            // ties += 1;
                            Console.WriteLine("Its a tie!");

                            if (numberOfBalls < 5)
                            {
                                whoopie3 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie3 = 0;
                            }
                            whoopie1 = 0;
                            whoopie2 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                        if (battingWicketsLost == 10 && secondInningsTotal < input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            secondInningsComplete = true;
                            // team1Wins += 1;
                            Console.WriteLine("Team " + sideNotPicked + " has only scored " + secondInningsTotal + " and has thus lost " +
                                " the game by " + (input - secondInningsTotal) + " runs.");

                            if (numberOfBalls < 5)
                            {
                                whoopie3 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie3 = 0;
                            }
                            whoopie1 = 0;
                            whoopie2 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }

                    numberOfBalls += 1;

                    if (numberOfBalls == 6)
                    {
                        currentBowlerOvers += 1;
                        numberOfOvers += 1;
                    }
                }

                playerBowler3Runs += currentBowlerRuns;
                playerBowler3Wickets += currentBowlerWickets;
                playerBowler3Overs += currentBowlerOvers;

                if (secondInningsComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sideNotPicked + " : " + secondInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + playerBowler3Overs + ". Runs: " +
                        playerBowler3Runs + ". Wickets: " + playerBowler3Wickets);
                    Console.WriteLine("         ");
                    string player = computerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("          ");
                    Console.WriteLine(" Team " + sideNotPicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");
                    Console.WriteLine("-----------");

                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }

                //player bowler #4
               
                    currentBowlerRuns = 0;
                    currentBowlerWickets = 0;
                    currentBowlerOvers = 0;
                    numberOfBalls = 0;
                    currentBowler = playerBowler4;
                

                //bowl over
                while (numberOfBalls < 6 && secondInningsComplete == false && gameOver == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        secondInningsTotal += battingScore;
                        currentBatsmanScore += battingScore;
                        currentBowlerRuns += battingScore;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = computerTeam[battingWicketsLost];
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : " +
                            battingScore + " runs.");

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();

                        if (secondInningsTotal > input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine("       ");
                            gameOver = true;
                            secondInningsComplete = true;
                            playerNotOut = true;
                            string playerC = computerTeam[battingWicketsLost];
                            computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            computerBatsmenScores.Add(currentBatsmanScore);
                            Console.WriteLine(playerC + " is not out on " + currentBatsmanScore);
                            // team2Wins += 1;
                            Console.WriteLine("       ");
                            Console.WriteLine("The second innings total is " + secondInningsTotal + " (for the loss of " + battingWicketsLost
                             + " wickets) and so Team " + sideNotPicked + " won the game.");

                            if (numberOfBalls < 5)
                            {
                                whoopie4 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie4 = 0;
                            }
                            whoopie1 = 0;
                            whoopie2 = 0;
                            whoopie3 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                    }

                    else if (battingScore == bowlingScore)
                    {
                        currentBowlerWickets += 1;
                        battingWicketsLost += 1;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = computerTeam[battingWicketsLost - 1];
                        computerBatsmenScores.Add(currentBatsmanScore);
                        computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine("      ");
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sideNotPicked + " : " + secondInningsTotal + " / " + battingWicketsLost);

                        if (battingWicketsLost < 10)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine(" Team " + sideNotPicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");
                        }

                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10 && secondInningsTotal == input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            secondInningsComplete = true;
                            // ties += 1;
                            Console.WriteLine("Its a tie!");

                            if (numberOfBalls < 5)
                            {
                                whoopie4 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie4 = 0;
                            }
                            whoopie1 = 0;
                            whoopie2 = 0;
                            whoopie3 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                        if (battingWicketsLost == 10 && secondInningsTotal < input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            secondInningsComplete = true;
                            // team1Wins += 1;
                            Console.WriteLine("Team " + sideNotPicked + " has only scored " + secondInningsTotal + " and has thus lost " +
                                " the game by " + (input - secondInningsTotal) + " runs.");

                            if (numberOfBalls < 5)
                            {
                                whoopie4 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie4 = 0;
                            }
                            whoopie1 = 0;
                            whoopie2 = 0;
                            whoopie3 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }

                    numberOfBalls += 1;

                    if (numberOfBalls == 6)
                    {
                        currentBowlerOvers += 1;
                        numberOfOvers += 1;
                    }
                }

                playerBowler4Runs += currentBowlerRuns;
                playerBowler4Wickets += currentBowlerWickets;
                playerBowler4Overs += currentBowlerOvers;

                if (secondInningsComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sideNotPicked + " : " + secondInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + playerBowler4Overs + ". Runs: " +
                        playerBowler4Runs + ". Wickets: " + playerBowler4Wickets);
                    Console.WriteLine("         ");
                    string player = computerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("          ");
                    Console.WriteLine(" Team " + sideNotPicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");
                    Console.WriteLine("-----------");

                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }
            }

            //what if a team gets all out in 2 overs? 
            playerBowlerRuns.Add(playerBowler1Runs);
            playerBowlerRuns.Add(playerBowler2Runs);
            playerBowlerRuns.Add(playerBowler3Runs);
            playerBowlerRuns.Add(playerBowler4Runs);

            playerBowlerOvers.Add(playerBowler1Overs);
            playerBowlerOvers.Add(playerBowler2Overs);
            playerBowlerOvers.Add(playerBowler3Overs);
            playerBowlerOvers.Add(playerBowler4Overs);

            playerBowlerWickets.Add(playerBowler1Wickets);
            playerBowlerWickets.Add(playerBowler2Wickets);
            playerBowlerWickets.Add(playerBowler3Wickets);
            playerBowlerWickets.Add(playerBowler4Wickets);

            int sumWhoopie = whoopie1 + whoopie2 + whoopie3 + whoopie4;

            Console.WriteLine("        ");
            Console.WriteLine("Team " + sideNotPicked + " has scored " + secondInningsTotal + " in " + numberOfOvers +
                "." + sumWhoopie +
                " overs.");

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            //bowler economy rate
            float completeOver = 6f;
            index = 0;

            while (index < 4)
            {
                if (!(playerBowlerOvers[index] + whoopie[index] == 0))
                {
                    float economyRateW = playerBowlerRuns[index] / (playerBowlerOvers[index] + (whoopie[index] / completeOver));
                    economyRate.Add(economyRateW);
                }
                else if (playerBowlerOvers[index] + whoopie[index] == 0)
                {
                    economyRate.Add("Not applicable");
                }
                index += 1;
            }

            //strike rate
            index = 0;

            while (index < 4)
            {
                if (!(playerBowlerWickets[index] == 0))
                {
                    float ballsPerOver = 6f;
                    float ballsIncOver = whoopie[index];
                    float ballsBowled = playerBowlerOvers[index] * ballsPerOver + ballsIncOver;
                    float wicketsTaken = playerBowlerWickets[index];
                    float strikeRateW = ballsBowled / wicketsTaken;
                    strikeRate.Add(strikeRateW);
                }
                else if (playerBowlerWickets[index] == 0)
                {
                    strikeRate.Add("--");
                }
                index += 1;
            }

            //bowling average
            index = 0;

            while (index < 4)
            {
                if (!(playerBowlerWickets[index] == 0))
                {
                    float runsGiven = playerBowlerRuns[index];
                    float wicketsTaken = playerBowlerWickets[index];
                    float averageW = runsGiven / wicketsTaken;
                    average.Add(averageW);
                }
                else if (playerBowlerWickets[index] == 0)
                {
                    average.Add("--");
                }
                index += 1;
            }

            Console.WriteLine("        ");
            Console.WriteLine("Batting Scorecard: ");
            Console.WriteLine("        ");

            //batting strike rate
            index = 0;

            while (index < chasingWicketLost)
            {
                if (!(computerBatsmenDeliveriesPlayed[index] == 0))
                {
                    float factor = 100f;
                    float runsMade = computerBatsmenScores[index];
                    float ballsPlayed = computerBatsmenDeliveriesPlayed[index];
                    float battingStrikeRateW = (runsMade / ballsPlayed) * factor;
                    battingStrikeRateC.Add(battingStrikeRateW);
                }
                else if (computerBatsmenDeliveriesPlayed[index] == 0)
                {
                    battingStrikeRateC.Add("N/A");
                }
                index += 1;
            }

            int numberBatsmenPrinted = 0;
            index = 0;

            while (numberBatsmenPrinted < chasingWicketLost)
            {
                Console.WriteLine(computerTeam[index] + " : " + computerBatsmenScores[index] + " (" +
                computerBatsmenDeliveriesPlayed[index] + "). Strike Rate: " +
                battingStrikeRateC[index]);
                index += 1;
                numberBatsmenPrinted += 1;
                if (numberBatsmenPrinted == chasingWicketLost && playerNotOut == true)
                {
                    Console.WriteLine(computerTeam[index] + " : " + computerBatsmenScores[index] + " (" +
                    computerBatsmenDeliveriesPlayed[index] + ") not out." );
                }
            }

            //total and overall runrate

            float ballsOver1 = 6f;

            float overs = numberOfOvers + (sumWhoopie / ballsOver1);

            float runrate = secondInningsTotal / overs;

            Console.WriteLine("    ");

            Console.WriteLine("Innings Total: " + secondInningsTotal + " / " +
                battingWicketsLost + ". Run rate: " + runrate);
            Console.WriteLine("    ");

            int numberBowlersPrinted = 0;
            index = 0;

            Console.WriteLine("        ");

            Console.WriteLine("Bowling Scorecard: ");

            Console.WriteLine("        ");

            while (numberBowlersPrinted < 4)
            {
                Console.WriteLine(playerBowlers[index] + ". Overs:  " + playerBowlerOvers[index]
                    + "." + whoopie[index] + ".  Runs: " +
                    playerBowlerRuns[index] + ". Wickets: " + playerBowlerWickets[index] +
                    ". Economy: " +
                    economyRate[index] + ". " /*Strike Rate: " + strikeRate[index]
                    + ". Average: " + average[index]*/);
                Console.WriteLine("       ");
                index += 1;
                numberBowlersPrinted += 1;
            }

            return secondInningsTotal;
        }

        public static int FirstInningscomputerTeamBats()
        {

            int battingWicketsLost = 0;
            firstInningsTotal = 0;
            int currentBatsmanScore = 0;
            bool firstInningsComplete = false;
            int numberOfBalls = 0;
            int index = 0;
            numberOfOvers = 0;
            int currentBowlerRuns = 0;
            int currentBowlerWickets = 0;
            int currentBowlerOvers = 0;

            int whoopie1 = 0;
            int whoopie2 = 0;
            int whoopie3 = 0;
            int whoopie4 = 0;

            List<int> whoopie = new List<int>();
            List<object> economyRate = new List<object>();
            List<object> strikeRate = new List<object>();
            List<object> average = new List<object>();
            List<object> battingStrikeRate = new List<object>();

            while (firstInningsComplete == false)
            {
                //player bowler #1

                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;
                currentBowler = playerBowler1;

                //bowl over
                while (numberOfBalls < 6 && firstInningsComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 15);

                    if (!(battingScore == bowlingScore))
                    {
                        firstInningsTotal += battingScore;
                        currentBatsmanScore += battingScore;
                        currentBowlerRuns += battingScore;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = computerTeam[battingWicketsLost];
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : " +
                            battingScore + " runs.");

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();

                    }
                    else if (battingScore == bowlingScore)
                    {
                        battingWicketsLost += 1;
                        currentBatsmanDeliveriesPlayed += 1;
                        currentBowlerWickets += 1;
                        string player = computerTeam[battingWicketsLost - 1];
                        computerBatsmenScores.Add(currentBatsmanScore);
                        computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {

                            firstInningsComplete = true;

                            //apply this sort of logic in the other spots.
                            if (numberOfBalls < 5)
                            {
                                whoopie1 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie1 = 0;
                            }
                            whoopie2 = 0;
                            whoopie3 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }
                    numberOfBalls += 1;

                    if (numberOfBalls == 6)
                    {
                        numberOfOvers += 1;
                        currentBowlerOvers += 1;
                    }

                    if (firstInningsComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                playerBowler1Runs += currentBowlerRuns;
                playerBowler1Wickets += currentBowlerWickets;
                playerBowler1Overs += currentBowlerOvers;

                if (firstInningsComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + playerBowler1Overs + ". Runs: " +
                        playerBowler1Runs + ". Wickets: " + playerBowler1Wickets);
                    Console.WriteLine("         ");
                    string player = computerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("-----------");

                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }

                //player bowler #2

                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;
                currentBowler = playerBowler2;

                //bowl over
                while (numberOfBalls < 6 && firstInningsComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        firstInningsTotal += battingScore;
                        currentBatsmanScore += battingScore;
                        currentBowlerRuns += battingScore;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = computerTeam[battingWicketsLost];
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : " +
                            battingScore + " runs.");

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }
                    else if (battingScore == bowlingScore)
                    {
                        battingWicketsLost += 1;
                        currentBowlerWickets += 1;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = computerTeam[battingWicketsLost - 1];
                        computerBatsmenScores.Add(currentBatsmanScore);
                        computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            firstInningsComplete = true;
                            if (numberOfBalls < 5)
                            {
                                whoopie2 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie2 = 0;
                            }
                            whoopie1 = 0;
                            whoopie3 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }

                    numberOfBalls += 1;

                    if (numberOfBalls == 6)
                    {
                        numberOfOvers += 1;
                        currentBowlerOvers += 1;
                    }

                    if (firstInningsComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                playerBowler2Runs += currentBowlerRuns;
                playerBowler2Wickets += currentBowlerWickets;
                playerBowler2Overs += currentBowlerOvers;

                if (firstInningsComplete == false)
                {

                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine(currentBowler + ". Overs: " + playerBowler2Overs + ". Runs: " +
                        playerBowler2Runs + ". Wickets: " + playerBowler2Wickets);
                    Console.WriteLine("         ");
                    string player = computerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("-----------");


                    Console.WriteLine("        ");
                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }

                //player bowler #3

                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;
                currentBowler = playerBowler3;

                //bowl over
                while (numberOfBalls < 6 && firstInningsComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        firstInningsTotal += battingScore;
                        currentBatsmanScore += battingScore;
                        currentBowlerRuns += battingScore;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = computerTeam[battingWicketsLost];
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : " +
                            battingScore + " runs.");

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }
                    else if (battingScore == bowlingScore)
                    {
                        battingWicketsLost += 1;
                        currentBowlerWickets += 1;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = computerTeam[battingWicketsLost - 1];
                        computerBatsmenScores.Add(currentBatsmanScore);
                        computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            firstInningsComplete = true;
                            if (numberOfBalls < 5)
                            {
                                whoopie3 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie3 = 0;
                            }
                            whoopie1 = 0;
                            whoopie2 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }

                    numberOfBalls += 1;

                    if (numberOfBalls == 6)
                    {
                        numberOfOvers += 1;
                        currentBowlerOvers += 1;
                    }

                    if (firstInningsComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                playerBowler3Runs += currentBowlerRuns;
                playerBowler3Wickets += currentBowlerWickets;
                playerBowler3Overs += currentBowlerOvers;

                if (firstInningsComplete == false)
                {

                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine(currentBowler + ". Overs: " + playerBowler3Overs + ". Runs: " +
                        playerBowler3Runs + ". Wickets: " + playerBowler3Wickets);
                    Console.WriteLine("         ");
                    string player = computerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("-----------");


                    Console.WriteLine("        ");
                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }

                //player bowler #4

                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;
                currentBowler = playerBowler4;

                //bowl over
                while (numberOfBalls < 6 && firstInningsComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        firstInningsTotal += battingScore;
                        currentBatsmanScore += battingScore;
                        currentBowlerRuns += battingScore;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = computerTeam[battingWicketsLost];
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : " +
                            battingScore + " runs.");

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }
                    else if (battingScore == bowlingScore)
                    {
                        battingWicketsLost += 1;
                        currentBowlerWickets += 1;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = computerTeam[battingWicketsLost - 1];
                        computerBatsmenScores.Add(currentBatsmanScore);
                        computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            firstInningsComplete = true;
                            if (numberOfBalls < 5)
                            {
                                whoopie4 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie4 = 0;
                            }
                            whoopie1 = 0;
                            whoopie3 = 0;
                            whoopie2 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }

                    numberOfBalls += 1;

                    if (numberOfBalls == 6)
                    {
                        numberOfOvers += 1;
                        currentBowlerOvers += 1;
                    }

                    if (firstInningsComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                playerBowler4Runs += currentBowlerRuns;
                playerBowler4Wickets += currentBowlerWickets;
                playerBowler4Overs += currentBowlerOvers;

                if (firstInningsComplete == false)
                {

                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine(currentBowler + ". Overs: " + playerBowler4Overs + ". Runs: " +
                        playerBowler4Runs + ". Wickets: " + playerBowler4Wickets);
                    Console.WriteLine("         ");
                    string player = computerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("-----------");


                    Console.WriteLine("        ");
                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }
            }

            playerBowlerRuns.Add(playerBowler1Runs);
            playerBowlerRuns.Add(playerBowler2Runs);
            playerBowlerRuns.Add(playerBowler3Runs);
            playerBowlerRuns.Add(playerBowler4Runs);

            playerBowlerOvers.Add(playerBowler1Overs);
            playerBowlerOvers.Add(playerBowler2Overs);
            playerBowlerOvers.Add(playerBowler3Overs);
            playerBowlerOvers.Add(playerBowler4Overs);

            playerBowlerWickets.Add(playerBowler1Wickets);
            playerBowlerWickets.Add(playerBowler2Wickets);
            playerBowlerWickets.Add(playerBowler3Wickets);
            playerBowlerWickets.Add(playerBowler4Wickets);

            int sumWhoopie = whoopie1 + whoopie2 + whoopie3 + whoopie4;

            Console.WriteLine("        ");
            Console.WriteLine("Team " + sideNotPicked + " has scored " + firstInningsTotal + " in " + numberOfOvers +
               "." + sumWhoopie + " overs.");

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("        ");

            //batting strike rate
            index = 0;

            while (index < 10)
            {
                if (!(computerBatsmenDeliveriesPlayed[index] == 0))
                {
                    float factor = 100f;
                    float runsMade = computerBatsmenScores[index];
                    float ballsPlayed = computerBatsmenDeliveriesPlayed[index];
                    float battingStrikeRateW = (runsMade / ballsPlayed) * factor;
                    battingStrikeRate.Add(battingStrikeRateW);
                }
                else if (computerBatsmenDeliveriesPlayed[index] == 0)
                {
                    battingStrikeRate.Add("N/A");
                }
                index += 1;
            }

            //run rate
            float ballsOver = 6f;

            float numberOfBalls1 = numberOfOvers + (sumWhoopie / ballsOver);

            float runrate = firstInningsTotal / numberOfBalls1;

            int numberBatsmenPrinted = 0;
            index = 0;

            Console.WriteLine("Batting Scorecard: ");

            while (numberBatsmenPrinted < 10)
            {
                Console.WriteLine(computerTeam[index] + " : " + computerBatsmenScores[index] + " (" +
                    computerBatsmenDeliveriesPlayed[index] + ") . Strike Rate: " +
                    battingStrikeRate[index]);
                index += 1;
                numberBatsmenPrinted += 1;
            }

            Console.WriteLine("        ");

            //print runrate and total:

            Console.WriteLine("Innings Total: " + firstInningsTotal + " / " +
                battingWicketsLost + ". Run rate: " + runrate);
            Console.WriteLine("     ");

            //bowling economy
            float completeOver = 6f;
            index = 0;

            while (index < 4)
            {
                if (!(playerBowlerOvers[index] + whoopie[index] == 0))
                {
                    float economyRateW = playerBowlerRuns[index] / (playerBowlerOvers[index] + (whoopie[index] / completeOver));
                    economyRate.Add(economyRateW);
                }
                else if (playerBowlerOvers[index] + whoopie[index] == 0)
                {
                    economyRate.Add("--");
                }
                index += 1;
            }

            //strike rate
            index = 0;

            while (index < 4)
            {
                if (!(playerBowlerWickets[index] == 0))
                {
                    float ballsPerOver = 6f;
                    float ballsIncOver = whoopie[index];
                    float ballsBowled = playerBowlerOvers[index] * ballsPerOver + ballsIncOver;
                    float wicketsTaken = playerBowlerWickets[index];
                    float strikeRateW = ballsBowled / wicketsTaken;
                    strikeRate.Add(strikeRateW);
                }
                else if (playerBowlerWickets[index] == 0)
                {
                    strikeRate.Add("--");
                }
                index += 1;
            }

            //bowling average
            index = 0;

            while (index < 4)
            {
                if (!(playerBowlerWickets[index] == 0))
                {
                    float runsGiven = playerBowlerRuns[index];
                    float wicketsTaken = playerBowlerWickets[index];
                    float averageW = runsGiven / wicketsTaken;
                    average.Add(averageW);
                }
                else if (playerBowlerWickets[index] == 0)
                {
                    average.Add("--");
                }
                index += 1;
            }

            Console.WriteLine("Bowling Scorecard:");
            Console.WriteLine("        ");

            int numberBowlersPrinted = 0;
            index = 0;

            while (numberBowlersPrinted < 4)
            {
                Console.WriteLine(playerBowlers[index] + ". Overs:  " + playerBowlerOvers[index] + "."
                    + whoopie[index] + ".  Runs: " +
                    playerBowlerRuns[index] + ". Wickets: " + playerBowlerWickets[index] +
                    ". Economy: " + economyRate[index] + ". " /*"Strike Rate: " +
                    strikeRate[index] + ". Average: " + average[index]*/);
                index += 1;
                numberBowlersPrinted += 1;
                Console.WriteLine("     ");
            }

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            return firstInningsTotal;
        }

        public static int SecondInningsplayerTeamBats(int input)
        {
            
            int battingWicketsLost = 0;
            int secondInningsTotal = 0;
            int currentBatsmanScore = 0;
            secondInningsComplete = false;
            gameOver = false;

            numberOfBalls = 0;
            int index = 0;
            numberOfOvers = 0;
            int currentBowlerRuns = 0;
            int currentBowlerWickets = 0;
            int currentBowlerOvers = 0;

            int whoopie1 = 0;
            int whoopie2 = 0;
            int whoopie3 = 0;
            int whoopie4 = 0;

            List<int> whoopie = new List<int>();
            List<object> economyRate = new List<object>();
            List<object> strikeRate = new List<object>();
            List<object> average = new List<object>();
            List<object> battingStrikeRateC = new List<object>();

            while (secondInningsComplete == false && gameOver == false)
            {
                //computer bowler #1

                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;
                currentBowler = computerBowler1;

                //bowl over
                while (numberOfBalls < 6 && secondInningsComplete == false && gameOver == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 15);

                    if (!(battingScore == bowlingScore))
                    {
                        secondInningsTotal += battingScore;
                        currentBatsmanScore += battingScore;
                        currentBowlerRuns += battingScore;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = playerTeam[battingWicketsLost];
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : " +
                            battingScore + " runs.");

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();

                        if (secondInningsTotal > input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine("       ");
                            gameOver = true;
                            secondInningsComplete = true;
                            playerNotOut = true;
                            string playerC = playerTeam[battingWicketsLost];
                            playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            playerBatsmenScores.Add(currentBatsmanScore);
                            Console.WriteLine(playerC + " is not out on " + currentBatsmanScore);
                            playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            playerBatsmenScores.Add(currentBatsmanScore);
                            // team2Wins += 1;
                            Console.WriteLine("       ");
                            Console.WriteLine("The second innings total is " + secondInningsTotal + " (for the loss of " + battingWicketsLost
                             + " wickets) and so Team " + sidePicked + " won the game.");
                            if (numberOfBalls < 5)
                            {
                                whoopie1 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie1 = 0;
                            }
                            whoopie2 = 0;
                            whoopie3 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                    }

                    else if (battingScore == bowlingScore)
                    {
                        currentBowlerWickets += 1;
                        battingWicketsLost += 1;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = playerTeam[battingWicketsLost - 1];
                        playerBatsmenScores.Add(currentBatsmanScore);
                        playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine("      ");
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sidePicked + " : " + secondInningsTotal + " / " + battingWicketsLost);

                        if (battingWicketsLost < 10)
                        {
                            Console.WriteLine(" Team " + sidePicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");

                        }

                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10 && secondInningsTotal == input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            secondInningsComplete = true;
                            // ties += 1;
                            Console.WriteLine("Its a tie!");
                            if (numberOfBalls < 5)
                            {
                                whoopie1 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie1 = 0;
                            }
                            whoopie2 = 0;
                            whoopie3 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                        if (battingWicketsLost == 10 && secondInningsTotal < input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            secondInningsComplete = true;
                            // team1Wins += 1;
                            Console.WriteLine("Team " + sidePicked + " has only scored " + secondInningsTotal + " and has thus lost " +
                                " the game by " + (input - secondInningsTotal) + " runs.");
                            if (numberOfBalls < 5)
                            {
                                whoopie1 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie1 = 0;
                            }
                            whoopie2 = 0;
                            whoopie3 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }

                    numberOfBalls += 1;

                    if (numberOfBalls == 6)
                    {
                        currentBowlerOvers += 1;
                        numberOfOvers += 1;
                    }
                }

                computerBowler1Runs += currentBowlerRuns;
                computerBowler1Wickets += currentBowlerWickets;
                computerBowler1Overs += currentBowlerOvers;

                if (secondInningsComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + secondInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + computerBowler1Overs + ". Runs: " +
                        computerBowler1Runs + ". Wickets: " + computerBowler1Wickets);
                    Console.WriteLine("         ");
                    string player = playerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("          ");
                    Console.WriteLine(" Team " + sidePicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");
                    Console.WriteLine("-----------");

                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }


                //computer bowler #2

                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;
                currentBowler = computerBowler2;

                //bowl over
                while (numberOfBalls < 6 && secondInningsComplete == false && gameOver == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        secondInningsTotal += battingScore;
                        currentBatsmanScore += battingScore;
                        currentBowlerRuns += battingScore;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = playerTeam[battingWicketsLost];
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : " +
                            battingScore + " runs.");

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();

                        if (secondInningsTotal > input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine("       ");
                            gameOver = true;
                            secondInningsComplete = true;
                            playerNotOut = true;
                            string playerC = playerTeam[battingWicketsLost];
                            playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            playerBatsmenScores.Add(currentBatsmanScore);
                            Console.WriteLine(playerC + " is not out on " + currentBatsmanScore);
                            playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            playerBatsmenScores.Add(currentBatsmanScore);
                            // team2Wins += 1;
                            Console.WriteLine("       ");
                            Console.WriteLine("The second innings total is " + secondInningsTotal + " (for the loss of " + battingWicketsLost
                             + " wickets) and so Team " + sidePicked + " won the game.");
                            if (numberOfBalls < 5)
                            {
                                whoopie2 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie2 = 0;
                            }
                            whoopie1 = 0;
                            whoopie3 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                    }

                    else if (battingScore == bowlingScore)
                    {
                        currentBowlerWickets += 1;
                        battingWicketsLost += 1;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = playerTeam[battingWicketsLost - 1];
                        playerBatsmenScores.Add(currentBatsmanScore);
                        playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine("      ");
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sidePicked + " : " + secondInningsTotal + " / " + battingWicketsLost);

                        if (battingWicketsLost < 10)
                        {
                            Console.WriteLine(" Team " + sidePicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");

                        }

                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10 && secondInningsTotal == input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            secondInningsComplete = true;
                            // ties += 1;
                            Console.WriteLine("Its a tie!");
                            if (numberOfBalls < 5)
                            {
                                whoopie2 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie2 = 0;
                            }
                            whoopie1 = 0;
                            whoopie3 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                        if (battingWicketsLost == 10 && secondInningsTotal < input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            secondInningsComplete = true;
                            // team1Wins += 1;
                            Console.WriteLine("Team " + sidePicked + " has only scored " + secondInningsTotal + " and has thus lost " +
                                " the game by " + (input - secondInningsTotal) + " runs.");
                            if (numberOfBalls < 5)
                            {
                                whoopie2 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie2 = 0;
                            }
                            whoopie1 = 0;
                            whoopie3 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }

                    numberOfBalls += 1;

                    if (numberOfBalls == 6)
                    {
                        currentBowlerOvers += 1;
                        numberOfOvers += 1;
                    }
                }

                computerBowler2Runs += currentBowlerRuns;
                computerBowler2Wickets += currentBowlerWickets;
                computerBowler2Overs += currentBowlerOvers;

                if (secondInningsComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + secondInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + computerBowler2Overs + ". Runs: " +
                        computerBowler2Runs + ". Wickets: " + computerBowler2Wickets);
                    Console.WriteLine("         ");
                    string player = playerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("          ");
                    Console.WriteLine(" Team " + sidePicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");
                    Console.WriteLine("-----------");

                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }

                //computer bowler #3

                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;
                currentBowler = computerBowler3;

                //bowl over
                while (numberOfBalls < 6 && secondInningsComplete == false && gameOver == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        secondInningsTotal += battingScore;
                        currentBatsmanScore += battingScore;
                        currentBowlerRuns += battingScore;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = playerTeam[battingWicketsLost];
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : " +
                            battingScore + " runs.");

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();

                        if (secondInningsTotal > input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine("       ");
                            gameOver = true;
                            secondInningsComplete = true;
                            playerNotOut = true;
                            string playerC = playerTeam[battingWicketsLost];
                            playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            playerBatsmenScores.Add(currentBatsmanScore);
                            Console.WriteLine(playerC + " is not out on " + currentBatsmanScore);
                            playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            playerBatsmenScores.Add(currentBatsmanScore);
                            // team2Wins += 1;
                            Console.WriteLine("       ");
                            Console.WriteLine("The second innings total is " + secondInningsTotal + " (for the loss of " + battingWicketsLost
                             + " wickets) and so Team " + sidePicked + " won the game.");
                            if (numberOfBalls < 5)
                            {
                                whoopie3 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie3 = 0;
                            }
                            whoopie2 = 0;
                            whoopie1 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                    }

                    else if (battingScore == bowlingScore)
                    {
                        currentBowlerWickets += 1;
                        battingWicketsLost += 1;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = playerTeam[battingWicketsLost - 1];
                        playerBatsmenScores.Add(currentBatsmanScore);
                        playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine("      ");
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sidePicked + " : " + secondInningsTotal + " / " + battingWicketsLost);

                        if (battingWicketsLost < 10)
                        {
                            Console.WriteLine(" Team " + sidePicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");

                        }

                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10 && secondInningsTotal == input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            secondInningsComplete = true;
                            // ties += 1;
                            Console.WriteLine("Its a tie!");
                            if (numberOfBalls < 5)
                            {
                                whoopie3 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie3 = 0;
                            }
                            whoopie2 = 0;
                            whoopie1 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                        if (battingWicketsLost == 10 && secondInningsTotal < input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            secondInningsComplete = true;
                            // team1Wins += 1;
                            Console.WriteLine("Team " + sidePicked + " has only scored " + secondInningsTotal + " and has thus lost " +
                                " the game by " + (input - secondInningsTotal) + " runs.");
                            if (numberOfBalls < 5)
                            {
                                whoopie3 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie3 = 0;
                            }
                            whoopie2 = 0;
                            whoopie1 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }

                    numberOfBalls += 1;

                    if (numberOfBalls == 6)
                    {
                        currentBowlerOvers += 1;
                        numberOfOvers += 1;
                    }
                }

                computerBowler3Runs += currentBowlerRuns;
                computerBowler3Wickets += currentBowlerWickets;
                computerBowler3Overs += currentBowlerOvers;

                if (secondInningsComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + secondInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + computerBowler3Overs + ". Runs: " +
                        computerBowler3Runs + ". Wickets: " + computerBowler3Wickets);
                    Console.WriteLine("         ");
                    string player = playerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("          ");
                    Console.WriteLine(" Team " + sidePicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");
                    Console.WriteLine("-----------");

                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }

                //computer bowler #4

                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;
                currentBowler = computerBowler4;

                //bowl over
                while (numberOfBalls < 6 && secondInningsComplete == false && gameOver == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        secondInningsTotal += battingScore;
                        currentBatsmanScore += battingScore;
                        currentBowlerRuns += battingScore;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = playerTeam[battingWicketsLost];
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : " +
                            battingScore + " runs.");

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();

                        if (secondInningsTotal > input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine("       ");
                            gameOver = true;
                            secondInningsComplete = true;
                            playerNotOut = true;
                            string playerC = playerTeam[battingWicketsLost];
                            playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            playerBatsmenScores.Add(currentBatsmanScore);
                            Console.WriteLine(playerC + " is not out on " + currentBatsmanScore);
                            playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            playerBatsmenScores.Add(currentBatsmanScore);
                            // team2Wins += 1;
                            Console.WriteLine("       ");
                            Console.WriteLine("The second innings total is " + secondInningsTotal + " (for the loss of " + battingWicketsLost
                             + " wickets) and so Team " + sidePicked + " won the game.");
                            if (numberOfBalls < 5)
                            {
                                whoopie4 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie4 = 0;
                            }
                            whoopie2 = 0;
                            whoopie3 = 0;
                            whoopie1 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                    }

                    else if (battingScore == bowlingScore)
                    {
                        currentBowlerWickets += 1;
                        battingWicketsLost += 1;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = playerTeam[battingWicketsLost - 1];
                        playerBatsmenScores.Add(currentBatsmanScore);
                        playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine("      ");
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sidePicked + " : " + secondInningsTotal + " / " + battingWicketsLost);

                        if (battingWicketsLost < 10)
                        {
                            Console.WriteLine(" Team " + sidePicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");

                        }

                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10 && secondInningsTotal == input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            secondInningsComplete = true;
                            // ties += 1;
                            Console.WriteLine("Its a tie!");
                            if (numberOfBalls < 5)
                            {
                                whoopie4 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie4 = 0;
                            }
                            whoopie2 = 0;
                            whoopie3 = 0;
                            whoopie1 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }
                        if (battingWicketsLost == 10 && secondInningsTotal < input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            secondInningsComplete = true;
                            // team1Wins += 1;
                            Console.WriteLine("Team " + sidePicked + " has only scored " + secondInningsTotal + " and has thus lost " +
                                " the game by " + (input - secondInningsTotal) + " runs.");
                            if (numberOfBalls < 5)
                            {
                                whoopie4 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie4 = 0;
                            }
                            whoopie2 = 0;
                            whoopie3 = 0;
                            whoopie1 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                        }

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }

                    numberOfBalls += 1;

                    if (numberOfBalls == 6)
                    {
                        currentBowlerOvers += 1;
                        numberOfOvers += 1;
                    }
                }

                computerBowler4Runs += currentBowlerRuns;
                computerBowler4Wickets += currentBowlerWickets;
                computerBowler4Overs += currentBowlerOvers;

                if (secondInningsComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + secondInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + computerBowler4Overs + ". Runs: " +
                        computerBowler4Runs + ". Wickets: " + computerBowler4Wickets);
                    Console.WriteLine("         ");
                    string player = playerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("          ");
                    Console.WriteLine(" Team " + sidePicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");
                    Console.WriteLine("-----------");

                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }

            }

            computerBowlerRuns.Add(computerBowler1Runs);
            computerBowlerRuns.Add(computerBowler2Runs);
            computerBowlerRuns.Add(computerBowler3Runs);
            computerBowlerRuns.Add(computerBowler4Runs);

            computerBowlerOvers.Add(computerBowler1Overs);
            computerBowlerOvers.Add(computerBowler2Overs);
            computerBowlerOvers.Add(computerBowler3Overs);
            computerBowlerOvers.Add(computerBowler4Overs);

            computerBowlerWickets.Add(computerBowler1Wickets);
            computerBowlerWickets.Add(computerBowler2Wickets);
            computerBowlerWickets.Add(computerBowler3Wickets);
            computerBowlerWickets.Add(computerBowler4Wickets);

            int sumWhoopie = whoopie1 + whoopie2 + whoopie3 + whoopie4;

            Console.WriteLine("        ");
            Console.WriteLine("Team " + sidePicked + " has scored " + secondInningsTotal + " in " + numberOfOvers +
                "." + sumWhoopie +
                " overs.");

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            //bowler economy rate (not putting bowling strike rate and average here)
            float completeOver = 6f;
            index = 0;

            while (index < 4)
            {
                if (!(computerBowlerOvers[index] + whoopie[index] == 0))
                {
                    float economyRateW = computerBowlerRuns[index] / (computerBowlerOvers[index] + (whoopie[index] / completeOver));
                    economyRate.Add(economyRateW);
                }
                else if (computerBowlerOvers[index] + whoopie[index] == 0)
                {
                    economyRate.Add("Not applicable");
                }
                index += 1;
            }

            Console.WriteLine("        ");
            Console.WriteLine("Batting Scorecard: ");
            Console.WriteLine("        ");

            //batting strike rate
            index = 0;

            while (index < chasingWicketLost)
            {
                if (!(playerBatsmenDeliveriesPlayed[index] == 0))
                {
                    float factor = 100f;
                    float runsMade = playerBatsmenScores[index];
                    float ballsPlayed = playerBatsmenDeliveriesPlayed[index];
                    float battingStrikeRateW = (runsMade / ballsPlayed) * factor;
                    battingStrikeRateC.Add(battingStrikeRateW);
                }
                else if (playerBatsmenDeliveriesPlayed[index] == 0)
                {
                    battingStrikeRateC.Add("N/A");
                }
                index += 1;
            }

            int numberBatsmenPrinted = 0;
            index = 0;

            while (numberBatsmenPrinted < chasingWicketLost)
            {
                Console.WriteLine(playerTeam[index] + " : " + playerBatsmenScores[index] + " (" +
                playerBatsmenDeliveriesPlayed[index] + "). Strike Rate: " +
                battingStrikeRateC[index]);
                index += 1;
                numberBatsmenPrinted += 1;
                if (numberBatsmenPrinted == chasingWicketLost && playerNotOut == true)
                {
                    Console.WriteLine(playerTeam[index] + " : " + playerBatsmenScores[index] + " (" +
                    playerBatsmenDeliveriesPlayed[index] + ") not out.");
                }
            }

            //total and overall runrate

            float ballsOver1 = 6f;

            float overs = numberOfOvers + (sumWhoopie / ballsOver1);

            float runrate = secondInningsTotal / overs;

            Console.WriteLine("    ");

            Console.WriteLine("Innings Total: " + secondInningsTotal + " / " +
                battingWicketsLost + ". Run rate: " + runrate);
            Console.WriteLine("    ");

            int numberBowlersPrinted = 0;
            index = 0;

            Console.WriteLine("        ");

            Console.WriteLine("Bowling Scorecard: ");

            Console.WriteLine("        ");

            while (numberBowlersPrinted < 4)
            {
                Console.WriteLine(computerBowlers[index] + ". Overs:  " + computerBowlerOvers[index]
                    + "." + whoopie[index] + ".  Runs: " +
                    computerBowlerRuns[index] + ". Wickets: " + computerBowlerWickets[index] +
                    ". Economy: " +
                    economyRate[index] + ". " /*Strike Rate: " + strikeRate[index]
                    + ". Average: " + average[index]*/);
                Console.WriteLine("     ");
                index += 1;
                numberBowlersPrinted += 1;
            }

            return secondInningsTotal;
        }
    }
}