using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp6
{
    [Serializable]
    public class Circle : Form_Cage_Rec//base Shape
    {
    
        //constructor
        public Circle(Point start, Point end, int penColor, int penWidth, int colorInside, float width, float height)
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
        //override method
        public override void Draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(Color.FromArgb(colorInside));//casting from int to Color,to draw inside
            Pen pen = new Pen(Color.FromArgb(penColor), penWidth);//casting from int to Color,Width of the pen respectively,to draw simpely

            g.FillEllipse(br, start.X, start.Y, width, height);//inside the Ellipse
            g.DrawEllipse(pen, start.X, start.Y, width, height);//draw the Ellipse
        }
        public override bool isFrame(int xP, int yP)
        {

            float centerX, centerY;
            float squreX, squreY;
            float a,b;

            centerX = (start.X + end.X) / 2;//radiousX
            centerY = (start.Y + end.Y) /2;//radiousY

            squreX = (xP - centerX) * (xP - centerX);//current xP - radiousX
            squreY = (yP - centerY) * (yP - centerY);//current yP - radiousY

            a = width / 2;
            b = height / 2;

            a = a * a;
            b = b * b;

            //a = the distance from the center 
            //b = the distance from the center 
            //the formal formula is : (x^2)/(a^2) + (y^2)/(b^2)=1

            return Math.Abs(squreX / a + squreY / b) <= 1;
        }
    }
}
