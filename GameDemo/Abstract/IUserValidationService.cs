using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
