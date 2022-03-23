using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    public class MathOperations
    {
        public static int Addition(int numOne, int numTwo = 0)
        {
            int result = (numOne + numTwo) * 10;
            return result;
        }
    }
}


//namespace MainMethodAssignment
//{
//    public class Addition
//    {
//        public static int Plus(int numOne)
//        {
//            int result = numOne + numOne;
//            return result;
//        }

//        public static int Dec(decimal numTwo)
//        {
//            int resultTwo = Convert.ToInt32(numTwo + numTwo);
//            return resultTwo;
//        }
//    }
//}