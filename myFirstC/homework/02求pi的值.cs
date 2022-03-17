// using System;
// namespace homework
// {
//     class qiupi
//     {
//         static void Main()
//         {
//             qiupi qiu = new qiupi();
//             double result = qiu.getPi(200);
//             Console.WriteLine(result);
//             Console.WriteLine("获得结果");
//         }
//         public double getPi(int n)
//         {
//             double sum = 1;
//             for (double i = 1; i <= n; i++)
//             {
//                 sum += ((1 / (4 * n - 3)) - (1 / (4 * n - 1)));
//             }
//             return sum * 4;
//         }
//     }
// }