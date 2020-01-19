using System;
using System.Collections;
using System.Collections.Generic;
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
