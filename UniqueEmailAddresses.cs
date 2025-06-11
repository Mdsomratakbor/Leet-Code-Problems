using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class UniqueEmailAddresses
    {
        public int NumUniqueEmails(string[] emails) {
    HashSet<string> uniqueEmails = new HashSet<string>();

    foreach (string email in emails) {
        string[] parts = email.Split('@');

        if (parts.Length != 2) 
            continue;  

        string localName = parts[0];
        string domainName = parts[1];

        if (!domainName.EndsWith(".com")) 
            continue; 

        localName = localName.Replace(".", ""); 
        localName = localName.Split('+')[0];     

        string newEmail = $"{localName}@{domainName}";
        uniqueEmails.Add(newEmail);
    }

    return uniqueEmails.Count;  
}

    }
}