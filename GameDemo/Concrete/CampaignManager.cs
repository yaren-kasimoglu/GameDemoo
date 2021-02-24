using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya güncellendi");
        }
    }
}
