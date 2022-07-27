using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;
namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        Bitmap bm;//The display of the screan,bitMap
        Graphics g;//Graphics of the screan
        bool paint = false;//when i draw it is true,by defualt it is false
        Point Contemporary, previous;//Contemporary  and previous former point and current point
        Pen p = new Pen(Color.Black, 4);//the pen, by defualt it is black with 4 size
        // Pen erase = new Pen(Color.White, 10);
        int index;//let me know which buttom the user press
        int xEndPressed, yEndPressed, w, h, xStartPressed, yStartPressed;//the last point the user pressed,width and height and the first point the user press
        ColorDialog color_Dialog = new ColorDialog(); //selecting a color from available colors
        Color new_color;//the selected color (the chosen one)
        //****************************************
        ShapeList _myShape = new ShapeList();//where i save every object which drawing on the screan
        List<Point> pen = new List<Point>();//Saving the point of my pen,good for undo and redo,create the pen
        Shape shapeShift;//abstract shape which i can access to every element to shift objects(select)
        bool flag_pressed = false;//let me know if i pressed inside on some shape of the screan(select)
        int curr_X,curr_Y;//after shifting the shape, these varible helps me know the original Coordination
        int last_X,last_Y;//after shifting the shape, these varible helps me know the original Coordination
        int deltaX, deltaY;//the distance(difference) form the former x to the current x,the same with y
        List<Point> originalPoint = new List<Point>();//when the user shifts the pen,this list help me know where each point 
        Stack<mission_unit> undo= new Stack<mission_unit>();//data structure stack in order to implement undo
        Stack<mission_unit> redo = new Stack<mission_unit>();//data structure stack in order to implement redo
        ShapeList deleted = new ShapeList();//in order to implement undo, i can take the last element and make undo 
        ShapeList moved = new ShapeList();//in order to implement undo, i can take the the identical id and make undo 
        ShapeList colorful = new ShapeList();//in order to implement undo, i can take the last element and make undo 
        ShapeList move_From_Undo = new ShapeList();//in order to implement redo, i can take the last element and make redo 
        ShapeList colorful_From_Undo = new ShapeList();//in order to implement redo, i can take the last element and make redo 
        public Form1()
        {
            InitializeComponent();
            this.Width = 1000;//The width of the scream
            this.Height = 700;//The Height of the scream

            bm = new Bitmap(pic.Width, pic.Height);//Show the scream
            g = Graphics.FromImage(bm);//drawing on the screan via Graphics which got from bm.
            g.Clear(Color.White);//represents the background color of the drawing surface.
            pic.Image = bm;//the picture of pictureBox equals bm,i cant draw without it
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)//while movinig
        {
            mission_unit task = new mission_unit();//let us know what the task we should do
            xEndPressed = e.X;//the end x
            yEndPressed = e.Y;//the end y
            w = Math.Abs(e.X - xStartPressed);//calculating the width
            h = Math.Abs(e.Y - yStartPressed);//calculating the height
            deltaX = e.X - xStartPressed;//the distance of current x - xStart
            deltaY = e.Y - yStartPressed;////the distance of current y - yStart
            

            if (paint)//if(paint == true)
            {
                if (flag_pressed && index == 10)//flag_pressed = pressed inside shape ,index 10 = select 
                {

                    
                    //start
                    shapeShift.start.X = curr_X + deltaX;//uptading the originX + deltaX(distance)
                    shapeShift.start.Y = curr_Y + deltaY;//uptading the originX + deltaY(distance)
                    //end
                    shapeShift.end.X = last_X + deltaX;//uptading the originX + deltaX(distance)
                    shapeShift.end.Y = last_Y + deltaY;//uptading the originX + deltaY(distance)

                    if (shapeShift.GetType() == typeof(MyPen))//verifying if the shiftObject is class MyPen
                    {
                        originalPoint.ToArray();//casting to array
                        for (int i = 0; i < originalPoint.Count; i++)
                        {
                            //updating the points of every shifting via last coordinates and dalta(distance)
                            ((MyPen)shapeShift).coord[i].X = originalPoint[i].X + deltaX;
                            ((MyPen)shapeShift).coord[i].Y = originalPoint[i].Y + deltaY;
                        }
                    }
                    g.Clear(Color.White);//clear the full screan(kind of clearAll)
                    pic.Image = bm;//the picture of pictureBox equals bm,i cant draw without it
                    _myShape.DrawAll(g);//now i can redraw without the  the new  coordinates of pen
                    shapeShift.Draw(g);//drawing with the new coordinates of pen

                }


                if (index == 1)//pencil
                {

                    Contemporary = e.Location;//updating the current coordinates
                    pen.Add(Contemporary);//appending to  the pen
                    g.DrawLine(p, Contemporary, previous);//drawing the line
                    previous = Contemporary;// saving the current point to the former one

                }
                if (index == 2)//eraser
                {
                    for (int i = _myShape.NextIndex - 1; i >= 0; i--)
                    {
                        if (_myShape[i].isFrame(e.X, e.Y))
                        {
                            task.Id = _myShape[i].Id;//saving the id in case of using undo
                            task.Task_number = 2;//Add = 2, when i delete an object, the undo adds it 
                            undo.Push(task);//adding the task into the undo with id and task_number
                            deleted.AddToEnd(_myShape[i]);//saving in the end the deleted object,in order to use it via undo
                            _myShape.Remove(i);//now i can remove the object from the _myShape,i no longer need that
                            g.Clear(Color.White);//the picture of pictureBox equals bm,i cant draw without it
                            pic.Image = bm;//the picture of pictureBox equals bm,i cant draw without it
                            _myShape.DrawAll(g);////now i can redraw without the  the new  coordinates of pen
                            break;

                        }
                    }


                }

            }

            pic.Refresh();//refreshing the work! (as invaildate)
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)//while mouse is up (namely stop clicking)
        {
            mission_unit task = new mission_unit();// let us know what the task we should do
            Shape temp;//creating temp Shape in order to add into the _myShape
            paint = false;//once i stopped clicking the mouse, i stopped drawing

            w = Math.Abs(e.X - xStartPressed);//calculating the width
            h = Math.Abs(e.Y - yStartPressed);//calculating the height

            int minX = xEndPressed > xStartPressed ? xStartPressed : xEndPressed;//to draw in every position
            int minY = yEndPressed > yStartPressed ? yStartPressed : yEndPressed;//to draw in every position

            int maxX = xEndPressed < xStartPressed ? xStartPressed : xEndPressed;//to draw in every position
            int maxY = yEndPressed < yStartPressed ? yStartPressed : yEndPressed;//to draw in every position


            if (index == 1)//pecnil = 1
            {
                temp = new MyPen(pen.ToArray(), new Point(xStartPressed, yStartPressed), new Point(xEndPressed, yEndPressed), p.Color.ToArgb(), ((int)p.Width), pen.Count);
                task.Id = temp.Id;//giving the id to the temp
                task.Task_number = 1;// Delete = 1  , when i create a new shape i let it be deleted
                undo.Push(task);//adding the task with id and task_number into the undo
                _myShape.AddToEnd(temp);//adding the temp into the _myShape
                pen.Clear();//now i need to delete the array of the point, in order to let the other points to be saved
            }
            if(flag_pressed && index == 10)//index 10 = select ,flag_pressed = pressed inside shape
            {
                _myShape.AddToEnd(shapeShift);//once i want to shift the shape,i need to add the new shape into the list
                task.Id = shapeShift.Id;//giving the id of shapeShift to task
                task.Task_number = 3;// Move = 3
                undo.Push(task);//adding into the stack Undo
                shapeShift = null;//rebooting the shapeShift
                flag_pressed = false;//changing the flag to False
                 g.Clear(Color.White);//the picture of pictureBox equals bm,i cant draw without it
                pic.Image = bm;//the picture of pictureBox equals bm,i cant draw without it
                _myShape.DrawAll(g);////now i can redraw without the  the new  coordinates of pen
            }
             if (index == 3)//index 3 = circle
            {
                
                temp = new Circle(new Point(xStartPressed, yStartPressed), new Point(xEndPressed, yEndPressed), p.Color.ToArgb(), ((int)p.Width),Color.Transparent.ToArgb(), deltaX, deltaY);//it is like w and h but wihtou the Math.abs
                temp.Draw(g);// calls the method of Draw namely polymorphism
                task.Id = temp.Id;//giving the id of shapeShift to task
                task.Task_number = 1;//Delete = 1
                undo.Push(task);//adding into the stack Undo
                _myShape.AddToEnd(temp);//adding the object Circle into the array of _myShape 

            }
            if (index == 4)//index 3 = Rectangle
            {
                temp = new Rectangle(new Point(minX, minY), new Point(maxX, maxY), p.Color.ToArgb(), ((int)p.Width), Color.Transparent.ToArgb(), w, h);
                temp.Draw(g);// calls the method of Draw namely polymorphism
                task.Id = temp.Id;//giving the id of shapeShift to task
                task.Task_number = 1;//Delete = 1
                undo.Push(task);//adding into the stack Undo
                _myShape.AddToEnd(temp);//adding the object Rectangle into the array of _myShape


            }
            if (index == 5)//index 3 = Line
            {
                temp = new Line(new Point(xStartPressed, yStartPressed), new Point(xEndPressed, yEndPressed), p.Color.ToArgb(), ((int)p.Width));
                temp.Draw(g);// calls the method of Draw namely polymorphism
                task.Id = temp.Id;//giving the id of shapeShift to task
                task.Task_number = 1;//Delete = 1
                undo.Push(task);//adding into the stack Undo
                _myShape.AddToEnd(temp);//adding the object Circle into the array of _myShape 
            }
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;//once I press the buttom pencil,index changes to 1
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;//once I press the buttom cricle,index changes to 3
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            index = 4;//once I press the buttom rectangle,index changes to 4
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;//once I press the buttom line,index changes to 5
        }
      
        private void btn_color_Click(object sender, EventArgs e)//ShowDialog,namely changing the color
        {
            color_Dialog.ShowDialog();//Open the color dialog,namely represents the clolor options
            new_color = color_Dialog.Color;//giving to the vairble new_color the  seleted color 
            pic_color.BackColor = color_Dialog.Color;//the small square chagne the color according the choice
            p.Color = color_Dialog.Color;//change the color of the pen
        }


        static Point set_point(PictureBox pb, Point pt)//getting PictureBox and Point
        {
            //Calculates the resolution of the PictureBox
            //taking care the other colorSelected
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

     
        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            //in short that command is responsible of the color on the right up
            Point point = set_point(color_picker, e.Location);//getting the excat Calculation
            pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);//the small square chagne the color according the choice
            new_color = pic_color.BackColor;//updating the color
            p.Color = pic_color.BackColor;//updating the pen
        }

        private void pic_Paint(object sender, PaintEventArgs e)//drawing the object even before it is created
        {
            Graphics g = e.Graphics;//creating an object from Graphics

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;//the way it is painted


            int minX = xEndPressed > xStartPressed ? xStartPressed : xEndPressed;//to draw in every position
            int minY = yEndPressed > yStartPressed ? yStartPressed : yEndPressed;//to draw in every position
        
            if (paint)//if(paint = true) namely we can paint
            {
                if (index == 3)//circle
                {
                    g.DrawEllipse(p, xStartPressed, yStartPressed, deltaX, deltaY);//deltaX and deltaY is like w and h but without Math.abs
                }
                if (index == 4)//Rectangle
                {
                    g.DrawRectangle(p, minX, minY, w, h);
                }
                if (index == 5)//Line
                {
                    g.DrawLine(p, xStartPressed, yStartPressed, xEndPressed, yEndPressed);
                }
            }
        }
       
        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    //!!!!
                    formatter.Serialize(stream, _myShape);//from my shape into the Stream
                }
            }
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            index = 7;//once I pressed fill ,index changes to 7
        }
      
        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            Shape somethingElse;
            mission_unit task = new mission_unit();
            if (index == 2)//eraser
            {
                for (int i = _myShape.NextIndex - 1; i >= 0; i--)//always priority to the last one
                {
                    if (_myShape[i].isFrame(e.X, e.Y))
                    {
                        task.Id = _myShape[i].Id;//saving the id in case of using undo
                        task.Task_number = 2;//Add = 2, when i delete an object, the undo adds it 
                        undo.Push(task);//adding the task into the undo with id and task_number
                        deleted.AddToEnd(_myShape[i]);//saving in the end the deleted object,in order to use it via undo
                        _myShape.Remove(i);//now i can remove the object from the _myShape,i no longer need that
                        g.Clear(Color.White);//the picture of pictureBox equals bm,i cant draw without it
                        pic.Image = bm;//the picture of pictureBox equals bm,i cant draw without it
                        _myShape.DrawAll(g);////now i can redraw without the  the new  coordinates of pen
                        break;//halt the for

                    }
                }
            }
             if (index==7)//fill
            {

                for(int i=_myShape.NextIndex-1;i>=0;i--)
                {
                    
                    if(_myShape[i].GetType() == typeof(Circle) && _myShape[i].isFrame(e.X,e.Y))// we can paint inside the object
                    {
                        //before painting the shape , we need to save the old one in case of using undo 
                        somethingElse = new Circle(_myShape[i].Start, _myShape[i].End,_myShape[i].PenColor,
                            _myShape[i].PenWidth,((Circle)(_myShape[i])).ColorInside, ((Circle)(_myShape[i])).Width,
                            ((Circle)(_myShape[i])).Height);
                       
                        somethingElse.Id = _myShape[i].Id;  //giving him the old id
                        colorful.AddToEnd(somethingElse);//adding the old one into colorful (for undo)

                        ((Circle)(_myShape[i])).ColorInside = p.Color.ToArgb();//casting Circle and changing the colorInside to penColor
                        g.Clear(Color.White);//clear all;
                        pic.Image = bm;//updating the screan
                        _myShape.DrawAll(g);//redrawing with the new change (chgange is the color inside)


                      

                        task.Id = _myShape[i].Id;//updating the id of the task
                        task.Task_number = 4;//color = 4
                        undo.Push(task);//adding the task to the undo

                        break;//halt the for

                    }
                    if(_myShape[i].GetType() == typeof(Rectangle) && (_myShape[i].isFrame(e.X, e.Y)))

                     {
                        //before painting the shape , we need to save the old one in case of using undo 
                        somethingElse = new Rectangle(_myShape[i].Start, _myShape[i].End, _myShape[i].PenColor, _myShape[i].PenWidth, 
                            ((Rectangle)(_myShape[i])).ColorInside, ((Rectangle)(_myShape[i])).Width, ((Rectangle)(_myShape[i])).Height);

                        somethingElse.Id = _myShape[i].Id;//giving him the old id
                        colorful.AddToEnd(somethingElse);//adding the old one into colorful

                        ((Rectangle)(_myShape[i])).ColorInside = p.Color.ToArgb();//casting Rectangle and changing the colorInside to penColor

                        g.Clear(Color.White);//clear all;
                        pic.Image = bm;//updating the screan
                        _myShape.DrawAll(g);//redrawing with the new change (chgange is the color inside



                        task.Id = _myShape[i].Id;//updating the id of the task
                        task.Task_number = 4;//color = 4
                        undo.Push(task);//adding the task to the undo

                        break;//halt the forss
                    }
                            

                }

            }
        }

        private void Thickness1_Click(object sender, EventArgs e)
        {
            p.Width = 1;//once I pressed Thickness1_Click ,the width of the pen is now 1
        }

        private void Thickness2_Click(object sender, EventArgs e)
        {
            p.Width = 4;//once I pressed Thickness2_Click ,the width of the pen is now 5

        }

        private void Thickness3_Click(object sender, EventArgs e)
        {
            p.Width = 8;//once I pressed Thickness3_Click ,the width of the pen is now 8

        }

        private void Thickness4_Click(object sender, EventArgs e)
        {
            p.Width = 12; //once I pressed Thickness4_Click ,the width of the pen is now 8
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
           
            mission_unit unit = null;//booting the unit to null
            if (undo.Count() != 0)// if i can take out from the stack so i do it
                 unit = undo.Pop();//taking the last element from the stack

         if(unit != null)//if i could take element from the stack namely the stack is no empty
         {
            if (unit.Task_number == 1) //Delete = 1
            {
                for (int i = _myShape.NextIndex - 1; i >= 0; i--)
                {
                    if (_myShape[i].Id == unit.Id)//once _myShape[i].Id from the end is found 
                     {
                           unit.Task_number = 2;//the oppsite action, if object deleted,then now it is added
                            redo.Push(unit);//now the object insreted into the redo stack 
                            deleted.AddToEnd(_myShape[i]);//adding the deleted object for redo



                         _myShape.Remove(i);// we can now delete it
                        break;//halt the loop
                    }
                }

                    g.Clear(Color.White);//clear all
                    pic.Image = bm;//chagne the screan
                    _myShape.DrawAll(g);//redraw without the last element  

                }
            else if (unit.Task_number == 2)//Add = 2 
            {
                for (int i = deleted.NextIndex - 1; i >= 0; i--) 
                    {
                    if (deleted[i].Id == unit.Id)//once deleted[i].Id from the end is found
                        {

                           unit.Task_number = 1;//the oppsite action, if object added,then now it is deleted
                           redo.Push(unit);//now the object insreted into the redo stack 
                          //no need to save it into _myShape since it has already been saved there


                        _myShape.AddToEnd(deleted[i]);//adding to the end the last one
                        deleted.Remove(i);//deleting the object,no longer usful for me
                        break;//halt the loop
                        }
                }
                    g.Clear(Color.White);//clear all
                    pic.Image = bm;//chagne the screan
                    _myShape.DrawAll(g);//redraw without the last element  
                }
            else if (unit.Task_number == 3)//Move = 3 
            {

                for (int i = _myShape.NextIndex - 1; i >= 0; i--)//always starts from the last one
                    {
                    if (_myShape[i].Id == unit.Id)//once _myShape[i].Id from the end is found
                     {
                          move_From_Undo.AddToEnd(_myShape[i]);//addint into deleted_From_Undo the last object from the undo
                            redo.Push(unit);// it is the same task(to move) thus, no needed to chagne it

                        _myShape.Remove(i);//deleting the old one
                        break;//halt the loop
                    }
                }
                for (int i = moved.NextIndex - 1; i >= 0; i--)
                {
                    if(moved[i].Id == unit.Id)//once moved[i].Id from the end is found
                    {
                        _myShape.AddToEnd(moved[i]);//now we can to add again
                        moved.Remove(i);//now we no longer need it from the moved
                        break;//halt the loop
                    }
                }
                    g.Clear(Color.White);//clear all
                    pic.Image = bm;//chagne the screan
                    _myShape.DrawAll(g);//redraw without the last element  
                }

                else if (unit.Task_number == 4)//color = 4 
                {
                    for (int i = _myShape.NextIndex - 1; i >= 0; i--)
                    {
                        if(_myShape[i].Id == unit.Id)//once _myShape[i].Id from the end is found
                        {
                            colorful_From_Undo.AddToEnd(_myShape[i]);//berfoe making a deleted to the last one with the color, i have to save it before
                            redo.Push(unit);//no need to change the task mision since it is the same


                            _myShape.Remove(i);//deleting the old one
                            break;//halt the loop
                        }
                    }
                    for (int i = colorful.NextIndex - 1; i >= 0; i--)
                    {
                        if (colorful[i].Id == unit.Id)//once colorful[i].Id from the end is found befroe it was painted
                        {
                            _myShape.AddToEnd(colorful[i]);//now we can to add again
                            colorful.Remove(i);// now we no longer need it from the colorful
                            break;//halt the loop
                        }
                    }
                    g.Clear(Color.White);//clear all
                    pic.Image = bm;//chagne the screan
                    _myShape.DrawAll(g);//redraw without the last element  
                }
         }
        }

        private void btn_redo_Click(object sender, EventArgs e)
        {
            mission_unit unit = null;//booting the unit to null
            if (redo.Count() != 0)// if i can take out from the stack so i do it
                unit = redo.Pop();//taking the last element from the stack


            if(unit != null)
            {
                if (unit.Task_number == 1) //Delete = 1
                {
                    for (int i = _myShape.NextIndex - 1; i >= 0; i--)
                    {
                        if (unit.Id == _myShape[i].Id)
                        {
                            unit.Task_number = 2;//the opposite action,now we need to chagne it into add = 2 
                            undo.Push(unit);//adding this into the undo stack
                            deleted.AddToEnd(_myShape[i]);//now giving the deleted the object for undo
                            _myShape.Remove(i);//romoving the object from my shape


                            break;//halt the loop
                        }


                    }
                    g.Clear(Color.White);//clear all
                    pic.Image = bm;//chagne the screan
                    _myShape.DrawAll(g);//redraw without the last element  
                }
                else if (unit.Task_number == 2)//Add = 2 
                {
                    for (int i = deleted.NextIndex - 1; i >= 0; i--)
                    {
                        if (unit.Id == deleted[i].Id)
                        {
                            unit.Task_number = 1;//the opposite action,now we need to chagne it into deleted = 1 
                            undo.Push(unit);//adding this into the undo stack
                            _myShape.AddToEnd(deleted[i]);//addint now deleted[i] into the _myShape
                            deleted.Remove(i);//romoving the object from my deleted
                            break;//halt the loop
                        }
                    }
                    g.Clear(Color.White);//clear all
                    pic.Image = bm;//chagne the screan
                    _myShape.DrawAll(g);//redraw without the last element  
                }
                else if (unit.Task_number == 3)//Move = 3 
                {

                    for (int i = _myShape.NextIndex - 1; i >= 0; i--)//always starts from the last one
                    {
                        if(unit.Id == _myShape[i].Id)
                        {
                            moved.AddToEnd(_myShape[i]);//before making  redo we need to take care for undo
                            undo.Push(unit);//adding another mision for undo
                            _myShape.Remove(i);//now deleting from _myShape the object
                            break;//halt the loop
                        }
                    }
                    for(int i = move_From_Undo.NextIndex -1;i>=0;i--)
                    {
                        if (unit.Id == move_From_Undo[i].Id)
                        {
                            _myShape.AddToEnd(move_From_Undo[i]);//adding the new object into the _myShape
                            move_From_Undo.Remove(i);//after adding into the _myShape i can remove it 
                            break;//halt the loop
                        }
                    }
                    g.Clear(Color.White);//clear all
                    pic.Image = bm;//chagne the screan
                    _myShape.DrawAll(g);//redraw without the last element  
                }
                else if (unit.Task_number == 4)//color = 4 
                {
                    for (int i = _myShape.NextIndex - 1; i >= 0; i--)//always starts from the last one
                    {
                        if (unit.Id == _myShape[i].Id)
                        {
                            colorful.AddToEnd(_myShape[i]);// before making redo we need to take care for undo
                            undo.Push(unit);//adding another mision for undo
                            _myShape.Remove(i);//now deleting from _myShape the object
                            break;//halt the loop
                        }
                    }
                    for (int i = colorful_From_Undo.NextIndex - 1; i >= 0; i--)
                    {
                        if (unit.Id == colorful_From_Undo[i].Id)
                        {
                            _myShape.AddToEnd(colorful_From_Undo[i]);//adding the new object into the _myShape
                            colorful_From_Undo.Remove(i);//after adding into the _myShape i can remove it 
                            break;//halt the loop
                        }
                    }
                    g.Clear(Color.White);//clear all
                    pic.Image = bm;//chagne the screan
                    _myShape.DrawAll(g);//redraw without the last element  

                }




            }
        }

        private void pic_Click(object sender, EventArgs e)
        {



        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();//in order to exit the paint so we can press it and we close the program
            
        }

        private void Upload_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);//opening the file
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();//creating an object
                //!!!!
                _myShape = (ShapeList)binaryFormatter.Deserialize(stream);//from stream to class shapeList
                pic.Invalidate();//refresh
            }
            _myShape.DrawAll(g);//printing everything on the screan so i can use it for my own uses
           
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            index = 10;//once I pressed _Select ,index is now 10
        }

        private void btn_clear_Click(object sender, EventArgs e)//clear all
        {
            g.Clear(Color.White);//clear everything 
            pic.Image = bm;//uptading the screan
            index = 0;//changing it into default index = 0
            _myShape.clearAll();//clear all from the _myShape
            deleted.clearAll();//clear all from the deleted
            moved.clearAll();//clear all from the moved
            colorful.clearAll();//clear all from the colorful
            move_From_Undo.clearAll();
            colorful_From_Undo.clearAll(); 
        }

        
        private void pic_MouseDown(object sender, MouseEventArgs e)//once i start clicking the screan,the first click
        {
            
            Shape obj;// new object from Shape
            paint = true;//now paint is true,namely now we may draw

            
            previous = e.Location;//first Coordinates 
            xStartPressed = e.X;//Initializing the xStart Coordinate
            yStartPressed = e.Y; //Initializing the yStart Coordinate

            if (index == 1)//index 1 = pencil
            {
                pen.Add(previous);//inserting the first Coordinates of the pen
            }
            if (index == 10)//index 10 = select
            {

               for(int i = _myShape.NextIndex-1; i>= 0; i--)//always giving priority to the end of the objects in Shape
                {
                    if (_myShape[i].isFrame(xStartPressed, yStartPressed))//if the point in the frame is pressed
                    {
                        
                        shapeShift = _myShape[i];//shapeShift now is _myShape[i]
                        flag_pressed = true;//now the flag has risen and now i can press


                        
                      if(shapeShift.GetType() == typeof(Rectangle))
                        {
                            //create new object of Rectangle
                            obj = new Rectangle(shapeShift.Start,shapeShift.End,shapeShift.PenColor,shapeShift.PenWidth,
                                ((Rectangle)shapeShift).ColorInside,((Rectangle)shapeShift).Width,
                                ((Rectangle)shapeShift).Height);

                            obj.Id =shapeShift.Id;//givig the ID of shapeShift,namely i want to create a copy of shapeShift
                            moved.AddToEnd(obj);//adding the obj into the moved data structre,namely i saved it before the shift
                        }
                        if (shapeShift.GetType() == typeof(Circle))
                        {
                            //create new object of Circle
                            obj = new Circle(shapeShift.Start, shapeShift.End, shapeShift.PenColor, shapeShift.PenWidth, ((Circle)shapeShift).ColorInside, ((Circle)shapeShift).Width, ((Circle)shapeShift).Height);

                            obj.Id = shapeShift.Id;//givig the ID of shapeShift,namely i want to create a copy of shapeShift
                            moved.AddToEnd(obj);//adding the obj into the moved data structre,namely i saved it before the shift
                        }
                        if (shapeShift.GetType() == typeof(Line))
                        {
                            //create new object of Line
                            obj = new Line(shapeShift.Start, shapeShift.End, shapeShift.PenColor, shapeShift.PenWidth);

                            obj.Id = shapeShift.Id;//givig the ID of shapeShift,namely i want to create a copy of shapeShift
                            moved.AddToEnd(obj);//adding the obj into the moved data structre,namely i saved it before the shift
                        }

                        if (shapeShift.GetType() == typeof(MyPen))
                        {
                            originalPoint.Clear();//deleting the originalPoint
                            for (int j = 0; j < ((MyPen)(shapeShift)).coord.Length; j++)
                                originalPoint.Add(((MyPen)(shapeShift)).coord[j]);//copying everyPoint

                            //create new object of MyPen
                            obj = new MyPen(((MyPen)shapeShift).coord,shapeShift.Start, shapeShift.End, shapeShift.PenColor, shapeShift.PenWidth, ((MyPen)shapeShift).Size);
                            obj.Id = shapeShift.Id;//givig the ID of shapeShift,namely i want to create a copy of shapeShift
                            moved.AddToEnd(obj);//adding the obj into the moved data structre,namely i saved it before the shift
                        }

                        curr_X = _myShape[i].Start.X;//berfore shifting i save curr_X
                        curr_Y = _myShape[i].Start.Y;//berfore shifting i save curr_Y

                        last_X = _myShape[i].End.X;//berfore shifting i save last_X
                        last_Y = _myShape[i].End.Y;//berfore shifting i save last_Y

                        _myShape.Remove(i);//deleting the old one from _myShape
                        break;//halt the for
                    }
                }
            }
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;//once i pressed that buttom,index changes to 2 
        }

        private void pic_color_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
