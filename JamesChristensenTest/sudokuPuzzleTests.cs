using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace JamesChristensenTest
{
    class SudokuPuzzleTests
    {
     

        public static void SolveTest()
        {
            //loop through the test files
            for (int x = 1; x < 6; x++ )
            {
                var stream = new StreamReader("puzzle" + x.ToString() + ".txt");
                var puzzles = new List<String>();
                while (!stream.EndOfStream)
                    puzzles.Add(stream.ReadLine());
                stream.Close();
                string fileName = "puzzle" + x.ToString() + "solution.txt";
                
                var times = puzzles.Select(p =>
                {
                    DateTime start = DateTime.Now;
                    var puz = new SudokuPuzzle(p).Solve();
                    SudokuPuzzle.Output(puz, fileName);
                    return (DateTime.Now - start);
                }).ToList();
            }
        }

     
    }
}
