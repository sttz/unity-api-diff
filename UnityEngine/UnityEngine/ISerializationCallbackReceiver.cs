using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public interface ISerializationCallbackReceiver
{
    public void OnAfterDeserialize();
    public void OnBeforeSerialize();

}

}
