﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMapper.Exceptions
{
    public class EntityDoesNotExistException : ServiceProviderException
    {
        public EntityDoesNotExistException(String message) : base(message)
        {

        }
    }
}
