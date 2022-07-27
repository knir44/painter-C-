using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp6
{
    [Serializable]
    public class Rectangle : Form_Cage_Rec//base Shape
    {
     
        //constructor
        public Rectangle(Point start,Point end, int penColor, int penWidth, int colorInside,float width, float height)
        {
            this.start = start;
            this.end = end;
            this.penColor = penColor;
            this.penWidth = penWidth;
            this.colorInside = colorInside;
            this.width = width;
            this.height = height;
            count++;
            this.id = count;
        }
        public override void Draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(Color.FromArgb(colorInside));//casting from int to Color,to draw inside
            Pen pen = new Pen(Color.FromArgb(penColor), penWidth);//casting from int to Color,Width of the pen respectively,to draw simpely

            g.FillRectangle(br, start.X, start.Y, width, height);//inside the Rectangle
            g.DrawRectangle(pen, start.X, start.Y, width, height);//draw the Rectangle
        }
        public override bool isFrame(int xP, int yP)
        {
           
            int centerX, CenterY;
            centerX = (Start.X + end.X) / 2;// X - the center of the rectangle
            CenterY = (start.Y + end.Y) / 2;//Y - the center of the rectangle


            return (Math.Abs(centerX - xP) <= width / 2 && Math.Abs(CenterY - yP) <= height / 2);
            // the distace from the poing the user touches must be smaller or equal to the half of the height and width


            //return false;
        }

    }
}
