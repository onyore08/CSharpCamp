using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserValidationManager: IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer!=null)
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
