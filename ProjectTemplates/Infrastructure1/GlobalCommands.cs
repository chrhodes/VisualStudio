﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Commands;

namespace Infrastructure1
{
    public static class GlobalCommands
    {
        public static CompositeCommand SaveAllCommand = new CompositeCommand();
    }
}
