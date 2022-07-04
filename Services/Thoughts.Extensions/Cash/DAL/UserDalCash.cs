﻿using UserDal = Thoughts.DAL.Entities.User;
using Thoughts.Interfaces.Base.Mapping;

namespace Thoughts.Extensions.Cash.DAL
{
    public class UserDalCash : ICash<string, UserDal>
    {
        public Dictionary<string, UserDal> Cash { get; } = new();
    }
}
