using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Shape
    {
        private int height;
        private int width;

        public Shape(int height, int width)
        {
            this.width = width;
            this.height = height;
        }


        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }

        public void setShape(int height, int width)
        {
            this.height = height;
            this.width = width;
        }
        public virtual int GetArea() {
            return 0;
        }
        public override string ToString()
        {
            return String.Format("Shape({0},{1})", this.width, this.height);
        }

    }
}
