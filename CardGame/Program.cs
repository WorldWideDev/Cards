using System;
using System.Collections.Generic;
using CardGame.Models;
using CardGame.Views;
using CardGame.Views.Utilities;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = BoxRenderer.BuildGrid(8, "Mom");
            BoxRenderer.RenderBox(grid);
        }
    }
}
