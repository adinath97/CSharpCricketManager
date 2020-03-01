using System;
using System.Collections.Generic;
using System.Numerics;

namespace All_Star_Cricket_Game_1
{
    class MainClass
    {
        //still need to include possibility of run out; allow 2 batsmen at a time/strik rotation
        //allow player to choose next batter/bowler. Show bowler stats and overs left for them (assuming we're playing limited overs)
        /* General note: At some point, need to go back and allow player to declare*/

        public static List<string> playerPoolBatsmen = new List<string>();
        public static List<string> playerPoolKeepers = new List<string>();
        public static List<string> playerPoolBowlers = new List<string>();
        public static List<string> playerPoolAllrounders = new List<string>();

        public static List<string> playerTeam = new List<string>();
        public static List<string> computerTeam = new List<string>();

        public static List<string> squadAustraliaBatsmen = new List<string>();
        public static List<string> squadAustraliaKeepers = new List<string>();
        public static List<string> squadAustraliaAllRounders = new List<string>();
        public static List<string> squadAustraliaBowlers = new List<string>();

        public static List<string> squadEnglandBatsmen = new List<string>();
        public static List<string> squadEnglandKeepers = new List<string>();
        public static List<string> squadEnglandAllRounders = new List<string>();
        public static List<string> squadEnglandBowlers = new List<string>();

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

        public static int firstInningTotalW;
        public static int secondInningTotalW;
        public static int thirdInningTotalW;
        public static int fourthInningTotalW;

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
        public static int chasingWicketLost;
        public static int firstInningsTotal;

        public static bool gameOver = false;
        public static bool secondInningsComplete = false;
        public static bool firstInningsComplete = false;
        public static bool overIncomplete = false;
        public static bool playerNotOut = false;
        public static bool pickedASide = false;

        public static void Main(string[] args)
        {
            PickAndCreateTeams();
            Toss();
            LetTheGamesBegin();
        }

        public static void PickAndCreateTeams()
        {
            //AUSTRALIAN SQUAD
            //Aussie batters
            squadAustraliaBatsmen.Add("Steven Smith");
            squadAustraliaBatsmen.Add("David Warner");
            squadAustraliaBatsmen.Add("Matthew Hayden");
            squadAustraliaBatsmen.Add("Justin Langer");
            squadAustraliaBatsmen.Add("Cameron Bancroft");
            squadAustraliaBatsmen.Add("Peter Handscomb");
            squadAustraliaBatsmen.Add("Michael Bevan");
            squadAustraliaBatsmen.Add("Ricky Ponting");
            squadAustraliaBatsmen.Add("Steve Waugh");
            squadAustraliaBatsmen.Add("Michael Clarke");

            //Aussie keepers
            squadAustraliaKeepers.Add("Adam Gilchrist");
            squadAustraliaKeepers.Add("Tim Paine");
            squadAustraliaKeepers.Add("Ian Healy");
            squadAustraliaKeepers.Add("Matthew Wade");

            //Aussie Allrounders
            squadAustraliaAllRounders.Add("Glenn Maxwell");
            squadAustraliaAllRounders.Add("Mitchell Marsh");

            //Aussie Bowlers
            squadAustraliaBowlers.Add("Glen McGrath");
            squadAustraliaBowlers.Add("Shane Warne");
            squadAustraliaBowlers.Add("Mitchell Johnson");
            squadAustraliaBowlers.Add("Stuart McGill");
            squadAustraliaBowlers.Add("Brett Lee");
            squadAustraliaBowlers.Add("Josh Hazlewood");
            squadAustraliaBowlers.Add("Mitchell Starc");
            squadAustraliaBowlers.Add("Jason Gillespie");
            squadAustraliaBowlers.Add("Nathan Lyon");
            squadAustraliaBowlers.Add("James Pattinson");

            //ENGLISH SQUAD
            //English batters
            squadEnglandBatsmen.Add("Alistair Cook");
            squadEnglandBatsmen.Add("Andrew Strauss");
            squadEnglandBatsmen.Add("Michael Vaughan");
            squadEnglandBatsmen.Add("Marcus Trescothick");
            squadEnglandBatsmen.Add("Joe Root");
            squadEnglandBatsmen.Add("Marcus Trescothick");
            squadEnglandBatsmen.Add("Joe Denly");
            squadEnglandBatsmen.Add("Kevin Pietersen");
            squadEnglandBatsmen.Add("Ian Bell");
            squadEnglandBatsmen.Add("Jonny Bairstow");


            //English keepers
            squadEnglandKeepers.Add("Matt Prior");
            squadEnglandKeepers.Add("Jos Buttler");

            //English Allrounders
            squadEnglandAllRounders.Add("Ben Strokes");
            squadEnglandAllRounders.Add("Moeen Ali");
            squadEnglandAllRounders.Add("Andrew Flintoff");

            //English Bowlers
            squadEnglandBowlers.Add("James Anderson");
            squadEnglandBowlers.Add("Stuart Broad");
            squadEnglandBowlers.Add("Steven Finn");
            squadEnglandBowlers.Add("Adil Rashid");
            squadEnglandBowlers.Add("Ashley Giles");
            squadEnglandBowlers.Add("Steve Harmison");
            squadEnglandBowlers.Add("Mark Wood");

            //choosing teams
            Console.WriteLine("Welcome to the Cricket Ashes: Survival. It's your team versus the computer's. " +
                "You both will now pick your teams. Choose wisely!");

            Console.WriteLine("------------");

            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("         ");

            Console.WriteLine("------------");

            Console.Write("Team England vs Team Australia. Which team would you like to build? Enter 'Australia' for " +
                "Team Australia or enter 'England' for Team England: ");
            sidePicked = Console.ReadLine();

            while (pickedASide == false)
            {
                if (sidePicked == "England")
                {
                    //pick player team from sets of England players
                    Console.WriteLine("------------");
                    Console.WriteLine("            ");
                    Console.WriteLine("You have chosen England");
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
                    sideNotPicked = "Australia";

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

                else if (sidePicked == "Australia")
                {
                    //pick player team from sets of Aussie players
                    Console.WriteLine("------------");
                    Console.WriteLine("            ");
                    Console.WriteLine("You have chosen Australia");
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
                    sideNotPicked = "England";
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

                else if (!(sidePicked == "Australia") && !(sidePicked == "England"))
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

                bool tossComplete = false;

                while (tossComplete == false)
                {
                    if (tossPlayerDecision == "Bat")
                    {
                        Console.WriteLine("Your team, Team " + sidePicked + " will bat first");
                        waitWhoBatting = 1;
                        tossComplete = true;
                    }
                    else if (tossPlayerDecision == "Bowl")
                    {
                        Console.WriteLine("Your team, Team " + sidePicked + " will bowl first");
                        waitWhoBatting = 2;
                        tossComplete = true;
                    }
                    else if (!(tossPlayerDecision == "Bat") && !(tossPlayerDecision == "Bowl"))
                    {
                        Console.WriteLine("Please try again: ");
                        tossPlayerDecision = Console.ReadLine();
                    }
                }
            }

            else
            {
                Console.WriteLine("Team " + sideNotPicked + " has won the toss");

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

                firstInningTotalW = FirstInningPlayerTeamBats();

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

                secondInningTotalW = SecondInningComputerTeamBats();

                int lead = (firstInningTotalW - secondInningTotalW);


                if (lead >= 0)
                {
                    Console.WriteLine("Your team is currently leading by " + lead
                        + " runs.");
                }
                else if (lead < 0)
                {
                    Console.WriteLine("Your team is currently trailing by " + (-lead)
                        + " runs.");
                }

                computerBowlerRuns.Clear();
                computerBowlerWickets.Clear();
                computerBowlerOvers.Clear();
                //Console.WriteLine("HELLO8");

                playerBatsmenDeliveriesPlayed.Clear();
                playerBatsmenScores.Clear();
                //Console.WriteLine("HELLO9");

                thirdInningTotalW = ThirdInningPlayerTeamBats(lead);

                if(firstInningTotalW + thirdInningTotalW < secondInningTotalW)
                {
                    Console.WriteLine("You have lost by an inning and " +
                        (secondInningTotalW - firstInningTotalW - thirdInningTotalW) + " runs.");
                }
                else if(firstInningTotalW + thirdInningTotalW >= secondInningTotalW)
                {
                    playerBowlerRuns.Clear();
                    playerBowlerWickets.Clear();
                    playerBowlerOvers.Clear();
                    //Console.WriteLine("HELLO10");

                    computerBatsmenDeliveriesPlayed.Clear();
                    computerBatsmenScores.Clear();
                    //Console.WriteLine("HELLO11");


                    fourthInningTotalW = FourthInningComputerTeamBats(thirdInningTotalW + lead);
                }

                //Console.WriteLine("HELLO12 DONE");
                /*
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

                firstInningTotalW = FirstInningComputerTeamBats();

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

                secondInningTotalW = SecondInningPlayerTeamBats();

                int lead = (secondInningTotalW - firstInningTotalW);


                if (lead >= 0)
                {
                    Console.WriteLine("Your team is currently leading by " + lead
                        + " runs.");
                }
                else if (lead < 0)
                {
                    Console.WriteLine("Your team is currently trailing by " + (-lead)
                        + " runs.");
                }

                playerBowlerRuns.Clear();
                playerBowlerWickets.Clear();
                playerBowlerOvers.Clear();
                Console.WriteLine("HELLO8");

                computerBatsmenDeliveriesPlayed.Clear();
                computerBatsmenScores.Clear();
                Console.WriteLine("HELLO9");

                thirdInningTotalW = ThirdInningComputerTeamBats(lead);

                if (firstInningTotalW + thirdInningTotalW < secondInningTotalW)
                {
                    Console.WriteLine("You have won by an inning and " +
                        (secondInningTotalW - firstInningTotalW - thirdInningTotalW) + " runs.");
                }
                else if (firstInningTotalW + thirdInningTotalW >= secondInningTotalW)
                {
                    computerBowlerRuns.Clear();
                    computerBowlerWickets.Clear();
                    computerBowlerOvers.Clear();
                    Console.WriteLine("HELLO10");

                    playerBatsmenDeliveriesPlayed.Clear();
                    playerBatsmenScores.Clear();
                    Console.WriteLine("HELLO11");


                    fourthInningTotalW = FourthInningPlayerTeamBats(thirdInningTotalW - lead);
                }*/

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

                firstInningTotalW = FirstInningComputerTeamBats();

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

                secondInningTotalW = SecondInningPlayerTeamBats();

                int lead = (secondInningTotalW - firstInningTotalW);


                if (lead >= 0)
                {
                    Console.WriteLine("Your team is currently leading by " + lead
                        + " runs.");
                }
                else if (lead < 0)
                {
                    Console.WriteLine("Your team is currently trailing by " + (-lead)
                        + " runs.");
                }

                playerBowlerRuns.Clear();
                playerBowlerWickets.Clear();
                playerBowlerOvers.Clear();
                //Console.WriteLine("HELLO8");

                computerBatsmenDeliveriesPlayed.Clear();
                computerBatsmenScores.Clear();
               // Console.WriteLine("HELLO9");

                thirdInningTotalW = ThirdInningComputerTeamBats(lead);

                if (firstInningTotalW + thirdInningTotalW < secondInningTotalW)
                {
                    Console.WriteLine("You have won by an inning and " +
                        (secondInningTotalW - firstInningTotalW - thirdInningTotalW) + " runs.");
                }
                else if (firstInningTotalW + thirdInningTotalW >= secondInningTotalW)
                {
                    computerBowlerRuns.Clear();
                    computerBowlerWickets.Clear();
                    computerBowlerOvers.Clear();
                    //Console.WriteLine("HELLO10");

                    playerBatsmenDeliveriesPlayed.Clear();
                    playerBatsmenScores.Clear();
                    //Console.WriteLine("HELLO11");


                    fourthInningTotalW = FourthInningPlayerTeamBats(thirdInningTotalW - lead);
                }
            }
        }

        //player team bats first

        public static int FirstInningPlayerTeamBats()
        {
            int battingWicketsLost = 0;
            int currentBatsmanScore = 0;
            int firstInningsTotal = 0;
            bool firstInningsComplete = false;
            int numberOfBalls = 0;
            int index = 0;
            int numberOfOvers = 0;
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
                //computer bowler #1

                //Console.WriteLine("HELLO1");
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
                            //Console.WriteLine("HELLO5");
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
                //Console.WriteLine("HELLO2");
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
                            //Console.WriteLine("HELLO5");
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
                //Console.WriteLine("HELLO3");
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
                            //Console.WriteLine("HELLO5");
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
                //Console.WriteLine("HELLO4");
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
                            //Console.WriteLine("HELLO5");
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

            //Console.WriteLine("HELLO6");

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
                else if (playerBatsmenDeliveriesPlayed[index] == 0)
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
            Console.WriteLine("        ");

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

            while (index < 4)
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

            while (index < 4)
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

            //Console.WriteLine("HELLO7");
            return firstInningsTotal;

        }

        public static int SecondInningComputerTeamBats()
        {
            int battingWicketsLost = 0;
            int secondInningsTotal = 0;
            int currentBatsmanScore = 0;
            bool secondInningsComplete = false;
            int numberOfBalls = 0;
            int index = 0;
            int numberOfOvers = 0;
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

            while (secondInningsComplete == false)
            {
                //computer bowler #1

                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;
                currentBowler = playerBowler1;

                //bowl over
                while (numberOfBalls < 6 && secondInningsComplete == false)
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
                        Console.WriteLine(" Team " + sideNotPicked + " : " + secondInningsTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {

                            secondInningsComplete = true;

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

                    if (secondInningsComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
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
                    Console.WriteLine("-----------");

                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }

                //computer bowler #2

                currentBowler = playerBowler2;
                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;


                //bowl over
                while (numberOfBalls < 6 && secondInningsComplete == false)
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
                        Console.WriteLine(" Team " + sideNotPicked + " : " + secondInningsTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            secondInningsComplete = true;
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

                    if (secondInningsComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
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

                //computer bowler #3

                currentBowler = playerBowler3;
                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;


                //bowl over
                while (numberOfBalls < 6 && secondInningsComplete == false)
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
                        Console.WriteLine(" Team " + sideNotPicked + " : " + secondInningsTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            secondInningsComplete = true;
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

                    if (secondInningsComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
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

                //computer bowler #4

                currentBowler = playerBowler4;
                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;


                //bowl over
                while (numberOfBalls < 6 && secondInningsComplete == false)
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
                        Console.WriteLine(" Team " + sideNotPicked + " : " + secondInningsTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            secondInningsComplete = true;
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

                    if (secondInningsComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
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
            Console.WriteLine("Team " + sideNotPicked + " has scored " + secondInningsTotal + " in " + numberOfOvers +
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

            float runrate = secondInningsTotal / numberOfBalls1;

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

            Console.WriteLine("Innings Total: " + secondInningsTotal + " / " +
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

            return secondInningsTotal;

        }

        public static int ThirdInningPlayerTeamBats(int input)
        {
            //clear batting info for repopulation
            playerBatsmenScores.Clear();
            playerBatsmenDeliveriesPlayed.Clear();

            //clear bowling info for repopulation
            computerBowlerRuns.Clear();
            computerBowlerOvers.Clear();
            computerBowlerWickets.Clear();

            

            int battingWicketsLost = 0;
            int currentBatsmanScore = 0;
            int thirdInningTotal = 0;
            bool thirdInningComplete = false;
            int numberOfBalls = 0;
            int index = 0;
            int numberOfOvers = 0;
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

            computerBowler1Overs = 0;
            computerBowler2Overs = 0;
            computerBowler3Overs = 0;
            computerBowler4Overs = 0;

            computerBowler1Runs = 0;
            computerBowler2Runs = 0;
            computerBowler3Runs = 0;
            computerBowler4Runs = 0;

            computerBowler1Wickets = 0;
            computerBowler2Wickets = 0;
            computerBowler3Wickets = 0;
            computerBowler4Wickets = 0;

            //Console.WriteLine("HELLO12");

            while (thirdInningComplete == false)
            {
                //computer bowler #1

                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;
                currentBowler = computerBowler1;

                //bowl over
                while (numberOfBalls < 6 && thirdInningComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 15);

                    if (!(battingScore == bowlingScore))
                    {
                        thirdInningTotal += battingScore;
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
                        Console.WriteLine(" Team " + sidePicked + " : " + thirdInningTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {

                            thirdInningComplete = true;

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

                    if (thirdInningComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                computerBowler1Runs += currentBowlerRuns;
                computerBowler1Wickets += currentBowlerWickets;
                computerBowler1Overs += currentBowlerOvers;

                if (thirdInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + thirdInningTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    if(input + thirdInningTotal >= 0)
                    {
                        Console.WriteLine("         ");
                        Console.WriteLine("Current lead is: " + (thirdInningTotal + input));
                        Console.WriteLine("         ");
                    }
                    else if(input + thirdInningTotal < 0)
                    {
                        Console.WriteLine("         ");
                        Console.WriteLine("Still trailing by: " + (-(thirdInningTotal + input)));
                        Console.WriteLine("         ");
                    }
                    
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
                while (numberOfBalls < 6 && thirdInningComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        thirdInningTotal += battingScore;
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
                        Console.WriteLine(" Team " + sidePicked + " : " + thirdInningTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            thirdInningComplete = true;
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

                    if (thirdInningComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                computerBowler2Runs += currentBowlerRuns;
                computerBowler2Wickets += currentBowlerWickets;
                computerBowler2Overs += currentBowlerOvers;

                if (thirdInningComplete == false)
                {

                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + thirdInningTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    if (input + thirdInningTotal >= 0)
                    {
                        Console.WriteLine("         ");
                        Console.WriteLine("Current lead is: " + (thirdInningTotal + input));
                        Console.WriteLine("         ");
                    }
                    else if (input + thirdInningTotal < 0)
                    {
                        Console.WriteLine("         ");
                        Console.WriteLine("Still trailing by: " + (-(thirdInningTotal + input)));
                        Console.WriteLine("         ");
                    }

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
                while (numberOfBalls < 6 && thirdInningComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        thirdInningTotal += battingScore;
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
                        Console.WriteLine(" Team " + sidePicked + " : " + thirdInningTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            thirdInningComplete = true;
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

                    if (thirdInningComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                computerBowler3Runs += currentBowlerRuns;
                computerBowler3Wickets += currentBowlerWickets;
                computerBowler3Overs += currentBowlerOvers;

                if (thirdInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + thirdInningTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    if (input + thirdInningTotal >= 0)
                    {
                        Console.WriteLine("         ");
                        Console.WriteLine("Current lead is: " + (thirdInningTotal + input));
                        Console.WriteLine("         ");
                    }
                    else if (input + thirdInningTotal < 0)
                    {
                        Console.WriteLine("         ");
                        Console.WriteLine("Still trailing by: " + (-(thirdInningTotal + input)));
                        Console.WriteLine("         ");
                    }

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
                while (numberOfBalls < 6 && thirdInningComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        thirdInningTotal += battingScore;
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
                        Console.WriteLine(" Team " + sidePicked + " : " + thirdInningTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            thirdInningComplete = true;
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

                    if (thirdInningComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                computerBowler4Runs += currentBowlerRuns;
                computerBowler4Wickets += currentBowlerWickets;
                computerBowler4Overs += currentBowlerOvers;

                if (thirdInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + thirdInningTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    if (input + thirdInningTotal >= 0)
                    {
                        Console.WriteLine("         ");
                        Console.WriteLine("Current lead is: " + (thirdInningTotal + input));
                        Console.WriteLine("         ");
                    }
                    else if (input + thirdInningTotal < 0)
                    {
                        Console.WriteLine("         ");
                        Console.WriteLine("Still trailing by: " + (-(thirdInningTotal + input)));
                        Console.WriteLine("         ");
                    }

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
            Console.WriteLine("Team " + sidePicked + " has scored " + thirdInningTotal + " in " + numberOfOvers +
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
                else if (playerBatsmenDeliveriesPlayed[index] == 0)
                {
                    battingStrikeRate.Add("N/A");
                }
                index += 1;
            }

            //run rate
            float ballsOver = 6f;

            float numberOfBalls1 = numberOfOvers + (sumWhoopie / ballsOver);

            float runrate = thirdInningTotal / numberOfBalls1;

            int numberBatsmenPrinted = 0;
            index = 0;

            Console.WriteLine("Batting Scorecard: ");
            Console.WriteLine("        ");

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

            Console.WriteLine("Innings Total: " + thirdInningTotal + " / " +
                battingWicketsLost + ". Run rate: " + runrate);
            Console.WriteLine("     ");

            //bowling economy
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

            while (index < 4)
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

            Console.WriteLine("Bowling Scorecard:");
            Console.WriteLine("        ");

            int XnumberBowlersPrinted = 0;
            index = 0;

            while (XnumberBowlersPrinted < 4)
            {
                Console.WriteLine(computerBowlers[index] + ". Overs:  " + computerBowlerOvers[index] + "."
                    + whoopie[index] + ".  Runs: " +
                    computerBowlerRuns[index] + ". Wickets: " + computerBowlerWickets[index] +
                    ". Economy: " + economyRate[index] + ". " /*"Strike Rate: " +
                    strikeRate[index] + ". Average: " + average[index]*/);
                index += 1;
                XnumberBowlersPrinted += 1;
                Console.WriteLine("     ");
            }

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            return thirdInningTotal;

        }

        public static int FourthInningComputerTeamBats(int input)
        {
            //clear batting info for repopulation
            computerBatsmenScores.Clear();
            computerBatsmenDeliveriesPlayed.Clear();

            //clear bowling info for repopulation
            playerBowlerRuns.Clear();
            playerBowlerOvers.Clear();
            playerBowlerWickets.Clear();


            int battingWicketsLost = 0;
            int fourthInningTotal = 0;
            int currentBatsmanScore = 0;
            bool fourthInningComplete = false;
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

            playerBowler1Overs = 0;
            playerBowler2Overs = 0;
            playerBowler3Overs = 0;
            playerBowler4Overs = 0;

            playerBowler1Wickets = 0;
            playerBowler2Wickets = 0;
            playerBowler3Wickets = 0;
            playerBowler4Wickets = 0;

            playerBowler1Runs = 0;
            playerBowler2Runs = 0;
            playerBowler3Runs = 0;
            playerBowler4Runs = 0;

            while (fourthInningComplete == false && gameOver == false)
            {
                //player bowler #1

                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;
                currentBowler = playerBowler1;

                //bowl over
                while (numberOfBalls < 6 && fourthInningComplete == false && gameOver == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 15);

                    if (!(battingScore == bowlingScore))
                    {
                        fourthInningTotal += battingScore;
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

                        if (fourthInningTotal > input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine("       ");
                            gameOver = true;
                            fourthInningComplete = true;
                            playerNotOut = true;
                            string playerC = computerTeam[battingWicketsLost];
                            computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            computerBatsmenScores.Add(currentBatsmanScore);
                            Console.WriteLine(playerC + " is not out on " + currentBatsmanScore);
                            computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            computerBatsmenScores.Add(currentBatsmanScore);
                            // team2Wins += 1;
                            Console.WriteLine("       ");
                            Console.WriteLine("The fourth innings total is " + fourthInningTotal + " (for the loss of " + battingWicketsLost
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
                        Console.WriteLine(" Team " + sideNotPicked + " : " + fourthInningTotal + " / " + battingWicketsLost);

                        if (battingWicketsLost < 10)
                        {
                            Console.WriteLine(" Team " + sideNotPicked + " needs " + (input - fourthInningTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");

                        }

                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10 && fourthInningTotal == input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            fourthInningComplete = true;
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
                        if (battingWicketsLost == 10 && fourthInningTotal < input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            fourthInningComplete = true;
                            // team1Wins += 1;
                            Console.WriteLine("Team " + sideNotPicked + " has only scored " + fourthInningTotal + " and has thus lost " +
                                " the game by " + (input - fourthInningTotal) + " runs.");
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

                if (fourthInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sideNotPicked + " : " + fourthInningTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + playerBowler1Overs + ". Runs: " +
                        playerBowler1Runs + ". Wickets: " + playerBowler1Wickets);
                    Console.WriteLine("         ");
                    string player = computerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("          ");
                    Console.WriteLine(" Team " + sideNotPicked + " needs " + (input + 1 - fourthInningTotal) +
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
                while (numberOfBalls < 6 && fourthInningComplete == false && gameOver == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        fourthInningTotal += battingScore;
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

                        if (fourthInningTotal > input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine("       ");
                            gameOver = true;
                            fourthInningComplete = true;
                            playerNotOut = true;
                            string playerC = computerTeam[battingWicketsLost];
                            computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            computerBatsmenScores.Add(currentBatsmanScore);
                            Console.WriteLine(playerC + " is not out on " + currentBatsmanScore);
                            // team2Wins += 1;
                            Console.WriteLine("       ");
                            Console.WriteLine("The fourth innings total is " + fourthInningTotal + " (for the loss of " + battingWicketsLost
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
                        Console.WriteLine(" Team " + sideNotPicked + " : " + fourthInningTotal + " / " + battingWicketsLost);

                        if (battingWicketsLost < 10)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine(" Team " + sideNotPicked + " needs " + (input + 1 - fourthInningTotal)
                                +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");

                        }

                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10 && fourthInningTotal == input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            fourthInningComplete = true;
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
                        if (battingWicketsLost == 10 && fourthInningTotal < input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            fourthInningComplete = true;
                            // team1Wins += 1;
                            Console.WriteLine("Team " + sideNotPicked + " has only scored " + fourthInningTotal + " and has thus lost " +
                                " the game by " + (input - fourthInningTotal) + " runs.");
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

                if (fourthInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sideNotPicked + " : " + fourthInningTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + playerBowler2Overs + ". Runs: " +
                        playerBowler2Runs + ". Wickets: " + playerBowler2Wickets);
                    Console.WriteLine("         ");
                    string player = computerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("          ");
                    Console.WriteLine(" Team " + sideNotPicked + " needs " + (input + 1 - fourthInningTotal) +
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
                while (numberOfBalls < 6 && fourthInningComplete == false && gameOver == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        fourthInningTotal += battingScore;
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

                        if (fourthInningTotal > input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine("       ");
                            gameOver = true;
                            fourthInningComplete = true;
                            playerNotOut = true;
                            string playerC = computerTeam[battingWicketsLost];
                            computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            computerBatsmenScores.Add(currentBatsmanScore);
                            Console.WriteLine(playerC + " is not out on " + currentBatsmanScore);
                            // team2Wins += 1;
                            Console.WriteLine("       ");
                            Console.WriteLine("The second innings total is " + fourthInningTotal + " (for the loss of " + battingWicketsLost
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
                        Console.WriteLine(" Team " + sideNotPicked + " : " + fourthInningTotal + " / " + battingWicketsLost);

                        if (battingWicketsLost < 10)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine(" Team " + sideNotPicked + " needs " + (input + 1 - fourthInningTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");
                        }

                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10 && fourthInningTotal == input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            fourthInningComplete = true;
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
                        if (battingWicketsLost == 10 && fourthInningTotal < input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            fourthInningComplete = true;
                            // team1Wins += 1;
                            Console.WriteLine("Team " + sideNotPicked + " has only scored " + fourthInningTotal + " and has thus lost " +
                                " the game by " + (input - fourthInningTotal) + " runs.");

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

                if (fourthInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sideNotPicked + " : " + fourthInningTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + playerBowler3Overs + ". Runs: " +
                        playerBowler3Runs + ". Wickets: " + playerBowler3Wickets);
                    Console.WriteLine("         ");
                    string player = computerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("          ");
                    Console.WriteLine(" Team " + sideNotPicked + " needs " + (input + 1 - fourthInningTotal) +
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
                while (numberOfBalls < 6 && fourthInningComplete == false && gameOver == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        fourthInningTotal += battingScore;
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

                        if (fourthInningTotal > input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine("       ");
                            gameOver = true;
                            fourthInningComplete = true;
                            playerNotOut = true;
                            string playerC = computerTeam[battingWicketsLost];
                            computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            computerBatsmenScores.Add(currentBatsmanScore);
                            Console.WriteLine(playerC + " is not out on " + currentBatsmanScore);
                            // team2Wins += 1;
                            Console.WriteLine("       ");
                            Console.WriteLine("The second innings total is " + fourthInningTotal + " (for the loss of " + battingWicketsLost
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
                        Console.WriteLine(" Team " + sideNotPicked + " : " + fourthInningTotal + " / " + battingWicketsLost);

                        if (battingWicketsLost < 10)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine(" Team " + sideNotPicked + " needs " + (input + 1 - fourthInningTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");
                        }

                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10 && fourthInningTotal == input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            fourthInningComplete = true;
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
                        if (battingWicketsLost == 10 && fourthInningTotal < input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            fourthInningComplete = true;
                            // team1Wins += 1;
                            Console.WriteLine("Team " + sideNotPicked + " has only scored " + fourthInningTotal + " and has thus lost " +
                                " the game by " + (input - fourthInningTotal) + " runs.");

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

                if (fourthInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sideNotPicked + " : " + fourthInningTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + playerBowler4Overs + ". Runs: " +
                        playerBowler4Runs + ". Wickets: " + playerBowler4Wickets);
                    Console.WriteLine("         ");
                    string player = computerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("          ");
                    Console.WriteLine(" Team " + sideNotPicked + " needs " + (input + 1 - fourthInningTotal) +
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
            Console.WriteLine("Team " + sideNotPicked + " has scored " + fourthInningTotal + " in " + numberOfOvers +
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

            while (index < chasingWicketLost - 1)
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
                    computerBatsmenDeliveriesPlayed[index] + ") not out.");
                }
            }

            //total and overall runrate

            float ballsOver1 = 6f;

            float overs = numberOfOvers + (sumWhoopie / ballsOver1);

            float runrate = fourthInningTotal / overs;

            Console.WriteLine("    ");

            Console.WriteLine("Innings Total: " + fourthInningTotal + " / " +
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

            return fourthInningTotal;
        }

        //************************************************************//

        //computer team bats first

        public static int FirstInningComputerTeamBats()
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

        public static int SecondInningPlayerTeamBats()
        {
            int battingWicketsLost = 0;
            int currentBatsmanScore = 0;
            int secondInningTotal = 0;
            bool secondInningComplete = false;
            int numberOfBalls = 0;
            int index = 0;
            int numberOfOvers = 0;
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

            while (secondInningComplete == false)
            {
                //computer bowler #1

                //Console.WriteLine("HELLO1");
                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;
                currentBowler = computerBowler1;

                //bowl over
                while (numberOfBalls < 6 && secondInningComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 15);

                    if (!(battingScore == bowlingScore))
                    {
                        secondInningTotal += battingScore;
                        currentBatsmanScore += battingScore;
                        currentBowlerRuns += battingScore;
                        currentBatsmanDeliveriesPlayed += 1;
                        string player = playerTeam[battingWicketsLost];
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : " +
                            battingScore + " runs.");

                        Console.WriteLine("        ");
                        Console.Write("Press Enter to continue!");
                        Console.ReadLine(); //

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
                        Console.WriteLine(" Team " + sidePicked + " : " + secondInningTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            //Console.WriteLine("HELLO5");
                            secondInningComplete = true;

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

                    if (secondInningComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                computerBowler1Runs += currentBowlerRuns;
                computerBowler1Wickets += currentBowlerWickets;
                computerBowler1Overs += currentBowlerOvers;

                if (secondInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + secondInningTotal + " / " + battingWicketsLost + " in "
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
                //Console.WriteLine("HELLO2");
                currentBowler = computerBowler2;
                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;


                //bowl over
                while (numberOfBalls < 6 && secondInningComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        secondInningTotal += battingScore;
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
                        Console.WriteLine(" Team " + sidePicked + " : " + secondInningTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            //Console.WriteLine("HELLO5");
                            secondInningComplete = true;
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

                    if (secondInningComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                computerBowler2Runs += currentBowlerRuns;
                computerBowler2Wickets += currentBowlerWickets;
                computerBowler2Overs += currentBowlerOvers;

                if (secondInningComplete == false)
                {

                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + secondInningTotal + " / " + battingWicketsLost + " in "
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
                //Console.WriteLine("HELLO3");
                currentBowler = computerBowler3;
                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;


                //bowl over
                while (numberOfBalls < 6 && secondInningComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        secondInningTotal += battingScore;
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
                        Console.WriteLine(" Team " + sidePicked + " : " + secondInningTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            //Console.WriteLine("HELLO5");
                            secondInningComplete = true;
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

                    if (secondInningComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                computerBowler3Runs += currentBowlerRuns;
                computerBowler3Wickets += currentBowlerWickets;
                computerBowler3Overs += currentBowlerOvers;

                if (secondInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + secondInningTotal + " / " + battingWicketsLost + " in "
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
                //Console.WriteLine("HELLO4");
                currentBowler = computerBowler4;
                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;


                //bowl over
                while (numberOfBalls < 6 && secondInningComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        secondInningTotal += battingScore;
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
                        Console.WriteLine(" Team " + sidePicked + " : " + secondInningTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            //Console.WriteLine("HELLO5");
                            secondInningComplete = true;
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

                    if (secondInningComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                computerBowler4Runs += currentBowlerRuns;
                computerBowler4Wickets += currentBowlerWickets;
                computerBowler4Overs += currentBowlerOvers;

                if (secondInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + secondInningTotal + " / " + battingWicketsLost + " in "
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

            //Console.WriteLine("HELLO6");

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
            Console.WriteLine("Team " + sidePicked + " has scored " + secondInningTotal + " in " + numberOfOvers +
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
                else if (playerBatsmenDeliveriesPlayed[index] == 0)
                {
                    battingStrikeRate.Add("N/A");
                }
                index += 1;
            }

            //run rate
            float ballsOver = 6f;

            float numberOfBalls1 = numberOfOvers + (sumWhoopie / ballsOver);

            float runrate = secondInningTotal / numberOfBalls1;

            int numberBatsmenPrinted = 0;
            index = 0;

            Console.WriteLine("Batting Scorecard: ");
            Console.WriteLine("        ");

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

            Console.WriteLine("Innings Total: " + secondInningTotal + " / " +
                battingWicketsLost + ". Run rate: " + runrate);
            Console.WriteLine("     ");

            //bowling economy
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

            while (index < 4)
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

            //Console.WriteLine("HELLO7");
            return secondInningTotal;

        }

        public static int ThirdInningComputerTeamBats(int input)
        {

            int battingWicketsLost = 0;
            int currentBatsmanScore = 0;
            int thirdInningTotal = 0;
            bool thirdInningComplete = false;
            int numberOfBalls = 0;
            int index = 0;
            int numberOfOvers = 0;
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

            playerBowler1Overs = 0;
            playerBowler2Overs = 0;
            playerBowler3Overs = 0;
            playerBowler4Overs = 0;

            playerBowler1Runs = 0;
            playerBowler2Runs = 0;
            playerBowler3Runs = 0;
            playerBowler4Runs = 0;

            playerBowler1Wickets = 0;
            playerBowler2Wickets = 0;
            playerBowler3Wickets = 0;
            playerBowler4Wickets = 0; 

            //Console.WriteLine("HELLO12");

            while (thirdInningComplete == false)
            {
                //computer bowler #1

                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;
                currentBowler = playerBowler1;

                //bowl over
                while (numberOfBalls < 6 && thirdInningComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 15);

                    if (!(battingScore == bowlingScore))
                    {
                        thirdInningTotal += battingScore;
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
                        Console.WriteLine(" Team " + sideNotPicked + " : " + thirdInningTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {

                            thirdInningComplete = true;

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

                    if (thirdInningComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                playerBowler1Runs += currentBowlerRuns;
                playerBowler1Wickets += currentBowlerWickets;
                playerBowler1Overs += currentBowlerOvers;

                if (thirdInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sideNotPicked + " : " + thirdInningTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    //left off figuring out the lead situation.
                    if (input - thirdInningTotal >= 0)
                    {
                        Console.WriteLine("         ");
                        Console.WriteLine("Your team is leading by: " + (input - thirdInningTotal));
                        Console.WriteLine("         ");
                    }
                    else if (input - thirdInningTotal < 0)
                    {
                        Console.WriteLine("         ");
                        Console.WriteLine("Your team is trailing by: " + (-(input - thirdInningTotal)));
                        Console.WriteLine("         ");
                    }

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

                //computer bowler #2

                currentBowler = playerBowler2;
                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;


                //bowl over
                while (numberOfBalls < 6 && thirdInningComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        thirdInningTotal += battingScore;
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
                        Console.WriteLine(" Team " + sideNotPicked + " : " + thirdInningTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            thirdInningComplete = true;
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

                    if (thirdInningComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                playerBowler2Runs += currentBowlerRuns;
                playerBowler2Wickets += currentBowlerWickets;
                playerBowler2Overs += currentBowlerOvers;

                if (thirdInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sideNotPicked + " : " + thirdInningTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    //left off figuring out the lead situation.
                    if (input - thirdInningTotal >= 0)
                    {
                        Console.WriteLine("         ");
                        Console.WriteLine("Your team is leading by: " + (input - thirdInningTotal));
                        Console.WriteLine("         ");
                    }
                    else if (input - thirdInningTotal < 0)
                    {
                        Console.WriteLine("         ");
                        Console.WriteLine("Your team is trailing by: " + (-(input - thirdInningTotal)));
                        Console.WriteLine("         ");
                    }

                    Console.WriteLine(currentBowler + ". Overs: " + playerBowler2Overs + ". Runs: " +
                        playerBowler2Runs + ". Wickets: " + playerBowler2Wickets);
                    Console.WriteLine("         ");
                    string player = computerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("-----------");

                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }

                //computer bowler #3

                currentBowler = playerBowler3;
                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;


                //bowl over
                while (numberOfBalls < 6 && thirdInningComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        thirdInningTotal += battingScore;
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
                        Console.WriteLine(" Team " + sideNotPicked + " : " + thirdInningTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            thirdInningComplete = true;
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

                    if (thirdInningComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                playerBowler3Runs += currentBowlerRuns;
                playerBowler3Wickets += currentBowlerWickets;
                playerBowler3Overs += currentBowlerOvers;

                if (thirdInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sideNotPicked + " : " + thirdInningTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    //left off figuring out the lead situation.
                    if (input - thirdInningTotal >= 0)
                    {
                        Console.WriteLine("         ");
                        Console.WriteLine("Your team is leading by: " + (input - thirdInningTotal));
                        Console.WriteLine("         ");
                    }
                    else if (input - thirdInningTotal < 0)
                    {
                        Console.WriteLine("         ");
                        Console.WriteLine("Your team is trailing by: " + (-(input - thirdInningTotal)));
                        Console.WriteLine("         ");
                    }

                    Console.WriteLine(currentBowler + ". Overs: " + playerBowler3Overs + ". Runs: " +
                        playerBowler3Runs + ". Wickets: " + playerBowler3Wickets);
                    Console.WriteLine("         ");
                    string player = computerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("-----------");

                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }

                //computer bowler #4

                currentBowler = playerBowler4;
                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;


                //bowl over
                while (numberOfBalls < 6 && thirdInningComplete == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        thirdInningTotal += battingScore;
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
                        Console.WriteLine(" Team " + sideNotPicked + " : " + thirdInningTotal + " / " + battingWicketsLost);
                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10)
                        {
                            thirdInningComplete = true;
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

                    if (thirdInningComplete == true && numberOfBalls < 6)
                    {
                        overIncomplete = true;
                    }
                }

                playerBowler4Runs += currentBowlerRuns;
                playerBowler4Wickets += currentBowlerWickets;
                playerBowler4Overs += currentBowlerOvers;

                if (thirdInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sideNotPicked + " : " + thirdInningTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    //left off figuring out the lead situation.
                    if (input - thirdInningTotal >= 0)
                    {
                        Console.WriteLine("         ");
                        Console.WriteLine("Your team is leading by: " + (input - thirdInningTotal));
                        Console.WriteLine("         ");
                    }
                    else if (input - thirdInningTotal < 0)
                    {
                        Console.WriteLine("         ");
                        Console.WriteLine("Your team is trailing by: " + (-(input - thirdInningTotal)));
                        Console.WriteLine("         ");
                    }

                    Console.WriteLine(currentBowler + ". Overs: " + playerBowler4Overs + ". Runs: " +
                        playerBowler4Runs + ". Wickets: " + playerBowler4Wickets);
                    Console.WriteLine("         ");
                    string player = computerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("-----------");

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
            Console.WriteLine("Team " + sidePicked + " has scored " + thirdInningTotal + " in " + numberOfOvers +
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

            float runrate = thirdInningTotal / numberOfBalls1;

            int numberBatsmenPrinted = 0;
            index = 0;

            Console.WriteLine("Batting Scorecard: ");
            Console.WriteLine("        ");

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

            Console.WriteLine("Innings Total: " + thirdInningTotal + " / " +
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

            int XnumberBowlersPrinted = 0;
            index = 0;

            while (XnumberBowlersPrinted < 4)
            {
                Console.WriteLine(playerBowlers[index] + ". Overs:  " + playerBowlerOvers[index] + "."
                    + whoopie[index] + ".  Runs: " +
                    playerBowlerRuns[index] + ". Wickets: " + playerBowlerWickets[index] +
                    ". Economy: " + economyRate[index] + ". " /*"Strike Rate: " +
                    strikeRate[index] + ". Average: " + average[index]*/);
                index += 1;
                XnumberBowlersPrinted += 1;
                Console.WriteLine("     ");
            }

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            return thirdInningTotal;

        }

        public static int FourthInningPlayerTeamBats(int input)
        {
            int battingWicketsLost = 0;
            int fourthInningTotal = 0;
            int currentBatsmanScore = 0;
            bool fourthInningComplete = false;
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

            computerBowler1Overs = 0;
            computerBowler2Overs = 0;
            computerBowler3Overs = 0;
            computerBowler4Overs = 0;

            computerBowler1Wickets = 0;
            computerBowler2Wickets = 0;
            computerBowler3Wickets = 0;
            computerBowler4Wickets = 0;

            computerBowler1Runs = 0;
            computerBowler2Runs = 0;
            computerBowler3Runs = 0;
            computerBowler4Runs = 0;

            while (fourthInningComplete == false && gameOver == false)
            {
                //player bowler #1

                currentBowlerRuns = 0;
                currentBowlerWickets = 0;
                currentBowlerOvers = 0;
                numberOfBalls = 0;
                currentBowler = computerBowler1;

                //bowl over
                while (numberOfBalls < 6 && fourthInningComplete == false && gameOver == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 15);

                    if (!(battingScore == bowlingScore))
                    {
                        fourthInningTotal += battingScore;
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

                        if (fourthInningTotal > input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine("       ");
                            gameOver = true;
                            fourthInningComplete = true;
                            playerNotOut = true;
                            string playerC = playerTeam[battingWicketsLost];
                            playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            playerBatsmenScores.Add(currentBatsmanScore);
                            Console.WriteLine(playerC + " is not out on " + currentBatsmanScore);
                            // team2Wins += 1;
                            Console.WriteLine("       ");
                            Console.WriteLine("The fourth innings total is " + fourthInningTotal + " (for the loss of " + battingWicketsLost
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
                        Console.WriteLine(" Team " + sidePicked + " : " + fourthInningTotal + " / " + battingWicketsLost);

                        if (battingWicketsLost < 10)
                        {
                            Console.WriteLine(" Team " + sidePicked + " needs " + (input - fourthInningTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");

                        }

                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10 && fourthInningTotal == input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            fourthInningComplete = true;
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
                        if (battingWicketsLost == 10 && fourthInningTotal < input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            fourthInningComplete = true;
                            // team1Wins += 1;
                            Console.WriteLine("Team " + sidePicked + " has only scored " + fourthInningTotal + " and has thus lost " +
                                " the game by " + (input - fourthInningTotal) + " runs.");
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

                if (fourthInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + fourthInningTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + computerBowler1Overs + ". Runs: " +
                        computerBowler1Runs + ". Wickets: " + computerBowler1Wickets);
                    Console.WriteLine("         ");
                    string player = playerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("          ");
                    Console.WriteLine(" Team " + sidePicked + " needs " + (input + 1 - fourthInningTotal) +
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
                currentBowler = computerBowler2;


                //bowl over
                while (numberOfBalls < 6 && fourthInningComplete == false && gameOver == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        fourthInningTotal += battingScore;
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

                        if (fourthInningTotal > input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine("       ");
                            gameOver = true;
                            fourthInningComplete = true;
                            playerNotOut = true;
                            string playerC = playerTeam[battingWicketsLost];
                            playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            playerBatsmenScores.Add(currentBatsmanScore);
                            Console.WriteLine(playerC + " is not out on " + currentBatsmanScore);
                            // team2Wins += 1;
                            Console.WriteLine("       ");
                            Console.WriteLine("The fourth innings total is " + fourthInningTotal + " (for the loss of " + battingWicketsLost
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
                        Console.WriteLine(" Team " + sidePicked + " : " + fourthInningTotal + " / " + battingWicketsLost);

                        if (battingWicketsLost < 10)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine(" Team " + sidePicked + " needs " + (input + 1 - fourthInningTotal)
                                +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");

                        }

                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10 && fourthInningTotal == input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            fourthInningComplete = true;
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
                        if (battingWicketsLost == 10 && fourthInningTotal < input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            fourthInningComplete = true;
                            // team1Wins += 1;
                            Console.WriteLine("Team " + sidePicked + " has only scored " + fourthInningTotal + " and has thus lost " +
                                " the game by " + (input - fourthInningTotal) + " runs.");
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

                if (fourthInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + fourthInningTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + computerBowler2Overs + ". Runs: " +
                        computerBowler2Runs + ". Wickets: " + computerBowler2Wickets);
                    Console.WriteLine("         ");
                    string player = playerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("          ");
                    Console.WriteLine(" Team " + sidePicked + " needs " + (input + 1 - fourthInningTotal) +
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
                currentBowler = computerBowler3;


                //bowl over
                while (numberOfBalls < 6 && fourthInningComplete == false && gameOver == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        fourthInningTotal += battingScore;
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

                        if (fourthInningTotal > input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine("       ");
                            gameOver = true;
                            fourthInningComplete = true;
                            playerNotOut = true;
                            string playerC = playerTeam[battingWicketsLost];
                            playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            playerBatsmenScores.Add(currentBatsmanScore);
                            Console.WriteLine(playerC + " is not out on " + currentBatsmanScore);
                            // team2Wins += 1;
                            Console.WriteLine("       ");
                            Console.WriteLine("The fourth innings total is " + fourthInningTotal + " (for the loss of " + battingWicketsLost
                             + " wickets) and so Team " + sidePicked + " won the game.");

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
                        string player = playerTeam[battingWicketsLost - 1];
                        playerBatsmenScores.Add(currentBatsmanScore);
                        playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine("      ");
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sidePicked + " : " + fourthInningTotal + " / " + battingWicketsLost);

                        if (battingWicketsLost < 10)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine(" Team " + sidePicked + " needs " + (input + 1 - fourthInningTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");
                        }

                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10 && fourthInningTotal == input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            fourthInningComplete = true;
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
                        if (battingWicketsLost == 10 && fourthInningTotal < input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            fourthInningComplete = true;
                            // team1Wins += 1;
                            Console.WriteLine("Team " + sidePicked + " has only scored " + fourthInningTotal + " and has thus lost " +
                                " the game by " + (input - fourthInningTotal) + " runs.");

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

                computerBowler3Runs += currentBowlerRuns;
                computerBowler3Wickets += currentBowlerWickets;
                computerBowler3Overs += currentBowlerOvers;

                if (fourthInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + fourthInningTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + computerBowler3Overs + ". Runs: " +
                        computerBowler3Runs + ". Wickets: " + computerBowler3Wickets);
                    Console.WriteLine("         ");
                    string player = playerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("          ");
                    Console.WriteLine(" Team " + sidePicked + " needs " + (input + 1 - fourthInningTotal) +
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
                currentBowler = computerBowler4;


                //bowl over
                while (numberOfBalls < 6 && fourthInningComplete == false && gameOver == false)
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    Random rbowlingScore = new Random();
                    int bowlingScore = rbowlingScore.Next(0, 10);

                    if (!(battingScore == bowlingScore))
                    {
                        fourthInningTotal += battingScore;
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

                        if (fourthInningTotal > input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine("       ");
                            gameOver = true;
                            fourthInningComplete = true;
                            playerNotOut = true;
                            string playerC = playerTeam[battingWicketsLost];
                            playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                            playerBatsmenScores.Add(currentBatsmanScore);
                            Console.WriteLine(playerC + " is not out on " + currentBatsmanScore);
                            // team2Wins += 1;
                            Console.WriteLine("       ");
                            Console.WriteLine("The fourth innings total is " + fourthInningTotal + " (for the loss of " + battingWicketsLost
                             + " wickets) and so Team " + sidePicked + " won the game.");

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
                        string player = playerTeam[battingWicketsLost - 1];
                        playerBatsmenScores.Add(currentBatsmanScore);
                        playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        Console.WriteLine("      ");
                        Console.WriteLine(numberOfOvers + "." + (numberOfBalls + 1) + " - " +
                           currentBowler + " to " + player + " : OUT. "
                            + player + " : " + currentBatsmanScore + " ( " + currentBatsmanDeliveriesPlayed
                            + " ).");
                        Console.WriteLine(" Team " + sidePicked + " : " + fourthInningTotal + " / " + battingWicketsLost);

                        if (battingWicketsLost < 10)
                        {
                            chasingWicketLost = battingWicketsLost;
                            Console.WriteLine(" Team " + sidePicked + " needs " + (input + 1 - fourthInningTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");
                        }

                        currentBatsmanScore = 0;
                        currentBatsmanDeliveriesPlayed = 0;

                        if (battingWicketsLost == 10 && fourthInningTotal == input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            fourthInningComplete = true;
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
                        if (battingWicketsLost == 10 && fourthInningTotal < input)
                        {
                            chasingWicketLost = battingWicketsLost;
                            gameOver = true;
                            fourthInningComplete = true;
                            // team1Wins += 1;
                            Console.WriteLine("Team " + sidePicked + " has only scored " + fourthInningTotal + " and has thus lost " +
                                " the game by " + (input - fourthInningTotal) + " runs.");

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

                computerBowler4Runs += currentBowlerRuns;
                computerBowler4Wickets += currentBowlerWickets;
                computerBowler4Overs += currentBowlerOvers;

                if (fourthInningComplete == false)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" Team " + sidePicked + " : " + fourthInningTotal + " / " + battingWicketsLost + " in "
                        + numberOfOvers + " overs");
                    Console.WriteLine("         ");
                    Console.WriteLine(currentBowler + ". Overs: " + computerBowler4Overs + ". Runs: " +
                        computerBowler4Runs + ". Wickets: " + computerBowler4Wickets);
                    Console.WriteLine("         ");
                    string player = playerTeam[battingWicketsLost];
                    Console.WriteLine(player + " is not out on " + currentBatsmanScore + " (" +
                        currentBatsmanDeliveriesPlayed + ") ");
                    Console.WriteLine("          ");
                    Console.WriteLine(" Team " + sidePicked + " needs " + (input + 1 - fourthInningTotal) +
                             " runs to win with " + (10 - battingWicketsLost) + " wickets left.");
                    Console.WriteLine("-----------");

                    Console.Write("Press Enter to continue!");
                    Console.ReadLine();
                }
            }

            //what if a team gets all out in 2 overs? 
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
            Console.WriteLine("Team " + sidePicked + " has scored " + fourthInningTotal + " in " + numberOfOvers +
                "." + sumWhoopie +
                " overs.");

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            //bowling economy
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
                    economyRate.Add("--");
                }
                index += 1;
            }

            /*
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
            }*/

            //bowling average
            index = 0;

            while (index < 4)
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

            float runrate = fourthInningTotal / overs;

            Console.WriteLine("    ");

            Console.WriteLine("Innings Total: " + fourthInningTotal + " / " +
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
                Console.WriteLine("       ");
                index += 1;
                numberBowlersPrinted += 1;
            }

            return fourthInningTotal;
        }
    }
}