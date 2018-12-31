﻿using System;

namespace _06_Student_action
{
    //step 1 - declare a delegate
    delegate void ActionHandler(string subject);


    class Student
    {
        //step 2 - create an event with the delegate from step 1
        public event ActionHandler MorningActions;

        public void WakeUp(string str)
        {
            //step 4 - call to the delegate - via the class
            MorningActions(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            //step 3 - subscribe a function to the event
            student.MorningActions+= (s) => { Console.WriteLine($"students says: {s}"); };

            student.WakeUp("I called the class");
                
        }
    }
}

/*
OUTPUT:
_______________________________________
students says: I called the class
*/

