namespace Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonIsTriangle = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavePluginsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenClassToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.плагиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlShapes = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_Star = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.Location = new System.Drawing.Point(19, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(703, 411);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTriangle.Location = new System.Drawing.Point(12, 43);
            this.buttonTriangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(79, 55);
            this.buttonTriangle.TabIndex = 2;
            this.buttonTriangle.Text = "Triangle";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSquare.Location = new System.Drawing.Point(12, 102);
            this.buttonSquare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(79, 55);
            this.buttonSquare.TabIndex = 3;
            this.buttonSquare.Text = "Square";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRectangle.Location = new System.Drawing.Point(12, 161);
            this.buttonRectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(79, 55);
            this.buttonRectangle.TabIndex = 4;
            this.buttonRectangle.Text = "Rectangle";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonIsTriangle
            // 
            this.buttonIsTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIsTriangle.Location = new System.Drawing.Point(12, 220);
            this.buttonIsTriangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIsTriangle.Name = "buttonIsTriangle";
            this.buttonIsTriangle.Size = new System.Drawing.Size(79, 55);
            this.buttonIsTriangle.TabIndex = 5;
            this.buttonIsTriangle.Text = "Isosceles Triangle";
            this.buttonIsTriangle.UseVisualStyleBackColor = true;
            this.buttonIsTriangle.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCircle.Location = new System.Drawing.Point(12, 279);
            this.buttonCircle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(79, 55);
            this.buttonCircle.TabIndex = 6;
            this.buttonCircle.Text = "Circle";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.плагиныToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(910, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.OpenToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavePluginsToolStripMenuItem1,
            this.SaveClassToolStripMenuItem});
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            // 
            // SavePluginsToolStripMenuItem1
            // 
            this.SavePluginsToolStripMenuItem1.Name = "SavePluginsToolStripMenuItem1";
            this.SavePluginsToolStripMenuItem1.Size = new System.Drawing.Size(243, 26);
            this.SavePluginsToolStripMenuItem1.Text = "Файл фигур(плагины)";
            this.SavePluginsToolStripMenuItem1.Click += new System.EventHandler(this.SavePluginsToolStripMenuItem1_Click);
            // 
            // SaveClassToolStripMenuItem
            // 
            this.SaveClassToolStripMenuItem.Name = "SaveClassToolStripMenuItem";
            this.SaveClassToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.SaveClassToolStripMenuItem.Text = "Файл фигур(классы)";
            this.SaveClassToolStripMenuItem.Click += new System.EventHandler(this.SaveClassToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenPluginsToolStripMenuItem,
            this.OpenClassToolStripMenuItem1});
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.OpenToolStripMenuItem.Text = "Открыть";
            // 
            // OpenPluginsToolStripMenuItem
            // 
            this.OpenPluginsToolStripMenuItem.Name = "OpenPluginsToolStripMenuItem";
            this.OpenPluginsToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.OpenPluginsToolStripMenuItem.Text = "Файл фигур(плагины)";
            this.OpenPluginsToolStripMenuItem.Click += new System.EventHandler(this.OpenPluginsToolStripMenuItem_Click);
            // 
            // OpenClassToolStripMenuItem1
            // 
            this.OpenClassToolStripMenuItem1.Name = "OpenClassToolStripMenuItem1";
            this.OpenClassToolStripMenuItem1.Size = new System.Drawing.Size(243, 26);
            this.OpenClassToolStripMenuItem1.Text = "Файл фигур(классы)";
            this.OpenClassToolStripMenuItem1.Click += new System.EventHandler(this.OpenClassToolStripMenuItem1_Click);
            // 
            // плагиныToolStripMenuItem
            // 
            this.плагиныToolStripMenuItem.Name = "плагиныToolStripMenuItem";
            this.плагиныToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.плагиныToolStripMenuItem.Text = "Загрузить плагины";
            this.плагиныToolStripMenuItem.Click += new System.EventHandler(this.плагиныToolStripMenuItem_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(616, 473);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(220, 32);
            this.button7.TabIndex = 8;
            this.button7.Text = "Редактировать объект";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(616, 509);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(220, 32);
            this.button8.TabIndex = 9;
            this.button8.Text = "Удалить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(373, 493);
            this.comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 24);
            this.comboBox.TabIndex = 10;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnColor.Location = new System.Drawing.Point(136, 493);
            this.btnColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(79, 42);
            this.btnColor.TabIndex = 12;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.button10_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(245, 493);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 22);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(117, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 413);
            this.panel1.TabIndex = 14;
            // 
            // pnlShapes
            // 
            this.pnlShapes.Location = new System.Drawing.Point(12, 405);
            this.pnlShapes.Name = "pnlShapes";
            this.pnlShapes.Size = new System.Drawing.Size(79, 130);
            this.pnlShapes.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_Star
            // 
            this.button_Star.Location = new System.Drawing.Point(12, 339);
            this.button_Star.Name = "button_Star";
            this.button_Star.Size = new System.Drawing.Size(77, 48);
            this.button_Star.TabIndex = 17;
            this.button_Star.Text = "Star";
            this.button_Star.UseVisualStyleBackColor = true;
            this.button_Star.Click += new System.EventHandler(this.button_Star_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 547);
            this.Controls.Add(this.button_Star);
            this.Controls.Add(this.pnlShapes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.buttonIsTriangle);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonTriangle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonIsTriangle;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btnColor;
        internal System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem плагиныToolStripMenuItem;
        private System.Windows.Forms.Panel pnlShapes;
        private System.Windows.Forms.ToolStripMenuItem SavePluginsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OpenPluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenClassToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveClassToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_Star;
    }
}

