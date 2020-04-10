﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Text;
using System.Windows.Shapes;

namespace TopoGiraffe
{
    class ArtPoint
    {
        public Ellipse cercle;
        private Point p;

        public Point P { get => p; set => p = value; }

        public ArtPoint(Ellipse cercle , Point p)
        {
            this.cercle = cercle;
            this.P = p;
        }
        public ArtPoint()
        {
          
        }
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                ArtPoint p1 = (ArtPoint)obj;
                return (this.p == p1.p) && (this.cercle == p1.cercle);
            }
        }

    }
}
