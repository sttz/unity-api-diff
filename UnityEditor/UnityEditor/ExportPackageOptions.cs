using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public enum ExportPackageOptions
{
    Default = 0,
    Interactive = 1,
    Recurse = 2,
    IncludeDependencies = 4,
    IncludeLibraryAssets = 8,
}

}
