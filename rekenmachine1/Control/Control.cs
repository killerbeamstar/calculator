using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using rekenmachine1.Interface;

namespace rekenmachine1.Control
{
    public class Control
    {
        IView View;
        /// <summary>
        /// create object
        /// </summary>
        public Control()
        {
            
        }
        /// <summary>
        /// make the view as the interface
        /// </summary>
        /// <param name="View"></param>
        public void SetView(IView View)
        {
            this.View = View;
        }
        /// <summary>
        /// send the number to the view
        /// </summary>
        /// <param name="number"></param>
        public void click(string number)
        {
            View.toTextbox(number);
        }
        /// <summary>
        /// send nothing to the view
        /// </summary>
        public void nothing()
        {
            View.empty();
        }
        /// <summary>
        /// check if the character is a number or character
        /// </summary>
        /// <param name="text"></param>
        public void calculate(string text)
        {
            if(text == "")
            {
                View.empty();//if the text is empty send it to view
            }
            else
            {
                //create variables
                string number1 = "";
                double counter = 0;
                string number2 = "";
                char symbol = '.';

                foreach (char thing in text) //for each chaaracter in the string
                {
                    if (thing == '/' || thing == '*' || thing == '+' || thing == '-' || thing == '.')//check if the character is a number or not
                    {
                        counter++; // if it isnt a number, up counter
                        if (counter > 1) 
                        {
                            number1 = calculator(symbol, number1, number2);//if the counter is higher then 1 run calculator and send the symbols and numbers to calculator amd put the answer in number1
                            symbol = thing; //give the symbol it's own variable
                            number2 = ""; //reset the second number

                        }
                        else
                        {
                            symbol = thing;//if the counter isnt higher then 1 only give the symbol its own variable

                        }
                    }
                    else
                    {
                        if (counter > 0) // if the character is a number check if the counter is higher then 0
                        {
                            number2 = number2 + Convert.ToString(thing);//if the counter is higher then 0 add the number to number2
                        }
                        else
                        {
                            number1 = number1 + Convert.ToString(thing);//if the counter is 0 add the number to number1
                        }
                    }
                }
                number1 = calculator(symbol, number1, number2); // when all the characters are done run the calculator again and put the answer to number1
                View.response(number1);//send the answer back to the view

            }

        }
        /// <summary>
        /// calaculate the sum
        /// </summary>
        /// <param name="character"></param>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public string calculator(char character, string number1, string number2)
        {
            double test = 0;//create variable
            switch (character)
            {
                case '-'://if the character is a minus substract the second number of the first
                    {
                        test = Convert.ToDouble(number1) - Convert.ToDouble(number2);
                        break;
                    }
                case '+'://if the character is a plus add the second number of the first
                    {
                        test = Convert.ToDouble(number1) + Convert.ToDouble(number2);
                        break;
                    }
                case '/'://if the character is a slash divide the second number of the first
                    {
                        test = Convert.ToDouble(number1) / Convert.ToDouble(number2);
                        break;
                    }
                case '*'://if the character is a star mutiply the second number of the first
                    {
                        test = Convert.ToDouble(number1) * Convert.ToDouble(number2);
                        break;
                    }
                case '.'://if the character is a dot, put a , between the numbers
                    {
                        string yeet = number1 + "," + number2;
                        test = Convert.ToDouble(yeet);
                        break;
                    }
            }
            string inbetween = Convert.ToString(test);//convert the answer to string
            return inbetween;//return the answer
        }
    }
}

