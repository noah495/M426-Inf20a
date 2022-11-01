using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

         public int Multiply(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

        public int Divide(int firstNum, int secondNum)
        {
            if(secondNum == 0){
                return "Cant divide by 0";
            } else {
                return firstNum / secondNum;
            }
        }
    }
}
