using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsApp6
{
    [Serializable] 
    public abstract class Shape//base
    {
        public Point start, end;//start and end of every object's picture
        protected int penColor;//the color of the pen
        protected int penWidth;//the width of the pen
        protected static int count = 0;//every object I create i give him id in order to recognize it using undo
        protected int id;//id of every object which getting via the currect count

        //getters and setters 
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Point Start
        {
            get{ return start;  }
            set { start = value; }
        }
        public Point End
        {
            get { return end; }
            set { end = value; }
        }
        public int PenColor
        {
            get { return penColor; }
            set { penColor = value; }
        }

        public int PenWidth
        {
            get { return penWidth; }
            set { penWidth = value; }
        }

        //abstract method 
        public abstract void Draw(Graphics g);
        public abstract bool isFrame(int xP, int yP);
    }
}
