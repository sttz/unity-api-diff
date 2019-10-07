using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class Ping
{
    public string ip { get; }
    public bool isDone { get; }
    public int time { get; }

    public Ping(string address);

    public void DestroyPing();

}

}
