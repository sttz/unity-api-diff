using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class WWWForm
{
    public byte[] data { get; }
    public Dictionary<string, string> headers { get; }

    public WWWForm();

    public void AddBinaryData(string fieldName, byte[] contents);
    public void AddBinaryData(string fieldName, byte[] contents, string fileName);
    public void AddBinaryData(string fieldName, byte[] contents, string fileName, string mimeType);
    public void AddField(string fieldName, int i);
    public void AddField(string fieldName, string value);
    public void AddField(string fieldName, string value, System.Text.Encoding e);

}

}
