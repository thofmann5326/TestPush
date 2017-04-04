﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISCAPLibrary;

namespace ISCAP.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
        }

    }
}

