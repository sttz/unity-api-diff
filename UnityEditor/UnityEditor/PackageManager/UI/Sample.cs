using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.PackageManager.UI
{

public struct Sample
{
    static public IEnumerable<UnityEditor.PackageManager.UI.Sample> FindByPackage(string packageName, string packageVersion);

    public string description { get; private set; }
    public string displayName { get; private set; }
    public string importPath { get; private set; }
    public bool interactiveImport { get; private set; }
    public bool isImported { get; }
    public string resolvedPath { get; private set; }

    public bool Import(ImportOptions options = 0);

    public enum ImportOptions
    {
        None = 0,
        OverridePreviousImports = 1,
        HideImportWindow = 2,
    }

}

}
