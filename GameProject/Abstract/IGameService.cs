using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Interfaces
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
