﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
   public abstract class BaseHero
    {
        public  BaseHero(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public int Power { get; set; }

        public virtual string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
