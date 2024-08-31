using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    /// <summary>
    /// Класс круга
    /// </summary>
    public class Disc : IHaveArea
    {
        private double radius;
        public Disc(double radius) 
        {
            this.radius = radius;
        }

        public double Area => Math.PI * radius * radius;
    }
}
