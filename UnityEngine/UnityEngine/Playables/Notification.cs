using System;
using UnityEngine;

namespace UnityEngine.Playables
{

public class Notification : Playables.INotification
{
    public PropertyName id { get; }

    public Notification(string name);

}

}
