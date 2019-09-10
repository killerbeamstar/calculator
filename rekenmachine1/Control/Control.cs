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
        public Control()
        {

        }

        public void SetView(IView View)
        {
            this.View = View;
        }

        public void click(string cijfer)
        {
            View.toTextbox(cijfer);
        }

        public void nothing()
        {
            View.empty();
        }

        public void calculate(string text)
        {
            if(text == "")
            {
                View.empty();
            }
            else
            {
                string number1 = "";
                double counter = 0;
                string number2 = "";
                char symbol = '.';
                foreach (char thing in text)
                {
                    if (thing == '/' || thing == '*' || thing == '+' || thing == '-' || thing == '.')
                    {
                        counter++;
                        if (counter > 1)
                        {
                            number1 = calculator(symbol, number1, number2);
                            symbol = thing;
                            number2 = "";

                        }
                        else
                        {
                            symbol = thing;

                        }
                    }
                    else
                    {
                        if (counter > 0)
                        {
                            number2 = number2 + Convert.ToString(thing);
                        }
                        else
                        {
                            number1 = number1 + Convert.ToString(thing);
                        }
                    }
                }
                number1 = calculator(symbol, number1, number2);
                View.response(number1);

            }

        }
        public string calculator(char character, string number1, string number2)
        {
            double test = 0;
            switch (character)
            {
                case '-':
                    {
                        test = Convert.ToDouble(number1) - Convert.ToDouble(number2);
                        break;
                    }
                case '+':
                    {
                        test = Convert.ToDouble(number1) + Convert.ToDouble(number2);
                        break;
                    }
                case '/':
                    {
                        test = Convert.ToDouble(number1) / Convert.ToDouble(number2);
                        break;
                    }
                case '*':
                    {
                        test = Convert.ToDouble(number1) * Convert.ToDouble(number2);
                        break;
                    }
                case '.':
                    {
                        string yeet = number1 + "," + number2;
                        test = Convert.ToDouble(yeet);
                        break;
                    }
            }
            string inbetween = Convert.ToString(test);
            return inbetween;
        }
    }
}

