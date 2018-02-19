﻿using System;
using System.Collections.Generic;
using System.Text;
using CodeRust.LinkedLists;
using System.Linq;

namespace CodeRust.Helpers
{
    public class PrintHelpers
    {
        public static void PrintArray<T>(string header, CustomLinkedList<T> input, CustomLinkedList<T> output, string specialInput = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("----------- {0} ---------", header));

            stringBuilder.AppendLine(string.Format("{0} {1}", GetInputOuput(input), specialInput));

            stringBuilder.AppendLine(GetInputOuput(output, "Output"));

            stringBuilder.AppendLine(string.Format("---------------------------------------------------"));
            Console.WriteLine(stringBuilder);
        }

        static string GetInputOuput<T>(CustomLinkedList<T> output, string comment = "Input")
        {
            //Output
            StringBuilder sb = new StringBuilder();
            var head = output.Head;
            while (head != null)
            {
                sb.Append(head.Value);
                sb.Append(", ");
                head = head.Next;
            }
            sb.Remove(sb.Length - 2, 2);
            return string.Format("{0}: [{1}]", comment, sb);
        }


        public static void PrintArray<T>(string header, IList<T> input, IList<T> output, string specialInput = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("----------- {0} ---------", header));

            stringBuilder.AppendLine(string.Format("{0} {1}", GetInputOuput(input), specialInput));

            stringBuilder.AppendLine(GetInputOuput(output, "Output"));

            stringBuilder.AppendLine(string.Format("---------------------------------------------------"));
            Console.WriteLine(stringBuilder);
        }

        public static void PrintArray<T>(string header, IEnumerable<IList<T>> inputs, IList<T> output, string specialInput = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("----------- {0} ---------", header));

            stringBuilder.AppendLine("Input: ");
            stringBuilder.AppendLine(string.Format("{0} {1}", GetInputOuputs(inputs), specialInput));

            stringBuilder.AppendLine(GetInputOuput(output, "Output"));

            stringBuilder.AppendLine(string.Format("---------------------------------------------------"));
            Console.WriteLine(stringBuilder);
        }

        public static void PrintArray<T>(string header, IList<T> input, IEnumerable<IList<T>> output, string specialInput = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("----------- {0} ---------", header));

            stringBuilder.AppendLine(string.Format("{0} {1}", GetInputOuput(input), specialInput));

            stringBuilder.AppendLine(GetInputOuputs(output, "Output"));

            stringBuilder.AppendLine(string.Format("---------------------------------------------------"));
            Console.WriteLine(stringBuilder);
        }

        static void PrintArray<T>(string header, IEnumerable<IList<T>> inputs, IEnumerable<IList<T>> output, string specialInput = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("----------- {0} ---------", header));

            stringBuilder.AppendLine("Input: ");
            stringBuilder.AppendLine(string.Format("{0} {1}", GetInputOuputs(inputs), specialInput));

            stringBuilder.AppendLine(GetInputOuputs(output, "Output"));

            stringBuilder.AppendLine(string.Format("---------------------------------------------------"));
            Console.WriteLine(stringBuilder);
        }

        static string GetInputOuput<T>(IList<T> output, string comment = "Input")
        {
            //Output
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < output.Count(); i++)
            {
                sb.Append(output[i]);
                sb.Append(", ");
            }
            sb.Remove(sb.Length - 2, 2);
            return string.Format("{0}: [{1}]", comment, sb);
        }

        static string GetInputOuputs<T>(IEnumerable<IList<T>> inputs, string comment = "Input")
        {
            // input
            StringBuilder stringBuilder = new StringBuilder();
            int counter = 0;
            inputs.ToList().ForEach(input =>
            {
                counter++;
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < input.Count(); i++)
                {
                    sb.Append(input[i]);
                    sb.Append(", ");
                }
                sb.Remove(sb.Length - 2, 2);
                stringBuilder.AppendLine(string.Format("{0} {1}: {2}", comment, counter, sb));
            });
            return stringBuilder.ToString();
        }
    }
}
