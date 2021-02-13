using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GameProject.Abstract
{

    public interface ISalesService
    {
        void Sales(Game game,Gamer gamer);
        void CampaignSales(Game game,Gamer gamer,Campaign campaign);
    }
}