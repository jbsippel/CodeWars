using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuValidator
{
    class Program
    {
        static void Main(string[] args)
        {
			int[,] solution = new int[9, 9]
			{
			{5, 3, 4, 6, 7, 8, 9, 1, 2},
			{6, 7, 2, 1, 9, 5, 3, 4, 8},
			{1, 9, 8, 3, 4, 2, 5, 6, 7},
			{8, 5, 9, 7, 6, 1, 4, 2, 3},
			{4, 2, 6, 8, 5, 3, 7, 9, 1},
			{7, 1, 3, 9, 2, 4, 8, 5, 6},
			{9, 6, 1, 5, 3, 7, 2, 8, 4},
			{2, 8, 7, 4, 1, 9, 6, 3, 5},
			{3, 4, 5, 2, 8, 6, 1, 7, 9}
			};
			Console.WriteLine(ValidSolution(solution));
			Console.ReadLine();
		}

		public static bool ValidSolution(int[,] solution)
		{
			int[] test = new int[9];
			//first check all rows
			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 9; j++)
				{
					test[j] = solution[i, j];
				}
				if (!ValidArray(test))
					return false;
			}

			//then check all columns
			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 9; j++)
				{
					test[j] = solution[j, i];
				}
				if (!ValidArray(test))
					return false;
			}

			//then check all sub-grids
			if (!ValidArray(ReturnGrid(solution, 0, 0, 2, 2)))
				return false;

			if (!ValidArray(ReturnGrid(solution, 0, 3, 2, 5)))
				return false;

			if (!ValidArray(ReturnGrid(solution, 0, 6, 2, 8)))
				return false;


			if (!ValidArray(ReturnGrid(solution, 3, 0, 5, 2)))
				return false;

			if (!ValidArray(ReturnGrid(solution, 3, 3, 5, 5)))
				return false;

			if (!ValidArray(ReturnGrid(solution, 3, 6, 5, 8)))
				return false;


			if (!ValidArray(ReturnGrid(solution, 6, 0, 8, 2)))
				return false;

			if (!ValidArray(ReturnGrid(solution, 6, 3, 8, 5)))
				return false;

			if (!ValidArray(ReturnGrid(solution, 6, 6, 8, 8)))
				return false;

			return true;
		}

		public static bool ValidArray(int[] arr)
		{
			int[] helper = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			int i = 0;
			foreach (var n in arr.OrderBy(c => c))
			{
				if (n != helper[i++])
					return false;
			}
			return true;

		}

		public static int[] ReturnGrid(int[,] solution, int istart, int jstart, int iend, int jend)
		{
			int[] test = new int[9];
			int k = 0;
			for (int i = istart; i <= iend; i++)
			{
				for (int j = jstart; j <= jend; j++)
				{
					test[k] = solution[i, j];
					k++;
				}
			}
			return test;
		}

	}
}
