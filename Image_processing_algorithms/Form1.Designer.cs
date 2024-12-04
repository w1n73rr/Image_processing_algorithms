namespace Image_processing_algorithms
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            bTB = new TextBox();
            aTB = new TextBox();
            preobrButton = new Button();
            TB22 = new TextBox();
            TB21 = new TextBox();
            TB20 = new TextBox();
            TB12 = new TextBox();
            TB11 = new TextBox();
            TB10 = new TextBox();
            TB02 = new TextBox();
            TB01 = new TextBox();
            TB00 = new TextBox();
            label5 = new Label();
            valueTextBox = new TextBox();
            thresholdButton = new Button();
            getBWButton = new Button();
            maskPB = new PictureBox();
            label4 = new Label();
            preparationPB = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            bwPicture = new PictureBox();
            label1 = new Label();
            samplePicture = new PictureBox();
            imgOFD = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maskPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)preparationPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bwPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)samplePicture).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(802, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(bTB);
            panel1.Controls.Add(aTB);
            panel1.Controls.Add(preobrButton);
            panel1.Controls.Add(TB22);
            panel1.Controls.Add(TB21);
            panel1.Controls.Add(TB20);
            panel1.Controls.Add(TB12);
            panel1.Controls.Add(TB11);
            panel1.Controls.Add(TB10);
            panel1.Controls.Add(TB02);
            panel1.Controls.Add(TB01);
            panel1.Controls.Add(TB00);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(valueTextBox);
            panel1.Controls.Add(thresholdButton);
            panel1.Controls.Add(getBWButton);
            panel1.Controls.Add(maskPB);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(preparationPB);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(bwPicture);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(samplePicture);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 623);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // bTB
            // 
            bTB.Location = new Point(737, 366);
            bTB.Name = "bTB";
            bTB.Size = new Size(49, 27);
            bTB.TabIndex = 23;
            bTB.Text = "0,25";
            // 
            // aTB
            // 
            aTB.Location = new Point(683, 366);
            aTB.Name = "aTB";
            aTB.Size = new Size(49, 27);
            aTB.TabIndex = 22;
            aTB.Text = "0";
            // 
            // preobrButton
            // 
            preobrButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            preobrButton.Location = new Point(484, 466);
            preobrButton.Name = "preobrButton";
            preobrButton.Size = new Size(156, 48);
            preobrButton.TabIndex = 21;
            preobrButton.Text = "Преобразовать";
            preobrButton.UseVisualStyleBackColor = true;
            preobrButton.Click += preobrButton_Click;
            // 
            // TB22
            // 
            TB22.Location = new Point(592, 433);
            TB22.Name = "TB22";
            TB22.Size = new Size(48, 27);
            TB22.TabIndex = 20;
            TB22.Text = "1";
            // 
            // TB21
            // 
            TB21.Location = new Point(538, 433);
            TB21.Name = "TB21";
            TB21.Size = new Size(48, 27);
            TB21.TabIndex = 19;
            TB21.Text = "0";
            // 
            // TB20
            // 
            TB20.Location = new Point(484, 433);
            TB20.Name = "TB20";
            TB20.Size = new Size(48, 27);
            TB20.TabIndex = 18;
            TB20.Text = "-1";
            // 
            // TB12
            // 
            TB12.Location = new Point(592, 400);
            TB12.Name = "TB12";
            TB12.Size = new Size(48, 27);
            TB12.TabIndex = 17;
            TB12.Text = "2";
            // 
            // TB11
            // 
            TB11.Location = new Point(538, 400);
            TB11.Name = "TB11";
            TB11.Size = new Size(48, 27);
            TB11.TabIndex = 16;
            TB11.Text = "0";
            // 
            // TB10
            // 
            TB10.Location = new Point(484, 400);
            TB10.Name = "TB10";
            TB10.Size = new Size(48, 27);
            TB10.TabIndex = 15;
            TB10.Text = "-2";
            // 
            // TB02
            // 
            TB02.Location = new Point(592, 367);
            TB02.Name = "TB02";
            TB02.Size = new Size(48, 27);
            TB02.TabIndex = 14;
            TB02.Text = "1";
            // 
            // TB01
            // 
            TB01.Location = new Point(538, 367);
            TB01.Name = "TB01";
            TB01.Size = new Size(48, 27);
            TB01.TabIndex = 13;
            TB01.Text = "0";
            // 
            // TB00
            // 
            TB00.Location = new Point(484, 367);
            TB00.Name = "TB00";
            TB00.Size = new Size(48, 27);
            TB00.TabIndex = 12;
            TB00.Text = "-1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(484, 121);
            label5.Name = "label5";
            label5.Size = new Size(215, 20);
            label5.TabIndex = 11;
            label5.Text = "Введите пороговое значение";
            // 
            // valueTextBox
            // 
            valueTextBox.Location = new Point(481, 144);
            valueTextBox.Name = "valueTextBox";
            valueTextBox.Size = new Size(125, 27);
            valueTextBox.TabIndex = 10;
            // 
            // thresholdButton
            // 
            thresholdButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            thresholdButton.Location = new Point(481, 49);
            thresholdButton.Name = "thresholdButton";
            thresholdButton.Size = new Size(160, 64);
            thresholdButton.TabIndex = 9;
            thresholdButton.Text = "Препарировать изображение";
            thresholdButton.UseVisualStyleBackColor = true;
            thresholdButton.Click += thresholdButton_Click;
            // 
            // getBWButton
            // 
            getBWButton.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            getBWButton.Location = new Point(12, 339);
            getBWButton.Name = "getBWButton";
            getBWButton.Size = new Size(196, 25);
            getBWButton.TabIndex = 8;
            getBWButton.Text = "Получить изображение";
            getBWButton.UseVisualStyleBackColor = true;
            getBWButton.Click += getBWButton_Click;
            // 
            // maskPB
            // 
            maskPB.Location = new Point(275, 367);
            maskPB.Name = "maskPB";
            maskPB.Size = new Size(200, 200);
            maskPB.TabIndex = 7;
            maskPB.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mont ExtraLight DEMO", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(275, 322);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 6;
            label4.Text = "3 задание:";
            // 
            // preparationPB
            // 
            preparationPB.Location = new Point(275, 49);
            preparationPB.Name = "preparationPB";
            preparationPB.Size = new Size(200, 200);
            preparationPB.TabIndex = 5;
            preparationPB.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mont ExtraLight DEMO", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(275, 4);
            label3.Name = "label3";
            label3.Size = new Size(527, 42);
            label3.TabIndex = 4;
            label3.Text = "Препарирование изображения (неполная пороговая обработка,\r\nрис.1.в).";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mont ExtraLight DEMO", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 322);
            label2.Name = "label2";
            label2.Size = new Size(234, 21);
            label2.TabIndex = 3;
            label2.Text = "Черно - белое изображение";
            // 
            // bwPicture
            // 
            bwPicture.Location = new Point(12, 367);
            bwPicture.Name = "bwPicture";
            bwPicture.Size = new Size(200, 200);
            bwPicture.TabIndex = 2;
            bwPicture.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mont ExtraLight DEMO", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(196, 21);
            label1.TabIndex = 1;
            label1.Text = "Исходное изображение";
            // 
            // samplePicture
            // 
            samplePicture.Location = new Point(12, 49);
            samplePicture.Name = "samplePicture";
            samplePicture.Size = new Size(200, 200);
            samplePicture.TabIndex = 0;
            samplePicture.TabStop = false;
            samplePicture.Click += samplePicture_Click;
            // 
            // imgOFD
            // 
            imgOFD.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 651);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maskPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)preparationPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)bwPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)samplePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private PictureBox samplePicture;
        private Label label2;
        private PictureBox bwPicture;
        private PictureBox preparationPB;
        private Label label3;
        private PictureBox maskPB;
        private Label label4;
        private OpenFileDialog imgOFD;
        private Button getBWButton;
        private Button thresholdButton;
        private Label label5;
        private TextBox valueTextBox;
        private TextBox TB22;
        private TextBox TB21;
        private TextBox TB20;
        private TextBox TB12;
        private TextBox TB11;
        private TextBox TB10;
        private TextBox TB02;
        private TextBox TB01;
        private TextBox TB00;
        private TextBox bTB;
        private TextBox aTB;
        private Button preobrButton;
    }
}
