using NUnit.Framework;
using NUnit.Framework.Internal;
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
            int result = 0;

            if (int.TryParse(variable1, out result))
            {

                 throw new ArgumentException("The input you have entered cannot be accepted please enter only string " + variable1 +"is not allowed");

            }
            else if (string.IsNullOrEmpty(variable1))
            {

                throw new ArgumentException("input field is blank Please re try var1");


            }
            else if (string.IsNullOrEmpty(variable2))
            {

                throw new ArgumentException("input field is blank Please re try");
            }

            return content;

        }




        public string makeSureValidEmail(string variable1, string variable2)
        {
            string content = "both inputs are matching and testing has passed";

            if ( variable1 == "")
            {
                throw new ArgumentException("input field is blank Please re try");

            }
            else if (!variable1.Contains('@'))
            {

              
                throw new ArgumentException("Please input the email with @ " + variable1 + "Your email doesnt have an @");


            }
            else if (variable1 != variable2)

            {
                Assert.AreNotEqual(variable1, variable2);

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


        public string makeSurePassword(string variable1, string variable2)
        {
            string content = "both inputs are matching and testing has passed";

            if (variable1 == null)
            {
                throw new ArgumentException("input field is blank Please re try");
            }
            else if ( variable1 != variable2)
            {


                throw new ArgumentException("input mismatch please try again" + "input by user " + variable1 + "Second Expected Input" + variable2);

            }

            return content;




        }




    }
}
