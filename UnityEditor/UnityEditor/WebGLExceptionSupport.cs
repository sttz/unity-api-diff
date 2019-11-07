using System;
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
