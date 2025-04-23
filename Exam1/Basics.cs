using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using Microsoft.VisualBasic;

namespace Exam1;
public class Q1_Add(int x, int y)
{
    int a = x;
    int b = y;

   
    public static int Add(int a, int b){
        return a+b;

    }
   
}
//public class Basics{
//    
//    int v;
//    int f;
//   
//     public static void Q2MultiplyAndReset(int  v, int f){
//        v=v*f;
//
//
//       
//    }
//}


public class Type1
{
    int t1;
    public int Count; 
    
    
}
public class Type2{
    int t2;
    public int Count { get;  set; }

    
}
public class  Q4Person {
    public int Age { get; set; }
    public string? Name { get; set; }

    public Q4Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string? Introduce()
    {
        return  $"Hello, my name is {Name} and I am {Age} years old.";
    }
    //public override string ToString()
    //{
    //    return  $"Hello, my name is{Name}and I am {Age} years old.";
    //}
}
// public class Basics{
//     public static void Q5TryCatchFinally(bool v, List<string> log){
//     try {

//         throw new NotImplementedException();
//     }
//     catch{
//         if (shouldThrow)
//         return "When shouldThrow is true, expect Try → Catch → Finally".to;
//     return"When shouldThrow is true, expect Try → Catch → Finally";
//     }
// }
// }

