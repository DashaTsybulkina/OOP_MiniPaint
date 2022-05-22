using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
using System.Linq;
using BaseClass;
using Star_Plugin;
using System.Security.Cryptography;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        List<Shape> listOfShapes = new List<Shape>();
        List<ShapePlugin> listOfPlugins = new List<ShapePlugin>();
        List<Type> plugins = new List<Type>();
        Color color = Color.Black;
        int index = 0;
        private Shape shape;
        private ShapePlugin shapePlugin1;
        private float penWidth;
        private Point startPoint;
        private Point endPoint;
        private bool isDrawn;
        private bool isDrawnPlugin;
        private bool isPlugin;

        public Form1()
        {
            color = Color.Black;
            penWidth = 1;
            InitializeComponent();
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = bitmap;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPlugin == true)
                isDrawnPlugin = true;
            else
                isDrawn = true;
            startPoint.X = e.X;
            startPoint.Y = e.Y;
            endPoint.X = e.X;
            endPoint.Y = e.Y;
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawn || isDrawnPlugin)
            {
                endPoint.X = e.X;
                endPoint.Y = e.Y;

                pictureBox.Refresh();
            }
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (shape != null)
            {
                endPoint.X = e.X;
                endPoint.Y = e.Y;

                isDrawn = false;
                if ((shape.StartPoint.X != 0) && (shape.StartPoint.Y != 0)){
                    listOfShapes.Add(shape);
                }

                if (shape != null)
                {
                    shape = shape.Clone();
                }
                pictureBox.Refresh();
            }
            if (shapePlugin1 != null)
            {
                endPoint.X = e.X;
                endPoint.Y = e.Y;

                isDrawnPlugin = false;

                if ((shapePlugin1.StartPoint.X != 0) && (shapePlugin1.StartPoint.X != 0))
                {
                    listOfPlugins.Add(shapePlugin1);
                }
                if (shapePlugin1 != null)
                {
                    object[] args;
                    args = new object[2] { color, penWidth };
                    shapePlugin1 = (ShapePlugin)Activator.CreateInstance(shapePlugin1.GetType(), args);
                }
            }
            changeComboBox();
        }

        private void changeComboBox()
        {
            comboBox.Items.Clear();
            foreach (Shape shape in listOfShapes)
            {
                if (shape.GetType().ToString() != "Lab_1.Adapter")
                {
                    string typeShape = shape.ToString();
                    comboBox.Items.Add(typeShape.Remove(0, 6));
                }
                else {
                    comboBox.Items.Add("Star");
                }
            }
            foreach (ShapePlugin shape in listOfPlugins)
            {
                string typeShape = shape.ToString();
                int index = typeShape.IndexOf(".") +1;
                comboBox.Items.Add(typeShape.Remove(0, index));
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            FactoryShape shapeFactory = new FactoryShape();
            shape = shapeFactory.GetShape(buttonCircle.Text, color, penWidth);
            isPlugin = false;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            FactoryShape shapeFactory = new FactoryShape();
            shape = shapeFactory.GetShape(buttonSquare.Text, color, penWidth);
            isPlugin = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FactoryShape shapeFactory = new FactoryShape();
            shape = shapeFactory.GetShape(buttonRectangle.Text, color, penWidth);
            isPlugin = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FactoryShape shapeFactory = new FactoryShape();
            shape = shapeFactory.GetShape(buttonIsTriangle.Text, color, penWidth);
            isPlugin = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FactoryShape shapeFactory = new FactoryShape();
            shape = shapeFactory.GetShape(buttonTriangle.Text,color, penWidth);
            isPlugin = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBox.SelectedIndex;
            if (index < listOfShapes.Count)
            {
                Shape shapeNew = listOfShapes[index];
                shape = shapeNew.Clone();
                shape.color = Color.Red;
                startPoint = shapeNew.StartPoint;
                endPoint = shapeNew.EndPoint;
                isDrawn = true;
                pictureBox.Refresh();
                isDrawn = false;
            }
            else {
                ShapePlugin shapeNew = listOfPlugins[index - listOfShapes.Count];
                shapePlugin1 = (ShapePlugin)Activator.CreateInstance(shapeNew.GetType(), Color.Red, penWidth);
                shapePlugin1.StartPoint = shapeNew.StartPoint;
                shapePlugin1.EndPoint = shapeNew.EndPoint;
                startPoint = shapeNew.StartPoint;
                endPoint = shapeNew.EndPoint;
                isDrawnPlugin = true;
                pictureBox.Refresh();
                isDrawnPlugin = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox.Text != "")
            {
                if (index < listOfShapes.Count)
                {
                    listOfShapes.RemoveAt(index);
                }
                else {
                    listOfPlugins.RemoveAt(index - listOfShapes.Count);
                }
                pictureBox.Refresh();
                comboBox.Text = "";
                changeComboBox();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox.Text != "")
            {
                if (index < listOfShapes.Count)
                {
                    Shape shapeNew = listOfShapes[index];
                    listOfShapes.RemoveAt(index);
                    Shape shape2 = shapeNew.Clone();
                    shape2.color = color;
                    shape2.penWidth = penWidth;
                    listOfShapes.Insert(index, shape2);
                }
                else
                {
                    ShapePlugin shapeNew = listOfPlugins[index - listOfShapes.Count];
                    listOfPlugins.RemoveAt(index - listOfShapes.Count);
                    ShapePlugin shape2 = (ShapePlugin)Activator.CreateInstance(shapeNew.GetType(), color, penWidth);
                    shape2.StartPoint = shapeNew.StartPoint;
                    shape2.EndPoint = shapeNew.EndPoint;
                    listOfPlugins.Insert(index, shape2);
                }
                pictureBox.Refresh();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog1.Color;
                color = colorDialog1.Color;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            penWidth = (float)numericUpDown1.Value;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape shape in listOfShapes)
            {
                shape.Draw(e.Graphics);
            }
            foreach (ShapePlugin shapePlugin1 in listOfPlugins)
            {
                shapePlugin1.Draw(e.Graphics);
            }
            if ((shape != null) && isDrawn)
            {
                shape.StartPoint = startPoint;
                shape.EndPoint = endPoint;
                shape.Draw(e.Graphics);
            }
            if ((shapePlugin1 != null) && isDrawnPlugin)
            {
                shapePlugin1.StartPoint = startPoint;
                shapePlugin1.EndPoint = endPoint;
                shapePlugin1.Draw(e.Graphics);
            }
        }


        private void cleanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = bitmap;

            listOfShapes.Clear();
        }

        private void плагиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapePluginsUpload();
            ButtonsInitialize();
        }

        private void ShapePluginsUpload()
        {
            string pluginPath = Directory.GetCurrentDirectory();

            plugins.Clear();

            DirectoryInfo pluginDirectory = new DirectoryInfo(pluginPath);
            if (!pluginDirectory.Exists)
                pluginDirectory.Create();
     
            var pluginFiles = Directory.GetFiles(pluginPath, "*.dll");
            foreach (var file in pluginFiles)
            {
                Assembly asm = Assembly.LoadFrom(file);
                var types = asm.GetTypes();
                foreach (var type in types)
                {
                    if (type.IsAbstract == false)
                    {
                        plugins.Add(type);
                    }
                }
            }
        }

        private void ButtonsInitialize()
        {
            pnlShapes.Controls.Clear();
            int X = 0;
            int Y = 10;
            int z = 0;
            foreach (Type shapePlugin in plugins)
            {
                Button button = new Button
                {
                    Name = shapePlugin.Name,
                    Tag = z,
                    Text = shapePlugin.Name,
                    Location = new Point(X, Y),
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                    Size = new Size(60, 45)

                };
                button.Click += ShapeButton_Click;
                Y += 45;
                z++;
                pnlShapes.Controls.Add(button);
            }
        }
        private void ShapeButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            object[] args;
            args = new object[2] { color, penWidth };
            object newShape = Activator.CreateInstance(plugins[int.Parse(button.Tag.ToString())], args);
            shapePlugin1 = (ShapePlugin)newShape;
            isPlugin = true;
        }

        private void SaveHash(FileStream fs)
        {
            fs.Position = 32;
            byte[] buffer = new byte[fs.Length - 32];
            fs.Read(buffer, 0, buffer.Length);
            using (SHA256 sha = SHA256.Create())
            {
                byte[] hashValue = sha.ComputeHash(buffer);
                fs.Position = 0;
                fs.Write(hashValue, 0, hashValue.Length);
            }
        }

        private bool CheckHash(FileStream fs)
        {
            byte[] hash = new byte[32];
            byte[] hashValue = new byte[32];
            fs.Read(hashValue, 0, 32);
            using (MemoryStream ms = new MemoryStream())
            {
                fs.CopyTo(ms);
                using (SHA256 sha = SHA256.Create())
                {
                    hash = sha.ComputeHash(ms.GetBuffer());
                }
            }
            for (int i = 0; i < hashValue.Length; i++)
            {
                if (hashValue[i] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }

        private void SavePluginsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("shapePlugins.dat", FileMode.Create))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    fs.Position = 32;
                    formatter.Serialize(fs, listOfShapes);
                    SaveHash(fs);
                }
            }
        }

        private void SaveClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("shape.dat", FileMode.Create))
            {
                fs.Position = 32;
                formatter.Serialize(fs, listOfShapes);
                SaveHash(fs);
            }
        }

        private void OpenPluginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("shapePlugins.dat", FileMode.OpenOrCreate))
            {
                    if (CheckHash(fs))
                    {
                        fs.Position = 32;
                        listOfPlugins.AddRange((List<ShapePlugin>)formatter.Deserialize(fs));
                    }
                    else
                    {
                        MessageBox.Show("Данный файл поврежден");
                    }
                
            }
            pictureBox.Refresh();
            changeComboBox();
        }

        private void OpenClassToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("shape.dat", FileMode.OpenOrCreate))
            {
                    if (CheckHash(fs))
                    {
                        fs.Position = 32;
                        listOfShapes.AddRange((List<Shape>)formatter.Deserialize(fs));
                    }
                    else
                    {
                        MessageBox.Show("Данный файл поврежден");
                    }
            }
            pictureBox.Refresh();
            changeComboBox();
        }

        private void button_Star_Click(object sender, EventArgs e)
        {
            FactoryShape shapeFactory = new FactoryShape();
            shape = shapeFactory.GetShape(button_Star.Text, color, penWidth);
            isPlugin = false;
        }

    }
}

