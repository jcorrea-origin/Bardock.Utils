﻿using System.ComponentModel.DataAnnotations;
namespace Bardock.Utils.UnitTest.Samples.SUT.DTOs
{
    public class CustomerCreate
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        [EmailAddress]
        public string frita { get; set; }

        public int StatusID { get; set; }
    }
}