using System.Windows.Forms;
using System.Xml.Linq;

namespace FrancoMarket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            load = new Button();
            save = new Button();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            Naaame = new Label();
            enter = new Button();
            Weight = new Label();
            Length = new Label();
            Neame = new Label();
            Ind = new Label();
            NameBox = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(load);
            panel1.Controls.Add(save);
            panel1.Controls.Add(numericUpDown3);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(Naaame);
            panel1.Controls.Add(enter);
            panel1.Controls.Add(Weight);
            panel1.Controls.Add(Length);
            panel1.Controls.Add(Neame);
            panel1.Controls.Add(Ind);
            panel1.Controls.Add(NameBox);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 460);
            panel1.TabIndex = 0;
            // 
            // load
            // 
            load.BackColor = SystemColors.Control;
            load.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            load.Location = new Point(100, 372);
            load.Name = "load";
            load.Size = new Size(138, 27);
            load.TabIndex = 16;
            load.Text = "Carica";
            load.UseVisualStyleBackColor = false;
            load.Click += load_Click;
            // 
            // save
            // 
            save.BackColor = SystemColors.Control;
            save.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            save.Location = new Point(100, 332);
            save.Name = "save";
            save.Size = new Size(138, 27);
            save.TabIndex = 15;
            save.Text = "Salva";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Location = new Point(190, 232);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 14;
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(190, 192);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 13;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(190, 112);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Naaame
            // 
            Naaame.AutoSize = true;
            Naaame.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Naaame.Location = new Point(12, 156);
            Naaame.Name = "Naaame";
            Naaame.Size = new Size(47, 19);
            Naaame.TabIndex = 11;
            Naaame.Text = "Nome";
            // 
            // enter
            // 
            enter.BackColor = SystemColors.ButtonHighlight;
            enter.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enter.Location = new Point(100, 278);
            enter.Name = "enter";
            enter.Size = new Size(138, 33);
            enter.TabIndex = 9;
            enter.Text = "Invia";
            enter.UseVisualStyleBackColor = false;
            enter.Click += enter_Click;
            // 
            // Weight
            // 
            Weight.AutoSize = true;
            Weight.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Weight.Location = new Point(12, 236);
            Weight.Name = "Weight";
            Weight.Size = new Size(39, 19);
            Weight.TabIndex = 8;
            Weight.Text = "Peso";
            // 
            // Length
            // 
            Length.AutoSize = true;
            Length.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Length.Location = new Point(12, 196);
            Length.Name = "Length";
            Length.Size = new Size(78, 19);
            Length.TabIndex = 7;
            Length.Text = "Lunghezza";
            // 
            // Neame
            // 
            Neame.Location = new Point(0, 0);
            Neame.Name = "Neame";
            Neame.Size = new Size(100, 23);
            Neame.TabIndex = 10;
            // 
            // Ind
            // 
            Ind.AutoSize = true;
            Ind.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ind.Location = new Point(12, 116);
            Ind.Name = "Ind";
            Ind.Size = new Size(174, 19);
            Ind.TabIndex = 1;
            Ind.Text = "Numero (0 per accodare)";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(190, 152);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(120, 23);
            NameBox.TabIndex = 3;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(190, -24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 39);
            label1.TabIndex = 0;
            label1.Text = "Merluzzatore";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Azure;
            flowLayoutPanel1.Location = new Point(353, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(528, 460);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(884, 461);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(900, 500);
            MinimumSize = new Size(900, 500);
            Name = "Form1";
            Text = "Merluzzatore";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox WeightBox;
        private TextBox LengthBox;
        private TextBox NameBox;
        private Label Neame;
        private Label Ind;
        private Label Weight;
        private Label Length;
        private Button enter;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label Naaame;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Button save;
        private Button load;
    }
}
