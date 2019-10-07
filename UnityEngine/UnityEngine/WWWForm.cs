using System;
using UnityEngine;

namespace UnityEngine
{

public class WWWForm
{
    public byte[] data { get; }
    public System.Collections.Generic.Dictionary<string, string> headers { get; }

    public WWWForm();

    public void AddBinaryData(string fieldName, byte[] contents);
    public void AddBinaryData(string fieldName, byte[] contents, string fileName);
    public void AddBinaryData(string fieldName, byte[] contents, string fileName, string mimeType);
    public void AddField(string fieldName, string value);
    public void AddField(string fieldName, string value, System.Text.Encoding e);
    public void AddField(string fieldName, int i);

}

}
