using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp6
{
    [Serializable]
    public class MyPen : Shape
    {
       

        public Point[] coord;//array of point int order to draw point bit by bit
        private int size;// the size of the array

        //constructor
        public MyPen(Point[] coord, Point start, Point end, int penColor, int penWidth,int size)
        {
            this.size = size;
            this.coord = new Point[size];
            this.start = start; 
            this.end = end; 
            this.penColor = penColor;
            this.penWidth = penWidth;
            for (int i = 0; i < size; i++)
                this.coord[i] = coord[i];
            count++;
            this.id = count;
        }
        //getters and setters
        public int Size { get { return size; } }
        public Point[] Coord
        {
            get { return Coord; }
            set { Coord = value; }
        }

        //override method
        public override void Draw(Graphics g)
        {

           for(int i=0; i < coord.Length - 1;i++)
            {
                g.DrawLine(new Pen(Color.FromArgb(penColor), penWidth), coord[i], coord[i+1]);
            }
        }
        public override bool isFrame(int xP, int yP)
        {
         

            for (int i = 0; i < coord.Length; i++)
                if (Math.Abs(coord[i].X - xP) <= 10 && Math.Abs(coord[i].Y - yP) <= 10)
                    return true;

            return false;


        }

    }
}
