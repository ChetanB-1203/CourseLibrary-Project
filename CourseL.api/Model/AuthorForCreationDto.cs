﻿using System.ComponentModel.DataAnnotations;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseL.api.Model
{
    public class AuthorForCreationDto
    {
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

        
        public DateTimeOffset DateOfBirth { get; set; }

       
        public string MainCategory { get; set; }

        public ICollection<CourseForCreationForDto> Courses { get; set; }= new List<CourseForCreationForDto>(); 
    }
}