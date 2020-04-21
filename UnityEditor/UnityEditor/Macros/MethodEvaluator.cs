using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Macros
{

public static class MethodEvaluator
{
    static public object Eval(string assemblyFile, string typeName, string methodName, Type[] paramTypes, object[] args);
    static public object ExecuteExternalCode(string parcel);

}

}
