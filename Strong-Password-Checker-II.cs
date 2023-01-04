using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Strong_Password_Checker_II
    {
        public bool StrongPasswordCheckerII(string password)
        {

            string regSyntax = @"^(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()+-]).*$";
            Regex re = new Regex(regSyntax);
            if (re.IsMatch(password))
            {
               for(int i=0; i<password.Length; i++)
                {
                    if(i == password.Length-1)
                        return true;
                    if (password[i] == password[i + 1])
                    {
                        return false;
                    }
                }
                return true;
            }
             
            else
                return false;
        }
    }
}
