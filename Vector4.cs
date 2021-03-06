﻿using System;

namespace FbxSharp
{
    public struct Vector4
    {
        public static readonly Vector4 Zero = new Vector4(0, 0, 0, 0);

        public Vector4(double pX, double pY, double pZ, double pW=1.0)
        {
            X = pX;
            Y = pY;
            Z = pZ;
            W = pW;
        }
        public Vector4(double[] pValue)
        {
            X = pValue[0];
            Y = pValue[1];
            Z = pValue[2];
            W = pValue[3];
        }
        public Vector4(Vector3 pValue, double pW=1.0)
        {
            X = pValue.X;
            Y = pValue.Y;
            Z = pValue.Z;
            W = pW;
        }

        public readonly double X;
        public readonly double Y;
        public readonly double Z;
        public readonly double W;

        public override string ToString()
        {
            return string.Format("{{X:{0} Y:{1} Z:{2} W:{3}}}", X, Y, Z, W);
        }

        public Vector3 ToVector3()
        {
            return new Vector3(X, Y, Z);
        }

        public double this [ int index ]
        {
            get
            {
                switch (index)
                {
                case 0: return X;
                case 1: return Y;
                case 2: return Z;
                case 3: return W;
                }

                throw new ArgumentOutOfRangeException("index", "index must be 0, 1, 2, or 3");
            }
            //set
            //{
            //    switch (index)
            //    {
            //    case 0: X = value; return;
            //    case 1: Y = value; return;
            //    case 2: Z = value; return;
            //    case 3: W = value; return;
            //    }
            //
            //    throw new ArgumentOutOfRangeException("index", "index must be 0, 1, 2, or 3");
            //}
        }
    }
}

