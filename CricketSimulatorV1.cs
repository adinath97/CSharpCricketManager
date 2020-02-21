using System;
using System.Numerics;
using System.Collections.Generic;

namespace CricketTenOnTenWithToss
{
    class MainClass
    {
        //team A = rcb; team B = csk

        public static BigInteger firstInningsTotal = 0;
        public static BigInteger secondInningsTotal = 0;
        public static BigInteger battingScore = 0;
        public static BigInteger currentBatsmanScore = 0;
        public static BigInteger bowlingScore = 0;
        public static int battingWicketsLost = 0;
        public static BigInteger numberOfPlayersTeamA = 0;
        public static BigInteger numberOfPlayersTeamB = 0;
        /* public static BigInteger numberOfTrials;
        public static BigInteger team1Wins = 0;
        public static BigInteger team2Wins = 0;
        public static BigInteger ties = 0;
        public static BigInteger highestFirstInningsScore = 0;
        public static BigInteger highestSecondInningsScore = 0;
        public static List<BigInteger> allFirstInningsScores = new List<BigInteger>();
        public static List<BigInteger> allSecondInningsScores = new List<BigInteger>(); */
        public static List<BigInteger> firstInnings = new List<BigInteger>();
        public static List<BigInteger> secondInnings = new List<BigInteger>();
        public static List<string> playerPool = new List<string>();
        public static List<string> teamA = new List<string>();
        public static List<string> teamB = new List<string>();
        public static bool firstInningsComplete = false;
        public static bool secondInningsComplete = false;
        public static bool gameOver = false;

        public static BigInteger toss1, tossResult, tossDecision, waitWhoBatting;

        public static void Main(string[] args)
        {
            CreateTeams();
            Toss();
            LetTheGamesBegin();
        }

        public static void LetTheGamesBegin()
        {
            if (waitWhoBatting == 1 || waitWhoBatting == 4)
            {
                /* Team A bats first, Team B bats second. */
                FirstInningsTeamABats();
                SecondInningsTeamBBats(firstInningsTotal);
            }
            if (waitWhoBatting == 2 || waitWhoBatting == 3)
            {
                /* Team B bats first, Team A bats second. */
                FirstInningsTeamBBats();
                SecondInningsTeamABats(firstInningsTotal);
            }
        }

        public static void CreateTeams()
        {
            //batsmen and keepers
            playerPool.Add("Virat Kohli");
            playerPool.Add("Saurav Ganguly");
            playerPool.Add("M.S. Dhoni");
            playerPool.Add("Sachin Tendulkar"); 
            playerPool.Add("Rahul Dravid"); 
            playerPool.Add("Steven Smith");
            playerPool.Add("Ricky Ponting");
            playerPool.Add("Kumar Sangakkara");
            playerPool.Add("Mahela Jayawardene");
            playerPool.Add("Alistair Cook");
            playerPool.Add("Jonathan Trott");
            playerPool.Add("Viv Richards");
            playerPool.Add("Brian Lara");
            playerPool.Add("Kane Williamson");
            playerPool.Add("VVS Laxman");
            playerPool.Add("Damian Flemming");


            //bowlers
            playerPool.Add("Shane Warne");
            playerPool.Add("Glen McGrath");
            playerPool.Add("James Anderson");
            playerPool.Add("Curtly Ambrose");
            playerPool.Add("Muttiah Muralidharan");
            playerPool.Add("Malcolm Marshall");
            playerPool.Add("Stuart Broad");
            playerPool.Add("Dale Steyn");
            playerPool.Add("Anil Kumble");
            playerPool.Add("Dennis Lillee");

            //allrounders
            playerPool.Add("Jacques Kallis");
            playerPool.Add("Shakib Al Hasan");

            while(numberOfPlayersTeamA < 10)
            {
                var random1 = new Random();
                int index1 = random1.Next(playerPool.Count);
                teamA.Add(playerPool[index1]);
                playerPool.Remove(playerPool[index1]);
                numberOfPlayersTeamA += 1;
            }

            while (numberOfPlayersTeamB < 10)
            {
                var random2 = new Random();
                int index2 = random2.Next(playerPool.Count);
                teamB.Add(playerPool[index2]);
                playerPool.Remove(playerPool[index2]);
                numberOfPlayersTeamB += 1;
            }

            Console.WriteLine("Team for Royal Challengers Bangalore: ");

            foreach (string x in teamA)
            {
                Console.WriteLine(x + ",");
            }

            Console.WriteLine("-------");

            Console.WriteLine("Team for Chennai Super Kings: ");

            foreach (string x in teamB)
            {
                Console.WriteLine(x + ",");
            }

            Console.WriteLine("-------");

        }

        public static BigInteger Toss()
        {
            Random tossR = new Random();
            toss1 = tossR.Next(0, 2);

            Random tossresult = new Random();
            tossResult = tossresult.Next(0, 2);

            if(toss1 == tossResult)
            {
                Console.WriteLine("Royal Challengers Bangalore have won the toss.");

                Random tossdecision = new Random();
                tossDecision = tossdecision.Next(0, 2);

                if (tossDecision == 1)
                {
                    Console.WriteLine("Royal Challengers Bangalore will bat first.");
                    waitWhoBatting = 1;
                    /* Team A bats first, Team B bats second. */
                }
                else
                {
                    Console.WriteLine("Royal Challengers Bangalore will bowl first.");
                    waitWhoBatting = 2;
                    /* Team B bats first, Team A bats second. */
                }
            }
            else
            {
                Console.WriteLine("Chennai Super Kings won the toss");

                Random tossdecision = new Random();
                tossDecision = tossdecision.Next(0, 2);

                if (tossDecision == 1)
                {
                    Console.WriteLine("Chennai Super Kings will bat first.");
                    waitWhoBatting = 3;
                    /* Team B bats first, Team A bats second. */

                }
                else
                {
                    Console.WriteLine("Chennai Super Kings will bowl first.");
                    waitWhoBatting = 4;
                    /* Team A bats first, Team B bats second. */
                }
            }

            return waitWhoBatting;
        }

        public static BigInteger FirstInningsTeamABats()
        {
            battingWicketsLost = 0;
            firstInningsTotal = 0;
            currentBatsmanScore = 0;
            firstInningsComplete = false;

            while (firstInningsComplete == false)
            {
                Random rbattingScore = new Random();
                battingScore = rbattingScore.Next(0, 7);

                Random rbowlingScore = new Random();
                bowlingScore = rbowlingScore.Next(0, 7);

                if (!(battingScore == bowlingScore))
                {
                    firstInningsTotal += battingScore;
                    currentBatsmanScore += battingScore;

                }
                else if (battingScore == bowlingScore)
                {
                    battingWicketsLost += 1;
                    string player = teamA[battingWicketsLost - 1];
                    Console.Write(player + " : " + currentBatsmanScore + ".");
                    Console.WriteLine(" RCB : " + firstInningsTotal + " / " + battingWicketsLost);
                    currentBatsmanScore = 0;

                    if (battingWicketsLost == 10)
                    {
                        firstInningsComplete = true;
                    }
                }
            }

            Console.WriteLine("RCB has scored " + firstInningsTotal);
            return firstInningsTotal;

        }

        public static BigInteger SecondInningsTeamBBats(BigInteger input)
        {
            battingScore = 0;
            bowlingScore = 0;
            battingWicketsLost = 0;
            secondInningsTotal = 0;
            currentBatsmanScore = 0;
            secondInningsComplete = false;
            gameOver = false;

            while (secondInningsComplete == false && gameOver == false)
            {
                Random rbattingScore = new Random();
                battingScore = rbattingScore.Next(0, 7);

                Random rbowlingScore = new Random();
                bowlingScore = rbowlingScore.Next(0, 7);

                if (!(battingScore == bowlingScore))
                {
                    secondInningsTotal += battingScore;
                    currentBatsmanScore += battingScore;

                    if (secondInningsTotal > input)
                    {
                        gameOver = true;
                        secondInningsComplete = true;
                        string player = teamB[battingWicketsLost];
                        Console.WriteLine(player + " is not out on " + currentBatsmanScore);
                        // team2Wins += 1;
                        Console.WriteLine("The second innings total is " + secondInningsTotal + " (for the loss of " + battingWicketsLost
                         + " wickets) and so CSK " + " won the game.");
                    }
                }

                else if (battingScore == bowlingScore)
                {
                    battingWicketsLost += 1;
                    string player = teamB[battingWicketsLost - 1];
                    Console.Write(player + " : " + currentBatsmanScore + " runs.");
                    Console.WriteLine(" CSK : " + secondInningsTotal + " / " + battingWicketsLost);
                    currentBatsmanScore = 0;

                    if (battingWicketsLost == 10 && secondInningsTotal == input)
                    {
                        gameOver = true;
                        secondInningsComplete = true;
                        // ties += 1;
                        Console.WriteLine("Its a tie!");
                    }
                    if (battingWicketsLost == 10 && secondInningsTotal < input)
                    {
                        gameOver = true;
                        secondInningsComplete = true;
                        // team1Wins += 1;
                        Console.WriteLine("CSK has only scored " + secondInningsTotal + " and has thus lost " +
                            " the game by " + (input - secondInningsTotal) + " runs.");
                    }
                }
            }

            return secondInningsTotal;
        }

        public static BigInteger FirstInningsTeamBBats()
        {
            battingWicketsLost = 0;
            firstInningsTotal = 0;
            currentBatsmanScore = 0;
            firstInningsComplete = false;

            while (firstInningsComplete == false)
            {
                Random rbattingScore = new Random();
                battingScore = rbattingScore.Next(0, 7);

                Random rbowlingScore = new Random();
                bowlingScore = rbowlingScore.Next(0, 7);

                if (!(battingScore == bowlingScore))
                {
                    firstInningsTotal += battingScore;
                    currentBatsmanScore += battingScore;
                }
                else if (battingScore == bowlingScore)
                {
                    battingWicketsLost += 1;
                    string player = teamB[battingWicketsLost - 1];
                    Console.Write(player + " : " + currentBatsmanScore + ".");
                    Console.WriteLine(" CSK : " + firstInningsTotal + " / " + battingWicketsLost);
                    currentBatsmanScore = 0;

                    if (battingWicketsLost == 10)
                    {
                        firstInningsComplete = true;
                    }
                }
            }

            Console.WriteLine("CSK has scored " + firstInningsTotal);
            return firstInningsTotal;
        }

        public static BigInteger SecondInningsTeamABats(BigInteger input)
        {
            battingScore = 0;
            bowlingScore = 0;
            currentBatsmanScore = 0;
            battingWicketsLost = 0;
            secondInningsTotal = 0;
            secondInningsComplete = false;
            gameOver = false;

            while (secondInningsComplete == false && gameOver == false)
            {
                Random rbattingScore = new Random();
                battingScore = rbattingScore.Next(0, 7);

                Random rbowlingScore = new Random();
                bowlingScore = rbowlingScore.Next(0, 7);

                if (!(battingScore == bowlingScore))
                {
                    secondInningsTotal += battingScore;
                    currentBatsmanScore += battingScore;

                    if (secondInningsTotal > input)
                    {
                        gameOver = true;
                        secondInningsComplete = true;
                        string player = teamA[battingWicketsLost];
                        Console.WriteLine(player + " is not out on " + currentBatsmanScore);
                        // team2Wins += 1;
                        Console.WriteLine("The second innings total is " + secondInningsTotal + " (for the loss of " + battingWicketsLost
                         + " wickets) and so RCB " + " won the game.");
                    }
                }

                else if (battingScore == bowlingScore)
                {
                    battingWicketsLost += 1;
                    string player = teamA[battingWicketsLost - 1];
                    Console.Write(player + " : " + currentBatsmanScore + " runs.");
                    Console.WriteLine(" RCB : " + secondInningsTotal + " / " + battingWicketsLost);
                    currentBatsmanScore = 0;

                    if (battingWicketsLost == 10 && secondInningsTotal == input)
                    {
                        gameOver = true;
                        secondInningsComplete = true;
                        // ties += 1;
                        Console.WriteLine("Its a tie!");
                    }
                    if (battingWicketsLost == 10 && secondInningsTotal < input)
                    {
                        gameOver = true;
                        secondInningsComplete = true;
                        // team1Wins += 1;
                        Console.WriteLine("RCB has only scored " + secondInningsTotal + " and has thus lost" +
                            " the game by " + (input - secondInningsTotal) + " runs.");
                    }
                }
            }

            return secondInningsTotal;
        }
    }
}