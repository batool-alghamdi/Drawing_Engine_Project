using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using DrawingEngine.Tokenization;
using DrawingEngine.Tokenization.Handlers;
using System.Drawing.Drawing2D;

namespace DrawingEngine
{
    enum ShapeType
    {
        Line,
        Circle,
        Rectangle
    }
    public partial class drawingEngine : Form
    {

        OpenFileDialog fileDialog = new OpenFileDialog();
        string line = "";
        StringBuilder sb = new StringBuilder();

        private ShapeType shapeType;
        private string shapeName = "line";
        private bool solidStyle = true;
        private bool drawMood = true;
        private int fontSize = 7;
        private bool isDrawing = false;
        private Shape currentShape = null;
        private int currentShapeIndex = -1;
        private int selectedShapeIndex = -1;
        private bool resizeLeft = false;
        private bool resizeRight = false;
        private bool resizeTop = false;
        private bool resizeBottom = false;
        private Point delta;
        private bool isClicked = false;
        private List<Shape> shapes = new List<Shape> { };
        Pen pen;

        Parser parser;

        /// <summary>
        /// Shape Class and it's childredn
        /// </summary>
        public abstract class Shape
        {
            public Point start;
            public Point end;
            public Pen pen;
            public string type;
            public int width;
            public int height;
            public Rectangle center, top, left, right, bottom;

            public abstract void draw(PaintEventArgs e);
            public abstract void drawBoundaries(PaintEventArgs e);

            public abstract bool checkSelectedShape(MouseEventArgs e);

            public bool checkSelectedSBoundry(MouseEventArgs e, Rectangle boundry)
            {
                Rectangle area = new Rectangle(e.Location.X, e.Location.Y, 10, 10);
                return boundry.IntersectsWith(area);
            }



        }

        public class Circle : Shape
        {

            public override void draw(PaintEventArgs e)
            {

                e.Graphics.DrawEllipse(this.pen, new Rectangle(this.start.X, this.start.Y, this.width, this.height));
                this.center = new Rectangle(this.start.X + (this.width - 20) / 2, this.start.Y + (this.height - 20) / 2, 20, 20);
                this.top = new Rectangle(this.start.X + (this.width - 20) / 2, this.start.Y - 10, 20, 20);
                this.left = new Rectangle(this.start.X - 10, this.start.Y + (this.height - 20) / 2, 20, 20);
                this.bottom = new Rectangle(((this.start.X - 10) + this.width / 2), (this.start.Y + this.height) - 10, 20, 20);
                this.right = new Rectangle((this.start.X + this.width - 10), (this.start.Y - 10) + this.height / 2, 20, 20);
            }
            public override void drawBoundaries(PaintEventArgs e)
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.Red), this.center);
                e.Graphics.FillEllipse(new SolidBrush(Color.Red), this.top);
                e.Graphics.FillEllipse(new SolidBrush(Color.Red), this.left);
                e.Graphics.FillEllipse(new SolidBrush(Color.Red), this.right);
                e.Graphics.FillEllipse(new SolidBrush(Color.Red), this.bottom);
            }
            public override bool checkSelectedShape(MouseEventArgs e)
            {
                Rectangle rec = new Rectangle(this.start.X, this.start.Y, this.width, this.height);
                Rectangle area = new Rectangle(e.Location.X, e.Location.Y, 10, 10);
                return rec.IntersectsWith(area);
            }



        }

        public class LineShape : Shape
        {
            public override void draw(PaintEventArgs e)
            {

                e.Graphics.DrawLine(this.pen, this.start, this.end);
                this.center = new Rectangle(((this.start.X + this.end.X) / 2) - 10, ((this.start.Y + this.end.Y) / 2) - 10, 20, 20);
                this.right = new Rectangle(this.end.X - 10, this.end.Y - 10, 20, 20);
                this.left = new Rectangle(this.start.X - 10, this.start.Y - 10, 20, 20);
            }
            public override void drawBoundaries(PaintEventArgs e)
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.Red), this.center);
                e.Graphics.FillEllipse(new SolidBrush(Color.Red), this.left);
                e.Graphics.FillEllipse(new SolidBrush(Color.Red), this.right);

            }

            public override bool checkSelectedShape(MouseEventArgs e)
            {

                GraphicsPath linePath = new GraphicsPath();
                linePath.AddLine(this.start, this.end);
                return linePath.GetBounds().Contains(e.Location.X, e.Location.Y);

            }


        }

        public class RectShape : Shape
        {
            public override void draw(PaintEventArgs e)
            {

                e.Graphics.DrawRectangle(this.pen, new Rectangle(this.start.X, this.start.Y, this.width, this.height));
                this.center = new Rectangle(this.start.X + (this.width - 20) / 2, this.start.Y + (this.height - 20) / 2, 20, 20);
                this.top = new Rectangle(this.start.X + (this.width - 20) / 2, this.start.Y - 10, 20, 20);
                this.left = new Rectangle(this.start.X - 10, this.start.Y + (this.height - 20) / 2, 20, 20);
                this.bottom = new Rectangle(((this.start.X - 10) + this.width / 2), (this.start.Y + this.height) - 10, 20, 20);
                this.right = new Rectangle((this.start.X + this.width - 10), (this.start.Y - 10) + this.height / 2, 20, 20);
            }

            public override void drawBoundaries(PaintEventArgs e)
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.Red), this.center);
                e.Graphics.FillEllipse(new SolidBrush(Color.Red), this.top);
                e.Graphics.FillEllipse(new SolidBrush(Color.Red), this.left);
                e.Graphics.FillEllipse(new SolidBrush(Color.Red), this.right);
                e.Graphics.FillEllipse(new SolidBrush(Color.Red), this.bottom);
            }

            public override bool checkSelectedShape(MouseEventArgs e)
            {
                Rectangle rec = new Rectangle(this.start.X, this.start.Y, this.width, this.height);
                Rectangle area = new Rectangle(e.Location.X, e.Location.Y, 10, 10);
                return rec.IntersectsWith(area);
            }


        }


        public drawingEngine()
        {
            InitializeComponent();
            tabs.SelectTab("designTab");
        }

     

    


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName);
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        sourceTextbox.AppendText("\r\n" + line);
                        sourceTextbox.ScrollToCaret();
                    }

                }
                sr.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fileDialog.Filter = "Text Files (.txt) | *.txt";
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog1.ShowDialog();
            Color pickedColor = colorDialog1.Color;
            if (dialogResult == DialogResult.OK)
            {
                
                if (pickedColor.IsNamedColor)
                {
                    string name = pickedColor.Name.ToLower();
                    Color red = Color.FromName(name);
                    Debug.WriteLine(red.Name);
                } else if (pickedColor.Name[0] == 'f' && pickedColor.Name[1] == 'f')
                {

                    int r = Convert.ToInt32(pickedColor.Name.Substring(2, 2), 16);
                    int g = Convert.ToInt32(pickedColor.Name.Substring(4, 2), 16);
                    int b = Convert.ToInt32(pickedColor.Name.Substring(6, 2), 16);
                    Debug.WriteLine(pickedColor.Name);
                    Debug.WriteLine($"r: {r}  g: {g}  b: {b}");
                    Color red = Color.FromArgb(r, g, b);
                    //this.penColor = red;
                }
                else
                {
                    Debug.WriteLine(pickedColor.Name);
                }
                //this.penColor = colorDialog1.Color;
                //this.pen.Color = this.penColor;
            }
        }

        private void sourceTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                sb.Clear();
                sb.Append(sourceTextbox.Text);



                //tokenize sb

                //    Tokenizer t = new Tokenizer(new Input(sb.ToString()), new Tokenizable[]
                //{
                //        //new ShapeHandler(),
                //        new ColorHandler(),
                //        new StringTokenizer(),
                //        new WhiteSpaceHandler(),
                //        new SpecialCharacterHandler(),
                //        new NumberHandler()


                //});

                //Token token = t.tokenize();
                //while (token != null)
                //{
                //    Debug.WriteLine($"value: {token.Value}        type: {token.Type}");
                //    token = t.tokenize();
                //}
                Tokenizer t = new Tokenizer(new Input(sb.ToString()), new Tokenizable[]
            {
                //new ShapeHandler(),
                new ColorHandler(),
                new StringTokenizer(),
                new WhiteSpaceHandler(),
                new SpecialCharacterHandler(),
                new NumberHandler()

            });
                parser = new Parser(t);
                Shape s = parser.ParseLine();
                Debug.WriteLine(s.start.X);
                Debug.WriteLine(s.start.Y);
                Debug.WriteLine(s.height);
                Debug.WriteLine(s.width);
                Debug.WriteLine(s.pen.Color.Name);
                Debug.WriteLine("----------------------------------------");
            }
        }

        private void sourceTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
