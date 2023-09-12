using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Check
{
    public class Check
    {
        public int Checking(string password)
        { 
            int strength = 0;

            if (Regex.IsMatch(password, @"\d")) strength += 1;
            if (Regex.IsMatch(password, @"[a-z]")) strength += 1;
            if (Regex.IsMatch(password, @"[A-Z]")) strength += 1;
            if (Regex.IsMatch(password, @"[!@#$%^&*()]")) strength += 1;
            if (password.Length > 7) strength += 1;
            if (password.Length > 9) strength += 1;

            return strength;
        }



    }
}
