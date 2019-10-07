using System;
using UnityEngine;

namespace UnityEngine.Windows
{

public static class File
{
    static public void Delete(string path);
    static public bool Exists(string path);
    static public byte[] ReadAllBytes(string path);
    static public void WriteAllBytes(string path, byte[] bytes);

}

}
