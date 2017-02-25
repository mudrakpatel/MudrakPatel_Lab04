﻿using System;
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
                Console.WriteLine("Name: {0,3}", student.name + " ID: " + student.id);
            }
            Console.WriteLine();
            //Add a new Student object by calling AddLinkedListItem() method
            AddLinkedListItem(studentLinkedList, new Student("Lucy", 6));
            //Remove Student object by calling removeLinkedListItem() method
            RemoveLinkedListItem(studentLinkedList, Stephen);
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

    }
}
