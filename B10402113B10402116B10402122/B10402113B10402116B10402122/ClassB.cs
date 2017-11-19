using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10402113B10402116B10402122
{
    class ClassB
    {
         int j = 0; 
for (int i = 2; i <= 1000; i++) 
{ 
if (i == 2 || i == 3 || i == 5 || i == 7) 
{ 
j++; 
Console.Write(" " + i); 
} 
if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0) 
{ 
j++; 
Console.Write(" " + i); 
if (j % 5 == 0) 
Console.WriteLine(); 
} 
}
    }
}
