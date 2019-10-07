using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface IUxmlAttributes
{
    public bool TryGetAttributeValue(string attributeName, out string value);

}

}
