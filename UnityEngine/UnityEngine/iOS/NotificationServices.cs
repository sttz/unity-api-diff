using System;
using UnityEngine;

namespace UnityEngine.iOS
{

public sealed class NotificationServices
{
    static public byte[] deviceToken { get; }
    static public iOS.NotificationType enabledNotificationTypes { get; }
    static public int localNotificationCount { get; }
    static public iOS.LocalNotification[] localNotifications { get; }
    static public string registrationError { get; }
    static public int remoteNotificationCount { get; }
    static public iOS.RemoteNotification[] remoteNotifications { get; }
    static public iOS.LocalNotification[] scheduledLocalNotifications { get; }

    static public void CancelAllLocalNotifications();
    static public void CancelLocalNotification(iOS.LocalNotification notification);
    static public void ClearLocalNotifications();
    static public void ClearRemoteNotifications();
    static public iOS.LocalNotification GetLocalNotification(int index);
    static public iOS.RemoteNotification GetRemoteNotification(int index);
    static public void PresentLocalNotificationNow(iOS.LocalNotification notification);
    static public void RegisterForNotifications(iOS.NotificationType notificationTypes);
    static public void RegisterForNotifications(iOS.NotificationType notificationTypes, bool registerForRemote);
    static public void ScheduleLocalNotification(iOS.LocalNotification notification);
    static public void UnregisterForRemoteNotifications();

    public NotificationServices();

}

}
