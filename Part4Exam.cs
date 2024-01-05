using System;
using System.Collections.Generic;
using System.Linq;

public class Part4Exam
{
    // Interface
    public interface IAnimal
    {
        void Speak();
    }

    // Class implementing the interface
    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Woof!");
        }
    }

    // Define a delegate
    public delegate void Notify();

    // Method that matches the delegate
    public class Process
    {
        public void ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }
    }

    // Events
    public class Button
    {
        // Declare an event
        public event EventHandler Clicked;

        // Method to raise the event
        public void Click()
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }

    public class EventHandlerClass
    {
        public void OnClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Button was clicked!");
        }
    }

    // Method to execute the actions
    public void Execute()
    {
        // Using the delegate
        Notify handler = new Process().ProcessCompleted;
        handler();

        // Subscribing to the event
        Button button = new Button();
        EventHandlerClass eventHandler = new EventHandlerClass();
        button.Clicked += eventHandler.OnClicked;
        button.Click();

        // Lambdas
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int evenCount = numbers.Count(n => n % 2 == 0);
        Console.WriteLine($"There are {evenCount} even numbers in the list.");
    }
}
