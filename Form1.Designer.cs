namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.Upload_btn = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_redo = new System.Windows.Forms.Button();
            this.btn_undo = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Thickness4 = new System.Windows.Forms.Button();
            this.Thickness3 = new System.Windows.Forms.Button();
            this.Thickness2 = new System.Windows.Forms.Button();
            this.Thickness1 = new System.Windows.Forms.Button();
            this.LineWidth = new System.Windows.Forms.TextBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.Exit_btn);
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Controls.Add(this.btn_rect);
            this.panel1.Controls.Add(this.Upload_btn);
            this.panel1.Controls.Add(this.btn_ellipse);
            this.panel1.Controls.Add(this.btn_eraser);
            this.panel1.Controls.Add(this.btn_pencil);
            this.panel1.Controls.Add(this.btn_fill);
            this.panel1.Controls.Add(this.btn_color);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(749, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(73, 26);
            this.btn_save.TabIndex = 9;
            this.btn_save.Tag = "Clear";
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // color_picker
            // 
            this.color_picker.Image = global::WindowsFormsApp6.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(12, 9);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(187, 91);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 8;
            this.color_picker.TabStop = false;
            this.color_picker.Click += new System.EventHandler(this.pic_color_Click);
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.White;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.Image = global::WindowsFormsApp6.Properties.Resources.line;
            this.btn_line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_line.Location = new System.Drawing.Point(664, 29);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(68, 55);
            this.btn_line.TabIndex = 7;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.Color.White;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.Image = global::WindowsFormsApp6.Properties.Resources.rectangle;
            this.btn_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rect.Location = new System.Drawing.Point(590, 29);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(68, 55);
            this.btn_rect.TabIndex = 6;
            this.btn_rect.Text = "Rectangle";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // Upload_btn
            // 
            this.Upload_btn.BackColor = System.Drawing.Color.White;
            this.Upload_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Upload_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Upload_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upload_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Upload_btn.Location = new System.Drawing.Point(749, 49);
            this.Upload_btn.Name = "Upload_btn";
            this.Upload_btn.Size = new System.Drawing.Size(73, 26);
            this.Upload_btn.TabIndex = 10;
            this.Upload_btn.Tag = "Clear";
            this.Upload_btn.Text = "Upload";
            this.Upload_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Upload_btn.UseVisualStyleBackColor = false;
            this.Upload_btn.Click += new System.EventHandler(this.Upload_btn_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.Color.White;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.Image = global::WindowsFormsApp6.Properties.Resources.circle;
            this.btn_ellipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ellipse.Location = new System.Drawing.Point(520, 29);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(64, 55);
            this.btn_ellipse.TabIndex = 5;
            this.btn_ellipse.Text = "Circle";
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.Color.White;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.Image = global::WindowsFormsApp6.Properties.Resources.eraser;
            this.btn_eraser.Location = new System.Drawing.Point(446, 29);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(68, 55);
            this.btn_eraser.TabIndex = 4;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.Color.White;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.Image = global::WindowsFormsApp6.Properties.Resources.pencil;
            this.btn_pencil.Location = new System.Drawing.Point(383, 29);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(57, 55);
            this.btn_pencil.TabIndex = 3;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = false;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.White;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.Image = global::WindowsFormsApp6.Properties.Resources.bucket;
            this.btn_fill.Location = new System.Drawing.Point(320, 29);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(57, 55);
            this.btn_fill.TabIndex = 2;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = false;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.White;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.Image = global::WindowsFormsApp6.Properties.Resources.color;
            this.btn_color.Location = new System.Drawing.Point(258, 29);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(56, 55);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(205, 42);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(38, 42);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            this.pic_color.Click += new System.EventHandler(this.pic_color_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(249, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 82);
            this.panel3.TabIndex = 3;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clear.Location = new System.Drawing.Point(871, 9);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(73, 26);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Tag = "Clear";
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btn_redo);
            this.panel2.Controls.Add(this.btn_undo);
            this.panel2.Controls.Add(this.btn_Select);
            this.panel2.Controls.Add(this.Thickness4);
            this.panel2.Controls.Add(this.Thickness3);
            this.panel2.Controls.Add(this.Thickness2);
            this.panel2.Controls.Add(this.Thickness1);
            this.panel2.Controls.Add(this.LineWidth);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 88);
            this.panel2.TabIndex = 1;
            // 
            // btn_redo
            // 
            this.btn_redo.BackColor = System.Drawing.Color.White;
            this.btn_redo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_redo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_redo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_redo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_redo.Location = new System.Drawing.Point(862, 3);
            this.btn_redo.Name = "btn_redo";
            this.btn_redo.Size = new System.Drawing.Size(73, 29);
            this.btn_redo.TabIndex = 13;
            this.btn_redo.Tag = "Select";
            this.btn_redo.Text = "Redo";
            this.btn_redo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_redo.UseVisualStyleBackColor = false;
            this.btn_redo.Click += new System.EventHandler(this.btn_redo_Click);
            // 
            // btn_undo
            // 
            this.btn_undo.BackColor = System.Drawing.Color.White;
            this.btn_undo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_undo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_undo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_undo.Location = new System.Drawing.Point(862, 47);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(73, 29);
            this.btn_undo.TabIndex = 12;
            this.btn_undo.Tag = "Select";
            this.btn_undo.Text = "Undo";
            this.btn_undo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_undo.UseVisualStyleBackColor = false;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.BackColor = System.Drawing.Color.White;
            this.btn_Select.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_Select.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Select.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Select.Location = new System.Drawing.Point(763, 6);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(73, 29);
            this.btn_Select.TabIndex = 11;
            this.btn_Select.Tag = "Select";
            this.btn_Select.Text = "Select";
            this.btn_Select.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Select.UseVisualStyleBackColor = false;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.White;
            this.Exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit_btn.Location = new System.Drawing.Point(871, 49);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(73, 26);
            this.Exit_btn.TabIndex = 9;
            this.Exit_btn.Tag = "Clear";
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Thickness4
            // 
            this.Thickness4.BackColor = System.Drawing.Color.White;
            this.Thickness4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Thickness4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Thickness4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Thickness4.Image = global::WindowsFormsApp6.Properties.Resources.thickness4;
            this.Thickness4.Location = new System.Drawing.Point(214, 21);
            this.Thickness4.Name = "Thickness4";
            this.Thickness4.Size = new System.Drawing.Size(57, 55);
            this.Thickness4.TabIndex = 6;
            this.Thickness4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Thickness4.UseVisualStyleBackColor = false;
            this.Thickness4.Click += new System.EventHandler(this.Thickness4_Click);
            // 
            // Thickness3
            // 
            this.Thickness3.BackColor = System.Drawing.Color.White;
            this.Thickness3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Thickness3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Thickness3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Thickness3.Image = global::WindowsFormsApp6.Properties.Resources.thickness3;
            this.Thickness3.Location = new System.Drawing.Point(151, 21);
            this.Thickness3.Name = "Thickness3";
            this.Thickness3.Size = new System.Drawing.Size(57, 55);
            this.Thickness3.TabIndex = 5;
            this.Thickness3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Thickness3.UseVisualStyleBackColor = false;
            this.Thickness3.Click += new System.EventHandler(this.Thickness3_Click);
            // 
            // Thickness2
            // 
            this.Thickness2.BackColor = System.Drawing.Color.White;
            this.Thickness2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Thickness2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Thickness2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Thickness2.Image = global::WindowsFormsApp6.Properties.Resources.thickness2;
            this.Thickness2.Location = new System.Drawing.Point(88, 21);
            this.Thickness2.Name = "Thickness2";
            this.Thickness2.Size = new System.Drawing.Size(57, 55);
            this.Thickness2.TabIndex = 4;
            this.Thickness2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Thickness2.UseVisualStyleBackColor = false;
            this.Thickness2.Click += new System.EventHandler(this.Thickness2_Click);
            // 
            // Thickness1
            // 
            this.Thickness1.BackColor = System.Drawing.Color.White;
            this.Thickness1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Thickness1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Thickness1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Thickness1.Image = global::WindowsFormsApp6.Properties.Resources.thickness1;
            this.Thickness1.Location = new System.Drawing.Point(25, 21);
            this.Thickness1.Name = "Thickness1";
            this.Thickness1.Size = new System.Drawing.Size(57, 55);
            this.Thickness1.TabIndex = 3;
            this.Thickness1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Thickness1.UseVisualStyleBackColor = false;
            this.Thickness1.Click += new System.EventHandler(this.Thickness1_Click);
            // 
            // LineWidth
            // 
            this.LineWidth.Location = new System.Drawing.Point(25, 0);
            this.LineWidth.Name = "LineWidth";
            this.LineWidth.Size = new System.Drawing.Size(246, 20);
            this.LineWidth.TabIndex = 0;
            this.LineWidth.Text = "Line Width";
            this.LineWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 100);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(947, 262);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button Thickness4;
        private System.Windows.Forms.Button Thickness3;
        private System.Windows.Forms.Button Thickness2;
        private System.Windows.Forms.Button Thickness1;
        private System.Windows.Forms.TextBox LineWidth;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Upload_btn;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_undo;
        private System.Windows.Forms.Button btn_redo;
    }
}

