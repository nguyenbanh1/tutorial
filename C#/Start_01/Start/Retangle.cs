using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    public class Retangle
    {
        int height;
        int width;

        public Retangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public override string ToString()
        {
            return "Height : " + this.height + ", width : " + this.width;
        }


    }
}
