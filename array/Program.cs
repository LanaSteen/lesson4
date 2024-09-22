namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region array
            //int[] num = new int[3];  // = [0,0,0]
            //num = [10, 20, 30];
            //num[0] = 30;




            //int[] numbers2 = { 10, 20, 30 };

            //Console.WriteLine();


            //string name = default;



            //int[] numebrs = [20, 60, 30];
            //for (int i =0; i<numebrs.Length; i++)
            //{
            //    Console.WriteLine(numebrs[i]);
            //}



            //foreach (int el in numebrs)
            //{
            //    Console.WriteLine(el);
            //}
            #endregion array

            #region random


            //Random random = new Random();
            //Console.WriteLine(random.Next(0,100));
            //Console.WriteLine(random.NextDouble());
            //Console.WriteLine(random.NextSingle());


            //Random random = new Random();
            //char c = Convert.ToChar(random.Next(33, 127));
            //Console.WriteLine(c);
            //int[] numArr = new int [5];
            //for (int i =0; i<numArr.Length; i++)
            //{
            //    numArr[i] = random.Next(0,100);

            //}

            //foreach (int el in numArr)
            //{
            //    Console.WriteLine(el);
            //}


            #endregion random


            #region classWork




            //   •	შემთხვევითი რიცხვებით შევსებულ მასივში მოძებნეთ დადებითი რიცხვების რაოდენობა.
            //Random random = new Random();
            //int[] numArr = new int[10];
            //for (int i = 0; i < numArr.Length; i++)
            //{
            //    numArr[i] = random.Next(-100, 100);

            //}
            //for (int i = 0; i < numArr.Length; i++)
            //{
            //    Console.Write($"{numArr[i]}, ");
            //}
            //Console.WriteLine();
            //foreach (int el in numArr)
            //{
            //    if (el > 0)
            //    {
            //        Console.Write(el);
            //    }
            //}




            //•	შეამოწმეთ შემთხვევითი რიცხვებით შევსებული მასივი შეიცავს თუ არა ისეთ 7 - ის ჯერად რიცხვს რომელიც მეტია 14 - ზე.


            //Random random = new Random();
            //int[] numArr = new int[10];
            //for (int i = 0; i < numArr.Length; i++)
            //{
            //    numArr[i] = random.Next(49, 51);

            //}
            //for (int i = 0; i < numArr.Length; i++)
            //{
            //    Console.Write($"{numArr[i]}, ");
            //}
            //Console.WriteLine();
            //foreach (int el in numArr)
            //{
            //    if (el % 7 == 0 && el > 14)
            //    {
            //        Console.Write($"{el}, ");
            //    }
            //}



            //-----------------------------
            //•	მოცემულია მასივი სადაც ჩაწერილია მომხმარებლების სახელები მაგალითად: [„ნიკა“,“გიორგი“,“ელენე“,“დავითი“] ამოიკითხეთ მასივიდან n რაოდენობის მონაცემები და დაბეჭდეთ კონსოლში შებრუნებული თანმიმდევრობით. n არის ნებისმიერი მთელი რიცხვი რომელიც არ აღემატება მასივის ზომას.

            //string[] names = ["Daviti", "Nika", "Elene", "Giorgi"];
            //Console.WriteLine($"Write number from 0 to {names.Length}");
            //string userNum = Console.ReadLine();
            //int.TryParse(userNum, out int userNumber);
            //try
            //{
            //    for (int i = userNumber - 1; i >= 0; i--)
            //    {
            //        Console.WriteLine(names[i]);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //----------------------
            #endregion classWork


            #region  2DArray
            int[] firstCollction = [10, 60, 30,];
            int[][] secondCollectoin = new int[2][];


            secondCollectoin[0] = [10, 60,  30,];
            secondCollectoin[1] = [3,  20,  9];


            //int sum = secondCollectoin[0][0] + secondCollectoin[1][secondCollectoin[1].Length - 1];
            //Console.WriteLine(sum);



            for (int i =0; i<secondCollectoin.Length; i++)
            {
                int maxInRow = 0;
                for (int j =0; j < secondCollectoin[i].Length; j++)
                {
                    if (secondCollectoin[i][j] > maxInRow)
                    {
                        maxInRow = secondCollectoin[i][j];
                    }
                   
                }
                Console.WriteLine(maxInRow);
            }

            #endregion  2DArray
        }
    }
}
