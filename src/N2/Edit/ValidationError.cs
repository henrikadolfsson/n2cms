﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace N2.Edit
{
    public class ValidationError
    {
        public ValidationError(string name, string message)
        {
            Name = name;
            Message = message;
        }

        public string Name { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return Message;
        }
    }
}