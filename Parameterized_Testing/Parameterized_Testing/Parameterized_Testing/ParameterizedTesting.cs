using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Constraints;
using System;
using System.Diagnostics;
using basic.math;



namespace UnitTestProjectDataDriven
{
    [TestClass]
    public class ParameterizedTesting
    {
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;

        public Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext {

            get { return _testContext; }

            set { _testContext = value; }
        }

        [TestMethod]
        public int Squaring(int number1)
        {
            number1 = 5;
            int result = number1 * number1;
            Console.WriteLine(result);
            return result;

       
            
       }
        [TestMethod]
        public int SquaringNumber2(int number2)
        {
            number2 = 25;
            int result = number2 * number2;
            Console.WriteLine(result);
            return result;

        }

        



        //        [TestMethod]
        [DeploymentItem("c:\\demo\\data.xls")]
        [DataSource("MyExcelDataSource")]
        public void TestingEmail()
        {
            string variable1 = (_testContext.DataRow["EmailInput"].ToString());
            Trace.WriteLine(_testContext.DataRow["EmailInput"].ToString());

            string variable2 = (_testContext.DataRow["EmailExpected"].ToString());
            Trace.WriteLine(_testContext.DataRow["EmailExpected"].ToString());

         TestingNUnitCases nUnitCases = new TestingNUnitCases();

            if (variable1 != variable2)
            {

                Assert.AreNotEqual(variable1, variable2);
            }
            else
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(variable1, variable2);
            }

        }

        //[TestMethod]
        [DeploymentItem("c:\\demo\\data.xls")]
        [DataSource("MyExcelDataSource")]
        public void TestingPassword()
        {
            string variable1 = (_testContext.DataRow["PasswordInput"].ToString());
            Trace.WriteLine(_testContext.DataRow["PasswordInput"].ToString());

            string variable2 = (_testContext.DataRow["PasswordExpected"].ToString());
            Trace.WriteLine(_testContext.DataRow["PasswordExpected"].ToString());

            TestingNUnitCases nUnitCases = new TestingNUnitCases();


            nUnitCases.makeSurePassword(variable1, variable2);
            Assert.AreNotEqual(variable1, variable2);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(variable1, variable2); 
        }

        //[TestMethod]
        [DeploymentItem("c:\\demo\\data.xls")]
        [DataSource("MyExcelDataSource")]
        public void TestingStreetNumber()
        {
            int variable1 = Convert.ToInt32(_testContext.DataRow["StreetNumberInput"].ToString());
            Trace.WriteLine(_testContext.DataRow["StreetNumberInput"].ToString());

            int variable2 = Convert.ToInt32(_testContext.DataRow["StreetNumberExpected"].ToString());
            Trace.WriteLine(_testContext.DataRow["StreetNumberExpected"].ToString());

            TestingNUnitCases nUnitCases = new TestingNUnitCases();


            nUnitCases.makeSureNumberIsValid(variable1, variable2);


            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(variable1, variable2);
        }

     //  [TestMethod]
        [DeploymentItem("c:\\demo\\data.xls")]
        [DataSource("MyExcelDataSource")]
        public void TestingStreetName()
        {
            string variable1 = (_testContext.DataRow["StreetNameInput"].ToString());
            Trace.WriteLine(_testContext.DataRow["StreetNameInput"].ToString());

            string variable2 = (_testContext.DataRow["StreetNameExpected"].ToString());
            Trace.WriteLine(_testContext.DataRow["StreetNameExpected"].ToString());


            if (variable1 != variable2)
            {

                Assert.AreNotEqual(variable1, variable2);
            }
            else
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(variable1, variable2);
            }

        }

        //    [TestMethod]
        [DeploymentItem("c:\\demo\\data.xls")]
        [DataSource("MyExcelDataSource")]
        public void TestingMobileNumber()
        {

            int variable1 = Convert.ToInt32(_testContext.DataRow["PhoneNumberInput"].ToString());
            Trace.WriteLine(_testContext.DataRow["PhoneNumberInput"].ToString());

            int variable2 = Convert.ToInt32(_testContext.DataRow["PhoneNumberExpected"].ToString());
            Trace.WriteLine(_testContext.DataRow["PhoneNumberExpected"].ToString());

            TestingNUnitCases nUnitCases = new TestingNUnitCases();


            nUnitCases.makeSureNumberIsValid(variable1, variable2);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(variable1, variable2);

          }


      //[TestMethod]
        [DeploymentItem("c:\\demo\\data.xls")]
        [DataSource("MyExcelDataSource")]
        public void TestingName()
        {
            string variable1 = (_testContext.DataRow["CustomerNameInput"].ToString());
            Trace.WriteLine(_testContext.DataRow["CustomerNameInput"].ToString());

            string variable2 = (_testContext.DataRow["CustomerNameExpected"].ToString());
            Trace.WriteLine(_testContext.DataRow["CustomerNameExpected"].ToString());

            if (variable1 != variable2)
            {

                Assert.AreNotEqual(variable1, variable2);
            }
            else
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(variable1, variable2);
            }

        }

    }
}
