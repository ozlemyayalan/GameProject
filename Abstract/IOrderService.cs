using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IOrderService
    {
        void Sale(Game game, Player player, Orders orders, Campaign campaign);


    }
}
