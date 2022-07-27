using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp6
{
    [Serializable]
    public abstract class Form_Cage_Rec : Shape
    {
       
        protected int colorInside;//let me know whether the color is inside is transparent or with color and which color;
        protected float width;//width of the form
        protected float height;//height of the form

        //getters and setters
        public int ColorInside
        {
            get { return colorInside; }
            set { colorInside = value; }
        }
        public float Width
        {
            get { return width; }
            set { width = value; }
        }
        public float Height
        {
            get { return height; }
            set { height = value; }
        }
    }
}
