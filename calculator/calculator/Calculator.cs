using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    
    internal class Calculator
    {
       public int sum = 0;
        public int prev = 0;
       public string prevSign = "";
      
       public int curr = 0;
        public void Calculate()
        {
            


                if (prevSign == "+")
                {
                    sum = prev + curr;
                }
                else if (prevSign == "-")
                {
                    sum = prev - curr;
                }
                else if (prevSign == "X")
                {
                    sum = prev * curr;
                }
                else if (prevSign == "/")
                {
                    if (curr == 0)
                    {
                        MessageBox.Show("Aja baja det går inte dela med noll!");
                    }
                    else
                    {
                        sum = prev / curr;
                    }

               
            }
        


        }
        public void Next(string prevSign2,Label label1,Label label2)
        {
         


                Calculate();
                prev = sum;
                prevSign = prevSign2;
                curr = 0;

                label1.Text = sum.ToString();
                label2.Text = prev.ToString() + prevSign;
            

        }
    }

   
}
