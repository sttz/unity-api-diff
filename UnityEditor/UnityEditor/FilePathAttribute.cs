using System;
using UnityEngine;

namespace UnityEditor
{

public class FilePathAttribute : Attribute
{
    public FilePathAttribute(string relativePath, Location location);

    public enum Location
    {
        PreferencesFolder = 0,
        ProjectFolder = 1,
    }

}

}
