using System;
using UnityEngine;

namespace UnityEngine.Networking
{

public class MultipartFormDataSection : Networking.IMultipartFormSection
{
    public string contentType { get; }
    public string fileName { get; }
    public byte[] sectionData { get; }
    public string sectionName { get; }

    public MultipartFormDataSection(string name, byte[] data, string contentType);
    public MultipartFormDataSection(string name, byte[] data);
    public MultipartFormDataSection(byte[] data);
    public MultipartFormDataSection(string name, string data, System.Text.Encoding encoding, string contentType);
    public MultipartFormDataSection(string name, string data, string contentType);
    public MultipartFormDataSection(string name, string data);
    public MultipartFormDataSection(string data);

}

}
