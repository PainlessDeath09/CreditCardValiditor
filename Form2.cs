using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credit_Card_Validator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string c = maskedCardNumberIn.Text;
            string a="";
            for(int i=0;i<c.Length;i++)
            {
                
                if (c[i] == '-')
                    continue;
                else
                    a += c[i];
            }
            long l = long.Parse(a);
            bool isValid(long number)
            {
                return (getSize(number) >= 13 &&
                        getSize(number) <= 16) &&
                        (prefixMatched(number, 4) ||
                        prefixMatched(number, 5) ||
                        prefixMatched(number, 37) ||
                        prefixMatched(number, 6)) &&
                        ((sumOfDoubleEvenPlace(number) +
                        sumOfOddPlace(number)) % 10 == 0);
            }

            // Get the result from Step 2 
            int sumOfDoubleEvenPlace(long number)
            {
                int sum = 0;
                String num = number + "";
                for (int i = getSize(number) - 2; i >= 0; i -= 2)
                    sum += getDigit(int.Parse(num[i] + "") * 2);

                return sum;
            }

            // Return this number if it is a  
            // single digit, otherwise, return  
            // the sum of the two digits 
            int getDigit(int number)
            {
                if (number < 9)
                    return number;
                return number / 10 + number % 10;
            }

            // Return sum of odd-place digits in number 
            int sumOfOddPlace(long number)
            {
                int sum = 0;
                String num = number + "";
                for (int i = getSize(number) - 1; i >= 0; i -= 2)
                    sum += int.Parse(num[i] + "");
                return sum;
            }

            // Return true if the digit d 
            // is a prefix for number 
            bool prefixMatched(long number, int d)
            {
                return getPrefix(number, getSize(d)) == d;
            }

            // Return the number of digits in d 
            int getSize(long d)
            {
                String num = d + "";
                return num.Length;
            }

            // Return the first k number of digits from  
            // number. If the number of digits in number 
            // is less than k, return number. 
            long getPrefix(long number, int k)
            {
                if (getSize(number) > k)
                {
                    String num = number + "";
                    return long.Parse(num.Substring(0, k));
                }
                return number;
            }
            Result1 r1 = new Result1();
            Result0 r0 = new Result0();
            if(isValid(l))
            {
                r1.ShowDialog();
            }
            else
            {
                r0.ShowDialog();
            }
            
        }

    }
}

