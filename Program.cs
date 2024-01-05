class Program
{
    static void Main(string[] args)
    {
        // Using the IAnimal interface and Dog class
        Part4Exam.IAnimal dog = new Part4Exam.Dog();
        dog.Speak(); // Outputs: Woof!

        // Using the delegate
        Part4Exam.Notify handler = new Part4Exam.Process().ProcessCompleted;
        handler(); // Outputs: Process Completed!

        // Using events
        Part4Exam.Button button = new Part4Exam.Button();
        Part4Exam.EventHandlerClass eventHandler = new Part4Exam.EventHandlerClass();
        button.Clicked += eventHandler.OnClicked;
        button.Click(); // Outputs: Button was clicked!

        // Using lambdas
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int evenCount = numbers.Count(n => n % 2 == 0);
        Console.WriteLine($"There are {evenCount} even numbers in the list."); // Outputs: There are 2 even numbers in the list.
    }
}