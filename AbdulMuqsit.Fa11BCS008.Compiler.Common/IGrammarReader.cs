﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler.Common
{
    public interface IGrammarReader
    {
        IGrammar Read(string @string);

    }
}
