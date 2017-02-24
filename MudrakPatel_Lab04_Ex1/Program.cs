using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudrakPatel_Lab04_Ex1
{
    class Program
    {
        private static int[] intElements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        private static Stack intStack; // stack stores ints
        static void Main(string[] args)
        {
            intStack = new Stack(10); // Initialize a new Stack with a size of 10 elements
            TestPushInt(); // Push each element of intElements[] in the intStack
            TestPeek(); // Test the Peek method of the custom Stack class
            TestPopInt(); // Pop the elements from the intStack
        }

        // test Push method with intStack
        private static void TestPushInt()
        {
            // push elements onto stack
            try
            {
                Console.WriteLine("\nPushing elements onto intStack");

                // push elements onto stack
                foreach (var element in intElements)
                {
                    Console.Write($"{element} ");
                    intStack.Push(element); // push onto intStack
                }
            }
            catch (CustomStackOverFlowException exception)
            {
                Console.WriteLine($"\nMessage: {exception.Message}");
                Console.WriteLine("\nPopping out an element to create space in the stack...");
                var poppedElement = intStack.Pop();
                Console.WriteLine("\nElement popped: {0,3}", poppedElement);
            }
        }

        // test Pop method with intStack
        private static void TestPopInt()
        {
            // pop elements from stack
            try
            {
                Console.WriteLine("\nPopping elements from intStack");

                int popValue; // stores element removed from stack

                // remove all elements from stack
                while (true)
                {
                    popValue = intStack.Pop(); // pop from intStack
                    Console.WriteLine("\nPopped element using Pop method: " + popValue);
                }
            }
            catch (CustomStackUnderFlowException exception)
            {
                Console.WriteLine("\nException message: " + exception.Message);
                Console.WriteLine("\nAdding an element to handle an underflow exception....");
                Random randomGenerator = new Random();
                var pushedElement = randomGenerator.Next(5, 20);
                intStack.Push(pushedElement);
                Console.WriteLine("\nNew element {0,3} pushed in the stack.", pushedElement);
            }
        }

        public static void TestPeek()
        {
            try {
                Console.WriteLine("Peeking the first element from the Stack\n-----------------------------------------------------");
                var peekedElement = Stack.Peek(intStack);
                Console.WriteLine("\nPeeked element: " + peekedElement);
            }
            catch(CustomStackOverFlowException exception) {
                Console.WriteLine("\n", exception.Message);
            } catch (CustomStackUnderFlowException exception) {
                Console.WriteLine("\n", exception.Message);
            }
        }
    }
}
