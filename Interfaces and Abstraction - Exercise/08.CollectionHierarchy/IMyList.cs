﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CollectionHierarchy
{
    public interface IMyList : IAddRemoveCollection
    {
        int Used { get; }
    }
}