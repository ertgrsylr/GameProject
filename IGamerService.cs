using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GamerProject.Abstract
{

    public interface IGamerService 
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}