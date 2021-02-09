using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void AddNewCampaign(Campaign campaign)
        {
            Console.WriteLine($"new campaign {campaign.CampaignName} with -%{campaign.CampaignDiscountRate * 100} discount rate added..");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine($" Campaign {campaign.CampaignName} with -%{campaign.CampaignDiscountRate * 100} discount rate deleted..");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine($" Campaign {campaign.CampaignName} updated..");
        }
    }
}
