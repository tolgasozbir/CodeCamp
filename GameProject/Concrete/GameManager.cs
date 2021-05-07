using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + "Eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + "Silindi");
        }

        public void GameList(List<Game> games)
        {
            foreach (var item in games)
            {
                Console.WriteLine(item.Name + " " + item.Price + " Tl");
                Console.WriteLine("----------------------------");
            }
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + "Güncellendi");
        }
    }
}
