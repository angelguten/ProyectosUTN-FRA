﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public int getX()
        {
            return this.x;
        }public int getY()
        {
            return this.y;
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
