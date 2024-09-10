﻿using System.Security.Claims;

namespace CMCS.Models
{
    public class Lecturer
    {
        public int LecturerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }

        public List<Claim> Claims { get; set; }
    }
}