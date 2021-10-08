using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_1
{
    //varfurile unui graf
    //urm linie lista ne muchii
    /// <summary>
    /// 1 2
    /// 2 3
    /// 2 4
    /// 3 5
    /// 0 1 0 0 0
    /// 1 0 1 1 0
    /// 0 1 0 0 1
    /// 0 1 0 0 0
    /// 0 0 1 0 0
    /// </summary>
    class Program
    {
        static int[,] matrix;
        static int varfuri;
        static void load(string fileName)
        {
            string line;
            char[] seps = { ' ', '\t', '\n' };
            using (StreamReader sr = new StreamReader(fileName))
            {
                string[] tokens;
                line = sr.ReadLine();
                varfuri = int.Parse(line);
                matrix = new int[varfuri, varfuri];
                while ((line = sr.ReadLine()) != null)
                {
                    tokens = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);
                    int i = int.Parse(tokens[0]);
                    int j = int.Parse(tokens[1]);
                    matrix[i - 1, j - 1] = 1;
                    matrix[j - 1, i - 1] = 1;
                }
            }
        }
        static void view(int[,] matrix)
        {
            for (int i = 0; i < varfuri; i++)
            {
                for (int j = 0; j < varfuri; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            load("TextFile1.txt");
            view(matrix);
        }
    }
}
