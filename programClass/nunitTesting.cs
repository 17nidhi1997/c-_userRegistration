using NUnit.Framework;
using System.Collections.Generic;
namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FirstNameTest()
        {
            fun aa = new fun();
            Assert.IsTrue(aa.Firstname("Nidhi"));
        }

        [Test]
        public void FirstNameTest2()
        {
            fun aa = new fun();
            Assert.IsFalse(aa.Firstname("nidhi"));
        }

        [Test]
        public void LastNameTest()
        {
            fun2 aa = new fun2();
            Assert.IsTrue(aa.Lastname("Nidhi"));
        }

        [Test]
        public void LastnameTest2()
        {
            fun2 aa = new fun2();
            Assert.IsFalse(aa.Lastname("nidhi"));
        }

        [Test]
        public void EmailTest()
        {
            Email aa = new Email();
            Assert.IsTrue(aa.Email_s("nidhinavaya@gmail.com"));
        }

        [Test]
        public void EmailTest2()
        {
            Email aa = new Email();
            Assert.IsFalse(aa.Email_s("nidhi.com"));
        }

        [Test]
        public void passwordTest()
        {
            password aa = new password();
            Assert.IsTrue(aa.pass1("ab1nmkhA1"));
        }

        [Test]
        public void passwordTest2()
        {
            password aa = new password();
            Assert.IsFalse(aa.pass1("abc"));
        }

        [Test]
        public void password2Test()
        {
            password aa = new password();
            Assert.IsTrue(aa.pass2("ab1nmkhA1"));
        }

        [Test]
        public void password2Test2()
        {
            password aa = new password();
            Assert.IsFalse(aa.pass2("abc123casd"));
        }

        [Test]
        public void password3Test()
        {
            password aa = new password();
            Assert.IsTrue(aa.pass3("12ASQqwe45"));
        }

        [Test]
        public void password3Test2()
        {
            password aa = new password();
            Assert.IsFalse(aa.pass3("abcbnmASDc"));
        }

        [Test]
        public void password4Test()
        {
            password aa = new password();
            Assert.IsTrue(aa.pass4("12A@SQqwe45"));
        }

        [Test]
        public void password4Test2()
        {
            password aa = new password();
            Assert.IsFalse(aa.pass4("abcbn@#$mASDc"));
        }

        [Test]
        public void phoneTest()
        {
            phoneno aa = new phoneno();
            Assert.IsTrue(aa.phno("123 139 3455"));
        }

        [Test]
        public void phnoTest2()
        {
            password aa = new password();
            Assert.IsFalse(aa.pass4("9971438479"));
        }

      public static IEnumerable<TestCaseData> abc()
        {
            yield return new TestCaseData("abc.@gmail.com");
            yield return new TestCaseData("abc-100@yahoo.com");
            yield return new TestCaseData("abc.100@yahoo.com");
            yield return new TestCaseData("abc111@abc.com");
            yield return new TestCaseData("abc-100@abc.net");
            yield return new TestCaseData("abc.100@abc.com.au");
            yield return new TestCaseData("abc@1.com");
            yield return new TestCaseData("abc@gmail.com.com");
            yield return new TestCaseData("abc+100@gmail.com");
           
        }
      [Test,TestCaseSource("abc")]
      public void testemail(string ab)
        {
            Email zz = new Email();
            Assert.IsTrue(zz.Email_s(ab));
        }

        public static IEnumerable<TestCaseData> bbc()
        {
            yield return new TestCaseData("abc");
            yield return new TestCaseData("abc@.com.my");
            yield return new TestCaseData("abc123@gmail.a");
            yield return new TestCaseData("abc111@.com");
            yield return new TestCaseData("abc-100@.com.com");
            yield return new TestCaseData(".abc@abc.com");
            yield return new TestCaseData("abc@%*.com");
            yield return new TestCaseData("abc()*@gmail.com");
            yield return new TestCaseData("abc..2002@gmail.com");
            yield return new TestCaseData("abc.@gmail.com");
            yield return new TestCaseData("abc@abc@gmail.com");
            yield return new TestCaseData("abc@gmail.com.la");
            yield return new TestCaseData("abc@gmail.com.aa.au");

        }
        [Test, TestCaseSource("bbc")]
        public void testemail2(string bb)
        {
            Email zz = new Email();
            Assert.IsFalse(zz.Email_s(bb));
        }

    }
}
