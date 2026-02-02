// using System;


// class Program
// {
//     static void Main(string[] args)
//     {
//         Dictionary<int, int> dic = new Dictionary<int, int>()
//         {
//             { 1, 20000 },
//             { 4, 40000 },
//             { 5, 15000 }
//         };

//         List<int> ids = new List<int> { 1, 4, 5 };

//         var sum = ids.Where(x=>dic.ContainsKey(x)).Sum(a=>dic[a]);
//         Console.WriteLine(sum);

//     }
// }