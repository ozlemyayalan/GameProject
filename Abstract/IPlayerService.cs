using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IPlayerService
    {
        void RegisterAccount(Player player);

        void UpdateInformation(Player player);

        void DeleteAccount(Player player);



    }
}
