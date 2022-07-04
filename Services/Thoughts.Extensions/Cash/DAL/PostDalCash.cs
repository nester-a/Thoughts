﻿using PostDal = Thoughts.DAL.Entities.Post;
using Thoughts.Interfaces.Base.Mapping;

namespace Thoughts.Extensions.Cash.DAL
{
    public class PostDalCash : ICash<int, PostDal>
    {
        public Dictionary<int, PostDal> Cash { get; } = new();
    }
}
