using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class FileUtil
{
    static public void CopyFileOrDirectory(string source, string dest);
    static public void CopyFileOrDirectoryFollowSymlinks(string source, string dest);
    static public bool DeleteFileOrDirectory(string path);
    static public string GetProjectRelativePath(string path);
    static public string GetUniqueTempPathInProject();
    static public void MoveFileOrDirectory(string source, string dest);
    static public void ReplaceDirectory(string src, string dst);
    static public void ReplaceFile(string src, string dst);

    public FileUtil();

}

}
