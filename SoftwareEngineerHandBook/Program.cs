﻿using SoftwareEngineerHandBookStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineerHandBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> test = new List<int> { 1, 4, 5, 6, 2, 56, 55, 90 };
            Console.WriteLine("Test : 1, 4, 5, 6, 2, 56, 55, 90 ");
            //1st example: Binary Trees
            BinaryTrees a = new BinaryTrees(test);

            //2nd example : Linked List
            LinkedLists b = new LinkedLists(test);

            //3rd Example : Queue
            Queues c = new Queues(test);

            //4th Example: Stacks
            Stacks d = new Stacks(test);

            //5th :1st Question and its answer by  Quick Sort
            QuestionAnswer q1 = new QuestionAnswer();

            ParanthesisQuestion q2 = new ParanthesisQuestion();
            //Terminate

            MagicString mS = new MagicString(3);

            Console.WriteLine("Press enter to terminate");
            Console.ReadLine();

                

        }
    }
}
