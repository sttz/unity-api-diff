using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public static class AssemblyReloadEvents
{
    static public event AssemblyReloadCallback afterAssemblyReload;
    static public event AssemblyReloadCallback beforeAssemblyReload;

    public delegate void AssemblyReloadCallback();

}

}
