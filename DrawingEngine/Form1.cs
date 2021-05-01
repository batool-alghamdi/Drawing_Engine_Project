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
<<<<<<< HEAD
=======
using System.Diagnostics;
>>>>>>> e5d5a71301304aec693ae93b3f9ecc15383f67d7

namespace DrawingEngine
{
    public partial class drawingEngine : Form
    {
        OpenFileDialog fileDialog = new OpenFileDialog();
        string line = "";
        String path = @"c:\Desktop\Projects\SourceCode.drw";
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
            fileDialog.Filter = "Text Files (.drw) | *.drw";
        }

<<<<<<< HEAD
        private void saveButton_Click(object sender, EventArgs e)
        {
           // File.WriteAllText(fileDialog.FileName, sourceTextbox.Text);
           OpenFileDialog browser1 = new OpenFileDialog();
            SaveFileDialog saver = new SaveFileDialog();
            DialogResult LocRes = saver.ShowDialog();
            if (LocRes == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saver.FileName + ".drw", sourceTextbox.Text);
                MessageBox.Show("File saved");
                sourceTextbox.Clear();
            }
        }
        
=======
        private void colorButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = colorDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Debug.WriteLine(colorDialog1.Color.Name);
                //this.penColor = colorDialog1.Color;
                //this.pen.Color = this.penColor;
            }
        }
>>>>>>> e5d5a71301304aec693ae93b3f9ecc15383f67d7
    }
}

