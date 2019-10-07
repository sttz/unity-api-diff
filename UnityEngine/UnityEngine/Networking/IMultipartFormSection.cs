using System;
using UnityEngine;

namespace UnityEngine.Networking
{

public interface IMultipartFormSection
{
    public string contentType { get; }
    public string fileName { get; }
    public byte[] sectionData { get; }
    public string sectionName { get; }

}

}
