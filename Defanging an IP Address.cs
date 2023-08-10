using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Defanging_an_IP_Address
    {
        public string DefangIPaddr(string address)
        {
        
            StringBuilder stringBuilder = new StringBuilder();
            for(int i=0; i<address.Length; i++)
            {
                
                if (address[i] == '.')
                {

                    stringBuilder.Append("[.]");

                } 
                else
                {
                    stringBuilder.Append(address[i]);
                }
             
            }


            return stringBuilder.ToString() ;
        }
    }
}
