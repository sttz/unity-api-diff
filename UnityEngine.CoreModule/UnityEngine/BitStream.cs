using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class BitStream
{
    public bool isReading { get; }
    public bool isWriting { get; }

    public BitStream();

    public void Serialize(bool value);
    public void Serialize(char value);
    public void Serialize(short value);
    public void Serialize(int value);
    public void Serialize(float value);
    public void Serialize(NetworkPlayer value);
    public void Serialize(Quaternion value);
    public void Serialize(Vector3 value);
    public void Serialize(NetworkViewID viewID);
    public void Serialize(float value, float maxDelta);
    public void Serialize(Quaternion value, float maxDelta);
    public void Serialize(Vector3 value, float maxDelta);

}

}
