﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BirthdayCelebrations
{
    public class Pet : IBirthdate
    {
        public string Name { get; private set; }
        public string Birthdate { get; private set; }
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
    }
}