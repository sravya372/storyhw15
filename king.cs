using System;
using System.Collections.Generic;
using System.Text;

namespace StoryClass
{
     class King : Animal
    {

        public int _weight { get; set; }

        public King(String name,int strength, int weight) : base(name, strength)
        {
            _rName = name;
            _strength = strength;
            _weight = weight;

        }

    }
}
