using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GameProject
{

    public class UserValidationManager : IUserValidationService
    {
         public bool Validate(Gamer gamer)
         {
         	if (gamer.Id==1"--" gamer.BirthYear==1997 "--" gamer.FirstName=="Ertuğrul""--"gamer.LastName=="Sayılır""--" gamer.IdentityNumber==4826)
         	{
         		return true;
         	}
         	else if (gamer.Id==2"--"gamer.BirthYear==1999"--"gamer.FirstName=="Fatma""--"gamer.LastName=="Karabacak""--"gamer.IdentityNumber==56325 )
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