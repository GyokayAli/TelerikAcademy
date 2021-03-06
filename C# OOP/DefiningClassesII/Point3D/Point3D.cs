﻿/*Problem 1. Structure
Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
Implement the ToString() to enable printing a 3D point.
 * 
Problem 2. Static read-only field
Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
Add a static property to return the point O.
 * 
Problem 3. Static class
Write a static class with a static method to calculate the distance between two points in the 3D space.
 * 
Problem 4. Path
Create a class Path to hold a sequence of points in the 3D space.
Create a static class PathStorage with static methods to save and load paths from a text file.
Use a file format of your choice.
*/
namespace Point3D
{
    using System;

    public struct Point3D
    {
        private static readonly Point3D initialXYZ = new Point3D(0, 0, 0);
        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

         public Point3D InitialXYZ
        {
            get { return initialXYZ; }
        }

        public override string ToString()
        {
            return string.Format("[{0:F2}, {1:F2}, {2:F2}]", this.X, this.Y, this.Z);
        }
    }
}
