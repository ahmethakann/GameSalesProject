using GameProject.Entites;
using GameProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Methods
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "Oyunu eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "Oyunu silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "Oyunu güncellendi.");
        }
    }
}
