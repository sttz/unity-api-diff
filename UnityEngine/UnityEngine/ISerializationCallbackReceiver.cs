using System;
using UnityEngine;

namespace UnityEngine
{

public interface ISerializationCallbackReceiver
{
    public void OnAfterDeserialize();
    public void OnBeforeSerialize();

}

}
