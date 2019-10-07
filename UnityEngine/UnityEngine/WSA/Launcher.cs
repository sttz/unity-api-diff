using System;
using UnityEngine;

namespace UnityEngine.WSA
{

public sealed class Launcher
{
    static public void LaunchFile(WSA.Folder folder, string relativeFilePath, bool showWarning);
    static public void LaunchFileWithPicker(string fileExtension);
    static public void LaunchUri(string uri, bool showWarning);

    public Launcher();

}

}
