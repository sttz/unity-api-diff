using System;
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
