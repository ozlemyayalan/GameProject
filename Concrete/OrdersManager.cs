using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class OrdersManager : IOrderService
    {
        public void Sale(Game game, Player player, Orders orders, Campaign campaign)
        {
            Console.WriteLine($"{player.FirstName}'s order (#{orders.OrderId}) has been completed. \nwith %{campaign.CampaignDiscountRate * 100} discount, {game.GameName} is yours now!.. Have fun!..");

        }
    }
}
