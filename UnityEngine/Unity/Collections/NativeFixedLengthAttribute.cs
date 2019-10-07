using System;
using UnityEngine;

namespace Unity.Collections
{

public sealed class NativeFixedLengthAttribute : Attribute
{
    public int FixedLength;

    public NativeFixedLengthAttribute(int fixedLength);

}

}
