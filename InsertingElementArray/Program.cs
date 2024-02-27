namespace InsertingElementArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int newElement = int.Parse(Console.ReadLine());
            list.Sort();
            for (int i = 1; i <= list.Count - 1; i++)
            {
                if (newElement < list[i + 1] && newElement > list[i - 1])
                {
                    list.Insert(i + 1, newElement);
                    break;
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
