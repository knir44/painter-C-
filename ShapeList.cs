using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;


namespace WindowsFormsApp6
{
    [Serializable]
    public class ShapeList//purpose: every object created is inside this class
    {
        protected SortedList myShape;

        //constructor
        public ShapeList()
        {
            myShape = new SortedList();
        }
        public int NextIndex
        {
            get
            {
               
                return myShape.Count;
            }
            //!!!
            // !! there is no set !!
        }
        public Shape this[int index]
        {
            get
            {
                if (index >= myShape.Count || index < 0)
                    return (Shape)null;

                //SortedList internal method
                return (Shape)myShape.GetByIndex(index);
            }
            set
            {
                if (index <= myShape.Count)
                    myShape[index] = value; 		
            }
        }
        public void AddToEnd(Shape element)//getting every time varible Shape
        {
            myShape.Add(this.NextIndex, element);
        }
        public void Remove(int element)
        {
            if (element >= 0 && element < myShape.Count)//stlye Haim Shafir
            {
                for (int i = element; i < myShape.Count - 1; i++)
                    myShape[i] = myShape[i + 1];
                myShape.RemoveAt(myShape.Count - 1);
            }
        }
        public void clearAll()
        {
            myShape.Clear();
        }
        public void DrawAll(Graphics g)
        {
          
            for (int i = 0; i < myShape.Count; i++)
                ((Shape)myShape[i]).Draw(g);
        }

    }
}

