using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.IO.LowLevel.Unsafe
{

public static class VirtualFileSystem
{
    static public bool GetLocalFileSystemName(string vfsFileName, out string localFileName, out ulong localFileOffset, out ulong localFileSize);

}

}
