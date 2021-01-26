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

        private decimal width = MIN_WIDTH;
        private decimal depth = MIN_DEPTH;
        private decimal surfaceArea;

        public decimal Width
        {
            get { return width; }
            set
            {
                // set width within constraints 
                if (value < MIN_WIDTH)
                {
                    width = MIN_WIDTH;
                }
                else if (value > MAX_WIDTH)
                {
                    width = MAX_WIDTH;
                }             
                else
                {
                    width = value;
                }
                
                // update surfaceArea every time width is set
                surfaceArea = width * depth;
            }
        } 

        public decimal Depth
        {
            get { return depth; }
            set
            {
                // set depth within constraints 
                if (value < MIN_DEPTH)
                {
                    depth = MIN_DEPTH;
                }
                else if (value > MAX_DEPTH)
                {
                    depth = MAX_DEPTH;
                }
                else
                {
                    depth = value;
                }

                // update surfaceArea every time width is set
                surfaceArea = width * depth;
            }
        }

        public decimal SurfaceArea
        {
            get { return surfaceArea; }
            set
            {
                // might need something here
            }
        }

        public int NumberOfDrawers { get; set; }
        
        public SurfaceMaterial SurfaceMaterial { get; set; }
    }
}
