using System;
using System.Collections.Generic;
using System.Text;

namespace EasyToml
{
    public enum TomlValueKind : byte
    {
        Undefined,
        Object,
        Array,
        String,
        Number,
        True,
        False,
        Null
    }
}
