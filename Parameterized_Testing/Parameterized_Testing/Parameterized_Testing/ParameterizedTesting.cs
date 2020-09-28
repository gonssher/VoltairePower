﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Diagnostics;

namespace UnitTestProjectDataDriven
{
    [TestClass]
    public class ParameterizedTesting
    {
        private TestContext _testContext;

        public  TestContext TestContext {

            get { return _testContext; }

            set { _testContext = value; }
        }

        [TestMethod]
        [DeploymentItem("c:\\demo\\data.xls")]
        [DataSource("MyExcelDataSource")]
        public void TestingEmail()
        {
            string variable1 = (_testContext.DataRow["EmailInput"].ToString());
            Trace.WriteLine(_testContext.DataRow["EmailInput"].ToString());

            string variable2 = (_testContext.DataRow["EmailExpected"].ToString());
            Trace.WriteLine(_testContext.DataRow["EmailExpected"].ToString());

            Assert.AreEqual(variable1, variable2); 
        }


        [TestMethod]
        [DeploymentItem("c:\\demo\\data.xls")]
        [DataSource("MyExcelDataSource")]
        public void TestingPassword()
        {
            string variable1 = (_testContext.DataRow["PasswordInput"].ToString());
            Trace.WriteLine(_testContext.DataRow["PasswordInput"].ToString());

            string variable2 = (_testContext.DataRow["PasswordExpected"].ToString());
            Trace.WriteLine(_testContext.DataRow["PasswordExpected"].ToString());

            Assert.AreEqual(variable1, variable2); 
        }

        [TestMethod]
        [DeploymentItem("c:\\demo\\data.xls")]
        [DataSource("MyExcelDataSource")]
        public void TestingStreetNumber()
        {
            int variable1 = Convert.ToInt32(_testContext.DataRow["StreetNumberInput"].ToString());
            Trace.WriteLine(_testContext.DataRow["StreetNumberInput"].ToString());

            int variable2 = Convert.ToInt32(_testContext.DataRow["StreetNumberExpected"].ToString());
            Trace.WriteLine(_testContext.DataRow["StreetNumberExpected"].ToString());

            Assert.AreEqual(variable1, variable2);
        }

        [TestMethod]
        [DeploymentItem("c:\\demo\\data.xls")]
        [DataSource("MyExcelDataSource")]
        public void TestingStreetName()
        {
            string variable1 = (_testContext.DataRow["StreetNameInput"].ToString());
            Trace.WriteLine(_testContext.DataRow["StreetNameInput"].ToString());

            string variable2 = (_testContext.DataRow["StreetNameExpected"].ToString());
            Trace.WriteLine(_testContext.DataRow["StreetNameExpected"].ToString());

            Assert.AreEqual(variable1, variable2);
        }

        [TestMethod]
        [DeploymentItem("c:\\demo\\data.xls")]
        [DataSource("MyExcelDataSource")]
        public void TestingMobileNumber()
        {

            int variable1 = Convert.ToInt32(_testContext.DataRow["PhoneNumberInput"].ToString());
            Trace.WriteLine(_testContext.DataRow["PhoneNumberInput"].ToString());

            int variable2 = Convert.ToInt32(_testContext.DataRow["PhoneNumberExpected"].ToString());
            Trace.WriteLine(_testContext.DataRow["PhoneNumberExpected"].ToString());

            Assert.AreEqual(variable1, variable2);
        }


        [TestMethod]
        [DeploymentItem("c:\\demo\\data.xls")]
        [DataSource("MyExcelDataSource")]
        public void TestingName()
        {
            string variable1 = (_testContext.DataRow["CustomerNameInput"].ToString());
            Trace.WriteLine(_testContext.DataRow["CustomerNameInput"].ToString());

            string variable2 = (_testContext.DataRow["CustomerNameExpected"].ToString());
            Trace.WriteLine(_testContext.DataRow["CustomerNameExpected"].ToString());

            Assert.AreEqual(variable1, variable2);
        }









    }
}