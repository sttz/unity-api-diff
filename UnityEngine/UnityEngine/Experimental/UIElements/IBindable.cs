using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public interface IBindable
{
    public Experimental.UIElements.IBinding binding { get; set; }
    public string bindingPath { get; set; }

}

}
