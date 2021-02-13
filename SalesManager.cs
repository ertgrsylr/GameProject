using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GameProject
{

    public class SalesManager : ISalesService
    {
         public void Sales(Game game,Gamer gamer)
         {
         	Console.WriteLine(gamer.FirstName+game.GameName+"oyunu aldı.");
         }
         
         public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
         {
         	Console.WriteLine(gamer.FirstName+campaign.CampaignName+"ve"+game.GameName+"oyunu aldı.");
         }
    }
}