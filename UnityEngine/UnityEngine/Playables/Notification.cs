using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Playables
{

public class Notification : Playables.INotification
{
    public PropertyName id { get; }

    public Notification(string name);

}

}
