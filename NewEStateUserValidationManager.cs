using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GameProject
{

    public class NewEStateUserValidationManager : IUserValidationService
    {
      public bool Validate(Gamer gamer)
      {
      	return true;
      }
    }
}