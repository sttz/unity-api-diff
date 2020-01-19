using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class CreateAssetMenuAttribute : Attribute
{
    public string fileName { get; set; }
    public string menuName { get; set; }
    public int order { get; set; }

    public CreateAssetMenuAttribute();

}

}
