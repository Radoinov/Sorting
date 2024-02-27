namespace ComparingSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split().ToArray();
            string[] arr2 = Console.ReadLine().Split().ToArray();
            int smallerArray = Math.Min(arr1.Length, arr2.Length);
            for (int i = 0; i < smallerArray; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                    break;
                }
                if (i == smallerArray - 1)
                {
                    if (arr1.Length < arr2.Length)
                    {
                        Console.WriteLine((string.Join("", arr1)));
                        Console.WriteLine(string.Join("", arr2));
                    }
                    else if (arr1.Length > arr2.Length)
                    {
                        Console.WriteLine(string.Join("", arr2));
                        Console.WriteLine(string.Join("", arr1));
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", arr1));
                        Console.WriteLine(string.Join("", arr2));
                    }
                }
            }
        }
    }
}

