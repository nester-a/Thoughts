﻿using RoleDal = Thoughts.DAL.Entities.Role;
using Thoughts.Interfaces.Base.Mapping;

namespace Thoughts.Extensions.Cash.DAL
{
    public class RoleDalCash : ICash<int, RoleDal>
    {
        public Dictionary<int, RoleDal> Cash { get; } = new();
    }
}
