using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class ProgressItem
{
    public bool cancellable { get; }
    public string description { get; }
    public float elapsedTime { get; }
    public bool finished { get; }
    public int id { get; internal set; }
    public bool indefinite { get; }
    public string name { get; }
    public UnityEditor.ProgressOptions options { get; }
    public int parentId { get; }
    public float progress { get; }
    public bool responding { get; }
    public bool running { get; }
    public DateTime startTime { get; }
    public UnityEditor.ProgressStatus status { get; }
    public DateTime updateTime { get; }

    public bool Cancel();

}

}
