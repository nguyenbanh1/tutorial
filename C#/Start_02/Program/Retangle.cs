using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Program
{
    class Retangle : Shape
    {

        private int code;
        
        
        public Retangle(int height, int width) : base(height,width)
        {
 
        }
        public Retangle(int height, int width, int code) : base(height, width)
        {
            this.code = code;
        }

        public override int GetArea()
        {
            return this.Width * this.Height;
        }

        public override string ToString()
        {
            return String.Format("Retangle({0},{1},{2})", this.Width, this.Height,this.code);
        }

        public int getCostByArea()
        {
            return GetArea() * 500;
        }
    }
}
