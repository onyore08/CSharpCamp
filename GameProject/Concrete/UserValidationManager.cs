using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserValidationManager
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Can" && gamer.LastName == "Evcimen" && gamer.IdentityNumber == "123456" && gamer.Id == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
