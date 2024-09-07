using System;




// declare variable in pascal case or camel case
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myNum = 15;
      myNum = 20;
      Console.WriteLine(myNum);
    }
  }
}


using System;




// declare variable in pascal case or camel case
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myNum = 15;
      myNum = 20;
      Console.WriteLine(myNum);
    }
  }
}


// C# implementation to demonstrate
// the Boxing
using System;
class Boxing {

    // Main Method
    static public void Main()
    {

        // assigned int value
        // 2020 to num
        int num = 2020;

        // boxing
        object obj = num;

        // value of num to be change
        num = 100;

        System.Console.WriteLine
        (&quot;Value - type value of num is : {0}&quot;, num);
        System.Console.WriteLine
        (&quot;Object - type value of obj is : {0}&quot;, obj);
    }
}


// C# implementation to demonstrate
// the Unboxing
using System;
class unBoxing {

    // Main Method
    static public void Main()
    {

        // assigned int value
        // 23 to num
        int num = 23;

        // boxing
        object obj = num;

        // unboxing
        int i = (int)obj;

        // Display result
        Console.WriteLine(&quot;Value of ob object is : &quot; + obj);
        Console.WriteLine(&quot;Value of i is : &quot; + i);
    }
}
