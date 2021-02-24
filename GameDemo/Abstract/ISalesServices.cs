using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface ISalesServices
    {
        void Sales(Game game, Gamer gamer);
        void SaleswithCampaign(Game game, Gamer gamer, Campaign campaign);s
    }
}
