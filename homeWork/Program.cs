namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //დავალება 1
            //•	დაწერეთ პროგრამა რომელიც კონსოლში დაბეჭდავს მასივში შემავალი ყველა ლუწი ელემენტის ჯამს.

            //Console.WriteLine("Enter number...");
            //string userNum = Console.ReadLine();
            //int.TryParse(userNum, out int userNumber);


            //Random random = new Random();
            //int[] numArr = new int[userNumber];
            //for (int i = 0; i < numArr.Length; i++)
            //{
            //    numArr[i] = random.Next(0, 100);

            //}
            //for (int i = 0; i < numArr.Length; i++)
            //{
            //    Console.Write($"{numArr[i]}, ");
            //}
            //Console.WriteLine();
            //int sumOfEven = 0;
            //foreach (int el in numArr)
            //{
            //    if (el %2==0)
            //    {
            //        sumOfEven += el;
            //    }
            //}
            //Console.WriteLine($"Sum of even numbers is {sumOfEven}");

            //დავალება 2
            //•	დაწერეთ პროგრამა რომელიც ერთ მასივიდან მეორეში გადააკოპირებს ყველა ელემენტს (ჩათვალეთ რომ ორივე მასივის ზომა ერთი და იგივეა).
            //int[] firstArr = [20, 60, 30, 15];
            //int[] secondArr = new int[firstArr.Length];

            //for (int i =0; i<firstArr.Length; i++)
            //{
            //    secondArr[i] = firstArr[i];
            //}
            //foreach (int el in secondArr)
            //{
            //    Console.Write($"{el} ");
            //}


            //დავალება 3
            //•	დაწერეთ პროგრამა რომელიც კონსოლში დაბეჭდავს მხოლოდ მასივის უნიკალურ ელემენტებს ანუ ისეთ ელემენტებს რომლებიც არსებულ მასივში მხოლოდ ერთხელ გვხვდებიან.
            //int[] arr = [20, 60, 30, 15, 20, 60, 30, 40];

            //for (int i = 0; i < arr.Length; i++) {
            //    int count = 0;
            //    for (int j = 0; j<arr.Length; j++) 
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;

            //        }
            //    }
            //    if (count >=2)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}

            //დავალება 4
            //•	დაწერეთ პროგრამა რომელიც მასივში მოძებნის მაქსიმალურ ელემენტს.

            //int[] arr = [20, 200, 30, 15, 20, -10, 30, 100];
            //int max = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //}
            //Console.WriteLine(max);


            //დავალება 5
            //•	დაწერეთ პროგრამა რომელიც მასივში მოძებნის მაქსიმალური ელემენტის ინდექსს.
            //int[] arr = [20, 200, 30, 1500, 20, -10, 30, 100];
            //int maxElIndex = 0;
            //int max = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //        maxElIndex = i;
            //    }
            //}
            //Console.WriteLine(maxElIndex);



            //დავალება 6
            //•	დაალაგეთ მოცემული მასივი ზრდადობის მიხედვით. (არ გამოიყენოთ C#-ში არსებული მზა ფუნქციები მაგალითად OrderBy ან რაიმე მსგავსი სრული ფუნქციონალი დაწერეთ ხელით)

            int[] arr = [20, 200, 30, 1500, 20, -10, 30, 100];

            foreach (int element in arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }

               
            }
            foreach (int el in arr)
            {
                Console.Write($"{el} ");
            }

        }
    }
}


