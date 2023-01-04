using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class ValidIPAddressChecker
    {
        public string ValidIPAddress(string queryIP)
        {


            var data = queryIP.Split(new Char[] { '.', ':' });
            if (data.Length == 4)
            {
                return IsValidIpV4(data);
            }
            if (data.Length == 8)
            {
                return IsValidIpV6(data);
            }
            return "Neither";
        }
        public bool HexaNumberCheck(string data)
        {
            foreach (char c in data)
            {
                if ((c >= '0' && c <= '9') ||
                        (c >= 'a' && c <= 'f') ||
                        (c >= 'A' && c <= 'F'))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public string IsValidIpV4(string[] data)
        {
            for (int i = 0; i < 4; i++)
            {
                int number = 0;
                if (data[i].StartsWith('0') && data[i].Length > 1)
                {
                    return "Neither";
                }
                if (!Int32.TryParse(data[i], out number))
                {
                    return "Neither";
                }
                if (number > 255 || number < 0)
                {
                    return "Neither";
                }
            }
            return "IPv4";
        }
        public string IsValidIpV6(string[] data)
        {
            for (int i = 0; i < 8; i++)
            {
                if (data[i].Length < 1 || data[i].Length > 4)
                {
                    return "Neither";
                }
                if (!HexaNumberCheck(data[i]))
                {
                    return "Neither";
                }

            }
            return "IPv6";
        }
    }
}
