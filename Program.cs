using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GameProject
{

    public static class Program 
    {
        public static void Main(string[] args) 
        {
           GamerManager gamerManager1 = new GamerManager(new UserValidationManager());
           Gamer gamer1 = new Gamer() { Id=1,BirthYear=1997 ,FirstName="Ertuğrul",LastName="Sayılır",IdentityNumber=4826};
           GamerManager gamerManager2 = new GamerManager(new UserValidationManager());
           Gamer gamer2 = new Gamer() {Id=2,BirthYear=1999,FirstName="Fatma",LastName="Karabacak",IdentityNumber=56325};
           
           Game game1 = new Game() { Id=3,GameName ="Wild Rift",GamePrice=800};
           Game game2 = new Game() { Id=4,GameName ="CYBERPUNK",GamePrice=1500};
           Game game3 = new Game() { Id=5,GameName ="GTA 5",GamePrice=750};
           
           Campaign campaign1 = new Campaign() { CampaignName="YENİ YIL KAMPANYASI",DiscountRate=20,CampaignId=2};
           Campaign campaign2 = new Campaign() { CampaignName="MART KAMPANYASI",DiscountRate=30,CampaignId=3};
           
           CampaignManager campaignManager = new CampaignManager();
           campaignManager.Add(campaign1);
           campaignManager.Add(campaign2);
           campaignManager.Update(campaign1);
           campaignManager.Update(campaign2);
           campaignManager.Delete(campaign1);
           campaignManager.Delete(campaign2);
           
           SalesManager salesManager = new SalesManager();
           salesManager.Sales(game2,game1);
           salesManager.CampaignSales(game2,game3,campaign2);
         
         
        }
    }
}