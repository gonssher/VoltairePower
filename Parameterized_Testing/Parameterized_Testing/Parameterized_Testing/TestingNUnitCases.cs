using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectDataDriven
{
    public class TestingNUnitCases
    {


        public string DataVerification(string first, string second)
        {


            
            return first + second;


        }


        public string makeSureValid(string variable1, string variable2)
        {
            string content = "both inputs are matching and testing has passed";

            if (variable1 != variable2)
            {

                throw new ArgumentException("input mismatch please try again");

            }
            else if (variable1 == "")
            {

                throw new ArgumentException("input field is blank Please re try");


            }

            return content;

        }




        public string makeSureValidEmail(string variable1, string variable2)
        {
            string content = "both inputs are matching and testing has passed";

            if (!variable1.Contains('@'))
            {

                throw new ArgumentException("Please input the string in the correct format");

            }
            else if (variable1 == "")
            {

                throw new ArgumentException("input field is blank Please re try");


            }
            else if (variable1 != variable2)

            {
                throw new ArgumentException("input mismatch please try again");

            }



            return content;

        }


        public string makeSureNumberIsValid(int variable1, int variable2)
        {
            string content = "both inputs are matching and testing has passed";

            if (variable1 != variable2)
            {

                throw new ArgumentException("input mismatch please try again");

            }
            else if (variable1 == null)
            {

                throw new ArgumentException("input field is blank Please re try");


            }

            return content;




        }

    }
}
