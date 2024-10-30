using System.Security.Cryptography;

namespace _08.CollectionHierarchy
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] elementsToAdd = Console.ReadLine().Split();
            int removeOperations = int.Parse(Console.ReadLine());
            ICollection addCollection = new AddCollection();
            IAddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            IMyList myList = new MyList();
            List<int> addResultsAddCollection = new List<int>();
            List<int> addResultsAddRemoveCollection = new List<int>();
            List<int> addResultsMyList = new List<int>();
            foreach (string element in elementsToAdd)
            {
                addResultsAddCollection.Add(addCollection.Add(element));
                addResultsAddRemoveCollection.Add(addRemoveCollection.Add(element));
                addResultsMyList.Add(myList.Add(element));
            }
            List<string> removeResultsAddRemoveCollection = new List<string>();
            List<string> removeResultsMyList = new List<string>();
            for (int i = 0; i < removeOperations; i++)
            {
                removeResultsAddRemoveCollection.Add(addRemoveCollection.Remove());
                removeResultsMyList.Add(myList.Remove());
            }
            Console.WriteLine(string.Join(" ", addResultsAddCollection));
            Console.WriteLine(string.Join(" ", addResultsAddRemoveCollection));
            Console.WriteLine(string.Join(" ", addResultsMyList));
            Console.WriteLine(string.Join(" ", removeResultsAddRemoveCollection));
            Console.WriteLine(string.Join(" ", removeResultsMyList));
        }
    }
}