using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public interface IBindable
{
    public Experimental.UIElements.IBinding binding { get; set; }
    public string bindingPath { get; set; }

}

}
