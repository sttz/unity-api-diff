using System;
using UnityEngine;

namespace UnityEngine.Networking
{

public class MultipartFormFileSection : Networking.IMultipartFormSection
{
    public string contentType { get; }
    public string fileName { get; }
    public byte[] sectionData { get; }
    public string sectionName { get; }

    public MultipartFormFileSection(string name, byte[] data, string fileName, string contentType);
    public MultipartFormFileSection(byte[] data);
    public MultipartFormFileSection(string fileName, byte[] data);
    public MultipartFormFileSection(string name, string data, System.Text.Encoding dataEncoding, string fileName);
    public MultipartFormFileSection(string data, System.Text.Encoding dataEncoding, string fileName);
    public MultipartFormFileSection(string data, string fileName);

}

}
