﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceInvaders
{
    public class Invader: GameObjects
    {
        public char Symbol { get; set; }
        public Invader(int x, int y) : base(x, y)
        {
            Symbol = '#';
        }
    }
}
