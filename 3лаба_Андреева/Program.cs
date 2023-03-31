using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace _3лаба_Андреева
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }

        public static BigInteger Factorial(BigInteger num)
        {
            BigInteger result = new BigInteger(1);
            for (int i = 1; i <= num; i++)
                result *= i;
            return result;
        }

        //public static long Recursion(long num)
        //{
        //    if(num == 0)
        //    {
        //        return num;
        //    }
        //    else if (num < 0)
        //    {
        //        throw new Exception("Факториал отрицательный!");
        //    }
        //    return Recursion(num - 1) * num;
        //}
    }
}
