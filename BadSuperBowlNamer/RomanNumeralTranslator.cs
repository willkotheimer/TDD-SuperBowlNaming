using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperBowlNamer
{
    public class RomanNumeralTranslator
    {
        public string NumberToNumeral(int numberToConvert)
        {
            var result = "";
            // throw new NotImplementedException();

           /* var result = numberToConvert switch
            {
                1 => "I",
                5 => "V",
                9 => "IX"
            };*/

            while (numberToConvert >0)
            {
                if(numberToConvert >= 100)
                {
                    result += "C";
                    numberToConvert -= 100;
                }
                else if(numberToConvert >= 50)
                {
                    result += "L";
                    numberToConvert -= 50;
                } 
                else if (numberToConvert >= 40)
                {
                    result += "XL";
                    numberToConvert -= 40;
                }
                else if(numberToConvert >= 10)
                {
                    var numberOfTens = numberToConvert / 10;
                    numberToConvert %= 10;
                    result += new string('X', numberOfTens);                   
                   
                }
                else if (numberToConvert == 9)
                {
                    result += "IX";
                    numberToConvert -=9;
                }
                else if (numberToConvert >= 5)
                {
                    result += "V";
                    numberToConvert -=5;
                }
                else if (numberToConvert == 4)
                {
                    result += "IV";
                    numberToConvert -=4;
                }
                else if (numberToConvert <=3)
                {
                    result += new string('I', numberToConvert);
                    numberToConvert =0;
                }
            }
            return result;
        }
        
    }
}
