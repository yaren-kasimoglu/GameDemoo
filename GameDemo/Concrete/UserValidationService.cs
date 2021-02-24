using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class UserValidationService : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.UserIdNo == 1 && gamer.UserName == "Yaren" && gamer.Gmail=="yagmurryaren.35@gmail.com")
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
