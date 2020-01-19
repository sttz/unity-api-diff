using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Playables
{

public static class PlayableOutputExtensions
{
    static public void AddNotificationReceiver<U>(U output, Playables.INotificationReceiver receiver);
    static public Playables.INotificationReceiver[] GetNotificationReceivers<U>(U output);
    static public Object GetReferenceObject<U>(U output);
    static public int GetSourceInputPort<U>(U output);
    static public int GetSourceOutputPort<U>(U output);
    static public Playables.Playable GetSourcePlayable<U>(U output);
    static public Object GetUserData<U>(U output);
    static public float GetWeight<U>(U output);
    static public bool IsOutputNull<U>(U output);
    static public bool IsOutputValid<U>(U output);
    static public void PushNotification<U>(U output, Playables.Playable origin, Playables.INotification notification, object context = null);
    static public void RemoveNotificationReceiver<U>(U output, Playables.INotificationReceiver receiver);
    static public void SetReferenceObject<U>(U output, Object value);
    static public void SetSourceInputPort<U>(U output, int value);
    static public void SetSourceOutputPort<U>(U output, int value);
    static public void SetSourcePlayable<U, V>(U output, V value);
    static public void SetSourcePlayable<U, V>(U output, V value, int port);
    static public void SetUserData<U>(U output, Object value);
    static public void SetWeight<U>(U output, float value);

}

}
