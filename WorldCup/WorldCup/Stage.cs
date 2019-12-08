using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    public enum GameStage
    {
        ForTestCase,
        playoff,
        group,
        knockout,
        quarterfinal,
        semifinal,
        final
    }
    public enum RoundPerRound
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H

    }
    public class Stage
    {
        public List<Teem> InitTeem = new List<Teem>();
        public Match math = new Match();
        public Result result = new Result();
        public DatabaseConnector database = new DatabaseConnector();


        public List<int> RoundHasPlay =new List<int>();
        public void Add_Teem_To_Stage(List<Teem> teemObject)
        {
            InitTeem.AddRange(teemObject);
        }
        public void printAllTeem_In_Match()
        {
            foreach (var item in InitTeem)
            {
                item.printallPlayer();
            }
        }
        public bool InitTeemForBattle()
        {
            try
            {
                for (int i = 1; i <= 7; i++)
                {
                    InitTeem.AddRange(database.makeTeam_QueryBy_Continnent(i));
                }
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        } 
        public void PlayoffStage(Teem teemA,Teem teemB,Teem teemC,Teem teemD)
        {
            Match match = new Match();

        }

        public int getGround(Stage_Enum stage_Enum)
        {
            switch (stage_Enum)
            {
                case Stage_Enum.TestCase:
                    return 0;
                    break;
                case Stage_Enum.playoff:
                    return 1;
                    break;
                case Stage_Enum.group:
                    return 2;
                    break;
                case Stage_Enum.knockout:
                    return 3;
                    break;
                case Stage_Enum.quarterfinal:
                    return 4;
                    break;
                case Stage_Enum.semifinal:
                    return 5;
                    break;
                case Stage_Enum.final:
                    return 6;
                    break;
                default:
                    return 0;
                    break;
            }

        }
        public int getRoundPerRound(RoundPerRound round)
        {
            switch (round)
            {
                case RoundPerRound.A:
                    return 1;
                    break;
                case RoundPerRound.B:
                    return 2;
                    break;
                case RoundPerRound.C:
                    return 3;
                    break;
                case RoundPerRound.D:
                    return 4;
                    break;
                case RoundPerRound.E:
                    return 5;
                    break;
                case RoundPerRound.F:
                    return 6;
                    break;
                case RoundPerRound.G:
                    return 7;
                    break;
                case RoundPerRound.H:
                    return 8;
                    break;
                default:
                    return 0;
                    break;
            }
        }

        public void Start_Frist_PlayOff()
        {
            int counterRound = 1;
            List<int> Teemremote = new List<int>();
            math.TeemA = InitTeem[5];
            math.TeemB = InitTeem[14];
            String matchSroceZ = math._winSroce + ":" + math._loseSroce;
            result.writeResultToDatabase(math.Winner, math.Loser, stage: getGround(Stage_Enum.playoff), ground: counterRound, sroce: matchSroceZ);
            Teemremote.Add(math.Loser.teemindexing);
            counterRound += 1;
            //Start Cleaning up the lose teem
            var descendingOrder = Teemremote.OrderByDescending(i => i).ToList();
            int remotecounter = 0;
            foreach (var item in Teemremote)
            {
                if (item != null)
                {
                    InitTeem.RemoveAt(descendingOrder[remotecounter]);
                    remotecounter += 1;
                }
            }
        }

        public bool Start_Sec_PlayOff()
        {
            int counterRound = 1;
            List<int> Teemremote = new List<int>();
                math.TeemA = InitTeem[17];
                math.TeemB = InitTeem[18];
                String matchSroceZ = math._winSroce + ":" + math._loseSroce;
                result.writeResultToDatabase(math.Winner, math.Loser, stage: getGround(Stage_Enum.playoff), ground: counterRound, sroce: matchSroceZ);
                Teemremote.Add(math.Loser.teemindexing);
                counterRound += 1;
                //Start Cleaning up the lose teem
                var descendingOrder = Teemremote.OrderByDescending(i => i).ToList();
                int remotecounter = 0;

            foreach (var item in Teemremote)
            {
                if (item != null)
                {
                    InitTeem.RemoveAt(descendingOrder[remotecounter]);
                    remotecounter += 1;
                }
            }
            return true;
            
        }

        public bool Start_Frist_RoundBattle()
        {
            int counterRound = 1;
            List<int> Teemremote = new List<int>();
            try
            {
                for (int i = 0; i < 32; i += 2)
                {
                    //if (i <= 31)
                    //{
                        math.TeemA = InitTeem[i];
                        math.TeemB = InitTeem[i + 1];
                        math.who_Is_Winning();
                        Console.WriteLine(math.Winner.teemindexing.ToString() + "    " + math.Loser.teemindexing.ToString());
                        String matchSroceZ = math._winSroce + ":" + math._loseSroce;
                        result.writeResultToDatabase(math.Winner, math.Loser, stage: getGround(Stage_Enum.group), ground: counterRound, sroce: matchSroceZ);
                        Teemremote.Add(math.Loser.teemindexing);
                        RoundHasPlay.Add(counterRound);
                        counterRound += 1;
                    //}
                    //else
                    //{
                    //    break;
                    //}

                }
                    //Start Cleaning up the lose teem
                    var descendingOrder = Teemremote.OrderByDescending(i => i).ToList();
                for (int i = 0; i < descendingOrder.Count; i++)
                {
                    if (descendingOrder[i] > 31)
                    {
                        descendingOrder.RemoveAt(i);
                    }
                }
                int remotecounter = 0;
                foreach (var item in descendingOrder)
                {
                    if (item != null)
                    {
                        InitTeem.RemoveAt(descendingOrder[remotecounter]);
                        remotecounter += 1;
                    }
                }
                //for (int i = 0; i < descendingOrder.Count; i++)
                //{
                //    Console.WriteLine(InitTeem.Count);
                //    InitTeem.RemoveAt(descendingOrder[i]);
                //    Console.WriteLine(InitTeem.Count);
                //    remotecounter += 1;
                //}
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
           

        }


        public bool Start_Sec_RoundBattle()
        {
            Console.WriteLine("Sec Round");
            int counterRound = 1;
            List<int> Teemremote = new List<int>();
            try
            {
                for (int i = 0; i <= 16; i += 2)
                {
                    if (i < 15)
                    {
                        math.TeemA = InitTeem[i];
                        math.TeemB = InitTeem[i + 1];
                        math.who_Is_Winning();
                        Console.WriteLine(math.Winner.teemindexing.ToString() + "    " + math.Loser.teemindexing.ToString());
                        String matchSroceZ = math._winSroce + ":" + math._loseSroce;
                        result.writeResultToDatabase(math.Winner, math.Loser, stage: getGround(Stage_Enum.group), ground: counterRound, sroce: matchSroceZ);
                        
                        if (math.TeemA.SrocePerRound > math.TeemB.SrocePerRound)
                        {
                            Teemremote.Add(i);
                        }
                        else
                        {
                            Teemremote.Add(i+1);
                        }
                        RoundHasPlay.Add(counterRound);
                        counterRound += 1;
                    }
                    else
                    {
                        break;
                    }

                }
                //Start Cleaning up the lose teem
                var descendingOrder = Teemremote.OrderByDescending(i => i).ToList();
                int remotecounter = 0;
                for (int i = 0; i <= descendingOrder.Count; i++)
                {
                    if (descendingOrder[i] >= 16)
                    {
                        descendingOrder.RemoveAt(i);
                    }
                }
                Console.WriteLine("AA");
                for (int i = 0; i < descendingOrder.Count; i++)
                {
                    InitTeem.RemoveAt(i);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }


        }

        public bool Start_QuaterFinal() {

            int counterRound2 = 1;
            List<int> Teemremote = new List<int>();
            for (int i = 0; i <= 8; i += 2)
            {
                if (i <= 6)
                {
                    math.TeemA = InitTeem[i];
                    math.TeemB = InitTeem[i + 1];
                    math.who_Is_Winning();
                    Console.WriteLine(math.Winner.teemindexing.ToString() + "    " + math.Loser.teemindexing.ToString());
                    String matchSroceZ = math._winSroce + ":" + math._loseSroce;
                    result.writeResultToDatabase(math.Winner, math.Loser, stage: getGround(Stage_Enum.quarterfinal), ground: counterRound2, sroce: matchSroceZ);
                    RoundHasPlay.Add(counterRound2);
                    Teemremote.Add(math.Loser.teemindexing);
                    counterRound2 += 1;
                }
                else
                {
                    break;
                }

            }
            //Start Cleaning up the lose teem
            var descendingOrder = Teemremote.OrderByDescending(i => i).ToList();
            int remotecounter = 0;
            foreach (var item in Teemremote)
            {
                if (item != null)
                {
                    InitTeem.RemoveAt(descendingOrder[remotecounter]);
                    remotecounter += 1;
                }
            }

            return false;
        }
        public bool Start_SemiFinal()
        {

            int counterRound2 = 1;
            List<int> Teemremote = new List<int>();
            for (int i = 0; i <= 4; i += 2)
            {
                if (i <= 2)
                {
                    math.TeemA = InitTeem[i];
                    math.TeemB = InitTeem[i + 1];
                    math.who_Is_Winning();
                    Console.WriteLine(math.Winner.teemindexing.ToString() + "    " + math.Loser.teemindexing.ToString());
                    String matchSroceZ = math._winSroce + ":" + math._loseSroce;
                    result.writeResultToDatabase(math.Winner, math.Loser, stage: getGround(Stage_Enum.semifinal), ground: counterRound2, sroce: matchSroceZ);
                    RoundHasPlay.Add(counterRound2);
                    Teemremote.Add(math.Loser.teemindexing);
                    counterRound2 += 1;
                }
                else
                {
                    break;
                }

            }
            //Start Cleaning up the lose teem
            var descendingOrder = Teemremote.OrderByDescending(i => i).ToList();
            int remotecounter = 0;
            foreach (var item in Teemremote)
            {
                if (item != null)
                {
                    InitTeem.RemoveAt(descendingOrder[remotecounter]);
                    remotecounter += 1;
                }
            }

            return false;
        }

        public bool Start_Final()
        {
            int counterRound2 = 1;
            List<int> Teemremote = new List<int>();
            for (int i = 0; i <= 2; i += 2)
            {
                if (i <= 2)
                {
                    math.TeemA = InitTeem[i];
                    math.TeemB = InitTeem[i + 1];
                    math.who_Is_Winning();
                    Console.WriteLine(math.Winner.teemindexing.ToString() + "    " + math.Loser.teemindexing.ToString());
                    String matchSroceZ = math._winSroce + ":" + math._loseSroce;
                    result.writeResultToDatabase(math.Winner, math.Loser, stage: getGround(Stage_Enum.semifinal), ground: counterRound2, sroce: matchSroceZ);
                    RoundHasPlay.Add(counterRound2);
                    Teemremote.Add(math.Loser.teemindexing);
                    counterRound2 += 1;
                }
                else
                {
                    break;
                }

            }
            //Start Cleaning up the lose teem
            var descendingOrder = Teemremote.OrderByDescending(i => i).ToList();
            int remotecounter = 0;
            foreach (var item in Teemremote)
            {
                if (item != null)
                {
                    InitTeem.RemoveAt(descendingOrder[remotecounter]);
                    remotecounter += 1;
                }
            }

            return false;
        }
    }


}
