using System;
using System.Drawing;

namespace xdxdxdxdxddxdxd.Models
{
    internal class Banner : ABanner, IBannerOperations
    {
        public Banner(int rowNum, int colNum) : base(rowNum, colNum)
        {
            Clear();
        }

        public Banner() : base()
        {
            Clear();
        }

        public void Clear()
        {
            for (int y = 0; y < RowNum; y++)
            {
                for (int x = 0; x < ColNum; x++)
                {
                    this[y, x] = Color.Transparent;
                }
            }
        }

        public void RotateToLeft()
        {
            Color[,] newPixels = new Color[ColNum, RowNum];
            for (int y = 0; y < RowNum; y++)
            {
                for (int x = 0; x < ColNum; x++)
                {
                    newPixels[ColNum - x - 1, y] = this[y, x];
                }
            }
            UpdatePixels(newPixels);
        }

        public void RotateToRight()
        {
            Color[,] newPixels = new Color[ColNum, RowNum];
            for (int y = 0; y < RowNum; y++)
            {
                for (int x = 0; x < ColNum; x++)
                {
                    newPixels[x, RowNum - y - 1] = this[y, x];
                }
            }
            UpdatePixels(newPixels);
        }

        public void ShiftToLeft(Color fillColor)
        {
            for (int y = 0; y < RowNum; y++)
            {
                for (int x = 1; x < ColNum; x++)
                {
                    this[y, x - 1] = this[y, x];
                }
                this[y, ColNum - 1] = fillColor;
            }
        }

        public void ShiftToRight(Color fillColor)
        {
            for (int y = 0; y < RowNum; y++)
            {
                for (int x = ColNum - 2; x >= 0; x--)
                {
                    this[y, x + 1] = this[y, x];
                }
                this[y, 0] = fillColor;
            }
        }
    }
}