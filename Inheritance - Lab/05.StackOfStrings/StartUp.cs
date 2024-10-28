namespace CustomStack
{
    public class StartUp
    {
        static void Main()
        {
            StackOfStrings stack = new StackOfStrings();
            Console.WriteLine("Is stack empty? " + stack.IsEmpty()); 

            stack.Push("first");
            stack.Push("second");
            Console.WriteLine("Is stack empty? " + stack.IsEmpty()); 

            stack.AddRange(new List<string> { "third", "fourth", "fifth" });
            Console.WriteLine("Stack contents:");
            foreach (var item in stack)
            {
                Console.WriteLine(item); 
            }
        }
    }
}