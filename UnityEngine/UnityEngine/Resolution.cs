using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct Resolution
{
    public int height { get; set; }
    public int refreshRate { get; set; }
    public int width { get; set; }

    public string ToString();

}

}
