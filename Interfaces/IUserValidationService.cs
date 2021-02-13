using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Interfaces
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
