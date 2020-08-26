using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Geometry
    {
    public class Square
        {
        #region Fields
        private double side;
        #endregion

        #region Properties
        public double Side
            {
            get { return side; }
            set { side = value; }
            }
        #endregion

        #region Constructor
        public Square()
            {

            }
        public Square(double side)
            {
            this.side = side;
            }
        #endregion

        #region Methods
        /// <summary>
        /// Get the perimeter
        /// </summary>
        /// <returns>This method returns the perimeter of a square</returns>
        public double GetPerimeter()
            {
            return 4 * side;
            }

        /// <summary>
        /// Get the perimeter with x amount of decimals
        /// </summary>
        /// <param name="decimals">Specify the amount of decimals to include</param>
        /// <returns>This method returns the perimeter of a square, with a given amount of decimals</returns>
        public double GetPerimeter(byte decimals)
            {
            return Math.Round(4 * side, decimals, MidpointRounding.AwayFromZero);
            }

        /// <summary>
        /// Get the area of the square
        /// </summary>
        /// <returns>This method returns the area of the square</returns>
        public double GetArea()
            {
            return side * side;
            }

        /// <summary>
        /// Get the area with x amount of decimals
        /// </summary>
        /// <param name="decimals">Specify the amount of decimals to include</param>
        /// <returns>This method returns the area of the square, with a given amount of decimals</returns>
        public double GetArea(byte decimals)
            {
            return Math.Round(side * side, decimals, MidpointRounding.AwayFromZero);
            }
        #endregion
        }
    }
