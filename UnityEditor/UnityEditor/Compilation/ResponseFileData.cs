using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Compilation
{

public class ResponseFileData
{
    public string[] Defines;
    public string[] Errors;
    public string[] FullPathReferences;
    public string[] OtherArguments;
    public bool Unsafe;

    public ResponseFileData();

}

}
