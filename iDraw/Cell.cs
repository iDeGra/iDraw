using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace iDraw {
    abstract class iCell {
        
        public iCell(Rectangle square) {
            this.backColor = new SolidBrush(Color.White);
            this.frame = new Pen(Color.Black, 2);
            this.square = square;
        }
        public iCell(iCell parent, Point point) {
            this.backColor = parent.backColor;
            this.frame = parent.frame;
            int squareSize = parent.square.Width / parent.child.GetLength(1);
            this.square = new Rectangle(point, new Size(squareSize, squareSize));
            this.parent = parent; 
        }

        public void Cut(int cuts) {
            if (child != null) {
                return;
            }
            this.child = new Cell[cuts, cuts];
            for (int i = 0; i < cuts; ++i) {
                for (int j = 0; j < cuts; ++j) {
                    Point p = new Point(square.Left + square.Width * j / cuts, square.Top + square.Height * i / cuts);
                    this.child[i, j] = new Cell(this, p);
                }
            }
        }
        public void Draw(PaintEventArgs e) {
            if (child == null) {
                if (frame.Width != 0) {
                    e.Graphics.DrawRectangle(frame, square);
                }
                e.Graphics.FillRectangle(backColor, square);
            }
            else {
                int cuts = child.GetLength(1);
                double size = this.square.Width / cuts;
                for (int i = 0; i < cuts; ++i) {
                    for (int j = 0; j < cuts; ++j) {
                        child[i, j].Draw(e);
                    }
                }
            }
        }
        public void Resize(Rectangle square, int frameSize) {
            this.frame.Width = frameSize;
            this.square = square;
            if (child != null) {
                int cuts = child.GetLength(0);
                for (int i = 0; i < cuts; ++i) {
                    for (int j = 0; j < cuts; ++j) {
                        Rectangle tmpSquare = new Rectangle(square.Location.X + square.Width * j / cuts,
                                                       square.Location.Y + square.Width * i / cuts,
                                                       square.Width / cuts, square.Width / cuts);
                        child[i, j].Resize(tmpSquare, frameSize);
                    }
                }
            }
        }

        public SolidBrush backColor;
        protected Pen frame; // Color and size
        public Rectangle square;
        public iCell parent;
        public iCell[,] child;

    }
    class Cell : iCell {
        public Cell(iCell parent, Point point)
            : base(parent, point) {
        }
    }
    class PaintField : iCell {
        public PaintField(Rectangle square) : base(square) {
        }
    }
    
    
}
