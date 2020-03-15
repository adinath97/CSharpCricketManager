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
        //FIX THE WHOOPIES!!!!!
        /* Find a way to end the game if the only available option is to pick a bowler who just bowled.
         * Keep a set of all the overs all the bowlers have, and after every over, check the set. If the
         set is ever empty, game over. */
         //ISSUES TO FIX:
         /* 1. Sometimes, batting score board is not correct. Seems to happen in the first innings
          * of semi-final games. Doesn't happen all the time
          2. */


        public static List<string> teams = new List<string> { "India", "New Zealand", "Pakistan"
        , "Australia", "West Indies", "Bangladesh", "England", "Sri Lanka"};

        //India
        public static List<string> squadIndiaBatsmen = new List<string> {"Rohit Sharma", "Virat Kohli",
        "Shikar Dhawan", "KL Rahul", "Yuvraj Singh"};

        public static List<string> squadIndiaKeepers = new List<string> { "Rishabh Pant" } ;
        public static List<string> squadIndiaAllRounders = new List<string> { "Hardik Pandya", "Ravindra Jadeja"};
        public static List<string> squadIndiaBowlers = new List<string> {"Jasprit Bumrah", "Ravichandan Ashwin",
            "Mohammad Shami", "Y. Chahal", "Kuldeep Yadav" };

        //New Zealand
        public static List<string> squadNewZealandBatsmen = new List<string> { "Colin Munro", "Martin Guptill",
        "Kane Williamson", "Ross Taylor", "Tom Latham"};
        public static List<string> squadNewZealandKeepers = new List<string> {"Brendan McCullum" };
        public static List<string> squadNewZealandAllRounders = new List<string> { "Mitchell Santner", "Daniel Vettori"};
        public static List<string> squadNewZealandBowlers = new List<string> { "Tim Southee", "Trent Boult", "Shane Bond",
        "Neil Wagner"};

        //England
        public static List<string> squadEnglandBatsmen = new List<string> { "Joe Root", "Alistair Cook", "Jos Buttler",
        "James Vince", "Eion Morgan"};
        public static List<string> squadEnglandKeepers = new List<string> { "Jonny Bairstow", "Matt Prior"};
        public static List<string> squadEnglandAllRounders = new List<string> { "Chris Woakes", "Ben Strokes", "Moeen Ali"};
        public static List<string> squadEnglandBowlers = new List<string> { "James Anderson", "Stuart Broad", "Jofra Archer"};

        //Australia
        public static List<string> squadAustraliaBatsmen = new List<string> { "David Warner", "Steven Smith",
        "Michael Clarke", "Shaun Marsh", "Ricky Ponting"};
        public static List<string> squadKAustraliaKeepers = new List<string> { "Adam Gilchrist", "Tim Paine",
        "Matthew Wade"};
        public static List<string> squadAustraliaAllRounders = new List<string> { "Glen Maxwell", "Mitchell Marsh" };
        public static List<string> squadAustraliaBowlers = new List<string> { "Mitchell Starc", "Josh Hazelwood", "Nathan Lyon",
        "James Pattinson"};

        //West Indies
        public static List<string> squadWestIndiesBatsmen = new List<string> {"Chris Gayle", "Darren Bravo",
        "Evin Lewis", "Lendl Simmons", "Shimron Hetmyer", "Dwayne Bravo", "Andre Russell"};
        public static List<string> squadWestIndiesKeepers = new List<string> { "Shai Hope"};
        public static List<string> squadWestIndiesAllRounders = new List<string> { "Darren Sammy", "Kieron Pollard", "Andre Russell"};
        public static List<string> squadWestIndiesBowlers = new List<string> {"Jason Holder", "Kesrick Williams", "Sunil Narine",
           "Hayden Walsh Jr."  };

        //Pakistan
        public static List<string> squadPakistanBatsmen = new List<string> { "Fakhar Zaman", "Babar Azam", "Shoaib Malik",
        "Mohammad Hafeez", "Umar Akmal"};
        public static List<string> squadPakistanKeepers = new List<string> {"Kamran Akmal", "Mohammad Rizwan" };
        public static List<string> squadPakistanAllRounders = new List<string> {"Shadab Khan" , "Shahid Afridi" };
        public static List<string> squadPakistanBowlers = new List<string> {"Imad Wasim", "Mohammad Amir", "Naseem Shah",
        "Shaheen Shah Afridi"};

        //Sri Lanka
        public static List<string> squadSriLankaBatsmen = new List<string> { "Kusal Mendis", "Niroshan Dickwella",
        "Angelo Matthews", "Aviska Ferando", "Shehan Jayasuriya"};
        public static List<string> squadSriLankaKeepers = new List<string> { "Kusal Perera"};
        public static List<string> squadSriLankaAllRounders = new List<string> { "Thisara Perera", "Jevan Mendis"};
        public static List<string> squadSriLankaBowlers = new List<string> { "Lasith Malinga", "Lahiru Kumara", "Nuwan Pradeep"};

        //Bangladesh
        public static List<string> squadBangladeshBatsmen = new List<string> { "Tamim Iqbal", "Soumya Sarkar",
        "Liton Das", "Sabbir Rahman", "Mahmadullah"};
        public static List<string> squadBangladeshKeepers = new List<string> { "Mushfiqur Rahim"};
        public static List<string> squadBangladeshAllRounders = new List<string> { "Shakib Al Hasan"};
        public static List<string> squadBangladeshBowlers = new List<string> { "Mashrafe Mortaza", "Taskin Ahmed"
        , "Mustafizur Rahman", "Rubel Hossain"};

        //List of all sets of batsmen
        public static List<List<string>> allTeamBatsmen = new List<List<string>> {squadIndiaBatsmen,
        squadNewZealandBatsmen, squadPakistanBatsmen, squadAustraliaBatsmen, squadWestIndiesBatsmen,
        squadBangladeshBatsmen, squadEnglandBatsmen, squadSriLankaBatsmen};

        //Lists of all sets of keepers
        public static List<List<string>> allTeamKeepers = new List<List<string>> {squadIndiaKeepers,
        squadNewZealandKeepers, squadPakistanKeepers, squadKAustraliaKeepers, squadWestIndiesKeepers,
        squadBangladeshKeepers, squadEnglandKeepers, squadSriLankaKeepers};

        //lists of all sets of allrounders
        public static List<List<string>> allTeamAllRounders = new List<List<string>> { squadIndiaAllRounders,
        squadNewZealandAllRounders, squadPakistanAllRounders, squadAustraliaAllRounders,
        squadWestIndiesAllRounders, squadBangladeshAllRounders, squadEnglandAllRounders,
        squadSriLankaAllRounders};

        //Lists of all sets of bowlers
        public static List<List<string>> allTeamBowlers = new List<List<string>> { squadIndiaBowlers,
        squadNewZealandBowlers, squadPakistanBowlers, squadAustraliaBowlers, squadWestIndiesBowlers,
        squadBangladeshBowlers, squadEnglandBowlers, squadSriLankaBowlers};

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

        public static List<string> opponentBatting = new List<string>();
        public static List<string> opponentKeeping = new List<string>();
        public static List<string> opponentAllRound = new List<string>();
        public static List<string> opponentBowling = new List<string>();
              
        public static List<string> playerBatting = new List<string>();
        public static List<string> playerKeeping = new List<string>();
        public static List<string> playerAllRound = new List<string>();
        public static List<string> playerBowling = new List<string>();

        public static List<string> computerWicketTakers = new List<string>();
        public static List<int> computerFallOfWicket_Runs = new List<int>();
        public static List<int> computerFallOfWicket_Wickets = new List<int>();

        public static List<string> playerWicketTakers = new List<string>();
        public static List<int> playerFallOfWicket_Runs = new List<int>();
        public static List<int> playerFallOfWicket_Wickets = new List<int>();

        public static int limitedOverVariation = 20;
        public static int bowlerUpperLimit;

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

        public static int battingScore;
        public static int bowlingScore;
        public static int r2d2;

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

        public static int compBowler1M;
        public static int compBowler2M;
        public static int compBowler3M;
        public static int compBowler4M;
        public static int compBowler5M;

        public static int compBowler1B;
        public static int compBowler2B;
        public static int compBowler3B;
        public static int compBowler4B;
        public static int compBowler5B;

        public static int playBowler1;
        public static int playBowler2;
        public static int playBowler3;
        public static int playBowler4;
        public static int playBowler5;

        public static int playBowler1M;
        public static int playBowler2M;
        public static int playBowler3M;
        public static int playBowler4M;
        public static int playBowler5M;

        public static int playBowler1B;
        public static int playBowler2B;
        public static int playBowler3B;
        public static int playBowler4B;
        public static int playBowler5B;

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

        public static string battleItOut1C;
        public static string battleItOut2C;

        public static List<string> bat1C = new List<string>();
        public static List<string> keep1C = new List<string>();
        public static List<string> allround1C = new List<string>();
        public static List<string> bowl1C = new List<string>();

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
        public static bool onlyOneOpponentLeft = false;

        public static int numberGamesOccured = 0;
        public static int opponent;

        public static bool playerKnockedOut = false;

        public static void Main(string[] args)
        {
            //choosing teams
            Console.WriteLine("Welcome to the survival T" + limitedOverVariation + " World Cup.");

            Console.WriteLine("------------");

            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("         ");

            Console.WriteLine("------------");

            Console.Write("This World Cup consists of 12 teams. Only 8 now remain: England, Australia" +
                ", India, New Zealand, West Indies, Pakistan, Sri Lanka, and Bangladesh. The knock-out" +
                " stage has begun. One loss, and you're eliminated. Pick your team from the list and enter" +
                "the name: ");

            PickAndCreateTeams();

            while (playerKnockedOut == false)
            {
                if(teams.Count < 8)
                {
                    NextGameTeams();
                }

                computerBowler1Runs = 0;
                computerBowler1Wickets = 0;
                computerBowler1Overs = 0;

                computerBowler2Runs = 0;
                computerBowler2Wickets = 0;
                computerBowler2Overs = 0;

                computerBowler3Runs = 0;
                computerBowler3Wickets = 0;
                computerBowler3Overs = 0;

                computerBowler4Runs = 0;
                computerBowler4Wickets = 0;
                computerBowler4Overs = 0;

                computerBowler5Runs = 0;
                computerBowler5Wickets = 0;
                computerBowler5Overs = 0;

                playerBowler1Runs = 0;
                playerBowler1Wickets = 0;
                playerBowler1Overs = 0;

                playerBowler2Runs = 0;
                playerBowler2Wickets = 0;
                playerBowler2Overs = 0;

                playerBowler3Runs = 0;
                playerBowler3Wickets = 0;
                playerBowler3Overs = 0;

                playerBowler4Runs = 0;
                playerBowler4Wickets = 0;
                playerBowler4Overs = 0;

                playerBowler5Runs = 0;
                playerBowler5Wickets = 0;
                playerBowler5Overs = 0;

                Toss();
                LetTheGamesBegin();
                OtherTeamsPlay();

                computerTeam.Clear();
                computerBatsmenDeliveriesPlayed.Clear();
                playerBatsmenDeliveriesPlayed.Clear();
                playerBatsmenScores.Clear();
                computerBatsmenScores.Clear();

                playerBowlerBowledOut.Clear();
                computerBowlerBowledOut.Clear();
                playerWicketTakers.Clear();
                computerWicketTakers.Clear();

                playerFallOfWicket_Runs.Clear();
                computerFallOfWicket_Runs.Clear();
                playerFallOfWicket_Wickets.Clear();
                computerFallOfWicket_Wickets.Clear();

                playerBowlerRuns.Clear();
                playerBowlerOvers.Clear();
                playerBowlerWickets.Clear();
                computerBowlerRuns.Clear();
                computerBowlerOvers.Clear();
                computerBowlerWickets.Clear();

                opponentBatting.Clear();
                opponentBowling.Clear();
                opponentAllRound.Clear();
                opponentKeeping.Clear();

                computerBowlers.Clear();
                //Console.WriteLine("MADE IT TILL HERE!");

                if (teams.Count == 1 && teams[0] == sidePicked)
                {
                    Console.WriteLine("      ");
                    Console.WriteLine("Congratulations! You are world champions!");
                    playerKnockedOut = true;
                }
            }
        }

        public static void PickAndCreateTeams()
        {

            sidePicked = Console.ReadLine();

            bool pickedASide = false;

            while (pickedASide == false)
            {
                if(sidePicked == "New Zealand")
                {
                    //pick player team from sets of Player players
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

                    int player = 1;

                    playerBatting = allTeamBatsmen[player];

                    while (playerTeam.Count < 5)
                    {
                        foreach (string x in playerBatting)
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
                            int result = playerBatting.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerBatting.Remove(playerSelection);

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

                    playerKeeping = allTeamKeepers[player];

                    while (playerTeam.Count > 4 && playerTeam.Count < 6)
                    {
                        foreach (string x in playerKeeping)
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
                            int result = playerKeeping.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerKeeping.Remove(playerSelection);

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

                    playerAllRound = allTeamAllRounders[player];

                    while (playerTeam.Count > 5 && playerTeam.Count < 7)
                    {
                        foreach (string x in playerAllRound)
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
                            int result = playerAllRound.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerAllRound.Remove(playerSelection);

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

                    playerBowling = allTeamBowlers[player];

                    while (playerTeam.Count < 10)
                    {
                        foreach (string x in playerBowling)
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
                            int result = playerBowling.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerBowling.Remove(playerSelection);

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

                    //computer picks players from sets of Opponent players

                    bool pickedOpponent = false;

                    while(pickedOpponent == false)
                    {
                        Random t1 = new Random();
                        opponent = t1.Next(0, teams.Count - 1);
                        sideNotPicked = teams[opponent];
                        if(!(sidePicked == sideNotPicked))
                        {
                            pickedOpponent = true;
                        }
                    }

                    int numberPlayersSelected = 0;

                    opponentBatting = allTeamBatsmen[opponent];
                    allTeamBatsmen.Remove(opponentBatting);
                    //select opponent batsmen
                    while (computerTeam.Count < 5)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentBatting.Count - 1);
                        playerSelection = opponentBatting[elementW];
                        computerTeam.Add(playerSelection);
                        opponentBatting.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent keeper
                    numberPlayersSelected = 0;

                    opponentKeeping = allTeamKeepers[opponent];
                    allTeamKeepers.Remove(opponentKeeping);

                    while (computerTeam.Count > 4 && computerTeam.Count < 6)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentKeeping.Count - 1);
                        playerSelection = opponentKeeping[elementW];
                        computerTeam.Add(playerSelection);
                        opponentKeeping.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent Allrounder
                    numberPlayersSelected = 0;

                    opponentAllRound = allTeamAllRounders[opponent];
                    allTeamAllRounders.Remove(opponentAllRound);

                    while (computerTeam.Count > 5 && computerTeam.Count < 7)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentAllRound.Count - 1);
                        playerSelection = opponentAllRound[elementW];
                        computerTeam.Add(playerSelection);
                        opponentAllRound.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent bowlers
                    numberPlayersSelected = 0;

                    opponentBowling = allTeamBowlers[opponent];
                    allTeamBowlers.Remove(opponentBowling);

                    while (computerTeam.Count < 10)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentBowling.Count - 1);
                        playerSelection = opponentBowling[elementW];
                        computerTeam.Add(playerSelection);
                        opponentBowling.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    Console.WriteLine("-----------");

                    Console.WriteLine("Your team, team " + sidePicked + ": ");

                    foreach (string x in playerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine(" ");

                    Console.WriteLine("-----------");
                    Console.WriteLine("Your opposition, team " + sideNotPicked + ": ");

                    foreach (string x in computerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine("  ");

                    pickedASide = true;

                }

                else if(sidePicked == "India")
                {
                    //pick player team from sets of Player players
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

                    int player = 0;

                    playerBatting = allTeamBatsmen[player];

                    while (playerTeam.Count < 5)
                    {
                        foreach (string x in playerBatting)
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
                            int result = playerBatting.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerBatting.Remove(playerSelection);

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

                    playerKeeping = allTeamKeepers[player];

                    while (playerTeam.Count > 4 && playerTeam.Count < 6)
                    {
                        foreach (string x in playerKeeping)
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
                            int result = playerKeeping.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerKeeping.Remove(playerSelection);

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

                    playerAllRound = allTeamAllRounders[player];

                    while (playerTeam.Count > 5 && playerTeam.Count < 7)
                    {
                        foreach (string x in playerAllRound)
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
                            int result = playerAllRound.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerAllRound.Remove(playerSelection);

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

                    playerBowling = allTeamBowlers[player];

                    while (playerTeam.Count < 10)
                    {
                        foreach (string x in playerBowling)
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
                            int result = playerBowling.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerBowling.Remove(playerSelection);

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

                    //computer picks players from sets of Opponent players
                    bool pickedOpponent = false;

                    while (pickedOpponent == false)
                    {
                        Random t1 = new Random();
                        opponent = t1.Next(0, teams.Count - 1);
                        sideNotPicked = teams[opponent];
                        if (!(sidePicked == sideNotPicked))
                        {
                            pickedOpponent = true;
                        }
                    }

                    int numberPlayersSelected = 0;

                    opponentBatting = allTeamBatsmen[opponent];
                    //select opponent batsmen
                    while (computerTeam.Count < 5)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentBatting.Count - 1);
                        playerSelection = opponentBatting[elementW];
                        computerTeam.Add(playerSelection);
                        opponentBatting.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent keeper
                    numberPlayersSelected = 0;

                    opponentKeeping = allTeamKeepers[opponent];

                    while (computerTeam.Count > 4 && computerTeam.Count < 6)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentKeeping.Count - 1);
                        playerSelection = opponentKeeping[elementW];
                        computerTeam.Add(playerSelection);
                        opponentKeeping.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent Allrounder
                    numberPlayersSelected = 0;

                    opponentAllRound = allTeamAllRounders[opponent];

                    while (computerTeam.Count > 5 && computerTeam.Count < 7)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentAllRound.Count - 1);
                        playerSelection = opponentAllRound[elementW];
                        computerTeam.Add(playerSelection);
                        opponentAllRound.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent bowlers
                    numberPlayersSelected = 0;

                    opponentBowling = allTeamBowlers[opponent];

                    while (computerTeam.Count < 10)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentBowling.Count - 1);
                        playerSelection = opponentBowling[elementW];
                        computerTeam.Add(playerSelection);
                        opponentBowling.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    Console.WriteLine("-----------");

                    Console.WriteLine("Your team, team " + sidePicked + ": ");

                    foreach (string x in playerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine(" ");

                    Console.WriteLine("-----------");
                    Console.WriteLine("Your opposition, team " + sideNotPicked + ": ");

                    foreach (string x in computerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine("  ");

                    allTeamBatsmen.Remove(opponentBatting);
                    allTeamKeepers.Remove(opponentKeeping);
                    allTeamAllRounders.Remove(opponentAllRound);
                    allTeamBowlers.Remove(opponentBowling);

                    pickedASide = true;

                }

                else if (sidePicked == "Pakistan")
                {
                    //pick player team from sets of Player players
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

                    int player = 2;

                    playerBatting = allTeamBatsmen[player];

                    while (playerTeam.Count < 5)
                    {
                        foreach (string x in playerBatting)
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
                            int result = playerBatting.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerBatting.Remove(playerSelection);

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

                    playerKeeping = allTeamKeepers[player];

                    while (playerTeam.Count > 4 && playerTeam.Count < 6)
                    {
                        foreach (string x in playerKeeping)
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
                            int result = playerKeeping.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerKeeping.Remove(playerSelection);

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

                    playerAllRound = allTeamAllRounders[player];

                    while (playerTeam.Count > 5 && playerTeam.Count < 7)
                    {
                        foreach (string x in playerAllRound)
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
                            int result = playerAllRound.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerAllRound.Remove(playerSelection);

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

                    playerBowling = allTeamBowlers[player];

                    while (playerTeam.Count < 10)
                    {
                        foreach (string x in playerBowling)
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
                            int result = playerBowling.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerBowling.Remove(playerSelection);

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

                    //computer picks players from sets of Opponent players
                    bool pickedOpponent = false;

                    while (pickedOpponent == false)
                    {
                        Random t1 = new Random();
                        opponent = t1.Next(0, teams.Count - 1);
                        sideNotPicked = teams[opponent];
                        if (!(sidePicked == sideNotPicked))
                        {
                            pickedOpponent = true;
                        }
                    }

                    int numberPlayersSelected = 0;

                    opponentBatting = allTeamBatsmen[opponent];
                    //select opponent batsmen
                    while (computerTeam.Count < 5)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentBatting.Count - 1);
                        playerSelection = opponentBatting[elementW];
                        computerTeam.Add(playerSelection);
                        opponentBatting.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent keeper
                    numberPlayersSelected = 0;

                    opponentKeeping = allTeamKeepers[opponent];

                    while (computerTeam.Count > 4 && computerTeam.Count < 6)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentKeeping.Count - 1);
                        playerSelection = opponentKeeping[elementW];
                        computerTeam.Add(playerSelection);
                        opponentKeeping.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent Allrounder
                    numberPlayersSelected = 0;

                    opponentAllRound = allTeamAllRounders[opponent];

                    while (computerTeam.Count > 5 && computerTeam.Count < 7)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentAllRound.Count - 1);
                        playerSelection = opponentAllRound[elementW];
                        computerTeam.Add(playerSelection);
                        opponentAllRound.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent bowlers
                    numberPlayersSelected = 0;

                    opponentBowling = allTeamBowlers[opponent];

                    while (computerTeam.Count < 10)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentBowling.Count - 1);
                        playerSelection = opponentBowling[elementW];
                        computerTeam.Add(playerSelection);
                        opponentBowling.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    Console.WriteLine("-----------");

                    Console.WriteLine("Your team, team " + sidePicked + ": ");

                    foreach (string x in playerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine(" ");

                    Console.WriteLine("-----------");
                    Console.WriteLine("Your opposition, team " + sideNotPicked + ": ");

                    foreach (string x in computerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine("  ");

                    allTeamBatsmen.Remove(opponentBatting);
                    allTeamKeepers.Remove(opponentKeeping);
                    allTeamAllRounders.Remove(opponentAllRound);
                    allTeamBowlers.Remove(opponentBowling);

                    pickedASide = true;

                }

                else if (sidePicked == "Australia")
                {
                    //pick player team from sets of Player players
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

                    int player = 3;

                    playerBatting = allTeamBatsmen[player];

                    while (playerTeam.Count < 5)
                    {
                        foreach (string x in playerBatting)
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
                            int result = playerBatting.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerBatting.Remove(playerSelection);

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

                    playerKeeping = allTeamKeepers[player];

                    while (playerTeam.Count > 4 && playerTeam.Count < 6)
                    {
                        foreach (string x in playerKeeping)
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
                            int result = playerKeeping.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerKeeping.Remove(playerSelection);

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

                    playerAllRound = allTeamAllRounders[player];

                    while (playerTeam.Count > 5 && playerTeam.Count < 7)
                    {
                        foreach (string x in playerAllRound)
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
                            int result = playerAllRound.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerAllRound.Remove(playerSelection);

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

                    playerBowling = allTeamBowlers[player];

                    while (playerTeam.Count < 10)
                    {
                        foreach (string x in playerBowling)
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
                            int result = playerBowling.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerBowling.Remove(playerSelection);

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

                    //computer picks players from sets of Opponent players
                    bool pickedOpponent = false;

                    while (pickedOpponent == false)
                    {
                        Random t1 = new Random();
                        opponent = t1.Next(0, teams.Count - 1);
                        sideNotPicked = teams[opponent];
                        if (!(sidePicked == sideNotPicked))
                        {
                            pickedOpponent = true;
                        }
                    }

                    int numberPlayersSelected = 0;

                    opponentBatting = allTeamBatsmen[opponent];
                    //select opponent batsmen
                    while (computerTeam.Count < 5)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentBatting.Count - 1);
                        playerSelection = opponentBatting[elementW];
                        computerTeam.Add(playerSelection);
                        opponentBatting.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent keeper
                    numberPlayersSelected = 0;

                    opponentKeeping = allTeamKeepers[opponent];

                    while (computerTeam.Count > 4 && computerTeam.Count < 6)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentKeeping.Count - 1);
                        playerSelection = opponentKeeping[elementW];
                        computerTeam.Add(playerSelection);
                        opponentKeeping.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent Allrounder
                    numberPlayersSelected = 0;

                    opponentAllRound = allTeamAllRounders[opponent];

                    while (computerTeam.Count > 5 && computerTeam.Count < 7)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentAllRound.Count - 1);
                        playerSelection = opponentAllRound[elementW];
                        computerTeam.Add(playerSelection);
                        opponentAllRound.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent bowlers
                    numberPlayersSelected = 0;

                    opponentBowling = allTeamBowlers[opponent];

                    while (computerTeam.Count < 10)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentBowling.Count - 1);
                        playerSelection = opponentBowling[elementW];
                        computerTeam.Add(playerSelection);
                        opponentBowling.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    Console.WriteLine("-----------");

                    Console.WriteLine("Your team, team " + sidePicked + ": ");

                    foreach (string x in playerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine(" ");

                    Console.WriteLine("-----------");
                    Console.WriteLine("Your opposition, team " + sideNotPicked + ": ");

                    foreach (string x in computerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine("  ");

                    allTeamBatsmen.Remove(opponentBatting);
                    allTeamKeepers.Remove(opponentKeeping);
                    allTeamAllRounders.Remove(opponentAllRound);
                    allTeamBowlers.Remove(opponentBowling);

                    pickedASide = true;

                }

                else if (sidePicked == "West Indies")
                {
                    //pick player team from sets of Player players
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

                    int player = 4;

                    playerBatting = allTeamBatsmen[player];

                    while (playerTeam.Count < 5)
                    {
                        foreach (string x in playerBatting)
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
                            int result = playerBatting.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerBatting.Remove(playerSelection);

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

                    playerKeeping = allTeamKeepers[player];

                    while (playerTeam.Count > 4 && playerTeam.Count < 6)
                    {
                        foreach (string x in playerKeeping)
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
                            int result = playerKeeping.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerKeeping.Remove(playerSelection);

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

                    playerAllRound = allTeamAllRounders[player];

                    while (playerTeam.Count > 5 && playerTeam.Count < 7)
                    {
                        foreach (string x in playerAllRound)
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
                            int result = playerAllRound.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerAllRound.Remove(playerSelection);

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

                    playerBowling = allTeamBowlers[player];

                    while (playerTeam.Count < 10)
                    {
                        foreach (string x in playerBowling)
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
                            int result = playerBowling.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerBowling.Remove(playerSelection);

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

                    //computer picks players from sets of Opponent players
                    bool pickedOpponent = false;

                    while (pickedOpponent == false)
                    {
                        Random t1 = new Random();
                        opponent = t1.Next(0, teams.Count - 1);
                        sideNotPicked = teams[opponent];
                        if (!(sidePicked == sideNotPicked))
                        {
                            pickedOpponent = true;
                        }
                    }

                    int numberPlayersSelected = 0;

                    opponentBatting = allTeamBatsmen[opponent];
                    //select opponent batsmen
                    while (computerTeam.Count < 5)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentBatting.Count - 1);
                        playerSelection = opponentBatting[elementW];
                        computerTeam.Add(playerSelection);
                        opponentBatting.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent keeper
                    numberPlayersSelected = 0;

                    opponentKeeping = allTeamKeepers[opponent];

                    while (computerTeam.Count > 4 && computerTeam.Count < 6)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentKeeping.Count - 1);
                        playerSelection = opponentKeeping[elementW];
                        computerTeam.Add(playerSelection);
                        opponentKeeping.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent Allrounder
                    numberPlayersSelected = 0;

                    opponentAllRound = allTeamAllRounders[opponent];

                    while (computerTeam.Count > 5 && computerTeam.Count < 7)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentAllRound.Count - 1);
                        playerSelection = opponentAllRound[elementW];
                        computerTeam.Add(playerSelection);
                        opponentAllRound.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent bowlers
                    numberPlayersSelected = 0;

                    opponentBowling = allTeamBowlers[opponent];

                    while (computerTeam.Count < 10)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentBowling.Count - 1);
                        playerSelection = opponentBowling[elementW];
                        computerTeam.Add(playerSelection);
                        opponentBowling.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    Console.WriteLine("-----------");

                    Console.WriteLine("Your team, team " + sidePicked + ": ");

                    foreach (string x in playerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine(" ");

                    Console.WriteLine("-----------");
                    Console.WriteLine("Your opposition, team " + sideNotPicked + ": ");

                    foreach (string x in computerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine("  ");

                    allTeamBatsmen.Remove(opponentBatting);
                    allTeamKeepers.Remove(opponentKeeping);
                    allTeamAllRounders.Remove(opponentAllRound);
                    allTeamBowlers.Remove(opponentBowling);

                    pickedASide = true;

                }

                else if (sidePicked == "Bangladesh")
                {
                    //pick player team from sets of Player players
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

                    int player = 5;

                    playerBatting = allTeamBatsmen[player];

                    while (playerTeam.Count < 5)
                    {
                        foreach (string x in playerBatting)
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
                            int result = playerBatting.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerBatting.Remove(playerSelection);

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

                    playerKeeping = allTeamKeepers[player];

                    while (playerTeam.Count > 4 && playerTeam.Count < 6)
                    {
                        foreach (string x in playerKeeping)
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
                            int result = playerKeeping.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerKeeping.Remove(playerSelection);

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

                    playerAllRound = allTeamAllRounders[player];

                    while (playerTeam.Count > 5 && playerTeam.Count < 7)
                    {
                        foreach (string x in playerAllRound)
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
                            int result = playerAllRound.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerAllRound.Remove(playerSelection);

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

                    playerBowling = allTeamBowlers[player];

                    while (playerTeam.Count < 10)
                    {
                        foreach (string x in playerBowling)
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
                            int result = playerBowling.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerBowling.Remove(playerSelection);

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

                    //computer picks players from sets of Opponent players
                    bool pickedOpponent = false;

                    while (pickedOpponent == false)
                    {
                        Random t1 = new Random();
                        opponent = t1.Next(0, teams.Count - 1);
                        sideNotPicked = teams[opponent];
                        if (!(sidePicked == sideNotPicked))
                        {
                            pickedOpponent = true;
                        }
                    }

                    int numberPlayersSelected = 0;

                    opponentBatting = allTeamBatsmen[opponent];
                    //select opponent batsmen
                    while (computerTeam.Count < 5)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentBatting.Count - 1);
                        playerSelection = opponentBatting[elementW];
                        computerTeam.Add(playerSelection);
                        opponentBatting.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent keeper
                    numberPlayersSelected = 0;

                    opponentKeeping = allTeamKeepers[opponent];

                    while (computerTeam.Count > 4 && computerTeam.Count < 6)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentKeeping.Count - 1);
                        playerSelection = opponentKeeping[elementW];
                        computerTeam.Add(playerSelection);
                        opponentKeeping.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent Allrounder
                    numberPlayersSelected = 0;

                    opponentAllRound = allTeamAllRounders[opponent];

                    while (computerTeam.Count > 5 && computerTeam.Count < 7)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentAllRound.Count - 1);
                        playerSelection = opponentAllRound[elementW];
                        computerTeam.Add(playerSelection);
                        opponentAllRound.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent bowlers
                    numberPlayersSelected = 0;

                    opponentBowling = allTeamBowlers[opponent];

                    while (computerTeam.Count < 10)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentBowling.Count - 1);
                        playerSelection = opponentBowling[elementW];
                        computerTeam.Add(playerSelection);
                        opponentBowling.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    Console.WriteLine("-----------");

                    Console.WriteLine("Your team, team " + sidePicked + ": ");

                    foreach (string x in playerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine(" ");

                    Console.WriteLine("-----------");
                    Console.WriteLine("Your opposition, team " + sideNotPicked + ": ");

                    foreach (string x in computerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine("  ");

                    allTeamBatsmen.Remove(opponentBatting);
                    allTeamKeepers.Remove(opponentKeeping);
                    allTeamAllRounders.Remove(opponentAllRound);
                    allTeamBowlers.Remove(opponentBowling);

                    pickedASide = true;

                }

                else if (sidePicked == "England")
                {
                    //pick player team from sets of Player players
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

                    int player = 6;

                    playerBatting = allTeamBatsmen[player];

                    while (playerTeam.Count < 5)
                    {
                        foreach (string x in playerBatting)
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
                            int result = playerBatting.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerBatting.Remove(playerSelection);

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

                    playerKeeping = allTeamKeepers[player];

                    while (playerTeam.Count > 4 && playerTeam.Count < 6)
                    {
                        foreach (string x in playerKeeping)
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
                            int result = playerKeeping.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerKeeping.Remove(playerSelection);

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

                    playerAllRound = allTeamAllRounders[player];

                    while (playerTeam.Count > 5 && playerTeam.Count < 7)
                    {
                        foreach (string x in playerAllRound)
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
                            int result = playerAllRound.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerAllRound.Remove(playerSelection);

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

                    playerBowling = allTeamBowlers[player];

                    while (playerTeam.Count < 10)
                    {
                        foreach (string x in playerBowling)
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
                            int result = playerBowling.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerBowling.Remove(playerSelection);

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

                    //computer picks players from sets of Opponent players
                    bool pickedOpponent = false;

                    while (pickedOpponent == false)
                    {
                        Random t1 = new Random();
                        opponent = t1.Next(0, teams.Count - 1);
                        sideNotPicked = teams[opponent];
                        if (!(sidePicked == sideNotPicked))
                        {
                            pickedOpponent = true;
                        }
                    }

                    int numberPlayersSelected = 0;

                    opponentBatting = allTeamBatsmen[opponent];
                    //select opponent batsmen
                    while (computerTeam.Count < 5)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentBatting.Count - 1);
                        playerSelection = opponentBatting[elementW];
                        computerTeam.Add(playerSelection);
                        opponentBatting.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent keeper
                    numberPlayersSelected = 0;

                    opponentKeeping = allTeamKeepers[opponent];

                    while (computerTeam.Count > 4 && computerTeam.Count < 6)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentKeeping.Count - 1);
                        playerSelection = opponentKeeping[elementW];
                        computerTeam.Add(playerSelection);
                        opponentKeeping.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent Allrounder
                    numberPlayersSelected = 0;

                    opponentAllRound = allTeamAllRounders[opponent];

                    while (computerTeam.Count > 5 && computerTeam.Count < 7)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentAllRound.Count - 1);
                        playerSelection = opponentAllRound[elementW];
                        computerTeam.Add(playerSelection);
                        opponentAllRound.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent bowlers
                    numberPlayersSelected = 0;

                    opponentBowling = allTeamBowlers[opponent];

                    while (computerTeam.Count < 10)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentBowling.Count - 1);
                        playerSelection = opponentBowling[elementW];
                        computerTeam.Add(playerSelection);
                        opponentBowling.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    Console.WriteLine("-----------");

                    Console.WriteLine("Your team, team " + sidePicked + ": ");

                    foreach (string x in playerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine(" ");

                    Console.WriteLine("-----------");
                    Console.WriteLine("Your opposition, team " + sideNotPicked + ": ");

                    foreach (string x in computerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine("  ");

                    allTeamBatsmen.Remove(opponentBatting);
                    allTeamKeepers.Remove(opponentKeeping);
                    allTeamAllRounders.Remove(opponentAllRound);
                    allTeamBowlers.Remove(opponentBowling);

                    pickedASide = true;

                }

                else if (sidePicked == "Sri Lanka")
                {
                    //pick player team from sets of Player players
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

                    int player = 7;

                    playerBatting = allTeamBatsmen[player];

                    while (playerTeam.Count < 5)
                    {
                        foreach (string x in playerBatting)
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
                            int result = playerBatting.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerBatting.Remove(playerSelection);

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

                    playerKeeping = allTeamKeepers[player];

                    while (playerTeam.Count > 4 && playerTeam.Count < 6)
                    {
                        foreach (string x in playerKeeping)
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
                            int result = playerKeeping.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerKeeping.Remove(playerSelection);

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

                    playerAllRound = allTeamAllRounders[player];

                    while (playerTeam.Count > 5 && playerTeam.Count < 7)
                    {
                        foreach (string x in playerAllRound)
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
                            int result = playerAllRound.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerAllRound.Remove(playerSelection);

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

                    playerBowling = allTeamBowlers[player];

                    while (playerTeam.Count < 10)
                    {
                        foreach (string x in playerBowling)
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
                            int result = playerBowling.IndexOf(playerSelection);
                            if (!(result == -1))
                            {
                                playerTeam.Add(playerSelection);
                                playerBowling.Remove(playerSelection);

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

                    //computer picks players from sets of Opponent players
                    bool pickedOpponent = false;

                    while (pickedOpponent == false)
                    {
                        Random t1 = new Random();
                        opponent = t1.Next(0, teams.Count - 1);
                        sideNotPicked = teams[opponent];
                        if (!(sidePicked == sideNotPicked))
                        {
                            pickedOpponent = true;
                        }
                    }

                    int numberPlayersSelected = 0;

                    opponentBatting = allTeamBatsmen[opponent];
                    //select opponent batsmen
                    while (computerTeam.Count < 5)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentBatting.Count - 1);
                        playerSelection = opponentBatting[elementW];
                        computerTeam.Add(playerSelection);
                        opponentBatting.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent keeper
                    numberPlayersSelected = 0;

                    opponentKeeping = allTeamKeepers[opponent];

                    while (computerTeam.Count > 4 && computerTeam.Count < 6)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentKeeping.Count - 1);
                        playerSelection = opponentKeeping[elementW];
                        computerTeam.Add(playerSelection);
                        opponentKeeping.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent Allrounder
                    numberPlayersSelected = 0;

                    opponentAllRound = allTeamAllRounders[opponent];

                    while (computerTeam.Count > 5 && computerTeam.Count < 7)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentAllRound.Count - 1);
                        playerSelection = opponentAllRound[elementW];
                        computerTeam.Add(playerSelection);
                        opponentAllRound.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    //select opponent bowlers
                    numberPlayersSelected = 0;

                    opponentBowling = allTeamBowlers[opponent];

                    while (computerTeam.Count < 10)
                    {
                        Random element = new Random();
                        int elementW = element.Next(0, opponentBowling.Count - 1);
                        playerSelection = opponentBowling[elementW];
                        computerTeam.Add(playerSelection);
                        opponentBowling.Remove(playerSelection);
                        numberPlayersSelected += 1;
                    }

                    Console.WriteLine("-----------");

                    Console.WriteLine("Your team, team " + sidePicked + ": ");

                    foreach (string x in playerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine(" ");

                    Console.WriteLine("-----------");
                    Console.WriteLine("Your opposition, team " + sideNotPicked + ": ");

                    foreach (string x in computerTeam)
                    {
                        Console.Write(x + ", ");
                    }

                    Console.WriteLine("  ");

                    allTeamBatsmen.Remove(opponentBatting);
                    allTeamKeepers.Remove(opponentKeeping);
                    allTeamAllRounders.Remove(opponentAllRound);
                    allTeamBowlers.Remove(opponentBowling);

                    pickedASide = true;

                }

                else
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

        public static void NextGameTeams()
        {
            bool keepGoing2 = false;

            while(keepGoing2 == false && onlyOneOpponentLeft == false)
            {
                Random c3po = new Random();
                r2d2 = c3po.Next(0, teams.Count - 1);
                sideNotPicked = teams[r2d2];   
                if(!(sideNotPicked == sidePicked))
                {
                    keepGoing2 = true;
                }
            }

            if(onlyOneOpponentLeft == true)
            {
                sideNotPicked = battleItOut1C;
            }

            if(teams.Count == 4)
            {

                Console.WriteLine("      ");
                Console.WriteLine("Welcome to the semi-finals of the World Cup. You will now play " +
                    sideNotPicked);
            }

            if(teams.Count == 2)
            {
                Console.WriteLine("      ");
                Console.WriteLine("This is it! Welcome to the World Cup final. Your ultimate competition" +
                    " will be: " + sideNotPicked);
            }

            if(onlyOneOpponentLeft == true)
            {
                opponentBatting = bat1C;
            }
            else if(onlyOneOpponentLeft == false)
            {
                opponent = r2d2;
                opponentBatting = allTeamBatsmen[opponent];
            }
            //select opponent batsmen
            while (computerTeam.Count < 5)
            {
                Random element = new Random();
                int elementW = element.Next(0, opponentBatting.Count - 1);
                playerSelection = opponentBatting[elementW];
                computerTeam.Add(playerSelection);
                opponentBatting.Remove(playerSelection);
            }

            //select opponent keeper
            if (onlyOneOpponentLeft == true)
            {
                opponentKeeping = keep1C;
            }
            else if (onlyOneOpponentLeft == false)
            {
                opponent = r2d2;
                opponentKeeping = allTeamKeepers[opponent];
            }

            while (computerTeam.Count > 4 && computerTeam.Count < 6)
            {
                Random element = new Random();
                int elementW = element.Next(0, opponentKeeping.Count - 1);
                playerSelection = opponentKeeping[elementW];
                computerTeam.Add(playerSelection);
                opponentKeeping.Remove(playerSelection);
            }

            //select opponent Allrounder
            if (onlyOneOpponentLeft == true)
            {
                opponentAllRound = allround1C;
            }
            else if (onlyOneOpponentLeft == false)
            {
                opponent = r2d2;
                opponentAllRound = allTeamAllRounders[opponent];
            }

            while (computerTeam.Count > 5 && computerTeam.Count < 7)
            {
                Random element = new Random();
                int elementW = element.Next(0, opponentAllRound.Count - 1);
                playerSelection = opponentAllRound[elementW];
                computerTeam.Add(playerSelection);
                opponentAllRound.Remove(playerSelection);
            }

            //select opponent bowlers
            if (onlyOneOpponentLeft == true)
            {
                opponentBowling = bowl1C;
            }
            else if (onlyOneOpponentLeft == false)
            {
                opponent = r2d2;
                opponentBowling = allTeamBowlers[opponent];
            }

            while (computerTeam.Count < 10)
            {
                Random element = new Random();
                int elementW = element.Next(0, opponentBowling.Count - 1);
                playerSelection = opponentBowling[elementW];
                computerTeam.Add(playerSelection);
                opponentBowling.Remove(playerSelection);
            }

            allTeamBatsmen.Remove(opponentBatting);
            allTeamKeepers.Remove(opponentKeeping);
            allTeamAllRounders.Remove(opponentAllRound);
            allTeamBowlers.Remove(opponentBowling);

            Console.WriteLine("      ");
            Console.WriteLine("-----------");

            Console.WriteLine("Your team, team " + sidePicked + ": ");

            foreach (string x in playerTeam)
            {
                Console.Write(x + ", ");
            }

            Console.WriteLine("      ");
            Console.WriteLine("-----------");

            Console.WriteLine("Your opponent, team " + sideNotPicked + ": ");

            foreach (string x in computerTeam)
            {
                Console.Write(x + ", ");
            }

            Console.WriteLine("      ");

        }

        //player bats first

        public static int FirstInningsplayerTeamBats()
        {
            currentBowler = "catInTheHat";
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

            teams.Remove(sideNotPicked);

            int whoopie1 = 0;
            int whoopie2 = 0;
            int whoopie3 = 0;
            int whoopie4 = 0;
            int whoopie5 = 0;

            //comp bowler 1
            Random CB1 = new Random();
            compBowler1 = CB1.Next(10, 20);

            Random CB1M = new Random();
            compBowler1M = CB1M.Next(9, 15);

            Random CB1B = new Random();
            compBowler1B = CB1B.Next(8, 10);

            //comp bowler 2
            Random CB2 = new Random();
            compBowler2 = CB2.Next(7, 20);

            Random CB2M = new Random();
            compBowler2M = CB2M.Next(7, 15);

            Random CB2B = new Random();
            compBowler2B = CB2B.Next(7, 10);

            //comp bowler 3
            Random CB3 = new Random();
            compBowler3 = CB3.Next(7, 20);

            Random CB3M = new Random();
            compBowler3M = CB3M.Next(7, 15);

            Random CB3B = new Random();
            compBowler3B = CB3B.Next(7, 10);

            //comp bowler 4
            Random CB4 = new Random();
            compBowler4 = CB4.Next(7, 20);

            Random CB4M = new Random();
            compBowler4M = CB4M.Next(7, 15);

            Random CB4B = new Random();
            compBowler4B = CB4B.Next(7, 10);

            //comp bowler 5

            Random CB5 = new Random();
            compBowler5 = CB5.Next(14, 20);

            Random CB5M = new Random();
            compBowler5M = CB5M.Next(11, 15);

            Random CB5B = new Random();
            compBowler5B = CB5B.Next(9, 12);

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
                while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
                {
                    Random rbattingScore = new Random();
                    battingScore = rbattingScore.Next(0, 7);

                    if (battingWicketsLost < 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler1);
                    }

                    else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler1M);
                    }

                    else if (battingWicketsLost >= 7)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler1B);
                    }

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
                        computerWicketTakers.Add(currentBowler);
                        playerFallOfWicket_Runs.Add(firstInningsTotal);
                        playerFallOfWicket_Wickets.Add(battingWicketsLost);
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

                if (firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
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
                while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    if (battingWicketsLost < 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler2);
                    }

                    else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler2M);
                    }

                    else if (battingWicketsLost >= 7)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler2B);
                    }

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
                        computerWicketTakers.Add(currentBowler);
                        playerFallOfWicket_Runs.Add(firstInningsTotal);
                        playerFallOfWicket_Wickets.Add(battingWicketsLost);
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

                if (firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
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
                while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    if (battingWicketsLost < 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler3);
                    }

                    else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler3M);
                    }

                    else if (battingWicketsLost >= 7)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler3B);
                    }

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
                        computerWicketTakers.Add(currentBowler);
                        playerFallOfWicket_Runs.Add(firstInningsTotal);
                        playerFallOfWicket_Wickets.Add(battingWicketsLost);
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

                if (firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
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
                while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    if (battingWicketsLost < 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler4);
                    }

                    else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler4M);
                    }

                    else if (battingWicketsLost >= 7)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler4B);
                    }

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
                        computerWicketTakers.Add(currentBowler);
                        playerFallOfWicket_Runs.Add(firstInningsTotal);
                        playerFallOfWicket_Wickets.Add(battingWicketsLost);
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

                if (firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
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
                while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
                {
                    Random rbattingScore = new Random();
                    int battingScore = rbattingScore.Next(0, 7);

                    if (battingWicketsLost < 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler5);
                    }

                    else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler5M);
                    }

                    else if (battingWicketsLost >= 7)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler5B);
                    }

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
                        computerWicketTakers.Add(currentBowler);
                        playerFallOfWicket_Runs.Add(firstInningsTotal);
                        playerFallOfWicket_Wickets.Add(battingWicketsLost);
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

                if (numberOfOvers == limitedOverVariation)
                {
                    firstInningsComplete = true;
                }

                if (firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
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

                if (numberOfOvers == limitedOverVariation && battingWicketsLost < 10)
                {
                    playerBatsmenScores.Add(currentBatsmanScore);
                    playerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                    firstInningsComplete = true;
                    playerNotOut = true;
                    //Console.WriteLine("HELLO1");
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

            if (battingWicketsLost < 10)
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

            Console.WriteLine("        ");

            //print batsmen
            Console.WriteLine("---------------");

            Console.WriteLine("Batting Scorecard: ");

            while (numberBatsmenPrinted < battingWicketsLost)
            {
                Console.WriteLine(playerTeam[index] + " : " + playerBatsmenScores[index] + " (" +
                    playerBatsmenDeliveriesPlayed[index] + ") . Strike Rate: " +
                    battingStrikeRate[index] + ". ");
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

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("        ");

            Console.WriteLine("--------------");

            //fall of wickets
            Console.WriteLine("Fall of Wickets");
            index = 0;
            while (index < battingWicketsLost)
            {
                Console.WriteLine("Score: " + playerFallOfWicket_Runs[index] + " / " +
                    playerFallOfWicket_Wickets[index] + " . Wicket by: " + computerWicketTakers[index]);
                index++;
            }

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

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("        ");

            Console.WriteLine("--------------");

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

            whoopie.Clear();
            economyRate.Clear();
            strikeRate.Clear();
            average.Clear();
            battingStrikeRate.Clear();

            //Console.WriteLine("HELLO22");
            return firstInningsTotal;

        }

        public static int SecondInningscomputerTeamBats(int input)
        {
            currentBowler = "catInTheHat";
            Console.WriteLine("       ");
            Console.WriteLine(sideNotPicked + " needs " + (input + 1) + " runs to win from " +
            (limitedOverVariation * 6) + " balls.");
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

            //player bowler 1
            Random PB1 = new Random();
            playBowler1 = PB1.Next(10, 20);

            Random PB1M = new Random();
            playBowler1M = PB1M.Next(9, 15);

            Random PB1B = new Random();
            playBowler1B = PB1B.Next(8, 10);

            //player bowler 2
            Random PB2 = new Random();
            playBowler2 = PB2.Next(7, 20);

            Random PB2M = new Random();
            playBowler2M = PB2M.Next(7, 15);

            Random PB2B = new Random();
            playBowler2B = PB2B.Next(7, 10);

            //player bowler 3
            Random PB3 = new Random();
            playBowler3 = PB3.Next(7, 20);

            Random PB3M = new Random();
            playBowler3M = PB3M.Next(7, 15);

            Random PB3B = new Random();
            playBowler3B = PB3B.Next(7, 10);

            //player bowler 4
            Random PB4 = new Random();
            playBowler4 = PB4.Next(7, 20);

            Random PB4M = new Random();
            playBowler4M = PB4M.Next(7, 15);

            Random PB4B = new Random();
            playBowler4B = PB4B.Next(7, 10);

            //comp bowler 5
            Random PB5 = new Random();
            compBowler5 = PB5.Next(14, 20);

            Random PB5M = new Random();
            playBowler5M = PB5M.Next(11, 15);

            Random PB5B = new Random();
            playBowler5B = PB5B.Next(9, 12);

            List<int> whoopie = new List<int>();
            List<object> economyRate = new List<object>();
            List<object> strikeRate = new List<object>();
            List<object> average = new List<object>();
            List<object> battingStrikeRateC = new List<object>();

            bowlerUpperLimit = limitedOverVariation / 5;

            Console.WriteLine("        ");

            Console.WriteLine("You to defend " + input + " runs in " + limitedOverVariation + " overs. You have 5 bowlers at" +
                " your disposal. Each can bowl at most " + bowlerUpperLimit + " overs. No bowler can bowl back-to-back overs. No bowler can bowl back-to-back overs. " +
                " Manage your bowlers carefully. If you are unable to complete the 20 overs due to " +
                " mismanagement of your attack, you may automatically lose the game.");


            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();
            Console.WriteLine("        ");

            bool gameHasBegun = false;
            bool choseBowler1 = false;
            bool onlyOneBowlerLeft = false;

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

                    if (playerBowlerBowledOut.Count == 4)
                    {
                        onlyOneBowlerLeft = true;
                    }

                    if ((bowlerNumber == 1 || bowlerNumber == 2 || bowlerNumber == 3 ||
                        bowlerNumber == 4 || bowlerNumber == 5) && playerBowlerBowledOut.Contains(bowlerNumber)
                        == false && (!(currentBowlerNumber == bowlerNumber) || onlyOneBowlerLeft == true))
                    {
                        //Console.WriteLine("HELLO23");
                        choseBowler1 = true;
                    }

                    if (playerBowlerBowledOut.Count == 3 && (onlyOneBowlerLeft == false))
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
                                if (playerBowler1Overs == playerBowler2Overs + 1)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 1 && otherBowlerNumber == 3)
                            {
                                if (playerBowler1Overs == playerBowler3Overs + 1)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 1 && otherBowlerNumber == 4)
                            {
                                if (playerBowler1Overs == playerBowler4Overs + 1)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 1 && otherBowlerNumber == 5)
                            {
                                if (playerBowler1Overs == playerBowler5Overs + 1)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }

                            if (bowlerNumber == 2 && otherBowlerNumber == 1)
                            {
                                if (playerBowler2Overs == 1 + playerBowler1Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 2 && otherBowlerNumber == 3)
                            {
                                if (playerBowler2Overs == 1 + playerBowler3Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 2 && otherBowlerNumber == 4)
                            {
                                if (playerBowler2Overs == 1 + playerBowler4Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 2 && otherBowlerNumber == 5)
                            {
                                if (playerBowler2Overs == 1 + playerBowler5Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }

                            if (bowlerNumber == 3 && otherBowlerNumber == 1)
                            {
                                if (playerBowler3Overs == 1 + playerBowler1Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 3 && otherBowlerNumber == 2)
                            {
                                if (playerBowler3Overs == 1 + playerBowler2Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 3 && otherBowlerNumber == 4)
                            {
                                if (playerBowler3Overs == 1 + playerBowler4Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 3 && otherBowlerNumber == 5)
                            {
                                if (playerBowler3Overs == 1 + playerBowler5Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }

                            if (bowlerNumber == 4 && otherBowlerNumber == 1)
                            {
                                if (playerBowler4Overs == 1 + playerBowler1Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 4 && otherBowlerNumber == 2)
                            {
                                if (playerBowler4Overs == 1 + playerBowler2Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 4 && otherBowlerNumber == 3)
                            {
                                if (playerBowler4Overs == 1 + playerBowler3Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 4 && otherBowlerNumber == 5)
                            {
                                if (playerBowler4Overs == 1 + playerBowler5Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }

                            if (bowlerNumber == 5 && otherBowlerNumber == 1)
                            {
                                if (playerBowler5Overs == 1 + playerBowler1Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 5 && otherBowlerNumber == 2)
                            {
                                if (playerBowler5Overs == 1 + playerBowler2Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 5 && otherBowlerNumber == 3)
                            {
                                if (playerBowler5Overs == 1 + playerBowler3Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 5 && otherBowlerNumber == 4)
                            {
                                if (playerBowler5Overs == 1 + playerBowler4Overs)
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
                        if (currentBowlerNumber == bowlerNumber && (onlyOneBowlerLeft == false))
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

                bowlerUpperLimit = limitedOverVariation / 5;

                if (gameHasBegun == false)
                {
                    //Console.WriteLine("HELLO24");
                    string proposedBowler = playerBowlers[bowlerNumber - 1];

                    //by now, we are assuming the proposed bowler has not bowled the previous over.
                    if (bowlerNumber == 1 && playerBowler1Overs < bowlerUpperLimit)
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
                        while (numberOfBalls < 6 && secondInningsComplete == false && gameOver == false && !(numberOfOvers == limitedOverVariation))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            if (battingWicketsLost < 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler1);
                            }

                            else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler1M);
                            }

                            else if (battingWicketsLost >= 7)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler1B);
                            }

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
                                string player = computerTeam[battingWicketsLost - 1];
                                computerBatsmenScores.Add(currentBatsmanScore);
                                computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                                playerWicketTakers.Add(currentBowler);
                                computerFallOfWicket_Runs.Add(secondInningsTotal);
                                computerFallOfWicket_Wickets.Add(battingWicketsLost);
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

                        playerBowler1Runs += currentBowlerRuns;
                        playerBowler1Wickets += currentBowlerWickets;
                        playerBowler1Overs += currentBowlerOvers;

                        if (secondInningsComplete == false && !(numberOfOvers == limitedOverVariation))
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
                                     " runs to win from " + ((limitedOverVariation * 6) - (numberOfOvers * 6)) + " balls.");
                            Console.WriteLine("          ");
                            //current run rate:
                            float secondInningsTotalSoFar1 = secondInningsTotal;
                            float oversSoFar = numberOfOvers;
                            float currentRunRate = secondInningsTotal / oversSoFar;
                            Console.WriteLine("Current run-rate: " + currentRunRate);
                            Console.WriteLine("         ");
                            //required run rate:
                            float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                            float OversToGo = limitedOverVariation - numberOfOvers;
                            float requiredRunRate = runsToGo / OversToGo;
                            Console.WriteLine("Required run-rate: " + requiredRunRate);
                            Console.WriteLine("-----------");

                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                        }

                        if (playerBowler1Overs == bowlerUpperLimit)
                        {
                            playerBowlerBowledOut.Add(1);
                        }
                    }

                    else if (bowlerNumber == 2 && playerBowler2Overs < bowlerUpperLimit)
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
                        while (numberOfBalls < 6 && secondInningsComplete == false && gameOver == false && !(numberOfOvers == limitedOverVariation))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            if (battingWicketsLost < 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler2);
                            }

                            else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler2M);
                            }

                            else if (battingWicketsLost >= 7)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler2B);
                            }

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
                                string player = computerTeam[battingWicketsLost - 1];
                                computerBatsmenScores.Add(currentBatsmanScore);
                                computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                                playerWicketTakers.Add(currentBowler);
                                computerFallOfWicket_Runs.Add(secondInningsTotal);
                                computerFallOfWicket_Wickets.Add(battingWicketsLost);
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

                        playerBowler2Runs += currentBowlerRuns;
                        playerBowler2Wickets += currentBowlerWickets;
                        playerBowler2Overs += currentBowlerOvers;

                        if (secondInningsComplete == false && !(numberOfOvers == limitedOverVariation))
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
                                     " runs to win from " + ((limitedOverVariation * 6) - (numberOfOvers * 6)) + " balls.");
                            Console.WriteLine("          ");
                            //current run rate:
                            float secondInningsTotalSoFar1 = secondInningsTotal;
                            float oversSoFar = numberOfOvers;
                            float currentRunRate = secondInningsTotal / oversSoFar;
                            Console.WriteLine("Current run-rate: " + currentRunRate);
                            Console.WriteLine("         ");
                            //required run rate:
                            float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                            float OversToGo = limitedOverVariation - numberOfOvers;
                            float requiredRunRate = runsToGo / OversToGo;
                            Console.WriteLine("Required run-rate: " + requiredRunRate);
                            Console.WriteLine("-----------");


                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                        }

                        if (playerBowler2Overs == bowlerUpperLimit)
                        {
                            playerBowlerBowledOut.Add(2);
                        }
                    }

                    else if (bowlerNumber == 3 && playerBowler3Overs < bowlerUpperLimit)
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
                        while (numberOfBalls < 6 && secondInningsComplete == false && gameOver == false && !(numberOfOvers == limitedOverVariation))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            if (battingWicketsLost < 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler3);
                            }

                            else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler3M);
                            }

                            else if (battingWicketsLost >= 7)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler3B);
                            }

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
                                string player = computerTeam[battingWicketsLost - 1];
                                computerBatsmenScores.Add(currentBatsmanScore);
                                computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                                playerWicketTakers.Add(currentBowler);
                                computerFallOfWicket_Runs.Add(secondInningsTotal);
                                computerFallOfWicket_Wickets.Add(battingWicketsLost);
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

                        playerBowler3Runs += currentBowlerRuns;
                        playerBowler3Wickets += currentBowlerWickets;
                        playerBowler3Overs += currentBowlerOvers;

                        if (secondInningsComplete == false && !(numberOfOvers == limitedOverVariation))
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
                                     " runs to win from " + ((limitedOverVariation * 6) - (numberOfOvers * 6)) + " balls.");
                            Console.WriteLine("          ");
                            //current run rate:
                            float secondInningsTotalSoFar1 = secondInningsTotal;
                            float oversSoFar = numberOfOvers;
                            float currentRunRate = secondInningsTotal / oversSoFar;
                            Console.WriteLine("Current run-rate: " + currentRunRate);
                            Console.WriteLine("         ");
                            //required run rate:
                            float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                            float OversToGo = limitedOverVariation - numberOfOvers;
                            float requiredRunRate = runsToGo / OversToGo;
                            Console.WriteLine("Required run-rate: " + requiredRunRate);
                            Console.WriteLine("-----------");

                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                        }

                        if (playerBowler3Overs == bowlerUpperLimit)
                        {
                            playerBowlerBowledOut.Add(3);
                        }
                    }

                    else if (bowlerNumber == 4 && playerBowler4Overs < bowlerUpperLimit)
                    {
                        // player bowler4 bowls
                        //player bowler #4

                        currentBowlerRuns = 0;
                        currentBowlerWickets = 0;
                        currentBowlerOvers = 0;
                        numberOfBalls = 0;
                        currentBowler = playerBowler4;
                        currentBowlerNumber = 4;
                        //Console.WriteLine("TESTING1");

                        //bowl over
                        while (numberOfBalls < 6 && secondInningsComplete == false && gameOver == false && !(numberOfOvers == limitedOverVariation))
                        {
                            // Console.WriteLine("TESTING2");
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            if (battingWicketsLost < 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler4);
                            }

                            else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler4M);
                            }

                            else if (battingWicketsLost >= 7)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler4B);
                            }

                            if (!(battingScore == bowlingScore))
                            {
                                //Console.WriteLine("TESTING3");
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
                                //Console.WriteLine("TESTING4");
                                currentBowlerWickets += 1;
                                battingWicketsLost += 1;
                                currentBatsmanDeliveriesPlayed += 1;
                                string player = computerTeam[battingWicketsLost - 1];
                                computerBatsmenScores.Add(currentBatsmanScore);
                                computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                                playerWicketTakers.Add(currentBowler);
                                computerFallOfWicket_Runs.Add(secondInningsTotal);
                                computerFallOfWicket_Wickets.Add(battingWicketsLost);
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
                                    whoopie5 = 0;
                                    whoopie.Add(whoopie1);
                                    whoopie.Add(whoopie2);
                                    whoopie.Add(whoopie3);
                                    whoopie.Add(whoopie4);
                                    whoopie.Add(whoopie5);

                                    Console.WriteLine("        ");
                                    Console.Write("Press Enter to continue!");
                                    Console.ReadLine();
                                }
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

                        if (secondInningsComplete == false && !(numberOfOvers == limitedOverVariation))
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
                                     " runs to win from " + ((limitedOverVariation * 6) - (numberOfOvers * 6)) + " balls.");
                            Console.WriteLine("          ");
                            //current run rate:
                            float secondInningsTotalSoFar1 = secondInningsTotal;
                            float oversSoFar = numberOfOvers;
                            float currentRunRate = secondInningsTotal / oversSoFar;
                            Console.WriteLine("Current run-rate: " + currentRunRate);
                            Console.WriteLine("         ");
                            //required run rate:
                            float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                            float OversToGo = limitedOverVariation - numberOfOvers;
                            float requiredRunRate = runsToGo / OversToGo;
                            Console.WriteLine("Required run-rate: " + requiredRunRate);
                            Console.WriteLine("-----------");

                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                        }

                        if (playerBowler4Overs == bowlerUpperLimit)
                        {
                            playerBowlerBowledOut.Add(4);
                        }
                    }

                    else if (bowlerNumber == 5 && playerBowler5Overs < bowlerUpperLimit)
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
                        while ((numberOfBalls < 6 && secondInningsComplete == false && gameOver == false) && !(numberOfOvers == limitedOverVariation))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            if (battingWicketsLost < 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler5);
                            }

                            else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler5M);
                            }

                            else if (battingWicketsLost >= 7)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler5B);
                            }

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
                                string player = computerTeam[battingWicketsLost - 1];
                                computerBatsmenScores.Add(currentBatsmanScore);
                                computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                                playerWicketTakers.Add(currentBowler);
                                computerFallOfWicket_Runs.Add(secondInningsTotal);
                                computerFallOfWicket_Wickets.Add(battingWicketsLost);
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
                                    Console.WriteLine("Team " + sideNotPicked + " has only scored " + secondInningsTotal + " and has thus lost " +
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

                        if (secondInningsComplete == false && !(numberOfOvers == limitedOverVariation))
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
                                     " runs to win from " + ((limitedOverVariation * 6) - (numberOfOvers * 6)) + " balls.");
                            Console.WriteLine("          ");
                            //current run rate:
                            float secondInningsTotalSoFar1 = secondInningsTotal;
                            float oversSoFar = numberOfOvers;
                            float currentRunRate = secondInningsTotal / oversSoFar;
                            Console.WriteLine("Current run-rate: " + currentRunRate);
                            Console.WriteLine("         ");
                            //required run rate:
                            float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                            float OversToGo = limitedOverVariation - numberOfOvers;
                            float requiredRunRate = runsToGo / OversToGo;
                            Console.WriteLine("Required run-rate: " + requiredRunRate);
                            Console.WriteLine("-----------");

                            Console.Write("Press Enter to continue!");
                            Console.ReadLine();
                        }

                        if (playerBowler5Overs == bowlerUpperLimit)
                        {
                            playerBowlerBowledOut.Add(5);
                        }
                    }

                    if (numberOfOvers == limitedOverVariation)
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
                Console.WriteLine("You've lost, and are knocked out of the World Cup");
                Console.WriteLine(sideNotPicked + " has won by " + (10 - battingWicketsLost) + " wickets.");
                playerKnockedOut = true;
                
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
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("        ");

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

            Console.WriteLine("---------------");

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
                    //Console.WriteLine("HELLO26");
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

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("        ");

            Console.WriteLine("---------------");

            Console.WriteLine("Fall of Wickets: ");
            index = 0;

            while (index < battingWicketsLost)
            {
                Console.WriteLine("Score: " + computerFallOfWicket_Runs[index] + " / " +
                    computerFallOfWicket_Wickets[index] + ". Wicket by: " + playerWicketTakers[index]);
                index++;
            }

            int numberBowlersPrinted = 0;
            index = 0;

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("        ");

            Console.WriteLine("---------------");

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

            whoopie.Clear();
            economyRate.Clear();
            strikeRate.Clear();
            average.Clear();
            battingStrikeRateC.Clear();

            return secondInningsTotal;
        }

        /***************************************************************/

        //computer bats first

        public static int FirstInningscomputerTeamBats()
        {
            currentBowler = "catInTheHat";
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

            playerNotOut = false;

            teams.Remove(sideNotPicked);

            int whoopie1 = 0;
            int whoopie2 = 0;
            int whoopie3 = 0;
            int whoopie4 = 0;
            int whoopie5 = 0;

            //player bowler 1
            Random PB1 = new Random();
            playBowler1 = PB1.Next(10, 20);

            Random PB1M = new Random();
            playBowler1M = PB1M.Next(9, 15);

            Random PB1B = new Random();
            playBowler1B = PB1B.Next(8, 10);

            //player bowler 2
            Random PB2 = new Random();
            playBowler2 = PB2.Next(7, 20);

            Random PB2M = new Random();
            playBowler2M = PB2M.Next(7, 15);

            Random PB2B = new Random();
            playBowler2B = PB2B.Next(7, 10);

            //player bowler 3
            Random PB3 = new Random();
            playBowler3 = PB3.Next(7, 20);

            Random PB3M = new Random();
            playBowler3M = PB3M.Next(7, 15);

            Random PB3B = new Random();
            playBowler3B = PB3B.Next(7, 10);

            //player bowler 4
            Random PB4 = new Random();
            playBowler4 = PB4.Next(7, 20);

            Random PB4M = new Random();
            playBowler4M = PB4M.Next(7, 15);

            Random PB4B = new Random();
            playBowler4B = PB4B.Next(7, 10);

            //comp bowler 5
            Random PB5 = new Random();
            compBowler5 = PB5.Next(14, 20);

            Random PB5M = new Random();
            playBowler5M = PB5M.Next(11, 15);

            Random PB5B = new Random();
            playBowler5B = PB5B.Next(9, 12);

            List<int> whoopie = new List<int>();
            List<object> economyRate = new List<object>();
            List<object> strikeRate = new List<object>();
            List<object> average = new List<object>();
            List<object> battingStrikeRate = new List<object>();

            bowlerUpperLimit = limitedOverVariation / 5;

            bool gameHasBegun = false;
            bool choseBowler1 = false;
            bool onlyOneBowlerLeft = false;

            Console.WriteLine("        ");

            Console.WriteLine("You have 5 bowlers at" +
                " your disposal. Each can bowl at most " + bowlerUpperLimit + " overs. No bowler can bowl back-to-back overs. " +
                " Manage your bowlers carefully. If you are unable to complete the 20 overs due to " +
                " mismanagement of your attack, you may automatically lose the game.");

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();
            Console.WriteLine("        ");


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

                    if (playerBowlerBowledOut.Count == 4)
                    {
                        onlyOneBowlerLeft = true;
                    }

                    if ((bowlerNumber == 1 || bowlerNumber == 2 || bowlerNumber == 3 ||
                        bowlerNumber == 4 || bowlerNumber == 5) && playerBowlerBowledOut.Contains(bowlerNumber)
                        == false && (!(currentBowlerNumber == bowlerNumber) || onlyOneBowlerLeft == true))
                    {
                       
                        //Console.WriteLine("HELLO23");
                        choseBowler1 = true;
                    }

                    if (playerBowlerBowledOut.Count == 3 && onlyOneBowlerLeft == false)
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
                                if (playerBowler1Overs == playerBowler2Overs + 1)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 1 && otherBowlerNumber == 3)
                            {
                                if (playerBowler1Overs == 1 + playerBowler3Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 1 && otherBowlerNumber == 4)
                            {
                                if (playerBowler1Overs == 1 + playerBowler4Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 1 && otherBowlerNumber == 5)
                            {
                                if (playerBowler1Overs == 1 + playerBowler5Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }

                            if (bowlerNumber == 2 && otherBowlerNumber == 1)
                            {
                                if (playerBowler2Overs == 1 + playerBowler1Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 2 && otherBowlerNumber == 3)
                            {
                                if (playerBowler2Overs == 1 + playerBowler3Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 2 && otherBowlerNumber == 4)
                            {
                                if (playerBowler2Overs == 1 + playerBowler4Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 2 && otherBowlerNumber == 5)
                            {
                                if (playerBowler2Overs == 1 + playerBowler5Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }

                            if (bowlerNumber == 3 && otherBowlerNumber == 1)
                            {
                                if (playerBowler3Overs == 1 + playerBowler1Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 3 && otherBowlerNumber == 2)
                            {
                                if (playerBowler3Overs == 1 + playerBowler2Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 3 && otherBowlerNumber == 4)
                            {
                                if (playerBowler3Overs == 1 + playerBowler4Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 3 && otherBowlerNumber == 5)
                            {
                                if (playerBowler3Overs == 1 + playerBowler5Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }

                            if (bowlerNumber == 4 && otherBowlerNumber == 1)
                            {
                                if (playerBowler4Overs == 1 + playerBowler1Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 4 && otherBowlerNumber == 2)
                            {
                                if (playerBowler4Overs == 1 + playerBowler2Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 4 && otherBowlerNumber == 3)
                            {
                                if (playerBowler4Overs == 1 + playerBowler3Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 4 && otherBowlerNumber == 5)
                            {
                                if (playerBowler4Overs == 1 + playerBowler5Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }

                            if (bowlerNumber == 5 && otherBowlerNumber == 1)
                            {
                                if (playerBowler5Overs == 1 + playerBowler1Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 5 && otherBowlerNumber == 2)
                            {
                                if (playerBowler5Overs == 1 + playerBowler2Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 5 && otherBowlerNumber == 3)
                            {
                                if (playerBowler5Overs == 1 + playerBowler3Overs)
                                {
                                    Console.WriteLine("You must pick the other available bowler (bowler number" +
                                        otherBowlerNumber + " ) to " +
                                    " ensure that no bowler bowls back to back overs.");
                                    choseBowler1 = false;
                                }
                            }
                            if (bowlerNumber == 5 && otherBowlerNumber == 4)
                            {
                                if (playerBowler5Overs == 1 + playerBowler4Overs)
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
                        if (currentBowlerNumber == bowlerNumber && onlyOneBowlerLeft == false)
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

                bowlerUpperLimit = limitedOverVariation / 5;

                if (gameHasBegun == false)
                {
                    //Console.WriteLine("HELLO24");
                    string proposedBowler = playerBowlers[bowlerNumber - 1];

                    //by now, we are assuming the proposed bowler has not bowled the previous over.
                    if (bowlerNumber == 1 && playerBowler1Overs < bowlerUpperLimit)
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
                        while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            if (battingWicketsLost < 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler1);
                            }

                            else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler1M);
                            }

                            else if (battingWicketsLost >= 7)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler1B);
                            }

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
                                computerFallOfWicket_Runs.Add(firstInningsTotal);
                                computerFallOfWicket_Wickets.Add(battingWicketsLost);
                                playerWicketTakers.Add(currentBowler);
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

                        if (firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
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

                        if (playerBowler1Overs == bowlerUpperLimit)
                        {
                            playerBowlerBowledOut.Add(1);
                        }
                    }

                    else if (bowlerNumber == 2 && playerBowler2Overs < bowlerUpperLimit)
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
                        while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            if (battingWicketsLost < 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler2);
                            }

                            else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler2M);
                            }

                            else if (battingWicketsLost >= 7)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler2B);
                            }

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
                                computerFallOfWicket_Runs.Add(firstInningsTotal);
                                computerFallOfWicket_Wickets.Add(battingWicketsLost);
                                playerWicketTakers.Add(currentBowler);
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

                        if (firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
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

                        if (playerBowler2Overs == bowlerUpperLimit)
                        {
                            playerBowlerBowledOut.Add(2);
                        }
                    }

                    else if (bowlerNumber == 3 && playerBowler3Overs < bowlerUpperLimit)
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
                        while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            if (battingWicketsLost < 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler3);
                            }

                            else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler3M);
                            }

                            else if (battingWicketsLost >= 7)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler3B);
                            }

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
                                computerFallOfWicket_Runs.Add(firstInningsTotal);
                                computerFallOfWicket_Wickets.Add(battingWicketsLost);
                                playerWicketTakers.Add(currentBowler);
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

                        if (firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
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

                        if (playerBowler3Overs == bowlerUpperLimit)
                        {
                            playerBowlerBowledOut.Add(3);
                        }
                    }

                    else if (bowlerNumber == 4 && playerBowler4Overs < bowlerUpperLimit)
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
                        while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            if (battingWicketsLost < 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler4);
                            }

                            else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler4M);
                            }

                            else if (battingWicketsLost >= 7)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler4B);
                            }

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
                                computerFallOfWicket_Runs.Add(firstInningsTotal);
                                computerFallOfWicket_Wickets.Add(battingWicketsLost);
                                playerWicketTakers.Add(currentBowler);
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

                        if (firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
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

                        if (playerBowler4Overs == bowlerUpperLimit)
                        {
                            playerBowlerBowledOut.Add(4);
                        }
                    }

                    else if (bowlerNumber == 5 && playerBowler5Overs < bowlerUpperLimit)
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
                        while (numberOfBalls < 6 && firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
                        {
                            Random rbattingScore = new Random();
                            int battingScore = rbattingScore.Next(0, 7);

                            if (battingWicketsLost < 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler5);
                            }

                            else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler5M);
                            }

                            else if (battingWicketsLost >= 7)
                            {
                                Random rbowlingScore = new Random();
                                bowlingScore = rbowlingScore.Next(0, playBowler5B);
                            }

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
                                computerFallOfWicket_Runs.Add(firstInningsTotal);
                                computerFallOfWicket_Wickets.Add(battingWicketsLost);
                                playerWicketTakers.Add(currentBowler);
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

                        if (firstInningsComplete == false && !(numberOfOvers == limitedOverVariation))
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

                        if (playerBowler5Overs == bowlerUpperLimit)
                        {
                            playerBowlerBowledOut.Add(5);
                        }
                    }

                    if (numberOfOvers == limitedOverVariation)
                    {
                        secondInningsComplete = true;
                        gameOver = true;
                        computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                        computerBatsmenScores.Add(currentBatsmanScore);
                    }
                }

                if (numberOfOvers == limitedOverVariation && battingWicketsLost < 10)
                {
                    computerBatsmenScores.Add(currentBatsmanScore);
                    computerBatsmenDeliveriesPlayed.Add(currentBatsmanDeliveriesPlayed);
                    firstInningsComplete = true;
                    playerNotOut = true;
                    //Console.WriteLine("HELLO1");
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

            Console.WriteLine("---------------");

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
                    //Console.WriteLine("HELLO THERE");
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

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();
            Console.WriteLine("--------------");
            //fall of wickets
            Console.WriteLine("Fall of wickets: ");
            index = 0;

            while (index < battingWicketsLost)
            {
                Console.WriteLine("Score: " + computerFallOfWicket_Runs[index] + " / " +
                    computerFallOfWicket_Wickets[index] + ". Wicket by: " + playerWicketTakers[index]);
                index++;
            }

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();
            Console.WriteLine("--------------");

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

            whoopie.Clear();
            economyRate.Clear();
            strikeRate.Clear();
            average.Clear();
            battingStrikeRate.Clear();

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            return firstInningsTotal;
        }

        public static int SecondInningsplayerTeamBats(int input)
        {
            currentBowler = "catInTheHat";
            Console.WriteLine("       ");
            Console.WriteLine(sidePicked + " needs " + (input + 1) + " runs to win from " +
            (limitedOverVariation * 6) + " balls.");
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

            //comp bowler 1
            Random CB1 = new Random();
            compBowler1 = CB1.Next(10, 20);

            Random CB1M = new Random();
            compBowler1M = CB1M.Next(9, 15);

            Random CB1B = new Random();
            compBowler1B = CB1B.Next(8, 10);

            //comp bowler 2
            Random CB2 = new Random();
            compBowler2 = CB2.Next(7, 20);

            Random CB2M = new Random();
            compBowler2M = CB2M.Next(7, 15);

            Random CB2B = new Random();
            compBowler2B = CB2B.Next(7, 10);

            //comp bowler 3
            Random CB3 = new Random();
            compBowler3 = CB3.Next(7, 20);

            Random CB3M = new Random();
            compBowler3M = CB3M.Next(7, 15);

            Random CB3B = new Random();
            compBowler3B = CB3B.Next(7, 10);

            //comp bowler 4
            Random CB4 = new Random();
            compBowler4 = CB4.Next(7, 20);

            Random CB4M = new Random();
            compBowler4M = CB4M.Next(7, 15);

            Random CB4B = new Random();
            compBowler4B = CB4B.Next(7, 10);

            //comp bowler 5
            Random CB5 = new Random();
            compBowler5 = CB5.Next(14, 20);

            Random CB5M = new Random();
            compBowler5M = CB5M.Next(11, 15);

            Random CB5B = new Random();
            compBowler5B = CB5B.Next(9, 12);

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

                    if (battingWicketsLost < 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler1);
                    }

                    else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler1M);
                    }

                    else if (battingWicketsLost >= 7)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler1B);
                    }

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
                        playerFallOfWicket_Runs.Add(secondInningsTotal);
                        playerFallOfWicket_Wickets.Add(battingWicketsLost);
                        computerWicketTakers.Add(currentBowler);
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
                                     " runs to win from " + ((limitedOverVariation * 6) - (numberOfOvers * 6)) + " balls.");
                    //current run rate:
                    float secondInningsTotalSoFar1 = secondInningsTotal;
                    float oversSoFar = numberOfOvers;
                    float currentRunRate = secondInningsTotal / oversSoFar;
                    Console.WriteLine("Current run-rate: " + currentRunRate);
                    Console.WriteLine("         ");
                    //required run rate:
                    float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                    float OversToGo = limitedOverVariation - numberOfOvers;
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

                    if (battingWicketsLost < 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler2);
                    }

                    else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler2M);
                    }

                    else if (battingWicketsLost >= 7)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler2B);
                    }

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
                        playerFallOfWicket_Runs.Add(secondInningsTotal);
                        playerFallOfWicket_Wickets.Add(battingWicketsLost);
                        computerWicketTakers.Add(currentBowler);
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
                                     " runs to win from " + ((limitedOverVariation * 6) - (numberOfOvers * 6)) + " balls.");
                    //current run rate:
                    float secondInningsTotalSoFar1 = secondInningsTotal;
                    float oversSoFar = numberOfOvers;
                    float currentRunRate = secondInningsTotal / oversSoFar;
                    Console.WriteLine("Current run-rate: " + currentRunRate);
                    Console.WriteLine("         ");
                    //required run rate:
                    float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                    float OversToGo = limitedOverVariation - numberOfOvers;
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

                    if (battingWicketsLost < 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler3);
                    }

                    else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler3M);
                    }

                    else if (battingWicketsLost >= 7)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler3B);
                    }

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
                        playerFallOfWicket_Runs.Add(secondInningsTotal);
                        playerFallOfWicket_Wickets.Add(battingWicketsLost);
                        computerWicketTakers.Add(currentBowler);
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
                                     " runs to win from " + ((limitedOverVariation * 6) - (numberOfOvers * 6)) + " balls.");
                    //current run rate:
                    float secondInningsTotalSoFar1 = secondInningsTotal;
                    float oversSoFar = numberOfOvers;
                    float currentRunRate = secondInningsTotal / oversSoFar;
                    Console.WriteLine("Current run-rate: " + currentRunRate);
                    Console.WriteLine("         ");
                    //required run rate:
                    float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                    float OversToGo = limitedOverVariation - numberOfOvers;
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

                    if (battingWicketsLost < 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler4);
                    }

                    else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler4M);
                    }

                    else if (battingWicketsLost >= 7)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler4B);
                    }

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
                        playerFallOfWicket_Runs.Add(secondInningsTotal);
                        playerFallOfWicket_Wickets.Add(battingWicketsLost);
                        computerWicketTakers.Add(currentBowler);
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
                                     " runs to win from " + ((limitedOverVariation * 6) - (numberOfOvers * 6)) + " balls.");
                    //current run rate:
                    float secondInningsTotalSoFar1 = secondInningsTotal;
                    float oversSoFar = numberOfOvers;
                    float currentRunRate = secondInningsTotal / oversSoFar;
                    Console.WriteLine("Current run-rate: " + currentRunRate);
                    Console.WriteLine("         ");
                    //required run rate:
                    float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                    float OversToGo = limitedOverVariation - numberOfOvers;
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

                    if (battingWicketsLost < 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler5);
                    }

                    else if (battingWicketsLost < 7 && battingWicketsLost >= 5)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler5M);
                    }

                    else if (battingWicketsLost >= 7)
                    {
                        Random rbowlingScore = new Random();
                        bowlingScore = rbowlingScore.Next(0, compBowler5B);
                    }

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
                        playerFallOfWicket_Runs.Add(secondInningsTotal);
                        playerFallOfWicket_Wickets.Add(battingWicketsLost);
                        computerWicketTakers.Add(currentBowler);
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

                if (numberOfOvers == limitedOverVariation)
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
                                     " runs to win from " + ((limitedOverVariation * 6) - (numberOfOvers * 6)) + " balls.");
                    //current run rate:
                    float secondInningsTotalSoFar1 = secondInningsTotal;
                    float oversSoFar = numberOfOvers;
                    float currentRunRate = secondInningsTotal / oversSoFar;
                    Console.WriteLine("Current run-rate: " + currentRunRate);
                    Console.WriteLine("         ");
                    //required run rate:
                    float runsToGo = firstInningsTotal + 1 - secondInningsTotal;
                    float OversToGo = limitedOverVariation - numberOfOvers;
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

            if (!(secondInningsTotal > input) && battingWicketsLost < 10 && numberOfOvers == limitedOverVariation)
            {
                //Console.WriteLine("HELLO THERE3");
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

            if(secondInningsTotal < firstInningsTotal)
            {
                Console.WriteLine("   ");
                Console.WriteLine("You have been knocked out of the World Cup."); 
                Console.WriteLine("   ");
                playerKnockedOut = true;
            } 

            if (battingWicketsLost < 10)
            {
                //Console.WriteLine("HELLO THERE4");
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

            Console.WriteLine("-------------");

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
                    //Console.WriteLine("HELLO THERE1");
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

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("        ");

            Console.WriteLine("-------------");
            Console.WriteLine("Fall of Wickets: ");

            index = 0;

            while (index < battingWicketsLost)
            {
                Console.WriteLine("Score: " + playerFallOfWicket_Runs[index] + " / " +
                    playerFallOfWicket_Wickets[index] + " . Wicket by: " + computerWicketTakers[index]);
                index++;
            }

            Console.WriteLine("        ");
            Console.Write("Press Enter to continue!");
            Console.ReadLine();

            Console.WriteLine("        ");

            Console.WriteLine("-------------");

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

            whoopie.Clear();
            economyRate.Clear();
            strikeRate.Clear();
            average.Clear();
            battingStrikeRateC.Clear();

            return secondInningsTotal;
        }

        /***************************************************************/

        public static void OtherTeamsPlay()
        {
            teams.Remove(sidePicked);
            allTeamBatsmen.Remove(playerBatting);
            allTeamKeepers.Remove(playerKeeping);
            allTeamAllRounders.Remove(playerAllRound);
            allTeamBowlers.Remove(playerBowling);

            if (teams.Count == 6)
            {
                Random r11 = new Random();
                int aniEatsIceCream1 = r11.Next(0, teams.Count - 1);
                string battleItOut1 = teams[aniEatsIceCream1];
                teams.Remove(battleItOut1);
                List<string> bat1 = allTeamBatsmen[aniEatsIceCream1];
                List<string> keep1 = allTeamKeepers[aniEatsIceCream1];
                List<string> allround1 = allTeamAllRounders[aniEatsIceCream1];
                List<string> bowl1 = allTeamBowlers[aniEatsIceCream1];
                allTeamBatsmen.RemoveAt(aniEatsIceCream1);
                allTeamKeepers.RemoveAt(aniEatsIceCream1);
                allTeamAllRounders.RemoveAt(aniEatsIceCream1);
                allTeamBowlers.RemoveAt(aniEatsIceCream1);

                Random r12 = new Random();
                int aniEatsIceCream2 = r12.Next(0, teams.Count - 1);
                string battleItOut2 = teams[aniEatsIceCream2];
                teams.Remove(battleItOut2);
                List<string> bat2 = allTeamBatsmen[aniEatsIceCream2];
                List<string> keep2 = allTeamKeepers[aniEatsIceCream2];
                List<string> allround2 = allTeamAllRounders[aniEatsIceCream2];
                List<string> bowl2 = allTeamBowlers[aniEatsIceCream2];
                allTeamBatsmen.RemoveAt(aniEatsIceCream2);
                allTeamKeepers.RemoveAt(aniEatsIceCream2);
                allTeamAllRounders.RemoveAt(aniEatsIceCream2);
                allTeamBowlers.RemoveAt(aniEatsIceCream2);

                Random r13 = new Random();
                int aniEatsIceCream3 = r13.Next(0, teams.Count - 1);
                string battleItOut3 = teams[aniEatsIceCream3];
                teams.Remove(battleItOut3);
                List<string> bat3 = allTeamBatsmen[aniEatsIceCream3];
                List<string> keep3 = allTeamKeepers[aniEatsIceCream3];
                List<string> allround3 = allTeamAllRounders[aniEatsIceCream3];
                List<string> bowl3 = allTeamBowlers[aniEatsIceCream3];
                allTeamBatsmen.RemoveAt(aniEatsIceCream3);
                allTeamKeepers.RemoveAt(aniEatsIceCream3);
                allTeamAllRounders.RemoveAt(aniEatsIceCream3);
                allTeamBowlers.RemoveAt(aniEatsIceCream3);

                Random r14 = new Random();
                int aniEatsIceCream4 = r14.Next(0, teams.Count - 1);
                string battleItOut4 = teams[aniEatsIceCream4];
                teams.Remove(battleItOut4);
                List<string> bat4 = allTeamBatsmen[aniEatsIceCream4];
                List<string> keep4 = allTeamKeepers[aniEatsIceCream4];
                List<string> allround4 = allTeamAllRounders[aniEatsIceCream4];
                List<string> bowl4 = allTeamBowlers[aniEatsIceCream4];
                allTeamBatsmen.RemoveAt(aniEatsIceCream4);
                allTeamKeepers.RemoveAt(aniEatsIceCream4);
                allTeamAllRounders.RemoveAt(aniEatsIceCream4);
                allTeamBowlers.RemoveAt(aniEatsIceCream4);

                Random r15 = new Random();
                int aniEatsIceCream5 = r15.Next(0, teams.Count - 1);
                string battleItOut5 = teams[aniEatsIceCream5];
                teams.Remove(battleItOut5);
                List<string> bat5 = allTeamBatsmen[aniEatsIceCream5];
                List<string> keep5 = allTeamKeepers[aniEatsIceCream5];
                List<string> allround5 = allTeamAllRounders[aniEatsIceCream5];
                List<string> bowl5 = allTeamBowlers[aniEatsIceCream5];
                allTeamBatsmen.RemoveAt(aniEatsIceCream5);
                allTeamKeepers.RemoveAt(aniEatsIceCream5);
                allTeamAllRounders.RemoveAt(aniEatsIceCream5);
                allTeamBowlers.RemoveAt(aniEatsIceCream5);

                Random r16 = new Random();
                int aniEatsIceCream6 = r16.Next(0, teams.Count - 1);
                string battleItOut6 = teams[aniEatsIceCream6];
                teams.Remove(battleItOut6);
                List<string> bat6 = allTeamBatsmen[aniEatsIceCream6];
                List<string> keep6 = allTeamKeepers[aniEatsIceCream6];
                List<string> allround6 = allTeamAllRounders[aniEatsIceCream6];
                List<string> bowl6 = allTeamBowlers[aniEatsIceCream6];
                allTeamBatsmen.RemoveAt(aniEatsIceCream6);
                allTeamKeepers.RemoveAt(aniEatsIceCream6);
                allTeamAllRounders.RemoveAt(aniEatsIceCream6);
                allTeamBowlers.RemoveAt(aniEatsIceCream6);

                Console.WriteLine(battleItOut1 + " beat " + battleItOut2);
                Console.WriteLine(battleItOut3 + " beat " + battleItOut4);
                Console.WriteLine(battleItOut5 + " beat " + battleItOut6);

                teams.Add(battleItOut1);
                allTeamBatsmen.Add(bat1);
                allTeamKeepers.Add(keep1);
                allTeamAllRounders.Add(allround1);
                allTeamBowlers.Add(bowl1);

                teams.Add(battleItOut3);
                allTeamBatsmen.Add(bat3);
                allTeamKeepers.Add(keep3);
                allTeamAllRounders.Add(allround3);
                allTeamBowlers.Add(bowl3);

                teams.Add(battleItOut5);
                allTeamBatsmen.Add(bat5);
                allTeamKeepers.Add(keep5);
                allTeamAllRounders.Add(allround5);
                allTeamBowlers.Add(bowl5);
            }

            if (teams.Count == 2)
            {
                Random r11 = new Random();
                int aniEatsIceCream1 = r11.Next(0, teams.Count - 1);
                battleItOut1C = teams[aniEatsIceCream1];
                teams.Remove(battleItOut1C);
                bat1C = allTeamBatsmen[aniEatsIceCream1];
                keep1C = allTeamKeepers[aniEatsIceCream1];
                allround1C = allTeamAllRounders[aniEatsIceCream1];
                bowl1C = allTeamBowlers[aniEatsIceCream1];
                allTeamBatsmen.RemoveAt(aniEatsIceCream1);
                allTeamKeepers.RemoveAt(aniEatsIceCream1);
                allTeamAllRounders.RemoveAt(aniEatsIceCream1);
                allTeamBowlers.RemoveAt(aniEatsIceCream1);

                Random r12 = new Random();
                int aniEatsIceCream2 = r12.Next(0, teams.Count - 1);
                battleItOut2C = teams[aniEatsIceCream2];
                teams.Remove(battleItOut2C);
                List<string> bat2 = allTeamBatsmen[aniEatsIceCream2];
                List<string> keep2 = allTeamKeepers[aniEatsIceCream2];
                List<string> allround2 = allTeamAllRounders[aniEatsIceCream2];
                List<string> bowl2 = allTeamBowlers[aniEatsIceCream2];
                allTeamBatsmen.RemoveAt(aniEatsIceCream2);
                allTeamKeepers.RemoveAt(aniEatsIceCream2);
                allTeamAllRounders.RemoveAt(aniEatsIceCream2);
                allTeamBowlers.RemoveAt(aniEatsIceCream2);

                Console.WriteLine(battleItOut1C + " beat " + battleItOut2C);

                teams.Add(battleItOut1C);
                Console.WriteLine("Got Here");
                allTeamBatsmen.Add(bat1C);
                allTeamKeepers.Add(keep1C);
                allTeamAllRounders.Add(allround1C);
                allTeamBowlers.Add(bowl1C);

                onlyOneOpponentLeft = true;
            }

            teams.Add(sidePicked);
            allTeamBatsmen.Add(playerBatting);
            allTeamKeepers.Add(playerKeeping);
            allTeamAllRounders.Add(playerAllRound);
            allTeamBowlers.Add(playerBowling);
        }

    }
}