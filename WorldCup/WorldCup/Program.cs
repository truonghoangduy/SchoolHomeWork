using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    public class Program
    {
        static void Main(string[] args)
        {
            Area area = new Area();
            Stage stage = new Stage();
            //Player Induvitual = new Player("duy");
            //Console.WriteLine(Induvitual.playerName + Induvitual._Pesonalsroce.ToString());
            //Console.ReadLine();
            DatabaseConnector database = new DatabaseConnector();
            //String Querydata = @'SELECT * FROM player';


            //for (int i = 1; i <= area.GetContinentCode(Continent.Host); i++)
            //{
            //    Teem teemEnter = new Teem();
            //    teemEnter = database.makeQueryByTeem(i);
            //    stage.Add_Teem_To_Stage(teemEnter);
            //}
            //stage.printAllTeem_In_Match();

            //List<Teem> AsianTeem = new List<Teem>();
            //stage.Add_Teem_To_Stage(database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia)));
            //stage.printAllTeem_In_Match();

            //List<Player> players = new List<Player>();
            //players = database.GetPlayerByTeem(36);
            //foreach (var item in players)
            //{
            //    Console.WriteLine(item.playerName);
            //}



            //Match match = new Match();


            //FinalRound final = new FinalRound();
            //Teem teem = new Teem();
            //var teemList = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            //var whowin = final.startFinal(teemList[0], teemList[1]);
            //Console.WriteLine("Teem Enter");
            //for (int i = 0; i < teemList.Count; i++)
            //{
            //    Console.WriteLine(teemList[i].CountryName);
            //}
            //Console.WriteLine("---------------------");
            //Console.WriteLine("The winner is : "+whowin.CountryName +"  which the total of "+whowin.SrocePerRound);
            //foreach (var item in whowin.listOfPlayer)
            //{
            //    Console.WriteLine(item.playerName+" "+item._Pesonalsroce.ToString());
            //}



            //public bool WriteMatchToDB(Teem teemA, Teem teemB, int stage = 0, int ground = 0, string sroce = "")
            //{
            //    // this fuction write to Database which ref stage or ground if them are not 0 then it consider a legit match
            //    String GivenCommand = "INSERT INTO game (stage,ground,teemA,teemB,sroce)"
            //    + $"VALUES({stage},{ground},{teemA.CountryName},{teemB.CountryName},{sroce})";
            //    SqlCommand command = new SqlCommand(GivenCommand, makeConnection("open"));
            //    command.ExecuteNonQuery();
            //    makeConnection("close");
            //    return true;
            //}


            //Teem teemPlayoff = new Teem();
            //var TeemAsia = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            //var TeemNorthAmericaCentral = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            //stage.math.TeemA = TeemAsia[5];
            //stage.math.TeemB = TeemNorthAmericaCentral[3];
            //stage.math.who_Is_Winning();
            //String matchSroce = stage.math._winSroce + ":" + stage.math._loseSroce;
            ////stage.result.writeResultToDatabase(stage: 1, sroce: matchSroce);






            database._ClearTable("game");
            //List<Teem> teems = new List<Teem>();
            //List<Teem> teemTemp = new List<Teem>();

            //for (int i = 1; i <= 7; i++)
            //{
            //    stage.InitTeem.AddRange(database.makeTeam_QueryBy_Continnent(i));
            //}

            //A Match
            //stage.math.TeemA = teemTemp[1];
            //stage.math.TeemB = teemTemp[4];
            //stage.math.who_Is_Winning();
            //String matchSroceA = stage.math._winSroce + ":" + stage.math._loseSroce;

            //teemTemp.RemoveAt(stage.math.Loser.teemindexing);
            //stage.writeResultToDatabase(stage: stage.getGround(Stage_Enum.group),ground: stage.getRoundPerRound(RoundPerRound.A), sroce: matchSroceA);



            //stage.math.TeemA = teemTemp[2];
            //stage.math.TeemB = teemTemp[3];
            //stage.math.who_Is_Winning();
            //String matchSroceB = stage.math._winSroce + ":" + stage.math._loseSroce;
            //stage.writeResultToDatabase(stage: stage.getGround(Stage_Enum.group), ground: stage.getRoundPerRound(RoundPerRound.A), sroce: matchSroceB);



            //int counterRound = 1;
            //foreach (var item in stage.InitTeem)
            //{
            //    Console.WriteLine(item.teemindexing +" "+item.CountryName);
            //}
            //Console.WriteLine("=========");
            //List<int> Teemremote = new List<int>();
            //for (int i = 0; i <= 32; i+=2)
            //{
            //    if (i<=30)
            //    {
            //        stage.math.TeemA = stage.InitTeem[i];
            //        stage.math.TeemB = stage.InitTeem[i + 1];
            //        stage.math.who_Is_Winning();
            //        Console.WriteLine(stage.math.Winner.teemindexing.ToString() + "    " + stage.math.Loser.teemindexing.ToString());
            //        String matchSroceZ = stage.math._winSroce + ":" + stage.math._loseSroce;
            //        stage.result.writeResultToDatabase(stage.math.Winner, stage.math.Loser,stage: stage.getGround(Stage_Enum.group), ground: counterRound, sroce: matchSroceZ);

            //        Teemremote.Add(stage.math.Loser.teemindexing);
            //        counterRound += 1;
            //    }
            //    else
            //    {
            //        break;
            //    }

            //}
            //var descendingOrder = Teemremote.OrderByDescending(i => i).ToList();
            //int remotecounter = 0;
            //foreach (var item in Teemremote)
            //{
            //    if (item != null) { 
            //    stage.InitTeem.RemoveAt(descendingOrder[remotecounter]);
            //        remotecounter += 1;
            //    }
            //}
            //foreach (var item in stage.InitTeem)
            //{
            //    Console.WriteLine(item.CountryName);
            //}



            if (stage.InitTeemForBattle())
            {
                Console.WriteLine(stage.InitTeem.Count() ); 
                stage.Start_Frist_PlayOff();
                Console.WriteLine(stage.InitTeem.Count());
                stage.Start_Sec_PlayOff();
                Console.WriteLine(stage.InitTeem.Count());
                stage.Start_Frist_RoundBattle();
                stage.Start_Sec_RoundBattle();
                stage.Start_QuaterFinal();
                stage.Start_SemiFinal();

            }

            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            Console.ReadLine();

            //Area test = new Area();
            //test.radomArea(Continent.Asia);
            //test.printall();
            //Console.WriteLine("---");
            //test.radomArea(Continent.Australia);
            //test.printall();
            //Console.ReadLine();






        }
    }
}
