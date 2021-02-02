﻿using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public clsCustomer()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string valid(string tstFirstName)
        {
            if (tstFirstName.Length < 1)
            {
                return "First name cannot be blank";
            }
            if (tstFirstName.Length > 50)
            {
                return "First name cannot be more than 50";
            }
            else
            {
                return "";
            }
        }
    }
}