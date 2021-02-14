using GameProject.Entites;
using GameProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Methods
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.BirthYear == 1999 && gamer.FirstName == "Ahmet" && gamer.LastName == "Özgüven" && gamer.IdentityNumber == 1231231231)
            {
                return true;
            }
            else if (gamer.Id == 2 && gamer.BirthYear == 2002 && gamer.FirstName == "Mehmet" && gamer.LastName == "Yıldırım" && gamer.IdentityNumber == 1231231232)
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
