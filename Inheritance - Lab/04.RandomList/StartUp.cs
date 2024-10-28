using CustomRandomList;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main()
        {
            RandomList randomList = new RandomList();
            randomList.Add("apple");
            randomList.Add("banana");
            randomList.Add("cherry");
            randomList.Add("date");

            Console.WriteLine("Randomly selected element: " + randomList.RandomString());
            Console.WriteLine("Remaining elements in list:");
            foreach (string item in randomList)
            {
                Console.WriteLine(item);
            }
        }
    }
}