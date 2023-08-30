using System.Reflection;
using System.Text;

namespace Exercicio03_LMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            testClass obj = new testClass();

            string concatenatedResults = Reflections.ConcatStringMembers(obj);
            Console.WriteLine(concatenatedResults);
        }
        //    }
        //using System;
        //using System.Reflection;
        //using System.Text;

        //public class testClass
        //{
        //    public string Output1()
        //    {
        //        return "Output";
        //    }

        //    public string Output2()
        //    {
        //        return "It";
        //    }
        //}

        //public static class Reflection
        //{
        //    public static string ConcatStringMembers(object obj)
        //    {
        //        if (obj == null)
        //        {
        //            return "";
        //        }

        //        Type type = obj.GetType();
        //        MethodInfo[] methods = type.GetMethods();

        //        StringBuilder resultBuilder = new StringBuilder();

        //        foreach (MethodInfo method in methods)
        //        {
        //            if (method.ReturnType == typeof(string) && method.GetParameters().Length == 0)
        //            {
        //                string methodName = method.Name;
        //                object methodResult = method.Invoke(obj, null);
        //                string methodValue = methodResult != null ? methodResult.ToString() : "null";

        //                resultBuilder.AppendLine($"{methodName}: {methodValue}");
        //            }
        //        }

        //        return resultBuilder.ToString();
        //    }
        //}

        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        testClass obj = new testClass();
        //        string concatenatedResults = Reflection.ConcatStringMembers(obj);
        //        Console.WriteLine(concatenatedResults);
        //    }
        //}

    }
}
