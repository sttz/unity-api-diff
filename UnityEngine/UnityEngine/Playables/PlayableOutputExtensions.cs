using System;
using UnityEngine;

namespace UnityEngine.Playables
{

public static class PlayableOutputExtensions
{
    static public void AddNotificationReceiver(U output, Playables.INotificationReceiver receiver);
    static public Playables.INotificationReceiver[] GetNotificationReceivers(U output);
    static public Object GetReferenceObject(U output);
    static public int GetSourceInputPort(U output);
    static public int GetSourceOutputPort(U output);
    static public Playables.Playable GetSourcePlayable(U output);
    static public Object GetUserData(U output);
    static public float GetWeight(U output);
    static public bool IsOutputNull(U output);
    static public bool IsOutputValid(U output);
    static public void PushNotification(U output, Playables.Playable origin, Playables.INotification notification, object context = null);
    static public void RemoveNotificationReceiver(U output, Playables.INotificationReceiver receiver);
    static public void SetReferenceObject(U output, Object value);
    static public void SetSourceInputPort(U output, int value);
    static public void SetSourceOutputPort(U output, int value);
    static public void SetSourcePlayable(U output, V value);
    static public void SetSourcePlayable(U output, V value, int port);
    static public void SetUserData(U output, Object value);
    static public void SetWeight(U output, float value);

}

}
