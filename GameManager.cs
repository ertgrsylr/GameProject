using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GameProject.Manager
{

    public class GameManager:IGameService
    {
         public void Add(Game game)
         {
         	Console.WriteLine(game.GameName+"Eklendi.");
         }
         
         public void Delete(Game game)
         {
         	Console.WriteLine(game.GameName+"Silindi.");
         }
         
         public void Update(Game game)
         {
         	Console.WriteLine(game.GameName+"Güncellendi.");
         }
    }
}