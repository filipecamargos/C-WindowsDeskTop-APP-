using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskWindownsFilipe
{
    enum SurfaceMaterial
    {
        Pine,
        Laminate,
        Veneer,
        Oak,
        Rosewood
    }

    /// <summary>
    /// This class provide the ability to create a desk object
    /// that will be used for the quote in the program
    /// </summary>
    class Desk
    {
        const decimal MAX_DEPTH = 48;
        const decimal MIN_DEPTH = 12;

        const decimal MAX_WIDTH = 96;
        const decimal MIN_WIDTH = 24;

        private decimal width = MIN_WIDTH;
        private decimal depth = MIN_DEPTH;
        private decimal surfaceArea = MIN_WIDTH * MIN_DEPTH;
        private int numberOfDrawers;
        private SurfaceMaterial surfaceMaterial;

        public decimal Width
        {
            get { return width; }
            set
            {
                // set width within constraints 
                if (value < MIN_WIDTH)
                    width = MIN_WIDTH;                              
               
                else if (value > MAX_WIDTH)                
                    width = MAX_WIDTH;                                          
                
                else               
                    width = value;                
                
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
                    depth = MIN_DEPTH;

                else if (value > MAX_DEPTH)                
                    depth = MAX_DEPTH;
                
                else
                    depth = value;

                // update surfaceArea every time width is set
                surfaceArea = width * depth;
            }
        }

        public decimal SurfaceArea
        {
            get { return surfaceArea; }
            set { }
        }

        public int NumberOfDrawers { get; set; }
        
        public SurfaceMaterial SurfaceMaterial
        {
            get { return surfaceMaterial; }
            set { surfaceMaterial = value; }

        }

        public Desk(decimal width = 24,
                    decimal depth = 12,
                    int numberOfDrawers = 0,
                    SurfaceMaterial surfaceMaterial = SurfaceMaterial.Pine)
        {
            this.width = width;
            this.depth = depth;
            this.numberOfDrawers = numberOfDrawers;
            this.surfaceMaterial = surfaceMaterial;
        }
    }
}
