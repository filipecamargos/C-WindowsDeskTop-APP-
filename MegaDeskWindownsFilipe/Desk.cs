using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskWindownsFilipe
{   
    public enum SurfaceMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    /// <summary>
    /// This class provide the ability to create a desk object
    /// that will be used for the quote in the program
    /// </summary>
    public class Desk
    {
        const decimal MAX_DEPTH = 48;
        const decimal MIN_DEPTH = 12;

        const decimal MAX_WIDTH = 96;
        const decimal MIN_WIDTH = 24;

        public decimal Width { get; set; } 

        public decimal Depth { get; set; } 

        public int NumberOfDrawers { get; set; }
        
        public SurfaceMaterial SurfaceMaterial { get; set; }

        public decimal DeskArea()
        {   
            //TO DO : IF the mesures are out of range an exeception will be sent
            return this.Width * this.Depth;
        }
    }
}
