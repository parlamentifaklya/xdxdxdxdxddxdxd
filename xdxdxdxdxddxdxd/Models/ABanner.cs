using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xdxdxdxdxddxdxd.Models
{
    public abstract class ABanner
    {
        private const int MAX_ROWNUM = 700;
        private const int MAX_COLNUM = 1000;
        private const int MIN_ROWNUM = 30;
        private const int MIN_COLNUM = 20;

        private Color[,] pixel;

        protected ABanner(int rowNum, int colNum)
        {
            if (rowNum < MIN_COLNUM || rowNum > MAX_ROWNUM || colNum < MIN_COLNUM || colNum > MAX_COLNUM)
            {
                throw new ArgumentException("Anyad!");
            }
            pixel[rowNum, colNum] = new();
        }

        protected ABanner() : this(MIN_ROWNUM, MIN_COLNUM) { }

        public int RowNum => pixel.GetLength(0);
        public int ColNum => pixel.GetLength(1);

        public Color this[int rowIndex, int colIndex]
        {
            get 
            {
                if (rowIndex < MIN_COLNUM || rowIndex > MAX_ROWNUM || colIndex < MIN_COLNUM || colIndex > MAX_COLNUM)
                {
                    throw new ArgumentException("Anyad!");
                }
                return pixel[rowIndex, colIndex];
            }
            set { }
        }

        protected void UpdatePixels(Color[,] newPixels)
        {
            if (newPixels.GetLength(0) != RowNum || newPixels.GetLength(1) != ColNum)
            {
                throw new ArgumentException("New pixel array dimensions must match the current dimensions.");
            }

            pixel = newPixels;
        }
    }
}
