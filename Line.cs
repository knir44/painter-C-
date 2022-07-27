using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    [Serializable]
    public class Line : Shape
    {
      
        //constructor
        public Line(Point start, Point end, int penColor, int penWidth)
        {
            this.start = start;
            this.end = end;
            this.penColor = penColor;
            this.penWidth = penWidth;
            count++;
            this.id = count;
        }
        //override method 
        public override void Draw(Graphics g)
        {
            g.DrawLine(new Pen(Color.FromArgb(penColor), penWidth), start, end);//drawling a line
            // the casting is used in order to save the object propely since penColor is int and int can be saved well
        }
        public override bool isFrame(int xP, int yP)
        {

            int Xmin, Xmax, Ymin, Ymax;
            Xmax = start.X > end.X ? start.X : end.X;//calculating the max x
            Xmin = start.X < end.X ? start.X : end.X;//calculating the max x
            Ymin = start.Y < end.Y ? start.Y : end.Y;//calculating the max y
            Ymax = start.Y > end.Y ? start.Y : end.Y;//calculating the max y


            if (xP < Xmin - penWidth || xP > Xmax + penWidth)//if i pass the limit of the line,since there are infinity of points
                return false;

            if (yP < Ymin - penWidth || yP > Ymax + penWidth)//if i pass the limit of the line,since there are infinity of points
                return false;

            if (Math.Abs(start.X - end.X) <= 10 + penWidth)//in case it is like a stick y
                return true;

            if (Math.Abs(start.Y - end.Y) <= 10 + penWidth)
                return true;


            ////y = yp, y0 = end.Y

            ////m = (end.Y - start.Y)/(end.X - start.X)

            //// x = xP, y0 = end.X

            ////y-y0 - m(x-x0)<=15

            return Math.Abs((yP - end.Y) + -1 * ((int)((((double)(end.Y - start.Y) / ((double)(end.X - start.X))) * ((double)(xP - end.X)))))) <= (10 + penWidth);
                

        }
    }
}
