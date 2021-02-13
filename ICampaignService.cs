using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GameProject.Abstract
{

    public interface ICampaignService
    {
    	void Add(Campaign campaign);
    	void Update(Campaign campaign);
    	void Delete(Campaign campaign);
    }
}