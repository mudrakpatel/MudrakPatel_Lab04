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
            Student Wade = new Student("Wade", 0);
            studentLinkedList.AddLast(Wade);
            Student Peter = new Student("Peter", 1);
            studentLinkedList.AddLast(Peter);
            Student Stephen = new Student("Stephen", 2);
            studentLinkedList.AddLast(Stephen);
            Student Goku = new Student("Goku", 3);
            studentLinkedList.AddLast(Goku);
            Student Gon = new Student("Gon", 4);
            studentLinkedList.AddLast(Gon);
            Student Happy = new Student("Happy", 5);
            studentLinkedList.AddLast(Happy);
            //Print all current students
            Console.WriteLine("\n>>>List of initially enrolled students...\n");
            foreach (var student in studentLinkedList)
            {
                Console.WriteLine("Name: {0,3}", student.name + " ID: " + student.id + "\n");
            }
            Console.WriteLine();
            //Add a new Student object by calling AddLinkedListItem() method
            AddLinkedListItem(studentLinkedList, new Student("Lucy", 6));
            //Remove Student object by calling removeLinkedListItem() method
            RemoveLinkedListItem(studentLinkedList, Stephen);
            //Print all students data using PrintLinkedList method
            PrintLinkedList(studentLinkedList);
            //Search for a student using SearchLinkedListItem method
            SearchLinkedListItem(studentLinkedList, Goku);
        }

        //AddLinkedListItem method
        public static void AddLinkedListItem(LinkedList<Student> inputLinkedList, Student studentObject)
        {
            try
            {
                Console.WriteLine("Adding a student to the LinkedList...\n");
                LinkedListNode<Student> studentNode = new LinkedListNode<Student>(studentObject);
                inputLinkedList.AddLast(studentNode);
                Console.WriteLine("\nNew Student object added...\nName: "
                                  + studentObject.name + " ID: " + studentObject.id);
            }
            catch (Exception exception)
            {
                Console.WriteLine("\n{0,2}", exception.Message);
            }
        }
        //RemoveLinkedListItem method
        public static void RemoveLinkedListItem(LinkedList<Student> inputLinkedList, Student studentObject)
        {
            try
            {
                Console.WriteLine("\nRemoving a student to the LinkedList...\n");
                LinkedListNode<Student> studentNode = new LinkedListNode<Student>(studentObject);
                inputLinkedList.Remove(studentNode);
                Console.WriteLine("\nStudent object removed...\nName: "
                                  + studentObject.name + " ID: " + studentObject.id);
            }
            catch (Exception exception)
            {
                inputLinkedList.AddLast(studentObject);
                inputLinkedList.Remove(studentObject);
                Console.WriteLine("\n{0,2}\nException handling in process...", exception.Message);
                Console.WriteLine("\nStudent object removed...\nName: "
                                  + studentObject.name + " ID: " + studentObject.id + "\n");
            }
        }
        //PrintLinkedList method
        public static void PrintLinkedList(LinkedList<Student> inputLinkedList)
        {
            try
            {
                Console.WriteLine(">>>Printing student data using PrintLinkedList method....\n");
                foreach (var student in inputLinkedList)
                {
                    Console.WriteLine("--- Name: {0,3}", student.name + " ID: " + student.id + "\n");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("\n{0,2}\nException handling in process...", exception.Message);
            }
        }
        //SearchLinkedListItem method
        public static void SearchLinkedListItem(LinkedList<Student> inputLinkedList, Student studentObject)
        {
            try
            {
                Console.WriteLine("\nSearching for {0,3}...\n", studentObject.name, studentObject.id);
                var resultedItem = from item in inputLinkedList
                                   where ((item.name.Equals(studentObject.name)) &&
                                   (item.id.Equals(studentObject.id)))
                                   select item;
                Console.WriteLine("\n>>>Students that match the search criteria :\n");
                foreach (var item in resultedItem)
                {
                    Console.WriteLine("--- Name: {0,3} ID: {1,3}\n", item.name, item.id);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("\n{0,2}\nException handling in process...", exception.Message);
            }
        }
    }
}
