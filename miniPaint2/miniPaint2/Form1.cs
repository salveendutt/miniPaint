using System.Drawing.Imaging;
using System.Globalization;

namespace miniPaint2
{
    public partial class miniForm : Form
    {
        private enum PaintMode { Normal, Rectangular, Ellipse, Eraser };
        private PaintMode current = PaintMode.Normal;
        private Color tempColor = Color.Black;
        private Graphics g;
        private Bitmap? myBackground;
        private Bitmap drawArea;
        private Bitmap? mytemp;
        private Pen pen;
        private bool MouseIsDown = false;
        private bool BrushIsPressed = false;
        private Point LocationStart;
        private Point LocationEnd;
        private Point LocationLiveStart;
        private Point LocationLiveEnd;
        private Rectangle rect;
        public miniForm()
        {
            //Main Drawing Pen
            pen = new Pen(Brushes.Black, 1);
            pen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
            InitializeComponent();

            //Create White Background and make the drawArea with comboBox
            //This is for the saving part. If we dont do it, it will save transparent background
            Bitmap myback = new Bitmap(Canvas.Size.Width, Canvas.Size.Height);
            var myg = Graphics.FromImage(myback);
            myg.Clear(Color.White);
            drawArea = new Bitmap(myback, Canvas.Size.Width, Canvas.Size.Height);
            Canvas.Image = drawArea;

            //Adding Items to ComboBox 
            ComboBox1.Items.Add("1");
            ComboBox1.Items.Add("2");
            ComboBox1.Items.Add("3");
            ComboBox1.SelectedIndex = 1;

            //Fill flowLayoutPanel with colors
            foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.FromKnownColor(color);
                pic.Size = new Size(25, 25);
                pic.Name = color.ToString();
                flowLayoutPanel.Controls.Add(pic);
                pic.Click += new EventHandler(colorBoxes_Click);
            }
            g = Canvas.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            g.Dispose();
            myg.Dispose();
        }
        private void colorBoxes_Click(object? sender, EventArgs e)
        {
            if (sender == null) return;
            if (current == PaintMode.Eraser) return;
            PictureBox picBox = (PictureBox)sender;
            pen.Color = picBox.BackColor;
            tempColor = pen.Color;
            currentColorButton.BackColor = picBox.BackColor;
            Pen dashedPen = new Pen(Color.FromArgb(picBox.BackColor.ToArgb() ^ 0xFFFFFF), 4);
            dashedPen.DashPattern = new float[2] { 1f, 1f };

            //Clearing the PictureBoxes from Selection Image
            foreach (PictureBox pictureBox in flowLayoutPanel.Controls)
            {
                pictureBox.Image = null;
            }
            Bitmap newBitmap = new Bitmap(picBox.Width, picBox.Height);

            //Drawing the outline for the selected PirctureBox
            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                g.DrawRectangle(dashedPen, new Rectangle(0, 0, picBox.Width, picBox.Height));
            }
            picBox.Image = newBitmap;
            picBox.Refresh();
            dashedPen.Dispose();
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            MouseIsDown = true;
            LocationStart = e.Location;
            LocationLiveStart = e.Location;
        }
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            MouseIsDown = false;
            LocationEnd = e.Location;
            LocationLiveEnd = e.Location;
            // Drawing Rectangle or Ellipse
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                if (current == PaintMode.Rectangular)
                {
                    g.DrawRectangle(pen, GetRect(LocationStart, LocationEnd));
                }
                
                else if (current == PaintMode.Ellipse)
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawEllipse(pen, GetRect(LocationStart, LocationEnd));
                }
            }
            Canvas.Refresh();
        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            //Drawing with a Brush
            if (brushButton.Checked && MouseIsDown && current == PaintMode.Normal || current == PaintMode.Eraser
                && e.Button == MouseButtons.Left && e.Button != MouseButtons.Right)
            {
                using (Graphics g = Graphics.FromImage(drawArea))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawLine(pen, LocationStart, new Point(e.X, e.Y));
                    LocationStart = e.Location;
                }
            }
            Canvas.Refresh();
            LocationLiveEnd = e.Location;
        }
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            //Drawing Live Preview without leaving anything on the bitmap
            g = e.Graphics;
            if (MouseIsDown)
            {
                if (current == PaintMode.Rectangular)
                {
                    g.DrawRectangle(pen, GetRect(LocationLiveStart, LocationLiveEnd));
                }
                if (current == PaintMode.Ellipse)
                {
                    g.DrawEllipse(pen, GetRect(LocationLiveStart,LocationLiveEnd));
                }
            }
        }
         
        private Rectangle GetRect(Point LocStart, Point LocEnd)
        {
            rect = new Rectangle();
            rect.X = Math.Min(LocStart.X, LocEnd.X);
            rect.Y = Math.Min(LocStart.Y, LocEnd.Y);
            rect.Width = Math.Abs(LocStart.X - LocEnd.X);
            rect.Height = Math.Abs(LocStart.Y - LocEnd.Y);
            return rect;
        }
        private void ComboBox_Click(object sender, EventArgs e)
        {
            //To be able to open ComboBox by clicking in the middle of it.
            ComboBox1.DroppedDown = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.Clear(Color.White);
            }
            Canvas.Refresh();
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBox1.SelectedItem.ToString())
            {
                case "1":
                    pen = new Pen(pen.Color, 1);
                    break;
                case "2":
                    pen = new Pen(pen.Color, 2);
                    break;
                case "3":
                    pen = new Pen(pen.Color, 3);
                    break;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save as";
            saveFileDialog1.Filter = "Bitmap Image|*.bmp|JPeg Image|*.jpg|Png Image|*.png";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                //Create File and save it in a certain format
                FileStream fs = (FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        Canvas.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 2:
                        Canvas.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 3:
                        Canvas.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Open Image";
            dialog.Filter = "bmp files (*.bmp)|*.bmp|JPeg Image|*.jpg|Png Image|*.png";
            PictureBox pic = new PictureBox();
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                //Load the Image itself
                pic.Image = new Bitmap(dialog.FileName);

                Size = new Size(pic.Image.Width + 130, pic.Image.Height + 80);
                drawArea.Dispose();
                drawArea = new Bitmap(pic.Image, pic.Image.Width, pic.Image.Height);
                Canvas.Image = drawArea;
            }
            else
            {
                dialog.Dispose();
                return;
            }
            dialog.Dispose();
        }

        private void Canvas_SizeChanged_1(object sender, EventArgs e)
        {
            if (mytemp != null) mytemp.Dispose();
            mytemp = drawArea;

            if(myBackground != null) myBackground.Dispose();
            myBackground = new Bitmap(Canvas.Size.Width, Canvas.Size.Height);

            var myg = Graphics.FromImage(myBackground);
            myg.Clear(Color.White);
            drawArea = new Bitmap(myBackground, Canvas.Size.Width, Canvas.Size.Height);
            Canvas.Image = drawArea;
            using(Graphics g = Graphics.FromImage(drawArea))
            {
                g.DrawImage(mytemp, new Point(0, 0));
            }
            myg.Dispose();
        }
        private void brushButton_Click(object sender, EventArgs e)
        {
            //Unchecking Other Buttons
            if (rectButton.Checked) rectButton.Checked = false;
            else if (ellipseButton.Checked) ellipseButton.Checked = false;
            else if (eraserButton.Checked) eraserButton.Checked = false;

            //Functionality
            current = PaintMode.Normal;
            pen.Color = tempColor;
            if (BrushIsPressed) BrushIsPressed = false;
            else BrushIsPressed = true;
        }

        private void rectButton_Click(object sender, EventArgs e)
        {
            //Unchecking Other Buttons
            if (brushButton.Checked) brushButton.Checked = false;
            else if (ellipseButton.Checked) ellipseButton.Checked = false;
            else if (eraserButton.Checked) eraserButton.Checked = false;

            //Functionality
            current = PaintMode.Rectangular;
            pen.Color = tempColor;
        }

        private void ellipseButton_Click(object sender, EventArgs e)
        {
            //Uncheckign Other Buttons 
            if (brushButton.Checked) brushButton.Checked = false;
            else if (rectButton.Checked) rectButton.Checked = false;
            else if (eraserButton.Checked) eraserButton.Checked = false;

            //Functionality
            current = PaintMode.Ellipse;
            pen.Color = tempColor;
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            //Unchecking Other Buttons
            if (brushButton.Checked) brushButton.Checked = false;
            else if (ellipseButton.Checked) ellipseButton.Checked = false;
            else if (rectButton.Checked) rectButton.Checked = false;

            //Functionality
            current = PaintMode.Eraser;
            pen.Color = Color.White;
        }

        private void EnglishButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-EN");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-EN");

            ChangeLanguageSettings();
        }

        private void RussianButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");

            ChangeLanguageSettings();
        }
        public void ChangeLanguageSettings()
        {
            //Saving Value of the Combobox
            var tempComboBoxValue = ComboBox1.SelectedIndex;
            var tempSize = Size;
            Controls.Clear();
            InitializeComponent();
            Size = tempSize;

            //Adding items to ComboBox
            Canvas.Image = drawArea;
            ComboBox1.Items.Add("1");
            ComboBox1.Items.Add("2");
            ComboBox1.Items.Add("3");

            //Fill flowLayoutPanel with colors
            foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.FromKnownColor(color);
                pic.Size = new Size(25, 25);
                pic.Name = color.ToString();
                flowLayoutPanel.Controls.Add(pic);
                pic.Click += new EventHandler(colorBoxes_Click);
            }

            //Setting the Parameters after language change
            if (current == PaintMode.Ellipse) ellipseButton.Checked = true;
            if (current == PaintMode.Rectangular) rectButton.Checked = true;
            if (current == PaintMode.Normal) brushButton.Checked = true;
            currentColorButton.BackColor = pen.Color;
            ComboBox1.SelectedIndex = tempComboBoxValue;
        }

        private void PolishButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pl-PL");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");

            ChangeLanguageSettings();
        }

        private void UkranianButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("uk-UA");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");

            ChangeLanguageSettings();
        }
    }
}