using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NUnitTestProject1
{
    class password
    {

        public bool pass1(String pas1)
        {
            string pat = @"^[a-zA-Z0-9]{8,}$";
            if (Regex.IsMatch(pas1, pat))
                return true;
            else
                Console.WriteLine("Invalid password");
            return false;
        }

        public bool pass2(String pas2)
        {
            string pat = @"^((?=.*[A-Z])([a-zA-Z0-9]){8,})$";
            if (Regex.IsMatch(pas2, pat))
                return true;
            else
                Console.WriteLine("Invalid password");
            return false;

        }
        public bool pass3(String pas3)
        {
            string pat = @"^((?=.*[0-9])([a-zA-Z0-9]){8,})$";
            if (Regex.IsMatch(pas3, pat))
                return true;
            else
                Console.WriteLine("Invalid password");
            return false;

        }

        public bool pass4(String pas4)
        {
            string pat = @"^.*(?=.{8,})(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!*#@3$%^&+=]).*$";
            if (Regex.IsMatch(pas4, pat))
                return true;
            else
                Console.WriteLine("Invalid password");
            return false;

        }

    }
}
