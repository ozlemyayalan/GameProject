using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class PlayerManager : BasePlayerManager
    {

        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void RegisterAccount(Player player)
        {
            if (_playerCheckService.checkIfRealPerson(player))
            {
                base.RegisterAccount(player);
            }
            else
            {
                Console.WriteLine("ID information could not be verified.");
            }

        }



    }
}
