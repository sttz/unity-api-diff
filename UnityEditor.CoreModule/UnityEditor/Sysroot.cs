using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public abstract class Sysroot
{
    public string HostArch { get; }
    public string HostPlatform { get; }
    public string Name { get; }
    public string TargetArch { get; }
    public string TargetPlatform { get; }

    protected Sysroot();

    public IEnumerable<string> GetIl2CppArguments();
    public bool Initialize();

}

}
