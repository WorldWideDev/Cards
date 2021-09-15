using System;
using System.Text;
namespace CardGame.Views
{
    public static class BoxRenderer
{
        // draws a square with "value" in the center ("#" for border)
        public static char[] ValueMap
        {
            get { return new char[3] { ' ', '#', 'x' };}
        }
        public static int[,] BuildGrid(int size, string value)
        {
            int width = size%2 == 0 ? size+1 : size;
            int length = size%2 == 0 ? size+1 : size;
            int[,] grid = new int[length,width];
            int currValue = 0;
            for(int x=0; x<width; x++)
            {
                for(int y=0; y<length; y++)
                {
                    // border
                    if(y == 0 || x == 0 || y == length-1 || x == width-1)
                    {
                        grid[y,x] = 1;
                    }
                    // center
                    else if(
                        currValue < value.Length &&
                        y == (length/2) && 
                        (x >= (width/2)-(value.Length/2) && x <= (width/2) + (value.Length/2))
                    )
                    {
                        // str.Append(value[currValue]);
                        grid[y,x] = value[currValue];
                        currValue++;
                    }
                }
            }
            return grid;

        }
        public static void RenderBox(int[,] grid)
        {
            int length = grid.GetLength(0);
            int width = grid.GetLength(1);
            for(int x=0; x<width; x++)
            {
                StringBuilder str = new StringBuilder();
                for(int y=0; y<length; y++)
                {
                    str.Append(ValueMap[grid[x,y]]);
                }
                Console.WriteLine(str.ToString());
            }

        }
        public static void RenderBox(int size, string value)
        {
            int width = size%2 == 0 ? size+1 : size;
            int length = size%2 == 0 ? size+1 : size;
            int currValue = 0;
            for(int y = 0; y < length; y++)
            {
                StringBuilder str = new StringBuilder();
                for(int x = 0; x < width; x++)
                {
                    // border
                    if(y == 0 || x == 0 || y == length-1 || x == width-1)
                    {
                        str.Append('#');
                    }
                    // center
                    else if(
                        currValue < value.Length &&
                        y == (length/2) && 
                        (x >= (width/2)-(value.Length/2) && x <= (width/2) + (value.Length/2))
                    )
                    {
                        str.Append(value[currValue]);
                        currValue++;
                    }
                    else
                    {
                        str.Append(' ');
                    }
                }
                Console.WriteLine(str);
            }
        }
    }
}
