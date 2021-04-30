
namespace DrawingEngine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.straight = new System.Windows.Forms.Panel();
            this.rightTab = new System.Windows.Forms.Panel();
            this.penStyle = new System.Windows.Forms.GroupBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.Label();
            this.sizePicker = new System.Windows.Forms.NumericUpDown();
            this.notDashedButton = new System.Windows.Forms.Button();
            this.dashedButton = new System.Windows.Forms.Button();
            this.Tools = new System.Windows.Forms.GroupBox();
            this.handButton = new System.Windows.Forms.Button();
            this.drawButton = new System.Windows.Forms.Button();
            this.Shapes = new System.Windows.Forms.GroupBox();
            this.CircleButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.designButton = new System.Windows.Forms.Button();
            this.sourceButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.rightTab.SuspendLayout();
            this.penStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizePicker)).BeginInit();
            this.Tools.SuspendLayout();
            this.Shapes.SuspendLayout();
            this.SuspendLayout();
            // 
            // straight
            // 
            this.straight.Location = new System.Drawing.Point(32, 30);
            this.straight.Name = "straight";
            this.straight.Size = new System.Drawing.Size(1225, 823);
            this.straight.TabIndex = 0;
            this.straight.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rightTab
            // 
            this.rightTab.Controls.Add(this.saveButton);
            this.rightTab.Controls.Add(this.openButton);
            this.rightTab.Controls.Add(this.penStyle);
            this.rightTab.Controls.Add(this.Tools);
            this.rightTab.Controls.Add(this.Shapes);
            this.rightTab.Location = new System.Drawing.Point(1276, 30);
            this.rightTab.Name = "rightTab";
            this.rightTab.Size = new System.Drawing.Size(327, 872);
            this.rightTab.TabIndex = 1;
            // 
            // penStyle
            // 
            this.penStyle.Controls.Add(this.colorButton);
            this.penStyle.Controls.Add(this.size);
            this.penStyle.Controls.Add(this.sizePicker);
            this.penStyle.Controls.Add(this.notDashedButton);
            this.penStyle.Controls.Add(this.dashedButton);
            this.penStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.penStyle.Location = new System.Drawing.Point(26, 556);
            this.penStyle.Name = "penStyle";
            this.penStyle.Size = new System.Drawing.Size(276, 243);
            this.penStyle.TabIndex = 12;
            this.penStyle.TabStop = false;
            this.penStyle.Text = "Pen Style";
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.colorButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorButton.Location = new System.Drawing.Point(64, 154);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(159, 57);
            this.colorButton.TabIndex = 12;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = false;
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.size.Location = new System.Drawing.Point(177, 50);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(50, 30);
            this.size.TabIndex = 0;
            this.size.Text = "Size";
            this.size.Click += new System.EventHandler(this.label1_Click);
            // 
            // sizePicker
            // 
            this.sizePicker.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizePicker.Location = new System.Drawing.Point(182, 83);
            this.sizePicker.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.sizePicker.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sizePicker.Name = "sizePicker";
            this.sizePicker.Size = new System.Drawing.Size(65, 46);
            this.sizePicker.TabIndex = 0;
            this.sizePicker.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // notDashedButton
            // 
            this.notDashedButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.notDashedButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notDashedButton.Location = new System.Drawing.Point(103, 77);
            this.notDashedButton.Name = "notDashedButton";
            this.notDashedButton.Size = new System.Drawing.Size(65, 57);
            this.notDashedButton.TabIndex = 6;
            this.notDashedButton.Text = "━━";
            this.notDashedButton.UseVisualStyleBackColor = false;
            // 
            // dashedButton
            // 
            this.dashedButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dashedButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dashedButton.Location = new System.Drawing.Point(26, 77);
            this.dashedButton.Name = "dashedButton";
            this.dashedButton.Size = new System.Drawing.Size(65, 57);
            this.dashedButton.TabIndex = 5;
            this.dashedButton.Text = "---";
            this.dashedButton.UseVisualStyleBackColor = false;
            // 
            // Tools
            // 
            this.Tools.Controls.Add(this.handButton);
            this.Tools.Controls.Add(this.drawButton);
            this.Tools.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tools.Location = new System.Drawing.Point(26, 356);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(276, 174);
            this.Tools.TabIndex = 11;
            this.Tools.TabStop = false;
            this.Tools.Text = "Tools";
            // 
            // handButton
            // 
            this.handButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.handButton.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.handButton.Location = new System.Drawing.Point(64, 68);
            this.handButton.Name = "handButton";
            this.handButton.Size = new System.Drawing.Size(65, 57);
            this.handButton.TabIndex = 5;
            this.handButton.Text = "✋";
            this.handButton.UseVisualStyleBackColor = false;
            // 
            // drawButton
            // 
            this.drawButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.drawButton.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drawButton.Location = new System.Drawing.Point(145, 68);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(65, 57);
            this.drawButton.TabIndex = 6;
            this.drawButton.Text = "✎";
            this.drawButton.UseVisualStyleBackColor = false;
            // 
            // Shapes
            // 
            this.Shapes.Controls.Add(this.CircleButton);
            this.Shapes.Controls.Add(this.RectangleButton);
            this.Shapes.Controls.Add(this.lineButton);
            this.Shapes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Shapes.Location = new System.Drawing.Point(26, 161);
            this.Shapes.Name = "Shapes";
            this.Shapes.Size = new System.Drawing.Size(276, 174);
            this.Shapes.TabIndex = 10;
            this.Shapes.TabStop = false;
            this.Shapes.Text = "Shape";
            // 
            // CircleButton
            // 
            this.CircleButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CircleButton.Location = new System.Drawing.Point(26, 68);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(65, 57);
            this.CircleButton.TabIndex = 7;
            this.CircleButton.Text = "○";
            this.CircleButton.UseVisualStyleBackColor = false;
            // 
            // RectangleButton
            // 
            this.RectangleButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RectangleButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RectangleButton.Location = new System.Drawing.Point(184, 68);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(65, 57);
            this.RectangleButton.TabIndex = 9;
            this.RectangleButton.Text = "▭";
            this.RectangleButton.UseVisualStyleBackColor = false;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lineButton.Location = new System.Drawing.Point(103, 68);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(65, 57);
            this.lineButton.TabIndex = 8;
            this.lineButton.Text = "╱";
            this.lineButton.UseVisualStyleBackColor = false;
            // 
            // designButton
            // 
            this.designButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.designButton.Location = new System.Drawing.Point(31, 845);
            this.designButton.Name = "designButton";
            this.designButton.Size = new System.Drawing.Size(159, 57);
            this.designButton.TabIndex = 10;
            this.designButton.Text = "Design";
            this.designButton.UseVisualStyleBackColor = false;
            // 
            // sourceButton
            // 
            this.sourceButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sourceButton.Location = new System.Drawing.Point(186, 845);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(159, 57);
            this.sourceButton.TabIndex = 11;
            this.sourceButton.Text = "Source";
            this.sourceButton.UseVisualStyleBackColor = false;
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.openButton.Location = new System.Drawing.Point(26, 65);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(129, 57);
            this.openButton.TabIndex = 12;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Location = new System.Drawing.Point(171, 65);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(129, 57);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DrawingEngine.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1628, 934);
            this.Controls.Add(this.rightTab);
            this.Controls.Add(this.straight);
            this.Controls.Add(this.designButton);
            this.Controls.Add(this.sourceButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.rightTab.ResumeLayout(false);
            this.penStyle.ResumeLayout(false);
            this.penStyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizePicker)).EndInit();
            this.Tools.ResumeLayout(false);
            this.Shapes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel straight;
        private System.Windows.Forms.Panel rightTab;
        private System.Windows.Forms.GroupBox Shapes;
        private System.Windows.Forms.Button CircleButton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button handButton;
        private System.Windows.Forms.Button designButton;
        private System.Windows.Forms.Button sourceButton;
        private System.Windows.Forms.GroupBox penStyle;
        private System.Windows.Forms.Button notDashedButton;
        private System.Windows.Forms.Button dashedButton;
        private System.Windows.Forms.GroupBox Tools;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.NumericUpDown sizePicker;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
    }
}

