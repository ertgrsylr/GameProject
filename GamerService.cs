using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GameProject
{

    public class GamerService : IGamerService
    {
    	   IUserValidationService _userValidationService;
         public GamerManager(IUserValidationService userValidationService)
         {
         	_userValidationService = userValidationService;
         }
         
         public void Add(Gamer gamer)
         {
         	if(_userValidationService.Validate(gamer)==true)
         	{
         		Console.WriteLine("Kayıt oldu.");
         	}
         	else
         	{
         		Console.WriteLine("Doğrulama başarısız. Kayıt başarısız");
         	}
         }
         
         public void Delete(Gamer gamer)
         {
         	Console.WriteLine("Kayıt silindi");
         }
         
         public void Update(Gamer gamer)
         {
         	Console.WriteLine("Kayıt güncellendi");
         }
    }
}