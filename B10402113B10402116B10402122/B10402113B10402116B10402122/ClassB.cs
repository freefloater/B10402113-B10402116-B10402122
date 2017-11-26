using System;
using System.Collections.Generic;
using System.Text;

namespace B10402113B10402116B10402122
{
    class ClassB
    {
        //Property
        int i;
        int num;
        //Method
        public int MATCH()
        {
            ClassA a = new ClassA();
            num = a.number;
            if (num < 2)
            {
                Console.WriteLine("{0}無任何質數", num);
            }
            for (int i = 2; i <= num; i++)
            {
                //開根號取最大值+1
                int sqrt = Convert.ToInt32(Math.Sqrt(i) + 1) + 1;
                for (int j = 2; j <= sqrt; j++)
                {
                    //目前讀取的數字與要比對的數字不同
                    if (i != j)
                    {
                        //如果餘數是 0 可以斷定該數字不是質數
                        if (i % j == 0)
                            break;
                        //如果一直到最後都無法整除便可斷定該數字是質數
                        if (i % j != 0 && j == sqrt)
                        {
                            Console.WriteLine(j);
                        }
                    }
                }
            }
            return
        }
    }
}