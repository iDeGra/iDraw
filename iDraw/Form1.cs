using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iDraw {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            
            cell = new PaintField(square);
            
            //int squareSize = Math.Min(drawPanel.Size.Width, drawPanel.Size.Height);
            //square = new Rectangle(new Point(drawPanel.Location.X + (drawPanel.Size.Width - squareSize) / 2 + offset, drawPanel.Location.Y + offset),
              //                     new Size(squareSize - 2 * offset, squareSize - 2 * offset));
            
            this.SizeChanged += this.OnSizeChanged;
            this.drawPanel.MouseClick += this.OnMouseClick;
            this.drawPanel.MouseWheel += this.OnMouseWheel;
        }
        

        protected virtual void OnMouseWheel(object sender, MouseEventArgs e) {
            if(!square.Contains(e.Location)) 
                return;
            if (cell.child == null) {
                if (cell.backColor == color)
                    return;
                cell.backColor = color;
            }
            else {
                int X = (e.X - drawPanel.Location.X - cell.square.X) / cell.child[0, 0].square.Size.Width;
                int Y = (e.Y - drawPanel.Location.Y - cell.square.Y) / cell.child[0, 0].square.Size.Height;
                int cuts = cell.child.GetLength(0);
                if (X >= 0 && Y >= 0 && X < cuts && Y < cuts) {
                    if (cell.child[Y, X].backColor == color)
                        return;
                    cell.child[Y, X].backColor = color;
                }
            }
            this.Refresh();
        }
        protected virtual void OnMouseClick(object sender, MouseEventArgs e) {
            if (!square.Contains(e.Location))
                return;
            if (e.Button == MouseButtons.Right) {
                if (cell.parent == null)
                    return;
                cell = cell.parent;
            }
            else {
                if (cell.child == null) {
                    cell.Cut(2);
                }
                else {
                    int X = (e.X - drawPanel.Location.X - cell.square.X) / cell.child[0, 0].square.Size.Width;
                    int Y = (e.Y - drawPanel.Location.Y - cell.square.Y) / cell.child[0, 0].square.Size.Height;
                    double cuts = cell.child.GetLength(0);
                    if (X >= 0 && Y >= 0 && X < cuts && Y < cuts) {
                        cell = cell.child[Y, X];
                    }
                }
            }
            this.Refresh();
        }
        protected virtual void OnSizeChanged(object sender, EventArgs e) {
            int squareSize = Math.Min(drawPanel.Size.Width, drawPanel.Size.Height);
            square = new Rectangle(new Point(drawPanel.Location.X + (drawPanel.Size.Width - squareSize) / 2 + offset, drawPanel.Location.Y + offset),
                                   new Size(squareSize - 2*offset, squareSize - 2*offset));
            this.Refresh();
        }


        private int offset = 50;
        private iCell cell;
        private Rectangle square;
        private SolidBrush color = new SolidBrush(Color.Red);


        private void Form1_Load(object sender, EventArgs e) {
            OnSizeChanged(sender, e);
        }
        private void drawPanel_Paint(object sender, PaintEventArgs e) {
            cell.Resize(square, 2);
            cell.Draw(e);
        }
        private void Color_Click(Button button) {
            color = new SolidBrush(button.BackColor);
        }
        private void RedColorButton_Click(object sender, EventArgs e) {
            Color_Click(RedColorButton);
        }
        private void GreenColorButton_Click(object sender, EventArgs e) {
            Color_Click(GreenColorButton);
        }
        private void BlueColorButton_Click(object sender, EventArgs e) {
            Color_Click(BlueColorButton);
        }
        
    }
}
