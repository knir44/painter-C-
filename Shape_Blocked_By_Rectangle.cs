﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
namespace WindowsFormsApp6
{
    [Serializable]
    abstract class Shape_Blocked_By_Rectangle:Shape
    {
        protected int width;
        protected int length;
        public Stack<int> color_inside=new Stack<int>();  // stuck of colors

        public int Width
        {
            get { return width; }
          set { width = value; }
        }
        public int Length
        {
          get { return length; }
            set { length = value; }

        }
        public Stack<int> Color_inside
        {
            get { return color_inside; }
            set { color_inside = value; }
           
        }
        //public void setcolorinside(int number)
      //  {
        //    color_inside.Push(number);
       // }

        // public abstract override void Draw(Graphics g); // for each shape


        // public abstract override bool Is_Inside(int x, int y); // for each shape





    }
}
