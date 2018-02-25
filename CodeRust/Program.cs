﻿using System;
using CodeRust.Arrays;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using CodeRust.LinkedLists;
using CodeRust.Helpers;
using CodeRust.BinaryTrees;

namespace CodeRust
{
    class Program
    {
        static void Main()
        {

            //Arrays
            ArrayHelpers.ArrayProblems();

            //Linked List
            LinkedListHelper.LinkedListProblems();

            // Binary Tree
            BinaryTreeHelper.BinaryTreeProblems();

            // Matrix
            Matrix.MatrixHelpers.MatrixProblems();

            Console.ReadKey();
        }

       
    }
}
