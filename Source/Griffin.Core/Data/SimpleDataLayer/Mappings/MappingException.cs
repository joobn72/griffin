﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Griffin.Core.Data.SimpleDataLayer.Mappings
{
    class MappingException : Exception
    {
        public MappingException(string message, Type mappedType, string propertyName)
        {
            
        }
    }
}
