using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GameProject.Manager:IGameService
{

    class CampaignManager
    {
        public void Add(Campaign campaign)
        {
           Console.WriteLine("Kampanya eklendi: "+campaign.CampaignName+"İndirim oranı:"+campaign.DiscountRate+'\n');
        }
        
        public void Update(Campaign campaign)
        {
           Console.WriteLine("Kampanya güncellendi: "+campaign.CampaignName+"İndirim oranı:"+campaign.DiscountRate+'\n');
        }
        
        public void Delete(Campaign campaign)
        {
           Console.WriteLine(campaign.CampaignName+"süresi doldugundan kampanya silindi"+'\n');
        }
        
    }
}