using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {



        public virtual void RegisterAccount(Player player)
        {

            Console.WriteLine($" Our {player.Id + 1}. Player {player.FirstName}'s account has been created. Welcome to wonderland!..");

        }



        public virtual void DeleteAccount(Player player)
        {
            Console.WriteLine($" Player {player.FirstName}'s account has been deleted. :'(");
        }


        public virtual void UpdateInformation(Player player)
        {
            Console.WriteLine($" Player {player.FirstName}'s account has been updated.");
        }
    }
}
