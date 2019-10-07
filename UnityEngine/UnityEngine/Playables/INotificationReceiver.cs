using System;
using UnityEngine;

namespace UnityEngine.Playables
{

public interface INotificationReceiver
{
    public void OnNotify(Playables.Playable origin, Playables.INotification notification, object context);

}

}
