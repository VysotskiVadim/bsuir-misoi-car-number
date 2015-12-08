﻿using System;

namespace Bsuir.Misoi.Core.Images.Implementation.Hough
{
    public struct Line
    {
        public Line(double f, double r)
        {
            this.F = f;
            this.R = r;
            FRad = f * Math.PI / 180.0;
        }

        public double F { get; }   //угол
        public double R { get; }   //длина перпендикуляра
        public double FRad { get; }
    }
}
