using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        private IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            try
            {
                if (_userValidationService.Validate(gamer) == true)
                {
                    Console.WriteLine("Gamer Added");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("There is a problem. Not added.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated");
        }
    }
}
