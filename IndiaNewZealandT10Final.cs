using System;
using System.Collections.Generic;
using System.Numerics;

namespace All_Star_Cricket_Game_1
{
    class MainClass
    {
        //still need to include possibility of run out; allow 2 batsmen at a time/strik rotation
        //allow player to choose next batter/bowler. Show bowler stats and overs left for them (assuming we're playing limited overs)
        //allow force out option. Remove a batsman and replace them with a new one.

        public static List<string> playerPoolBatsmen = new List<string>();
        public static List<string> playerPoolKeepers = new List<string>();
        public static List<string> playerPoolBowlers = new List<string>();
        public static List<string> playerPoolAllrounders = new List<string>();

        public static List<string> squadAustraliaBatsmen = new List<string>();
        public static List<string> squadAustraliaKeepers = new List<string>();
        public static List<string> squadAustraliaAllRounders = new List<string>();
        public static List<string> squadAustraliaBowlers = new List<string>();

        public static List<string> squadEnglandBatsmen = new List<string>();
        public static List<string> squadEnglandKeepers = new List<string>();
        public static List<string> squadEnglandAllRounders = new List<string>();
        public static List<string> squadEnglandBowlers = new List<string>();

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

        public static int computerBowler5Runs = 0;
        public static int computerBowler5Wickets = 0;
        public static int computerBowler5Overs = 0;

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

        public static int playerBowler5Runs = 0;
        public static int playerBowler5Wickets = 0;
        public static int playerBowler5Overs = 0;

        public static int bowlerNumber;
        public static int bowlerNumber1;
        public static int currentBowlerNumber;
        public static int otherBowlerNumber;

        public static string playerBowler1;
        public static string playerBowler2;
        public static string playerBowler3;
        public static string playerBowler4;
        public static string playerBowler5;

        public static string computerBowler1;
        public static string computerBowler2;
        public static string computerBowler3;
        public static string computerBowler4;
        public static string computerBowler5;

        public static int compBowler1;
        public static int compBowler2;
        public static int compBowler3;
        public static int compBowler4;
        public static int compBowler5;

        public static int playBowler1;
        public static int playBowler2;
        public static int playBowler3;
        public static int playBowler4;
        public static int playBowler5;

        public static List<int> playerBowlerBowledOut = new List<int>();
        public static List<int> computerBowlerBowledOut = new List<int>();

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
            PickAndCreateTeams();
            Toss();
            LetTheGamesBegin();
        }
        public static void PickAndCreateTeams()
        {
            //INDIAN SQUAD
            //India batters
            squadAustraliaBatsmen.Add("Rohit Sharma");
            squadAustraliaBatsmen.Add("Virat Kohli");
            squadAustraliaBatsmen.Add("KL Rahul");
            squadAustraliaBatsmen.Add("Shikar Dhawan");
            squadAustraliaBatsmen.Add("Ajinkya Rahane");
            squadAustraliaBatsmen.Add("Mayank Agrawal");
            squadAustraliaBatsmen.Add("Cheteshwar Pujara");
            squadAustraliaBatsmen.Add("VVS Laxman");
            squadAustraliaBatsmen.Add("Saurav Ganguly");
            squadAustraliaBatsmen.Add("Sachin Tendulkar");
            squadAustraliaBatsmen.Add("Rahul Dravid");

            //Indian keepers
            squadAustraliaKeepers.Add("M.S. Dhoni");
            squadAustraliaKeepers.Add("W. Saha");
            squadAustraliaKeepers.Add("Rishabh Pant");

            //Indian Allrounders
            squadAustraliaAllRounders.Add("Ravindra Jadeja");
            squadAustraliaAllRounders.Add("Irfan Pathan");

            //Indian Bowlers
            squadAustraliaBowlers.Add("Jasprit Bumrah");
            squadAustraliaBowlers.Add("Zaheer Khan");
            squadAustraliaBowlers.Add("Ravichandran Ashwin");
            squadAustraliaBowlers.Add("Anil Kumble");
            squadAustraliaBowlers.Add("Amit Mishra");
            squadAustraliaBowlers.Add("Ishant Sharma");
            squadAustraliaBowlers.Add("Mohammad Shami");
            squadAustraliaBowlers.Add("S. Sreesanth");
            squadAustraliaBowlers.Add("Harbhajan Singh");

            //New Zealand SQUAD
            //Kiwi batters
            squadEnglandBatsmen.Add("Tom Latham");
            squadEnglandBatsmen.Add("Peter Fulton");
            squadEnglandBatsmen.Add("Kane Williamson");
            squadEnglandBatsmen.Add("Ross Taylor");
            squadEnglandBatsmen.Add("Jessie Ryder");
            squadEnglandBatsmen.Add("Martin Crowe");
            squadEnglandBatsmen.Add("Damian Flemming");


            //Kiwi keepers
            squadEnglandKeepers.Add("Brendan McCullum");
            squadEnglandKeepers.Add("B.J. Watling");

            //Kiwi Allrounders
            squadEnglandAllRounders.Add("Colin De Grandhomme");
            squadEnglandAllRounders.Add("Mitchell Santner");
            squadEnglandAllRounders.Add("Daniel Vettori");

            //Kiwi Bowlers
            squadEnglandBowlers.Add("Chris Martin");
            squadEnglandBowlers.Add("Trent Boult");
            squadEnglandBowlers.Add("Tim Southee");
            squadEnglandBowlers.Add("Neil Wagner");
            squadEnglandBowlers.Add("Shane Bond");

            //choosing teams
            Console.WriteLine("Welcome to the survival test between India and New Zealand. It's your team versus the computer's. " +
                "You both will now pick your teams. Choose wisely!");

            Console.WriteLine("------------");

            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("         ");

            Console.WriteLine("------------");

            Console.Write("Team India vs Team New Zealand. Which team would you like to build? Enter 'India' for " +
                "Team India or enter 'New Zealand' for Team New Zealand: ");
            sidePicked = Console.ReadLine();

            bool pickedASide = false;

            while (pickedASide == false)
            {
                if (sidePicked == "New Zealand")
                {
                    //pick player team from sets of England players
                    Console.WriteLine("------------");
                    Console.WriteLine("            ");
                    Console.WriteLine("You have chosen " + sidePicked);
                    Console.WriteLine("            ");
                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();

                    Console.WriteLine("         ");

                    //picking batsmen
                    Console.WriteLine("Your team must contain 5 batsmen." +
                        "You can select them from the following pool of players: ");

                    Console.WriteLine(" ");

                    while (playerTeam.Count < 5)
                    {
                        foreach (string x in squadEnglandBatsmen)
                        {
                            Console.Write(x + ", ");
                        }
                        Console.WriteLine(".");
                        Console.Write("You have " + (5 - playerTeam.Count) + " spots for batsmen left. Pick a batsman. Please enter " +
                            "their name as expressed in the list above: ");
                        playerSelection = Console.ReadLine();

                        bool okToProceed = false;

                        while (okToProceed == false)
                        {
                            int result = squadEnglandBatsmen.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                squadEnglandBatsmen.Remove(playerSelection);

                                okToProceed = true;
                            }
                            else if (result == -1)
                            {
                                Console.WriteLine("       ");
                                Console.Write("Please enter a name from the list: ");
                                playerSelection = Console.ReadLine();
                            }
                            Console.WriteLine("     ");
                        }
                    }

                    Console.WriteLine("-----------");

                    //picking keeper
                    Console.WriteLine("Your team must contain 1 wicket keeper." +
                        "You can select one from the following pool of players: ");

                    Console.WriteLine(" ");

                    while (playerTeam.Count > 4 && playerTeam.Count < 6)
                    {
                        foreach (string x in squadEnglandKeepers)
                        {
                            Console.Write(x + ", ");
                        }
                        Console.WriteLine(".");
                        Console.WriteLine("        ");
                        Console.Write("You have " + (6 - playerTeam.Count) + " spot for a keeper. Pick one. Please enter " +
                            " their name as expressed in the list above: ");
                        playerSelection = Console.ReadLine();

                        bool okToProceed = false;

                        while (okToProceed == false)
                        {
                            int result = squadEnglandKeepers.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                squadEnglandKeepers.Remove(playerSelection);

                                okToProceed = true;
                            }
                            else if (result == -1)
                            {
                                Console.WriteLine("       ");
                                Console.Write("Please enter a name from the list: ");
                                playerSelection = Console.ReadLine();
                            }
                            Console.WriteLine("     ");
                        }
                    }

                    Console.WriteLine("-----------");

                    //picking allrounder
                    Console.WriteLine("Your team must contain 1 allrounder." +
                        "You can select one from the following pool of players: ");

                    Console.WriteLine(" ");

                    while (playerTeam.Count > 5 && playerTeam.Count < 7)
                    {
                        foreach (string x in squadEnglandAllRounders)
                        {
                            Console.Write(x + ", ");
                        }
                        Console.WriteLine(".");
                        Console.WriteLine("          ");
                        Console.Write("You have " + (7 - playerTeam.Count) + " spot for an allrounder. Pick one. Please enter " +
                            " their name as expressed in the list above: ");
                        playerSelection = Console.ReadLine();

                        bool okToProceed = false;

                        while (okToProceed == false)
                        {
                            int result = squadEnglandAllRounders.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                squadEnglandAllRounders.Remove(playerSelection);

                                okToProceed = true;
                            }
                            else if (result == -1)
                            {
                                Console.WriteLine("       ");
                                Console.Write("Please enter a name from the list: ");
                                playerSelection = Console.ReadLine();
                            }
                            Console.WriteLine("     ");
                        }
                    }

                    Console.WriteLine("-----------");

                    //picking bowlers
                    Console.WriteLine("Your team must contain 3 bowlers." +
                        "You can select them from the following pool of players: ");

                    Console.WriteLine(" ");

                    while (playerTeam.Count < 10)
                    {
                        foreach (string x in squadEnglandBowlers)
                        {
                            Console.Write(x + ", ");
                        }
                        Console.WriteLine(".");
                        Console.Write("You have " + (10 - playerTeam.Count) + " spots for bowlers left. Pick a bowler. Please enter " +
                            "their name as expressed in the list above: ");
                        playerSelection = Console.ReadLine();

                        bool okToProceed = false;

                        while (okToProceed == false)
                        {
                            int result = squadEnglandBowlers.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                squadEnglandBowlers.Remove(playerSelection);

                                okToProceed = true;
                            }
                            else if (result == -1)
                            {
                                Console.WriteLine("       ");
                                Console.Write("Please enter a name from the list: ");
                                playerSelection = Console.ReadLine();
                            }
                            Console.WriteLine("     ");
                        }

                        Console.WriteLine(" ");
                    }

                    //computer picks players from sets of Aussie players
                    sideNotPicked = "India";

                    int numberPlayersSelected = 0;

                    //select Aussie batsmen
                    while (computerTeam.Count < 5)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, squadAustraliaBatsmen.Count - 1);
                        playerSelection = squadAustraliaBatsmen[elementW];
                        computerTeam.Add(playerSelection);
                        squadAustraliaBatsmen.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select Aussie keeper
                    numberPlayersSelected = 0;

                    while (computerTeam.Count > 4 && computerTeam.Count < 6)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, squadAustraliaKeepers.Count - 1);
                        playerSelection = squadAustraliaKeepers[elementW];
                        computerTeam.Add(playerSelection);
                        squadAustraliaKeepers.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select Aussie Allrounder
                    numberPlayersSelected = 0;

                    while (computerTeam.Count > 5 && computerTeam.Count < 7)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, squadAustraliaAllRounders.Count - 1);
                        playerSelection = squadAustraliaAllRounders[elementW];
                        computerTeam.Add(playerSelection);
                        squadAustraliaAllRounders.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select Aussie bowlers
                    numberPlayersSelected = 0;

                    while (computerTeam.Count < 10)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, squadAustraliaBowlers.Count - 1);
                        playerSelection = squadAustraliaBowlers[elementW];
                        computerTeam.Add(playerSelection);
                        squadAustraliaBowlers.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    Console.WriteLine("-----------");

                    Console.WriteLine("Your team, team England: ");

                    foreach (string x in playerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine(" ");

                    Console.WriteLine("-----------");
                    Console.WriteLine("Your opposition, team Australia: ");

                    foreach (string x in computerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine("  ");

                    pickedASide = true;

                }

                else if (sidePicked == "India")
                {
                    //pick player team from sets of Aussie players
                    Console.WriteLine("------------");
                    Console.WriteLine("            ");
                    Console.WriteLine("You have chosen " + sidePicked);
                    Console.WriteLine("            ");
                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                    Console.WriteLine("------------");
                    Console.WriteLine("         ");

                    //picking batsmen
                    Console.WriteLine("Your team must contain 5 batsmen." +
                        "You can select them from the following pool of players: ");

                    Console.WriteLine(" ");

                    while (playerTeam.Count < 5)
                    {
                        foreach (string x in squadAustraliaBatsmen)
                        {
                            Console.Write(x + ", ");
                        }
                        Console.WriteLine(".");
                        Console.Write("You have " + (5 - playerTeam.Count) + " spots for batsmen left. Pick a batsman. Please enter " +
                            "their name as expressed in the list above: ");
                        playerSelection = Console.ReadLine();

                        bool okToProceed = false;

                        while (okToProceed == false)
                        {
                            int result = squadAustraliaBatsmen.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                squadAustraliaBatsmen.Remove(playerSelection);

                                okToProceed = true;
                            }
                            else if (result == -1)
                            {
                                Console.WriteLine("       ");
                                Console.Write("Please enter a name from the list: ");
                                playerSelection = Console.ReadLine();
                            }
                            Console.WriteLine("     ");
                        }
                    }

                    Console.WriteLine("-----------");

                    //picking keeper
                    Console.WriteLine("Your team must contain 1 wicket keeper." +
                        "You can select one from the following pool of players: ");

                    Console.WriteLine(" ");

                    while (playerTeam.Count > 4 && playerTeam.Count < 6)
                    {
                        foreach (string x in squadAustraliaKeepers)
                        {
                            Console.Write(x + ", ");
                        }
                        Console.WriteLine(".");
                        Console.WriteLine("        ");
                        Console.Write("You have " + (6 - playerTeam.Count) + " spot for a keeper. Pick one. Please enter " +
                            " their name as expressed in the list above: ");
                        playerSelection = Console.ReadLine();

                        bool okToProceed = false;

                        while (okToProceed == false)
                        {
                            int result = squadAustraliaKeepers.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                squadEnglandKeepers.Remove(playerSelection);

                                okToProceed = true;
                            }
                            else if (result == -1)
                            {
                                Console.WriteLine("       ");
                                Console.Write("Please enter a name from the list: ");
                                playerSelection = Console.ReadLine();
                            }
                            Console.WriteLine("     ");
                        }
                    }

                    Console.WriteLine("-----------");

                    //picking allrounder
                    Console.WriteLine("Your team must contain 1 allrounder." +
                        "You can select one from the following pool of players: ");

                    Console.WriteLine(" ");

                    while (playerTeam.Count > 5 && playerTeam.Count < 7)
                    {
                        foreach (string x in squadAustraliaAllRounders)
                        {
                            Console.Write(x + ", ");
                        }
                        Console.WriteLine(".");
                        Console.WriteLine("          ");
                        Console.Write("You have " + (7 - playerTeam.Count) + " spot for an allrounder. Pick one. Please enter " +
                            " their name as expressed in the list above: ");
                        playerSelection = Console.ReadLine();

                        bool okToProceed = false;

                        while (okToProceed == false)
                        {
                            int result = squadAustraliaAllRounders.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                squadAustraliaAllRounders.Remove(playerSelection);

                                okToProceed = true;
                            }
                            else if (result == -1)
                            {
                                Console.WriteLine("       ");
                                Console.Write("Please enter a name from the list: ");
                                playerSelection = Console.ReadLine();
                            }
                            Console.WriteLine("     ");
                        }
                    }

                    Console.WriteLine("-----------");

                    //picking bowlers
                    Console.WriteLine("Your team must contain 3 bowlers." +
                        "You can select them from the following pool of players: ");

                    Console.WriteLine(" ");

                    while (playerTeam.Count < 10)
                    {
                        foreach (string x in squadAustraliaBowlers)
                        {
                            Console.Write(x + ", ");
                        }
                        Console.WriteLine(".");
                        Console.Write("You have " + (10 - playerTeam.Count) + " spots for bowlers left. Pick a bowler. Please enter " +
                            "their name as expressed in the list above: ");
                        playerSelection = Console.ReadLine();

                        bool okToProceed = false;

                        while (okToProceed == false)
                        {
                            int result = squadAustraliaBowlers.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                squadAustraliaBowlers.Remove(playerSelection);

                                okToProceed = true;
                            }
                            else if (result == -1)
                            {
                                Console.WriteLine("       ");
                                Console.Write("Please enter a name from the list: ");
                                playerSelection = Console.ReadLine();
                            }
                            Console.WriteLine("     ");
                        }

                        Console.WriteLine(" ");
                    }

                    //computer picks players from sets of English players.
                    sideNotPicked = "New Zealand";
                    int numberPlayersSelected = 0;

                    //select English batsmen
                    while (computerTeam.Count < 5)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, squadEnglandBatsmen.Count - 1);
                        playerSelection = squadEnglandBatsmen[elementW];
                        computerTeam.Add(playerSelection);
                        squadEnglandBatsmen.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select English keeper
                    numberPlayersSelected = 0;

                    while (computerTeam.Count > 4 && computerTeam.Count < 6)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, squadEnglandKeepers.Count - 1);
                        playerSelection = squadEnglandKeepers[elementW];
                        computerTeam.Add(playerSelection);
                        squadEnglandKeepers.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select English Allrounder
                    numberPlayersSelected = 0;

                    while (computerTeam.Count > 5 && computerTeam.Count < 7)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, squadEnglandAllRounders.Count - 1);
                        playerSelection = squadEnglandAllRounders[elementW];
                        computerTeam.Add(playerSelection);
                        squadEnglandAllRounders.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select English bowlers
                    numberPlayersSelected = 0;

                    while (computerTeam.Count < 10)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, squadEnglandBowlers.Count - 1);
                        playerSelection = squadEnglandBowlers[elementW];
                        computerTeam.Add(playerSelection);
                        squadEnglandBowlers.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    Console.WriteLine("Your team, team Australia: ");

                    foreach (string x in playerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine("        ");

                    Console.WriteLine("Your opposition, team England: ");


                    foreach (string x in computerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine("        ");

                    pickedASide = true;
                }

                else if (!(sidePicked == "New Zealand") && !(sidePicked == "India"))
                {
                    Console.Write("Please enter the name of the team again--spelled correctly: ");
                    sidePicked = Console.ReadLine();
                    Console.WriteLine("       ");
                }
            }
        }

        public static BigInteger Toss()
        {
            Console.WriteLine("------------");

            Console.WriteLine("Time for the toss. Please enter 'Heads' or 'Tails': ");
            tossOne = Console.ReadLine();

            if (tossOne == "Heads")
            {
                toss1 = 0;
            }
            else if (tossOne == "Tails")
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
                else if (tossPlayerDecision == "Bowl")
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
                //computer bowlers
                int i = 6;
                numberOfCompBowlers = 0;
                while (numberOfCompBowlers < 4)
                {
                    string wicketTaker = computerTeam[i];
                    computerBowlers.Add(wicketTaker);
                    i += 1;
                    numberOfCompBowlers += 1;

                    if (numberOfCompBowlers == 4)
                    {
                        Random r = new Random();
                        int r1 = r.Next(0, 5);
                        string wicketTaker1 = computerTeam[r1];
                        computerBowlers.Add(wicketTaker1);
                    }
                }

                computerBowler1 = computerBowlers[0];
                computerBowler2 = computerBowlers[1];
                computerBowler3 = computerBowlers[2];
                computerBowler4 = computerBowlers[3];
                computerBowler5 = computerBowlers[4];

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
                    if (numberOfPlayerBowlers == 4)
                    {
                        Random r = new Random();
                        int r1 = r.Next(0, 5);
                        string wicketTaker1 = playerTeam[r1];
                        playerBowlers.Add(wicketTaker1);
                    }
                }

                playerBowler1 = playerBowlers[0];
                playerBowler2 = playerBowlers[1];
                playerBowler3 = playerBowlers[2];
                playerBowler4 = playerBowlers[3];
                playerBowler5 = playerBowlers[4];

                SecondInningscomputerTeamBats(firstInningsTotal); */

                //player bowlers
                int i2 = 6;
                numberOfPlayerBowlers = 0;
                while (numberOfPlayerBowlers < 4)
                {
                    string wicketTaker = playerTeam[i2];
                    playerBowlers.Add(wicketTaker);
                    i2 += 1;
                    numberOfPlayerBowlers += 1;
                    if (numberOfPlayerBowlers == 4)
                    {
                        Random r = new Random();
                        int r1 = r.Next(0, 5);
                        string wicketTaker1 = playerTeam[r1];
                        playerBowlers.Add(wicketTaker1);
                    }
                }

                playerBowler1 = playerBowlers[0];
                playerBowler2 = playerBowlers[1];
                playerBowler3 = playerBowlers[2];
                playerBowler4 = playerBowlers[3];
                playerBowler5 = playerBowlers[4];

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
                    if (numberOfCompBowlers == 4)
                    {
                        Random r = new Random();
                        int r1 = r.Next(0, 5);
                        string wicketTaker1 = computerTeam[r1];
                        computerBowlers.Add(wicketTaker1);
                    }
                }

                computerBowler1 = computerBowlers[0];
                computerBowler2 = computerBowlers[1];
                computerBowler3 = computerBowlers[2];
                computerBowler4 = computerBowlers[3];
                computerBowler5 = computerBowlers[4];

                SecondInningsplayerTeamBats(firstInningsTotal);
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
                    if (numberOfPlayerBowlers == 4)
                    {
                        Random r = new Random();
                        int r1 = r.Next(0, 5);
                        string wicketTaker1 = playerTeam[r1];
                        playerBowlers.Add(wicketTaker1);
                    }
                }

                playerBowler1 = playerBowlers[0];
                playerBowler2 = playerBowlers[1];
                playerBowler3 = playerBowlers[2];
                playerBowler4 = playerBowlers[3];
                playerBowler5 = playerBowlers[4];

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
                    if (numberOfCompBowlers == 4)
                    {
                        Random r = new Random();
                        int r1 = r.Next(0, 5);
                        string wicketTaker1 = computerTeam[r1];
                        computerBowlers.Add(wicketTaker1);
                    }
                }

                computerBowler1 = computerBowlers[0];
                computerBowler2 = computerBowlers[1];
                computerBowler3 = computerBowlers[2];
                computerBowler4 = computerBowlers[3];
                computerBowler5 = computerBowlers[4];

                SecondInningsplayerTeamBats(firstInningsTotal);
            }
        }

        //player bats first

        public static int FirstInningsplayerTeamBats()
        {
            int battingWicketsLost = 0;
            firstInningsTotal = 0;
            int currentBatsmanScore = 0;
            bool firstInningsComplete = false;
            playerNotOut = false;
            int numberOfBalls = 0;
            int index = 0;
            numberOfOvers = 0;
            int currentBowlerRuns = 0;
            int currentBowlerWickets = 0;
            int currentBowlerOvers = 0;
            currentBatsmanDeliveriesPlayed = 0;

            int whoopie1 = 0;
            int whoopie2 = 0;
            int whoopie3 = 0;
            int whoopie4 = 0;
            int whoopie5 = 0;

            Random CB1 = new Random();
            compBowler1 = CB1.Next(10, 20);

            Random CB2 = new Random();
            compBowler2 = CB2.Next(7, 20);

            Random CB3 = new Random();
            compBowler3 = CB3.Next(7, 20);

            Random CB4 = new Random();
            compBowler4 = CB4.Next(7, 20);

            Random CB5 = new Random();
            compBowler5 = CB5.Next(14, 20);

            List<int> whoopie = new List<int>();
            List<object> economyRate = new List<object>();
            List<object> strikeRate = new List<object>();
            List<object> average = new List<object>();
            List<object> battingStrikeRate = new List<object>();

            while (firstInningsComplete == false)
            {
                //computer bowler #1

                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;
                currentBowler = computerBowler1;

                //bowl over
                while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == 10))
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, compBowler1);

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
                            whoopie5 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                            whoopie.Add(whoopie5);
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

                computerBowler1Runs += currentBowlerRuns;
                computerBowler1Wickets += currentBowlerWickets;
                computerBowler1Overs += currentBowlerOvers;

                if (firstInningsComplete == false && !(numberOfOvers == 10))
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + computerBowler1Overs + ". Runs: " +
                        computerBowler1Runs + ". Wickets: " + computerBowler1Wickets);
                    Console.WriteLine("           ");
                    //current run rate:
                    float firstInningsTotalSoFar1 = firstInningsTotal;
                    float oversSoFar = numberOfOvers;
                    float currentRunRate = firstInningsTotal / oversSoFar;
                    Console.WriteLine("Current run-rate: " + currentRunRate);
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
                while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == 10))
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, compBowler2);

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
                            whoopie5 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                            whoopie.Add(whoopie5);
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

                if (firstInningsComplete == false && !(numberOfOvers == 10))
                {

                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine(currentBowler + ". Overs: " + computerBowler2Overs + ". Runs: " +
                        computerBowler2Runs + ". Wickets: " + computerBowler2Wickets);
                    Console.WriteLine("         ");
                    //current run rate:
                    float firstInningsTotalSoFar1 = firstInningsTotal;
                    float oversSoFar = numberOfOvers;
                    float currentRunRate = firstInningsTotal / oversSoFar;
                    Console.WriteLine("Current run-rate: " + currentRunRate);
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
                while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == 10))
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, compBowler3);

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
                            whoopie5 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                            whoopie.Add(whoopie5);
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

                if (firstInningsComplete == false && !(numberOfOvers == 10))
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine(currentBowler + ". Overs: " + computerBowler3Overs + ". Runs: " +
                        computerBowler3Runs + ". Wickets: " + computerBowler3Wickets);
                    Console.WriteLine("         ");
                    //current run rate:
                    float firstInningsTotalSoFar1 = firstInningsTotal;
                    float oversSoFar = numberOfOvers;
                    float currentRunRate = firstInningsTotal / oversSoFar;
                    Console.WriteLine("Current run-rate: " + currentRunRate);
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
                while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == 10))
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, compBowler4);

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
                            whoopie5 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                            whoopie.Add(whoopie5);
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

                if (firstInningsComplete == false && !(numberOfOvers == 10))
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine(currentBowler + ". Overs: " + computerBowler4Overs + ". Runs: " +
                        computerBowler4Runs + ". Wickets: " + computerBowler4Wickets);
                    Console.WriteLine("         ");
                    //current run rate:
                    float firstInningsTotalSoFar1 = firstInningsTotal;
                    float oversSoFar = numberOfOvers;
                    float currentRunRate = firstInningsTotal / oversSoFar;
                    Console.WriteLine("Current run-rate: " + currentRunRate);
                    Console.WriteLine("         ");
                    string player = playerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("-----------");

                    Console.WriteLine("        ");
                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }

                //computer bowler #5

                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;
                currentBowler = computerBowler5;

                //bowl over
                while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == 10))
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, compBowler5);

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
                            if (numberOfBalls < 5)
                            {
                                whoopie5 = numberOfBalls + 1;
                            }
                            else if (numberOfBalls == 5)
                            {
                                whoopie5 = 0;
                            }
                            whoopie1 = 0;
                            whoopie2 = 0;
                            whoopie3 = 0;
                            whoopie4 = 0;
                            whoopie.Add(whoopie1);
                            whoopie.Add(whoopie2);
                            whoopie.Add(whoopie3);
                            whoopie.Add(whoopie4);
                            whoopie.Add(whoopie5);
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

                computerBowler5Runs += currentBowlerRuns;
                computerBowler5Wickets += currentBowlerWickets;
                computerBowler5Overs += currentBowlerOvers;

                if (numberOfOvers == 10)
                {
                    firstInningsComplete = true;
                }

                if (firstInningsComplete == false && numberOfOvers < 11)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine(currentBowler + ". Overs: " + computerBowler5Overs + ". Runs: " +
                        computerBowler5Runs + ". Wickets: " + computerBowler5Wickets);
                    Console.WriteLine("         ");
                    //current run rate:
                    float firstInningsTotalSoFar1 = firstInningsTotal;
                    float oversSoFar = numberOfOvers;
                    float currentRunRate = firstInningsTotal / oversSoFar;
                    Console.WriteLine("Current run-rate: " + currentRunRate);
                    Console.WriteLine("         ");
                    string player = playerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("-----------");

                    Console.WriteLine("        ");
                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }

                if (numberOfOvers == 10 && battingWicketsLost < 10)
                {
                    playerBatsmenScores.Add(currentBatsmanScore);
                    playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                    firstInningsComplete = true;
                    playerNotOut = true;
                    Console.WriteLine("HELLO1");
                }
            }

            computerBowlerRuns.Add(computerBowler1Runs);
            computerBowlerRuns.Add(computerBowler2Runs);
            computerBowlerRuns.Add(computerBowler3Runs);
            computerBowlerRuns.Add(computerBowler4Runs);
            computerBowlerRuns.Add(computerBowler5Runs);

            computerBowlerOvers.Add(computerBowler1Overs);
            computerBowlerOvers.Add(computerBowler2Overs);
            computerBowlerOvers.Add(computerBowler3Overs);
            computerBowlerOvers.Add(computerBowler4Overs);
            computerBowlerOvers.Add(computerBowler5Overs);

            computerBowlerWickets.Add(computerBowler1Wickets);
            computerBowlerWickets.Add(computerBowler2Wickets);
            computerBowlerWickets.Add(computerBowler3Wickets);
            computerBowlerWickets.Add(computerBowler4Wickets);
            computerBowlerWickets.Add(computerBowler5Wickets);

            whoopie.Add(whoopie1);
            whoopie.Add(whoopie2);
            whoopie.Add(whoopie3);
            whoopie.Add(whoopie4);
            whoopie.Add(whoopie5);

            if(battingWicketsLost < 10)
            {
                playerNotOut = true;
            }

            int sumWhoopie = whoopie1 + whoopie2 + whoopie3 + whoopie4 + whoopie5;

            Console.WriteLine("        ");
            Console.WriteLine("Team " + sidePicked + " has scored " + firstInningsTotal + " in " + numberOfOvers +
               "." + sumWhoopie + " overs.");

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();
            Console.WriteLine("        ");

            //batting strike rate
            index = 0;

            while (index < battingWicketsLost)
            {
                if (!(playerBatsmenDeliveriesPlayed[index] == 0))
                {
                    float factor = 100f;
                    float runsMade = playerBatsmenScores[index];
                    float ballsPlayed = playerBatsmenDeliveriesPlayed[index];
                    float battingStrikeRateW = (runsMade / ballsPlayed) * factor;
                    battingStrikeRate.Add(battingStrikeRateW);
                }
                else if (playerBatsmenDeliveriesPlayed[index] == 0)
                {
                    battingStrikeRate.Add("N/A");
                }
                index += 1;
                if (index == battingWicketsLost && playerNotOut == true)
                {
                    float factor = 100f;
                    float runsMade = playerBatsmenScores[index];
                    float ballsPlayed = playerBatsmenDeliveriesPlayed[index];
                    float battingStrikeRateW = (runsMade / ballsPlayed) * factor;
                    battingStrikeRate.Add(battingStrikeRateW);
                }
            }

            //run rate
            float ballsOver = 6f;

            float numberOfBalls1 = numberOfOvers + (sumWhoopie / ballsOver);

            float runrate = firstInningsTotal / numberOfBalls1;

            int numberBatsmenPrinted = 0;
            index = 0;

            //print batsmen

            Console.WriteLine("Batting Scorecard: ");

            while (numberBatsmenPrinted < battingWicketsLost)
            {
                Console.WriteLine(playerTeam[index] + " : " + playerBatsmenScores[index] + " (" +
                    playerBatsmenDeliveriesPlayed[index] + ") . Strike Rate: " +
                    battingStrikeRate[index]);
                index += 1;
                numberBatsmenPrinted += 1;
                if (index == battingWicketsLost && playerNotOut == true)
                {
                    Console.WriteLine(playerTeam[index] + " (not out) : " + playerBatsmenScores[index] + " (" +
                    playerBatsmenDeliveriesPlayed[index] + ") . Strike Rate: " +
                    battingStrikeRate[index]);
                }
            }

            Console.WriteLine("        ");

            //print runrate and total:

            Console.WriteLine("Innings Total: " + firstInningsTotal + " / " +
                battingWicketsLost + ". Run rate: " + runrate);
            Console.WriteLine("     ");

            //bowling economy
            float completeOver = 6f;
            index = 0;

            while (index < 5)
            {
                if (!(computerBowlerOvers[index] + whoopie[index] == 0))
                {
                    float economyRateW = computerBowlerRuns[index] / (computerBowlerOvers[index] + (whoopie[index] / completeOver));
                    economyRate.Add(economyRateW);
                }
                else if (computerBowlerOvers[index] + whoopie[index] == 0)
                {
                    economyRate.Add("--");
                }
                index += 1;
            }

            //strike rate
            index = 0;

            while (index < 5)
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

            while (index < 5)
            {
                if (!(computerBowlerWickets[index] == 0))
                {
                    float runsGiven = computerBowlerRuns[index];
                    float wicketsTaken = computerBowlerWickets[index];
                    float averageW = runsGiven / wicketsTaken;
                    average.Add(averageW);
                }
                else if (computerBowlerWickets[index] == 0)
                {
                    average.Add("--");
                }
                index += 1;
            }

            Console.WriteLine("Final Bowling Scorecard:");
            Console.WriteLine("        ");

            int numberBowlersPrinted = 0;
            index = 0;

            while (numberBowlersPrinted < 5)
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

            Console.WriteLine("HELLO22");
            return firstInningsTotal;

        }

        public static int SecondInningscomputerTeamBats(int input)
        {
            Console.WriteLine("       ");
            Console.WriteLine(sideNotPicked + " needs " + (input + 1) + " runs to win from " +
            (10 * 6) + " balls.");
            Console.WriteLine("       ");

            int battingWicketsLost = 0;
            int secondInningsTotal = 0;
            int currentBatsmanScore = 0;
            int currentBatsmanDeliveriesPlayed = 0;
            secondInningsComplete = false;
            gameOver = false;
            playerNotOut = false;

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
            int whoopie5 = 0;

            Random PB1 = new Random();
            playBowler1 = PB1.Next(10, 20);

            Random PB2 = new Random();
            playBowler2 = PB2.Next(7, 20);

            Random PB3 = new Random();
            playBowler3 = PB3.Next(7, 20);

            Random PB4 = new Random();
            playBowler4 = PB4.Next(7, 20);

            Random PB5 = new Random();
            playBowler5 = PB5.Next(14, 20);

            List<int> whoopie = new List<int>();
            List<object> economyRate = new List<object>();
            List<object> strikeRate = new List<object>();
            List<object> average = new List<object>();
            List<object> battingStrikeRateC = new List<object>();

            Console.WriteLine("You to defend " + input + " runs in 10 overs. You have 5 bowlers at" +
                " your disposal. Each can bowl at most 2 overs. No bowler can bowl back-to-back overs. ");


            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();
            Console.WriteLine("        ");

            bool gameHasBegun = false;
            bool choseBowler1 = false;

            //working on this still. Almost done:
            //need to ensure that, if you're down to 2 bowlers, you only get to pick the one with less overs
            while (secondInningsComplete == false && gameOver == false)
            {
                //list each bowlers stats. overs, wickets, etc.
                Console.WriteLine("Bowling Scorecard: ");
                Console.WriteLine("       ");
                Console.WriteLine("Bowler number: " + 1 + ". Bowler: " + playerBowler1 + ". Overs: " +
                    playerBowler1Overs + ". Runs: " + playerBowler1Runs + ". Wickets: " +
                    playerBowler1Wickets /* + ". Economy: " + (playerBowler1Runs / playerBowler1Overs)*/);
                Console.WriteLine("Bowler number: " + 2 + ". Bowler: " + playerBowler2 + ". Overs: " +
                    playerBowler2Overs + ". Runs: " + playerBowler2Runs + ". Wickets: " +
                    playerBowler2Wickets /*+ ". Economy: " + (playerBowler2Runs / playerBowler2Overs)*/);
                Console.WriteLine("Bowler number: " + 3 + ". Bowler: " + playerBowler3 + ". Overs: " +
                    playerBowler3Overs + ". Runs: " + playerBowler3Runs + ". Wickets: " +
                    playerBowler3Wickets /*+ ". Economy: " + (playerBowler3Runs / playerBowler3Overs)*/);
                Console.WriteLine("Bowler number: " + 4 + ". Bowler: " + playerBowler4 + ". Overs: " +
                    playerBowler4Overs + ". Runs: " + playerBowler4Runs + ". Wickets: " +
                    playerBowler4Wickets /*+ ". Economy: " + (playerBowler4Runs / playerBowler4Overs)*/);
                Console.WriteLine("Bowler number: " + 5 + ". Bowler: " + playerBowler5 + ". Overs: " +
                    playerBowler5Overs + ". Runs: " + playerBowler5Runs + ". Wickets: " +
                    playerBowler5Wickets /*+ ". Economy: " + (playerBowler5Runs / playerBowler5Overs)*/);

                choseBowler1 = false;

                while (choseBowler1 == false)
                {
                    //have to make sure input is an integer
                    //indicate which bowlers are bowled out so the player doesn't pick them.
                    if (!(playerBowlerBowledOut.Count == 0))
                    {
                        Console.WriteLine("    ");
                        Console.Write(" Bowlers who have bowled out are those with bowler numbers: ");
                        foreach (int x in playerBowlerBowledOut)
                        {
                            Console.Write(" " + x + ",");
                        }
                        Console.WriteLine("  ");
                    }
                    else if (playerBowlerBowledOut.Count == 0)
                    {
                        Console.WriteLine("None of the bowlers have been bowled out yet. ");
                    }

                    bool yesFinally = false;

                    while(yesFinally == false)
                    {
                        Console.Write("To choose a bowler, simply enter their bowler number. Choose your bowler " + ": ");
                        string number = Console.ReadLine();
                        int i;
                        bool success = int.TryParse(number, out i);

                        if (success == true)
                        {
                            bowlerNumber = Convert.ToInt32(number);
                            yesFinally = true;
                            Console.WriteLine("     ");
                        }
                        else if (success == false)
                        {
                            Console.WriteLine("You did not enter a number. Please try again.");
                        }
                    }
                    

                    if ((bowlerNumber == 1 || bowlerNumber == 2 || bowlerNumber == 3 ||
                        bowlerNumber == 4 || bowlerNumber == 5) && playerBowlerBowledOut.Contains(bowlerNumber)
                        == false && !(currentBowlerNumber == bowlerNumber))
                    {
                        Console.WriteLine("HELLO23");
                        choseBowler1 = true;
                    }

                    if (playerBowlerBowledOut.Count == 3)
                    {
                        //one of the remaining 2 bowlers
                        if (playerBowlerBowledOut.Contains(bowlerNumber) == false)
                        {
                            bool foundTheOtherOne = false;
                            //find the other bowler who isn't bowled out.
                            while (foundTheOtherOne == false)
                            {
                                Random r3 = new Random();
                                int tryThisOne = r3.Next(1, 6);
                                if (!(tryThisOne == bowlerNumber) && playerBowlerBowledOut.Contains(tryThisOne) == false)
                                {
                                    foundTheOtherOne = true;
                                    otherBowlerNumber = tryThisOne;
                                }
                            }

                            if (bowlerNumber == 1 && otherBowlerNumber == 2)
                            {
                                if (playerBowler1Overs > playerBowler2Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 1 && otherBowlerNumber == 3)
                            {
                                if (playerBowler1Overs > playerBowler3Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 1 && otherBowlerNumber == 4)
                            {
                                if (playerBowler1Overs > playerBowler4Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 1 && otherBowlerNumber == 5)
                            {
                                if (playerBowler1Overs > playerBowler5Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }

                            if (bowlerNumber == 2 && otherBowlerNumber == 1)
                            {
                                if (playerBowler2Overs > playerBowler1Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 2 && otherBowlerNumber == 3)
                            {
                                if (playerBowler2Overs > playerBowler3Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 2 && otherBowlerNumber == 4)
                            {
                                if (playerBowler2Overs > playerBowler4Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 2 && otherBowlerNumber == 5)
                            {
                                if (playerBowler2Overs > playerBowler5Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }

                            if (bowlerNumber == 3 && otherBowlerNumber == 1)
                            {
                                if (playerBowler3Overs > playerBowler1Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 3 && otherBowlerNumber == 2)
                            {
                                if (playerBowler3Overs > playerBowler2Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 3 && otherBowlerNumber == 4)
                            {
                                if (playerBowler3Overs > playerBowler4Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 3 && otherBowlerNumber == 5)
                            {
                                if (playerBowler3Overs > playerBowler5Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }

                            if (bowlerNumber == 4 && otherBowlerNumber == 1)
                            {
                                if (playerBowler4Overs > playerBowler1Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 4 && otherBowlerNumber == 2)
                            {
                                if (playerBowler4Overs > playerBowler2Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 4 && otherBowlerNumber == 3)
                            {
                                if (playerBowler4Overs > playerBowler3Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 4 && otherBowlerNumber == 5)
                            {
                                if (playerBowler4Overs > playerBowler5Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }

                            if (bowlerNumber == 5 && otherBowlerNumber == 1)
                            {
                                if (playerBowler5Overs > playerBowler1Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 5 && otherBowlerNumber == 2)
                            {
                                if (playerBowler5Overs > playerBowler2Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 5 && otherBowlerNumber == 3)
                            {
                                if (playerBowler5Overs > playerBowler3Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 5 && otherBowlerNumber == 4)
                            {
                                if (playerBowler5Overs > playerBowler4Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                        }
                    }

                    else
                    {
                        if (!(bowlerNumber == 1 || bowlerNumber == 2 || bowlerNumber == 3 ||
                        bowlerNumber == 4 || bowlerNumber == 5))
                        {
                            Console.WriteLine("Please enter a valid bowler number as written in the" +
                                " bowling score card");
                            Console.WriteLine("        ");
                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                            Console.WriteLine("        ");
                        }
                        if (playerBowlerBowledOut.Contains(bowlerNumber) == true)
                        {
                            Console.WriteLine("That bowler is bowled out. Please enter a different one.");
                            Console.WriteLine("        ");
                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                            Console.WriteLine("        ");
                        }
                        if (currentBowlerNumber == bowlerNumber)
                        {
                            Console.WriteLine("A bowler cannot bowl back-to-back overs. Please enter" +
                                " a different one from the set of available ones.");
                            Console.WriteLine("        ");
                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                            Console.WriteLine("        ");
                        }
                    }

                }

                if (gameHasBegun == false)
                {
                    Console.WriteLine("HELLO24");
                    string proposedBowler = playerBowlers[bowlerNumber - 1];

                    //by now, we are assuming the proposed bowler has not bowled the previous over.
                    if (bowlerNumber == 1 && playerBowler1Overs < 2)
                    {
                        // player bowler1 bowls
                        //player bowler #1

                        currentBowlerRuns = 0;
                        currentBowlerWickets = 0;
                        currentBowlerOvers = 0;
                        numberOfBalls = 0;
                        currentBowler = playerBowler1;
                        currentBowlerNumber = 1;

                        //bowl over
                        while (numberOfBalls < 6 && secondInningsComplete == false && gameOver == false && !(numberOfOvers == 10))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            Random rbowlingScore = new Random();
                            int bowlingScore = rbowlingScore.Next(0, playBowler1);

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
                                    playerNotOut = true;
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
                                    playerNotOut = true;
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

                        if (secondInningsComplete == false && !(numberOfOvers == 10))
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
                                     " runs to win from " + (60 - (numberOfOvers * 6)) + " balls.");
                            Console.WriteLine("          ");
                            //current run rate:
                            float secondInningsTotalSoFar1 = secondInningsTotal;
                            float oversSoFar = numberOfOvers;
                            float currentRunRate = secondInningsTotal / oversSoFar;
                            Console.WriteLine("Current run-rate: " + currentRunRate);
                            Console.WriteLine("         ");
                            //required run rate:
                            float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                            float OversToGo = 10 - numberOfOvers;
                            float requiredRunRate = runsToGo / OversToGo;
                            Console.WriteLine("Required run-rate: " + requiredRunRate);
                            Console.WriteLine("-----------");

                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                        }

                        if (playerBowler1Overs == 2)
                        {
                            playerBowlerBowledOut.Add(1);
                        }
                    }

                    else if (bowlerNumber == 2 && playerBowler2Overs < 2)
                    {
                        // player bowler2 bowls
                        //player bowler #2

                        currentBowlerRuns = 0;
                        currentBowlerWickets = 0;
                        currentBowlerOvers = 0;
                        numberOfBalls = 0;
                        currentBowler = playerBowler2;
                        currentBowlerNumber = 2;

                        //bowl over
                        while (numberOfBalls < 6 && secondInningsComplete == false && gameOver == false && !(numberOfOvers == 10))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            Random rbowlingScore = new Random();
                            int bowlingScore = rbowlingScore.Next(0, playBowler2);

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
                                    playerNotOut = true;
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
                                    playerNotOut = true;
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

                        if (secondInningsComplete == false && !(numberOfOvers == 10))
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
                                     " runs to win from " + (60 - (numberOfOvers * 6)) + " balls.");
                            Console.WriteLine("          ");
                            //current run rate:
                            float secondInningsTotalSoFar1 = secondInningsTotal;
                            float oversSoFar = numberOfOvers;
                            float currentRunRate = secondInningsTotal / oversSoFar;
                            Console.WriteLine("Current run-rate: " + currentRunRate);
                            Console.WriteLine("         ");
                            //required run rate:
                            float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                            float OversToGo = 10 - numberOfOvers;
                            float requiredRunRate = runsToGo / OversToGo;
                            Console.WriteLine("Required run-rate: " + requiredRunRate);
                            Console.WriteLine("-----------");


                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                        }

                        if (playerBowler2Overs == 2)
                        {
                            playerBowlerBowledOut.Add(2);
                        }
                    }

                    else if (bowlerNumber == 3 && playerBowler3Overs < 2)
                    {
                        // player bowler3 bowls
                        //player bowler #3

                        currentBowlerRuns = 0;
                        currentBowlerWickets = 0;
                        currentBowlerOvers = 0;
                        numberOfBalls = 0;
                        currentBowler = playerBowler3;
                        currentBowlerNumber = 3;

                        //bowl over
                        while (numberOfBalls < 6 && secondInningsComplete == false && gameOver == false && !(numberOfOvers == 10))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            Random rbowlingScore = new Random();
                            int bowlingScore = rbowlingScore.Next(0, playBowler3);

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
                                    playerNotOut = true;
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
                                    playerNotOut = true;
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

                        if (secondInningsComplete == false && !(numberOfOvers == 10))
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
                                     " runs to win from " + (60 - (numberOfOvers * 6)) + " balls.");
                            Console.WriteLine("          ");
                            //current run rate:
                            float secondInningsTotalSoFar1 = secondInningsTotal;
                            float oversSoFar = numberOfOvers;
                            float currentRunRate = secondInningsTotal / oversSoFar;
                            Console.WriteLine("Current run-rate: " + currentRunRate);
                            Console.WriteLine("         ");
                            //required run rate:
                            float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                            float OversToGo = 10 - numberOfOvers;
                            float requiredRunRate = runsToGo / OversToGo;
                            Console.WriteLine("Required run-rate: " + requiredRunRate);
                            Console.WriteLine("-----------");

                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                        }

                        if (playerBowler3Overs == 2)
                        {
                            playerBowlerBowledOut.Add(3);
                        }
                    }

                    else if (bowlerNumber == 4 && playerBowler4Overs < 2)
                    {
                        // player bowler4 bowls
                        //player bowler #4

                        currentBowlerRuns = 0;
                        currentBowlerWickets = 0;
                        currentBowlerOvers = 0;
                        numberOfBalls = 0;
                        currentBowler = playerBowler4;
                        currentBowlerNumber = 4;

                        //bowl over
                        while (numberOfBalls < 6 && secondInningsComplete == false && gameOver == false && !(numberOfOvers == 10))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            Random rbowlingScore = new Random();
                            int bowlingScore = rbowlingScore.Next(0, playBowler4);

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
                                    playerNotOut = true;
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
                                    playerNotOut = true;
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

                        if (secondInningsComplete == false && !(numberOfOvers == 10))
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
                                     " runs to win from " + (60 - (numberOfOvers * 6)) + " balls.");
                            Console.WriteLine("          ");
                            //current run rate:
                            float secondInningsTotalSoFar1 = secondInningsTotal;
                            float oversSoFar = numberOfOvers;
                            float currentRunRate = secondInningsTotal / oversSoFar;
                            Console.WriteLine("Current run-rate: " + currentRunRate);
                            Console.WriteLine("         ");
                            //required run rate:
                            float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                            float OversToGo = 10 - numberOfOvers;
                            float requiredRunRate = runsToGo / OversToGo;
                            Console.WriteLine("Required run-rate: " + requiredRunRate);
                            Console.WriteLine("-----------");

                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                        }

                        if (playerBowler4Overs == 2)
                        {
                            playerBowlerBowledOut.Add(4);
                        }
                    }

                    else if (bowlerNumber == 5 && playerBowler5Overs < 2)
                    {
                        // player bowler5 bowls
                        //player bowler #5

                        currentBowlerRuns = 0;
                        currentBowlerWickets = 0;
                        currentBowlerOvers = 0;
                        numberOfBalls = 0;
                        currentBowler = playerBowler5;
                        currentBowlerNumber = 5;

                        //bowl over
                        while ((numberOfBalls < 6 && secondInningsComplete == false && gameOver == false) && !(numberOfOvers == 10))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            Random rbowlingScore = new Random();
                            int bowlingScore = rbowlingScore.Next(0, playBowler5);

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
                                        whoopie5 = numberOfBalls + 1;
                                    }
                                    else if (numberOfBalls == 5)
                                    {
                                        whoopie5 = 0;
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
                                    playerNotOut = true;
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
                                    playerNotOut = true;
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

                        playerBowler5Runs += currentBowlerRuns;
                        playerBowler5Wickets += currentBowlerWickets;
                        playerBowler5Overs += currentBowlerOvers;

                        if (secondInningsComplete == false && !(numberOfOvers == 10))
                        {
                            Console.WriteLine("-----------");
                            Console.WriteLine(" Team " + sideNotPicked + " : " + secondInningsTotal + " / " + battingWicketsLost + " in "
                                + numberOfOvers + " overs");
                            Console.WriteLine("         ");
                            Console.WriteLine(currentBowler + ". Overs: " + playerBowler5Overs + ". Runs: " +
                                playerBowler5Runs + ". Wickets: " + playerBowler5Wickets);
                            Console.WriteLine("         ");
                            string player = computerTeam[battingWicketsLost];
                            Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                                currentBatsmanDeliveriesPlayed + ") ");
                            Console.WriteLine("          ");
                            Console.WriteLine(" Team " + sideNotPicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                                     " runs to win from " + (60 - (numberOfOvers * 6)) + " balls.");
                            Console.WriteLine("          ");
                            //current run rate:
                            float secondInningsTotalSoFar1 = secondInningsTotal;
                            float oversSoFar = numberOfOvers;
                            float currentRunRate = secondInningsTotal / oversSoFar;
                            Console.WriteLine("Current run-rate: " + currentRunRate);
                            Console.WriteLine("         ");
                            //required run rate:
                            float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                            float OversToGo = 10 - numberOfOvers;
                            float requiredRunRate = runsToGo / OversToGo;
                            Console.WriteLine("Required run-rate: " + requiredRunRate);
                            Console.WriteLine("-----------");

                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                        }

                        if (playerBowler5Overs == 2)
                        {
                            playerBowlerBowledOut.Add(5);
                        }
                    }

                    if (numberOfOvers == 10)
                    {
                        secondInningsComplete = true;
                        gameOver = true;
                        computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        computerBatsmenScores.Add(currentBatsmanScore);
                    }
                }

                if (secondInningsTotal > input)
                {
                    secondInningsComplete = true;
                    gameOver = true;
                }
            }

            playerBowlerRuns.Add(playerBowler1Runs);
            playerBowlerRuns.Add(playerBowler2Runs);
            playerBowlerRuns.Add(playerBowler3Runs);
            playerBowlerRuns.Add(playerBowler4Runs);
            playerBowlerRuns.Add(playerBowler5Runs);

            playerBowlerOvers.Add(playerBowler1Overs);
            playerBowlerOvers.Add(playerBowler2Overs);
            playerBowlerOvers.Add(playerBowler3Overs);
            playerBowlerOvers.Add(playerBowler4Overs);
            playerBowlerOvers.Add(playerBowler5Overs);

            playerBowlerWickets.Add(playerBowler1Wickets);
            playerBowlerWickets.Add(playerBowler2Wickets);
            playerBowlerWickets.Add(playerBowler3Wickets);
            playerBowlerWickets.Add(playerBowler4Wickets);
            playerBowlerWickets.Add(playerBowler5Wickets);

            if (battingWicketsLost < 10 && secondInningsTotal <= input)
            {
                whoopie1 = 0;
                whoopie2 = 0;
                whoopie3 = 0;
                whoopie4 = 0;
                whoopie5 = 0;
                whoopie.Add(whoopie1);
                whoopie.Add(whoopie2);
                whoopie.Add(whoopie3);
                whoopie.Add(whoopie4);
                whoopie.Add(whoopie5);
                playerNotOut = true;
            }

            int sumWhoopie = whoopie1 + whoopie2 + whoopie3 + whoopie4 + whoopie5;

            Console.WriteLine("        ");
            Console.WriteLine("Team " + sideNotPicked + " has scored " + secondInningsTotal + " in " + numberOfOvers +
                "." + sumWhoopie +
                " overs.");

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            if (secondInningsTotal < input)
            {
                Console.WriteLine("Your team has won the game by " + (input - secondInningsTotal) +
                    " runs.");
            }
            else if (secondInningsTotal > input)
            {
                Console.WriteLine("You've lost.");
                Console.WriteLine(sideNotPicked + " has won by " + battingWicketsLost + " wickets.");
            }
            else if (secondInningsTotal == input)
            {
                Console.WriteLine("It's a tie!");
            }

            //bowler economy rate
            float completeOver = 6f;
            index = 0;

            while (index < 5)
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

            while (index < 5)
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

            while (index < 5)
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
                    Console.WriteLine("HELLO26");
                    Console.WriteLine(computerTeam[index] + " : " + computerBatsmenScores[index] + " (" +
                    computerBatsmenDeliveriesPlayed[index] + ") not out.");
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

            Console.WriteLine("Final Bowling Scorecard: ");

            Console.WriteLine("        ");

            while (numberBowlersPrinted < 5)
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

        /***************************************************************/

        //computer bats first

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
            currentBatsmanDeliveriesPlayed = 0;

            int whoopie1 = 0;
            int whoopie2 = 0;
            int whoopie3 = 0;
            int whoopie4 = 0;
            int whoopie5 = 0;

            Random PB1 = new Random();
            playBowler1 = PB1.Next(10, 20);

            Random PB2 = new Random();
            playBowler2 = PB2.Next(7, 20);

            Random PB3 = new Random();
            playBowler3 = PB3.Next(7, 20);

            Random PB4 = new Random();
            playBowler4 = PB4.Next(7, 20);

            Random PB5 = new Random();
            playBowler5 = PB5.Next(14, 20);

            List<int> whoopie = new List<int>();
            List<object> economyRate = new List<object>();
            List<object> strikeRate = new List<object>();
            List<object> average = new List<object>();
            List<object> battingStrikeRate = new List<object>();

            bool gameHasBegun = false;
            bool choseBowler1 = false;

            //working on this still. Almost done:
            //need to ensure that, if you're down to 2 bowlers, you only get to pick the one with less overs
            while (firstInningsComplete == false)
            {
                //list each bowlers stats. overs, wickets, etc.
                Console.WriteLine("Bowling Scorecard: ");
                Console.WriteLine("       ");
                Console.WriteLine("Bowler number: " + 1 + ". Bowler: " + playerBowler1 + ". Overs: " +
                    playerBowler1Overs + ". Runs: " + playerBowler1Runs + ". Wickets: " +
                    playerBowler1Wickets /* + ". Economy: " + (playerBowler1Runs / playerBowler1Overs)*/);
                Console.WriteLine("Bowler number: " + 2 + ". Bowler: " + playerBowler2 + ". Overs: " +
                    playerBowler2Overs + ". Runs: " + playerBowler2Runs + ". Wickets: " +
                    playerBowler2Wickets /*+ ". Economy: " + (playerBowler2Runs / playerBowler2Overs)*/);
                Console.WriteLine("Bowler number: " + 3 + ". Bowler: " + playerBowler3 + ". Overs: " +
                    playerBowler3Overs + ". Runs: " + playerBowler3Runs + ". Wickets: " +
                    playerBowler3Wickets /*+ ". Economy: " + (playerBowler3Runs / playerBowler3Overs)*/);
                Console.WriteLine("Bowler number: " + 4 + ". Bowler: " + playerBowler4 + ". Overs: " +
                    playerBowler4Overs + ". Runs: " + playerBowler4Runs + ". Wickets: " +
                    playerBowler4Wickets /*+ ". Economy: " + (playerBowler4Runs / playerBowler4Overs)*/);
                Console.WriteLine("Bowler number: " + 5 + ". Bowler: " + playerBowler5 + ". Overs: " +
                    playerBowler5Overs + ". Runs: " + playerBowler5Runs + ". Wickets: " +
                    playerBowler5Wickets /*+ ". Economy: " + (playerBowler5Runs / playerBowler5Overs)*/);

                choseBowler1 = false;

                while (choseBowler1 == false)
                {
                    //have to make sure input is an integer
                    //indicate which bowlers are bowled out so the player doesn't pick them.
                    if (!(playerBowlerBowledOut.Count == 0))
                    {
                        Console.WriteLine("    ");
                        Console.Write(" Bowlers who have bowled out are those with bowler numbers: ");
                        foreach (int x in playerBowlerBowledOut)
                        {
                            Console.Write(" " + x + ",");
                        }
                        Console.WriteLine("  ");
                    }
                    else if (playerBowlerBowledOut.Count == 0)
                    {
                        Console.WriteLine("None of the bowlers have been bowled out yet. ");
                    }

                    bool yesFinally = false;

                    while (yesFinally == false)
                    {
                        Console.Write("To choose a bowler, simply enter their bowler number. Choose your bowler " + ": ");
                        string number = Console.ReadLine();
                        int i;
                        bool success = int.TryParse(number, out i);

                        if (success == true)
                        {
                            bowlerNumber = Convert.ToInt32(number);
                            yesFinally = true;
                            Console.WriteLine("     ");
                        }
                        else if (success == false)
                        {
                            Console.WriteLine("You did not enter a number. Please try again.");
                        }
                    }

                    if ((bowlerNumber == 1 || bowlerNumber == 2 || bowlerNumber == 3 ||
                        bowlerNumber == 4 || bowlerNumber == 5) && playerBowlerBowledOut.Contains(bowlerNumber)
                        == false && !(currentBowlerNumber == bowlerNumber))
                    {
                        Console.WriteLine("HELLO23");
                        choseBowler1 = true;
                    }

                    if (playerBowlerBowledOut.Count == 3)
                    {
                        //one of the remaining 2 bowlers
                        if (playerBowlerBowledOut.Contains(bowlerNumber) == false)
                        {
                            bool foundTheOtherOne = false;
                            //find the other bowler who isn't bowled out.
                            while (foundTheOtherOne == false)
                            {
                                Random r3 = new Random();
                                int tryThisOne = r3.Next(1, 6);
                                if (!(tryThisOne == bowlerNumber) && playerBowlerBowledOut.Contains(tryThisOne) == false)
                                {
                                    foundTheOtherOne = true;
                                    otherBowlerNumber = tryThisOne;
                                }
                            }

                            if (bowlerNumber == 1 && otherBowlerNumber == 2)
                            {
                                if (playerBowler1Overs > playerBowler2Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 1 && otherBowlerNumber == 3)
                            {
                                if (playerBowler1Overs > playerBowler3Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 1 && otherBowlerNumber == 4)
                            {
                                if (playerBowler1Overs > playerBowler4Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 1 && otherBowlerNumber == 5)
                            {
                                if (playerBowler1Overs > playerBowler5Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }

                            if (bowlerNumber == 2 && otherBowlerNumber == 1)
                            {
                                if (playerBowler2Overs > playerBowler1Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 2 && otherBowlerNumber == 3)
                            {
                                if (playerBowler2Overs > playerBowler3Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 2 && otherBowlerNumber == 4)
                            {
                                if (playerBowler2Overs > playerBowler4Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 2 && otherBowlerNumber == 5)
                            {
                                if (playerBowler2Overs > playerBowler5Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }

                            if (bowlerNumber == 3 && otherBowlerNumber == 1)
                            {
                                if (playerBowler3Overs > playerBowler1Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 3 && otherBowlerNumber == 2)
                            {
                                if (playerBowler3Overs > playerBowler2Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 3 && otherBowlerNumber == 4)
                            {
                                if (playerBowler3Overs > playerBowler4Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 3 && otherBowlerNumber == 5)
                            {
                                if (playerBowler3Overs > playerBowler5Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }

                            if (bowlerNumber == 4 && otherBowlerNumber == 1)
                            {
                                if (playerBowler4Overs > playerBowler1Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 4 && otherBowlerNumber == 2)
                            {
                                if (playerBowler4Overs > playerBowler2Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 4 && otherBowlerNumber == 3)
                            {
                                if (playerBowler4Overs > playerBowler3Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 4 && otherBowlerNumber == 5)
                            {
                                if (playerBowler4Overs > playerBowler5Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }

                            if (bowlerNumber == 5 && otherBowlerNumber == 1)
                            {
                                if (playerBowler5Overs > playerBowler1Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 5 && otherBowlerNumber == 2)
                            {
                                if (playerBowler5Overs > playerBowler2Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 5 && otherBowlerNumber == 3)
                            {
                                if (playerBowler5Overs > playerBowler3Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 5 && otherBowlerNumber == 4)
                            {
                                if (playerBowler5Overs > playerBowler4Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                        }
                    }

                    else
                    {
                        if (!(bowlerNumber == 1 || bowlerNumber == 2 || bowlerNumber == 3 ||
                        bowlerNumber == 4 || bowlerNumber == 5))
                        {
                            Console.WriteLine("Please enter a valid bowler number as written in the" +
                                " bowling score card");
                            Console.WriteLine("        ");
                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                            Console.WriteLine("        ");
                        }
                        if (playerBowlerBowledOut.Contains(bowlerNumber) == true)
                        {
                            Console.WriteLine("That bowler is bowled out. Please enter a different one.");
                            Console.WriteLine("        ");
                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                            Console.WriteLine("        ");
                        }
                        if (currentBowlerNumber == bowlerNumber)
                        {
                            Console.WriteLine("A bolwer cannot bowl back-to-back overs. Please enter" +
                                " a different one from the set of available ones.");
                            Console.WriteLine("        ");
                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                            Console.WriteLine("        ");
                        }
                    }

                }

                if (gameHasBegun == false)
                {
                    Console.WriteLine("HELLO24");
                    string proposedBowler = playerBowlers[bowlerNumber - 1];

                    //by now, we are assuming the proposed bowler has not bowled the previous over.
                    if (bowlerNumber == 1 && playerBowler1Overs < 2)
                    {
                        // player bowler1 bowls
                        //player bowler #1

                        currentBowlerRuns = 0;
                        currentBowlerWickets = 0;
                        currentBowlerOvers = 0;
                        numberOfBalls = 0;
                        currentBowler = playerBowler1;
                        currentBowlerNumber = 1;

                        //bowl over
                        while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == 10))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            Random rbowlingScore = new Random();
                            int bowlingScore = rbowlingScore.Next(0, playBowler1);

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
                                Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost);

                                currentBatsmanScore = 0;
                                currentBatsmanDeliveriesPlayed = 0;

                                if (battingWicketsLost == 10)
                                {
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
                                    whoopie5 = 0;
                                    whoopie.Add(whoopie1);
                                    whoopie.Add(whoopie2);
                                    whoopie.Add(whoopie3);
                                    whoopie.Add(whoopie4);
                                    whoopie.Add(whoopie5);
                                    firstInningsComplete = true;
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

                        if (firstInningsComplete == false && !(numberOfOvers == 10))
                        {
                            Console.WriteLine("-----------");
                            Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                                + numberOfOvers + " overs");
                            Console.WriteLine("         ");
                            Console.WriteLine(currentBowler + ". Overs: " + playerBowler1Overs + ". Runs: " +
                                playerBowler1Runs + ". Wickets: " + playerBowler1Wickets);
                            Console.WriteLine("         ");
                            //current run rate:
                            float firstInningsTotalSoFar1 = firstInningsTotal;
                            float oversSoFar = numberOfOvers;
                            float currentRunRate = firstInningsTotal / oversSoFar;
                            Console.WriteLine("Current run-rate: " + currentRunRate);
                            Console.WriteLine("         ");
                            string player = computerTeam[battingWicketsLost];
                            Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                                currentBatsmanDeliveriesPlayed + ") ");
                            Console.WriteLine("-----------");

                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                        }

                        if (playerBowler1Overs == 2)
                        {
                            playerBowlerBowledOut.Add(1);
                        }
                    }

                    else if (bowlerNumber == 2 && playerBowler2Overs < 2)
                    {
                        // player bowler2 bowls
                        //player bowler #2

                        currentBowlerRuns = 0;
                        currentBowlerWickets = 0;
                        currentBowlerOvers = 0;
                        numberOfBalls = 0;
                        currentBowler = playerBowler2;
                        currentBowlerNumber = 2;

                        //bowl over
                        while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == 10))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            Random rbowlingScore = new Random();
                            int bowlingScore = rbowlingScore.Next(0, playBowler2);

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
                                Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost);

                                currentBatsmanScore = 0;
                                currentBatsmanDeliveriesPlayed = 0;

                                if (battingWicketsLost == 10)
                                {
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
                                    whoopie5 = 0;
                                    whoopie.Add(whoopie1);
                                    whoopie.Add(whoopie2);
                                    whoopie.Add(whoopie3);
                                    whoopie.Add(whoopie4);
                                    whoopie.Add(whoopie5);
                                    firstInningsComplete = true;
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

                        if (firstInningsComplete == false && !(numberOfOvers == 10))
                        {
                            Console.WriteLine("-----------");
                            Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                                + numberOfOvers + " overs");
                            Console.WriteLine("         ");
                            Console.WriteLine(currentBowler + ". Overs: " + playerBowler2Overs + ". Runs: " +
                                playerBowler2Runs + ". Wickets: " + playerBowler2Wickets);
                            Console.WriteLine("         ");
                            //current run rate:
                            float firstInningsTotalSoFar1 = firstInningsTotal;
                            float oversSoFar = numberOfOvers;
                            float currentRunRate = firstInningsTotal / oversSoFar;
                            Console.WriteLine("Current run-rate: " + currentRunRate);
                            Console.WriteLine("         ");
                            string player = computerTeam[battingWicketsLost];
                            Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                                currentBatsmanDeliveriesPlayed + ") ");
                            Console.WriteLine("-----------");

                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                        }

                        if (playerBowler2Overs == 2)
                        {
                            playerBowlerBowledOut.Add(2);
                        }
                    }

                    else if (bowlerNumber == 3 && playerBowler3Overs < 2)
                    {
                        // player bowler3 bowls
                        //player bowler #3

                        currentBowlerRuns = 0;
                        currentBowlerWickets = 0;
                        currentBowlerOvers = 0;
                        numberOfBalls = 0;
                        currentBowler = playerBowler3;
                        currentBowlerNumber = 3;

                        //bowl over
                        while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == 10))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            Random rbowlingScore = new Random();
                            int bowlingScore = rbowlingScore.Next(0, playBowler3);

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
                                Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost);

                                currentBatsmanScore = 0;
                                currentBatsmanDeliveriesPlayed = 0;

                                if (battingWicketsLost == 10)
                                {
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
                                    whoopie5 = 0;
                                    whoopie.Add(whoopie1);
                                    whoopie.Add(whoopie2);
                                    whoopie.Add(whoopie3);
                                    whoopie.Add(whoopie4);
                                    whoopie.Add(whoopie5);
                                    firstInningsComplete = true;
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

                        if (firstInningsComplete == false && !(numberOfOvers == 10))
                        {
                            Console.WriteLine("-----------");
                            Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                                + numberOfOvers + " overs");
                            Console.WriteLine("         ");
                            Console.WriteLine(currentBowler + ". Overs: " + playerBowler3Overs + ". Runs: " +
                                playerBowler3Runs + ". Wickets: " + playerBowler3Wickets);
                            Console.WriteLine("         ");
                            //current run rate:
                            float firstInningsTotalSoFar1 = firstInningsTotal;
                            float oversSoFar = numberOfOvers;
                            float currentRunRate = firstInningsTotal / oversSoFar;
                            Console.WriteLine("Current run-rate: " + currentRunRate);
                            Console.WriteLine("         ");
                            string player = computerTeam[battingWicketsLost];
                            Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                                currentBatsmanDeliveriesPlayed + ") ");
                            Console.WriteLine("-----------");

                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                        }

                        if (playerBowler3Overs == 2)
                        {
                            playerBowlerBowledOut.Add(3);
                        }
                    }

                    else if (bowlerNumber == 4 && playerBowler4Overs < 2)
                    {
                        // player bowler4 bowls
                        //player bowler #4

                        currentBowlerRuns = 0;
                        currentBowlerWickets = 0;
                        currentBowlerOvers = 0;
                        numberOfBalls = 0;
                        currentBowler = playerBowler4;
                        currentBowlerNumber = 4;

                        //bowl over
                        while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == 10))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            Random rbowlingScore = new Random();
                            int bowlingScore = rbowlingScore.Next(0, playBowler4);

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
                                Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost);

                                currentBatsmanScore = 0;
                                currentBatsmanDeliveriesPlayed = 0;

                                if (battingWicketsLost == 10)
                                {
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
                                    whoopie5 = 0;
                                    whoopie.Add(whoopie1);
                                    whoopie.Add(whoopie2);
                                    whoopie.Add(whoopie3);
                                    whoopie.Add(whoopie4);
                                    whoopie.Add(whoopie5);
                                    firstInningsComplete = true;
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

                        if (firstInningsComplete == false && !(numberOfOvers == 10))
                        {
                            Console.WriteLine("-----------");
                            Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                                + numberOfOvers + " overs");
                            Console.WriteLine("         ");
                            Console.WriteLine(currentBowler + ". Overs: " + playerBowler4Overs + ". Runs: " +
                                playerBowler4Runs + ". Wickets: " + playerBowler4Wickets);
                            Console.WriteLine("         ");
                            //current run rate:
                            float firstInningsTotalSoFar1 = firstInningsTotal;
                            float oversSoFar = numberOfOvers;
                            float currentRunRate = firstInningsTotal / oversSoFar;
                            Console.WriteLine("Current run-rate: " + currentRunRate);
                            Console.WriteLine("         ");
                            string player = computerTeam[battingWicketsLost];
                            Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                                currentBatsmanDeliveriesPlayed + ") ");
                            Console.WriteLine("-----------");

                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                        }

                        if (playerBowler4Overs == 2)
                        {
                            playerBowlerBowledOut.Add(4);
                        }
                    }

                    else if (bowlerNumber == 5 && playerBowler5Overs < 2)
                    {
                        // player bowler4 bowls
                        //player bowler #4

                        currentBowlerRuns = 0;
                        currentBowlerWickets = 0;
                        currentBowlerOvers = 0;
                        numberOfBalls = 0;
                        currentBowler = playerBowler5;
                        currentBowlerNumber = 5;

                        //bowl over
                        while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == 10))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            Random rbowlingScore = new Random();
                            int bowlingScore = rbowlingScore.Next(0, playBowler5);

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
                                Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost);

                                currentBatsmanScore = 0;
                                currentBatsmanDeliveriesPlayed = 0;

                                if (battingWicketsLost == 10)
                                {
                                    if (numberOfBalls < 5)
                                    {
                                        whoopie5 = numberOfBalls + 1;
                                    }
                                    else if (numberOfBalls == 5)
                                    {
                                        whoopie5 = 0;
                                    }
                                    whoopie1 = 0;
                                    whoopie2 = 0;
                                    whoopie4 = 0;
                                    whoopie3 = 0;
                                    whoopie.Add(whoopie1);
                                    whoopie.Add(whoopie2);
                                    whoopie.Add(whoopie3);
                                    whoopie.Add(whoopie4);
                                    whoopie.Add(whoopie5);
                                    firstInningsComplete = true;
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

                        playerBowler5Runs += currentBowlerRuns;
                        playerBowler5Wickets += currentBowlerWickets;
                        playerBowler5Overs += currentBowlerOvers;

                        if (firstInningsComplete == false && !(numberOfOvers == 10))
                        {
                            Console.WriteLine("-----------");
                            Console.WriteLine(" Team " + sideNotPicked + " : " + firstInningsTotal + " / " + battingWicketsLost + " in "
                                + numberOfOvers + " overs");
                            Console.WriteLine("         ");
                            Console.WriteLine(currentBowler + ". Overs: " + playerBowler5Overs + ". Runs: " +
                                playerBowler5Runs + ". Wickets: " + playerBowler5Wickets);
                            Console.WriteLine("         ");
                            //current run rate:
                            float firstInningsTotalSoFar1 = firstInningsTotal;
                            float oversSoFar = numberOfOvers;
                            float currentRunRate = firstInningsTotal / oversSoFar;
                            Console.WriteLine("Current run-rate: " + currentRunRate);
                            Console.WriteLine("         ");
                            string player = computerTeam[battingWicketsLost];
                            Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                                currentBatsmanDeliveriesPlayed + ") ");
                            Console.WriteLine("-----------");

                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                        }

                        if (playerBowler5Overs == 2)
                        {
                            playerBowlerBowledOut.Add(5);
                        }
                    }

                    if (numberOfOvers == 10)
                    {
                        secondInningsComplete = true;
                        gameOver = true;
                        computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        computerBatsmenScores.Add(currentBatsmanScore);
                    }
                }

                if (numberOfOvers == 10 && battingWicketsLost < 10)
                {
                    computerBatsmenScores.Add(currentBatsmanScore);
                    computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                    firstInningsComplete = true;
                    playerNotOut = true;
                    Console.WriteLine("HELLO1");
                }
            }

            playerBowlerRuns.Add(playerBowler1Runs);
            playerBowlerRuns.Add(playerBowler2Runs);
            playerBowlerRuns.Add(playerBowler3Runs);
            playerBowlerRuns.Add(playerBowler4Runs);
            playerBowlerRuns.Add(playerBowler5Runs);

            playerBowlerOvers.Add(playerBowler1Overs);
            playerBowlerOvers.Add(playerBowler2Overs);
            playerBowlerOvers.Add(playerBowler3Overs);
            playerBowlerOvers.Add(playerBowler4Overs);
            playerBowlerOvers.Add(playerBowler5Overs);

            playerBowlerWickets.Add(playerBowler1Wickets);
            playerBowlerWickets.Add(playerBowler2Wickets);
            playerBowlerWickets.Add(playerBowler3Wickets);
            playerBowlerWickets.Add(playerBowler4Wickets);
            playerBowlerWickets.Add(playerBowler5Wickets);

            if (battingWicketsLost < 10)
            {
                whoopie1 = 0;
                whoopie2 = 0;
                whoopie3 = 0;
                whoopie4 = 0;
                whoopie5 = 0;
                whoopie.Add(whoopie1);
                whoopie.Add(whoopie2);
                whoopie.Add(whoopie3);
                whoopie.Add(whoopie4);
                whoopie.Add(whoopie5);
                playerNotOut = true;
            }

            int sumWhoopie = whoopie1 + whoopie2 + whoopie3 + whoopie4 + whoopie5;

            Console.WriteLine("        ");
            Console.WriteLine("Team " + sideNotPicked + " has scored " + firstInningsTotal + " in " + numberOfOvers +
               "." + sumWhoopie + " overs.");

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("        ");

            //batting strike rate
            index = 0;

            while (index < battingWicketsLost)
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

            while (numberBatsmenPrinted < battingWicketsLost)
            {
                Console.WriteLine(computerTeam[index] + " : " + computerBatsmenScores[index] + " (" +
                    computerBatsmenDeliveriesPlayed[index] + ") . Strike Rate: " +
                    battingStrikeRate[index]);
                index += 1;
                numberBatsmenPrinted += 1;
                if (numberBatsmenPrinted == battingWicketsLost && playerNotOut == true)
                {
                    Console.WriteLine("HELLO THERE");
                    Console.WriteLine(computerTeam[index] + " (not out): " + computerBatsmenScores[index] + " (" +
                    computerBatsmenDeliveriesPlayed[index] + ")");
                }
            }

            Console.WriteLine("        ");

            //print runrate and total:

            Console.WriteLine("Innings Total: " + firstInningsTotal + " / " +
                battingWicketsLost + ". Run rate: " + runrate);
            Console.WriteLine("     ");

            //bowling economy
            float completeOver = 6f;
            index = 0;

            while (index < 5)
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

            while (index < 5)
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

            while (index < 5)
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

            while (numberBowlersPrinted < 5)
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
                Console.WriteLine("       ");
                Console.WriteLine(sidePicked + " needs " + (input + 1) + " runs to win from " +
                (10 * 6) + " balls.");
                Console.WriteLine("       ");
                int battingWicketsLost = 0;
                int secondInningsTotal = 0;
                int currentBatsmanScore = 0;
                currentBatsmanDeliveriesPlayed = 0;
                secondInningsComplete = false;
                gameOver = false;
                playerNotOut = false;

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
                int whoopie5 = 0;

                Random CB1 = new Random();
                compBowler1 = CB1.Next(10, 20);

                Random CB2 = new Random();
                compBowler2 = CB2.Next(7, 20);

                Random CB3 = new Random();
                compBowler3 = CB3.Next(7, 20);

                Random CB4 = new Random();
                compBowler4 = CB4.Next(7, 20);

                Random CB5 = new Random();
                compBowler5 = CB5.Next(14, 20);

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
                        int bowlingScore = rbowlingScore.Next(0, compBowler1);

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
                                whoopie5 = 0;
                                whoopie.Add(whoopie1);
                                whoopie.Add(whoopie2);
                                whoopie.Add(whoopie3);
                                whoopie.Add(whoopie4);
                                whoopie.Add(whoopie5);
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
                                whoopie5 = 0;
                                whoopie.Add(whoopie1);
                                whoopie.Add(whoopie2);
                                whoopie.Add(whoopie3);
                                whoopie.Add(whoopie4);
                                whoopie.Add(whoopie5);
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
                                whoopie5 = 0;
                                whoopie.Add(whoopie1);
                                whoopie.Add(whoopie2);
                                whoopie.Add(whoopie3);
                                whoopie.Add(whoopie4);
                                whoopie.Add(whoopie5);
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
                                         " runs to win from " + (60 - (numberOfOvers * 6)) + " balls.");
                        //current run rate:
                        float secondInningsTotalSoFar1 = secondInningsTotal;
                        float oversSoFar = numberOfOvers;
                        float currentRunRate = secondInningsTotal / oversSoFar;
                        Console.WriteLine("Current run-rate: " + currentRunRate);
                        Console.WriteLine("         ");
                        //required run rate:
                        float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                        float OversToGo = 10 - numberOfOvers;
                        float requiredRunRate = runsToGo / OversToGo;
                        Console.WriteLine("Required run-rate: " + requiredRunRate);
                        Console.WriteLine("        ");
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
                        int bowlingScore = rbowlingScore.Next(0, compBowler2);

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
                                whoopie5 = 0;
                                whoopie.Add(whoopie1);
                                whoopie.Add(whoopie2);
                                whoopie.Add(whoopie3);
                                whoopie.Add(whoopie4);
                                whoopie.Add(whoopie5);
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
                                whoopie5 = 0;
                                whoopie.Add(whoopie1);
                                whoopie.Add(whoopie2);
                                whoopie.Add(whoopie3);
                                whoopie.Add(whoopie4);
                                whoopie.Add(whoopie5);
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
                                whoopie5 = 0;
                                whoopie.Add(whoopie1);
                                whoopie.Add(whoopie2);
                                whoopie.Add(whoopie3);
                                whoopie.Add(whoopie4);
                                whoopie.Add(whoopie5);
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
                                         " runs to win from " + (60 - (numberOfOvers * 6)) + " balls.");
                        Console.WriteLine("          ");
                    //current run rate:
                    float secondInningsTotalSoFar1 = secondInningsTotal;
                        float oversSoFar = numberOfOvers;
                        float currentRunRate = secondInningsTotal / oversSoFar;
                        Console.WriteLine("Current run-rate: " + currentRunRate);
                        Console.WriteLine("         ");
                        //required run rate:
                        float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                        float OversToGo = 10 - numberOfOvers;
                        float requiredRunRate = runsToGo / OversToGo;
                        Console.WriteLine("Required run-rate: " + requiredRunRate);
                        Console.WriteLine("        ");
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
                        int bowlingScore = rbowlingScore.Next(0, compBowler3);

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
                                whoopie5 = 0;
                                whoopie.Add(whoopie1);
                                whoopie.Add(whoopie2);
                                whoopie.Add(whoopie3);
                                whoopie.Add(whoopie4);
                                whoopie.Add(whoopie5);
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
                                whoopie5 = 0;
                                whoopie.Add(whoopie1);
                                whoopie.Add(whoopie2);
                                whoopie.Add(whoopie3);
                                whoopie.Add(whoopie4);
                                whoopie.Add(whoopie5);
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
                                whoopie5 = 0;
                                whoopie.Add(whoopie1);
                                whoopie.Add(whoopie2);
                                whoopie.Add(whoopie3);
                                whoopie.Add(whoopie4);
                                whoopie.Add(whoopie5);
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
                                             " runs to win from " + (60 - (numberOfOvers * 6)) + " balls.");
                        Console.WriteLine("          ");
                        //current run rate:
                        float secondInningsTotalSoFar1 = secondInningsTotal;
                        float oversSoFar = numberOfOvers;
                        float currentRunRate = secondInningsTotal / oversSoFar;
                        Console.WriteLine("Current run-rate: " + currentRunRate);
                        Console.WriteLine("         ");
                        //required run rate:
                        float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                        float OversToGo = 10 - numberOfOvers;
                        float requiredRunRate = runsToGo / OversToGo;
                        Console.WriteLine("Required run-rate: " + requiredRunRate);
                        Console.WriteLine("        ");
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
                        int bowlingScore = rbowlingScore.Next(0, compBowler4);

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
                                whoopie1 = 0;
                                whoopie3 = 0;
                                whoopie5 = 0;
                                whoopie.Add(whoopie1);
                                whoopie.Add(whoopie2);
                                whoopie.Add(whoopie3);
                                whoopie.Add(whoopie4);
                                whoopie.Add(whoopie5);
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
                                whoopie1 = 0;
                                whoopie3 = 0;
                                whoopie5 = 0;
                                whoopie.Add(whoopie1);
                                whoopie.Add(whoopie2);
                                whoopie.Add(whoopie3);
                                whoopie.Add(whoopie4);
                                whoopie.Add(whoopie5);
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
                                whoopie1 = 0;
                                whoopie3 = 0;
                                whoopie5 = 0;
                                whoopie.Add(whoopie1);
                                whoopie.Add(whoopie2);
                                whoopie.Add(whoopie3);
                                whoopie.Add(whoopie4);
                                whoopie.Add(whoopie5);
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
                                         " runs to win from " + (60 - (numberOfOvers * 6)) + " balls.");
                        Console.WriteLine("          ");
                        //current run rate:
                        float secondInningsTotalSoFar1 = secondInningsTotal;
                        float oversSoFar = numberOfOvers;
                        float currentRunRate = secondInningsTotal / oversSoFar;
                        Console.WriteLine("Current run-rate: " + currentRunRate);
                        Console.WriteLine("         ");
                        //required run rate:
                        float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                        float OversToGo = 10 - numberOfOvers;
                        float requiredRunRate = runsToGo / OversToGo;
                        Console.WriteLine("Required run-rate: " + requiredRunRate);
                        Console.WriteLine("-----------");

                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }

                    //computer bowler #5

                    currentBowlerRuns = 0;
                    currentBowlerWickets = 0;
                    currentBowlerOvers = 0;
                    numberOfBalls = 0;
                    currentBowler = computerBowler5;

                    //bowl over
                    while (numberOfBalls < 6 && secondInningsComplete == false && gameOver == false)
                    {
                        Random rbattingScore = new Random();
                        int battingScore = rbattingScore.Next(0, 7);

                        Random rbowlingScore = new Random();
                        int bowlingScore = rbowlingScore.Next(0, compBowler5);

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
                                    whoopie5 = numberOfBalls + 1;
                                }
                                else if (numberOfBalls == 5)
                                {
                                    whoopie5 = 0;
                                }
                                whoopie2 = 0;
                                whoopie3 = 0;
                                whoopie4 = 0;
                                whoopie1 = 0;
                                whoopie.Add(whoopie1);
                                whoopie.Add(whoopie2);
                                whoopie.Add(whoopie3);
                                whoopie.Add(whoopie4);
                                whoopie.Add(whoopie5);
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
                                    whoopie5 = numberOfBalls + 1;
                                }
                                else if (numberOfBalls == 5)
                                {
                                    whoopie5 = 0;
                                }
                                whoopie2 = 0;
                                whoopie3 = 0;
                                whoopie4 = 0;
                                whoopie1 = 0;
                                whoopie.Add(whoopie1);
                                whoopie.Add(whoopie2);
                                whoopie.Add(whoopie3);
                                whoopie.Add(whoopie4);
                                whoopie.Add(whoopie5);
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
                                    whoopie5 = numberOfBalls + 1;
                                }
                                else if (numberOfBalls == 5)
                                {
                                    whoopie5 = 0;
                                }
                                whoopie2 = 0;
                                whoopie3 = 0;
                                whoopie4 = 0;
                                whoopie1 = 0;
                                whoopie.Add(whoopie1);
                                whoopie.Add(whoopie2);
                                whoopie.Add(whoopie3);
                                whoopie.Add(whoopie4);
                                whoopie.Add(whoopie5);
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

                    computerBowler5Runs += currentBowlerRuns;
                    computerBowler5Wickets += currentBowlerWickets;
                    computerBowler5Overs += currentBowlerOvers;

                    if(numberOfOvers == 10)
                {
                    secondInningsComplete = true;
                }

                    if (secondInningsComplete == false)
                    {
                        Console.WriteLine("-----------");
                        Console.WriteLine(" Team " + sidePicked + " : " + secondInningsTotal + " / " + battingWicketsLost + " in "
                            + numberOfOvers + " overs");
                        Console.WriteLine("         ");
                        Console.WriteLine(currentBowler + ". Overs: " + computerBowler5Overs + ". Runs: " +
                            computerBowler5Runs + ". Wickets: " + computerBowler5Wickets);
                        Console.WriteLine("         ");
                        string player = playerTeam[battingWicketsLost];
                        Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                            currentBatsmanDeliveriesPlayed + ") ");
                        Console.WriteLine("          ");
                        Console.WriteLine(" Team " + sidePicked + " needs " + (firstInningsTotal + 1 - secondInningsTotal) +
                                         " runs to win from " + (60 - (numberOfOvers * 6)) + " balls.");
                        Console.WriteLine("          ");
                        //current run rate:
                        float secondInningsTotalSoFar1 = secondInningsTotal;
                        float oversSoFar = numberOfOvers;
                        float currentRunRate = secondInningsTotal / oversSoFar;
                        Console.WriteLine("Current run-rate: " + currentRunRate);
                        Console.WriteLine("         ");
                        //required run rate:
                        float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                        float OversToGo = 10 - numberOfOvers;
                        float requiredRunRate = runsToGo / OversToGo;
                        Console.WriteLine("Required run-rate: " + requiredRunRate);
                        Console.WriteLine("-----------");

                        Console.Write("Press Enter to continue!");
                        Console.ReadLine();
                    }

                }

                computerBowlerRuns.Add(computerBowler1Runs);
                computerBowlerRuns.Add(computerBowler2Runs);
                computerBowlerRuns.Add(computerBowler3Runs);
                computerBowlerRuns.Add(computerBowler4Runs);
                computerBowlerRuns.Add(computerBowler5Runs);

                computerBowlerOvers.Add(computerBowler1Overs);
                computerBowlerOvers.Add(computerBowler2Overs);
                computerBowlerOvers.Add(computerBowler3Overs);
                computerBowlerOvers.Add(computerBowler4Overs);
                computerBowlerOvers.Add(computerBowler5Overs);

                computerBowlerWickets.Add(computerBowler1Wickets);
                computerBowlerWickets.Add(computerBowler2Wickets);
                computerBowlerWickets.Add(computerBowler3Wickets);
                computerBowlerWickets.Add(computerBowler4Wickets);
                computerBowlerWickets.Add(computerBowler5Wickets);

                if (!(secondInningsTotal > input) && battingWicketsLost < 10 && numberOfOvers == 10)
                {
                    Console.WriteLine("HELLO THERE3");
                    whoopie1 = 0;
                    whoopie2 = 0;
                    whoopie3 = 0;
                    whoopie4 = 0;
                    whoopie5 = 0;
                    whoopie.Add(whoopie1);
                    whoopie.Add(whoopie2);
                    whoopie.Add(whoopie3);
                    whoopie.Add(whoopie4);
                    whoopie.Add(whoopie5);
                Console.WriteLine(sidePicked + " has lost the game by " + (input - secondInningsTotal)
                    + " runs.");
                    playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                    playerBatsmenScores.Add(currentBatsmanScore);
                }

                if(battingWicketsLost < 10)
                {
                    Console.WriteLine("HELLO THERE4");
                    playerNotOut = true;
                }

                int sumWhoopie = whoopie1 + whoopie2 + whoopie3 + whoopie4 + whoopie5;

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

                while (index < 5)
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

                while (index < battingWicketsLost)
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

                while (numberBatsmenPrinted < battingWicketsLost)
                {
                    Console.WriteLine(playerTeam[index] + " : " + playerBatsmenScores[index] + " (" +
                    playerBatsmenDeliveriesPlayed[index] + "). Strike Rate: " +
                    battingStrikeRateC[index]);
                    index += 1;
                    numberBatsmenPrinted += 1;
                    if (numberBatsmenPrinted == battingWicketsLost && playerNotOut == true)
                    {
                        Console.WriteLine("HELLO THERE1");
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

                Console.WriteLine(" Final Bowling Scorecard: ");

                Console.WriteLine("        ");

                while (numberBowlersPrinted < 5)
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