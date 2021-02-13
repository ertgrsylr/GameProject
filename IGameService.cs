using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GameProject.Abstract
{

    public interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}