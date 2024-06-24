class Program
{
    static int LinearSearch(List<int>list,int num)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if(list[i]==num)
                return i;
        }
        return -1;
    }
    static void Main()
    {
        int num;
        string input;
        List<int> list = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13
        };
        foreach (int i in list)
        {
            Console.WriteLine($"These are your number in the list{i}");
        }
        do 
        {
            Console.WriteLine("Enter the number you would like to search");
            num = int.Parse(Console.ReadLine());
            int index = LinearSearch(list,num);
            if (index != -1)
            { Console.WriteLine($"The number you were seraching for {num} were found at index {index}"); }
            else
            { Console.WriteLine($"We did not find your number {num}"); }
            Console.WriteLine("Press any key to search new number");
            Console.WriteLine("Type exit to exit out of Program");
            input = Console.ReadLine();
        } while (input != "exit");
    }
}