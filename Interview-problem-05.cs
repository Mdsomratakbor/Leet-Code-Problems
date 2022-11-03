using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Interview_problem_05
    {


    }

    public class Clinician{
        public string name;
        public string hospitalName;
        public bool Login(string userName, string password)
        {
            if (IsSessionExists(userName))
                return true;
            else
                return false;
        }

        private bool IsSessionExists(string userName)
        {
            return true;
        }

        }
    public class Doctor : Clinician
    {
        public string practiceNumber;

        public void CreatePrescription(int patientNumber)
        {

        }
    }
    public class Pharmacist : Clinician
    {
        public string pharmacistNumber;
        public void dispenseMedications(string prescriptionNumber)
        {

        }
    }
}
