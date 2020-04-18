using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace NUnitTestProject1
{
    class userregistration
    {
      

public bool Firstname(string fname)
        {
            string pat = @"\b[A-Z]\w*\b{2,}$";
            if(Regex.IsMatch(fname, pat))
                return true;
            else
                Console.WriteLine("Name should be more then 3 char");
                return false;
            
        }



public bool Lastname(string lname)
        {
            string pat = @"\b[A-Z]\w*\b{2,}$";
            if(Regex.IsMatch(lname, pat))
            return true;
            else
            Console.WriteLine("lastName should be more then 3 char");
            return false;

        }

 public bool Email_s(string email)
        {
            
            string pat = @"^[a-z]{3,}([._+\-][a-z0-9]*)?[@]{1}[a-z]{2,}[.]{1}[a-z]{2,4}(\.[a-z]{2})?$";
            if (Regex.IsMatch(email, pat))
                return true;
            else
                Console.WriteLine("Enter the valid input");
            return false;

        }

 public bool phno(String phnum)
        {
            string pat = @"^(?<AreaCode>\d{3})(?!\d)";
            if (Regex.IsMatch(phnum, pat))
                return true;
            else
                Console.WriteLine("Invalid password");
            return false;

        }

     }

 }

