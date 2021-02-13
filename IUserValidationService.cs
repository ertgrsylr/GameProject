using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GameProject.Abstract
{

    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}