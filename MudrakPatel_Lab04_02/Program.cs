using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudrakPatel_Lab04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a LinkedList of Student objects and add initial students in it
            LinkedList<Student> studentLinkedList = new LinkedList<Student>();
            studentLinkedList.AddLast(new Student("Wade",0));
            studentLinkedList.AddLast(new Student("Peter", 1));
            studentLinkedList.AddLast(new Student("Stephen", 2));
            studentLinkedList.AddLast(new Student("Goku", 3));
            studentLinkedList.AddLast(new Student("Gon", 4));
            studentLinkedList.AddLast(new Student("Happy", 5));
            //Print all current students
            Console.WriteLine("\n>>>List of initially enrolled students...\n");
            foreach (var student in studentLinkedList)
            {
                Console.WriteLine("Name: {0,3}", student.name + " ID: " + student.id);
            }
            Console.WriteLine();
            //Add a neww Student object by calling AddLinkedListItem() method
            AddLinkedListItem(studentLinkedList, new Student("Lucy", 6));
        }

        public static void AddLinkedListItem(LinkedList<Student> inputLinkedList, Student studentObject)
        {
            Console.WriteLine("Adding a student to the LinkedList...\n");
            LinkedListNode<Student> studentNode = new LinkedListNode<Student>(studentObject);
            inputLinkedList.AddLast(studentNode);
            Console.WriteLine("\nNew Student object added...\nName: " 
                              + studentObject.name + " ID: " + studentObject.id);
        }
    }
}
