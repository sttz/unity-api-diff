using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking
{

public class MultipartFormFileSection : Networking.IMultipartFormSection
{
    public string contentType { get; }
    public string fileName { get; }
    public byte[] sectionData { get; }
    public string sectionName { get; }

    public MultipartFormFileSection(byte[] data);
    public MultipartFormFileSection(string data, string fileName);
    public MultipartFormFileSection(string fileName, byte[] data);
    public MultipartFormFileSection(string data, System.Text.Encoding dataEncoding, string fileName);
    public MultipartFormFileSection(string name, string data, System.Text.Encoding dataEncoding, string fileName);
    public MultipartFormFileSection(string name, byte[] data, string fileName, string contentType);

}

}
