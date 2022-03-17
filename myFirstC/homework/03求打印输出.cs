// using System;
// namespace homework{
//     class printout{
//         static void Main(){
//             printout n = new printout();
//             int row,col;
//             Console.WriteLine("请输入行数");
//             row = Convert.ToInt16(Console.ReadLine());
//             Console.Write("请输入列数");
//             col = Convert.ToInt16(Console.ReadLine());
//             n.print(row,col);

//         }
//         public void print(int row ,int col){
//             int ternval = 8;
//             for (int i = 1; i <= row; i++)
//             {
//                 int temp = i;
//                 int temp1 = ternval;
//                 ternval -= 2;
//                 for (int j =1 ; j <= col; j++)
//                 {
//                     while(temp!=1){
//                         Console.Write(" ");
//                         temp -= 1;
//                     }
//                     Console.Write("*");
//                 }
//                 for (int k =1 ; k <= col; k++)
//                 {
//                     while(temp1!=1){
//                         Console.Write(" ");
//                         temp1 -= 1;
//                     }
//                     Console.Write("*");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }