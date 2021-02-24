using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class GamerManager : IGamerManager
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.UserName + " Kayıt oldu ");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız");
            }
            
      
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " Silindi ");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " Güncellendi ");
        }
    }
}
