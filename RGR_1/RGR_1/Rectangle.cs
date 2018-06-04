using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_1
{
    class Rectangle
    {
        
        Double x;
        Double y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Rectangle()
        {
            this.x = 0;
            this.y = 0;
        }

        public bool EnterX(string x)
        {
            bool result = false;
            try
            {
                result = ((this.x = Convert.ToDouble(x)) > 0 ? true : false);
            }
            catch (Exception)
            { }

            return result;
        }

        public bool EnterY(string y)
        {
            bool result = false;
            try
            {
                result = ((this.y = Convert.ToDouble(y)) > 0 ? true : false);
            }
            catch (Exception)
            { }

            return result;
        }

        public double CalculatePerimetr()
        {
            return (this.x + this.y) * 2;
        }

    }
}

