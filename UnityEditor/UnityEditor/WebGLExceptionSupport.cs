using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public enum WebGLExceptionSupport
{
    None = 0,
    ExplicitlyThrownExceptionsOnly = 1,
    FullWithoutStacktrace = 2,
    FullWithStacktrace = 3,
}

}
