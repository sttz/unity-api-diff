using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Windows
{

public static class Directory
{
    static public string localFolder { get; }
    static public string roamingFolder { get; }
    static public string temporaryFolder { get; }

    static public void CreateDirectory(string path);
    static public void Delete(string path);
    static public bool Exists(string path);

}

}
