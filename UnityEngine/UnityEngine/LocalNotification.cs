using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class LocalNotification
{
    static public string defaultSoundName { get; }

    public string alertAction { get; set; }
    public string alertBody { get; set; }
    public string alertLaunchImage { get; set; }
    public int applicationIconBadgeNumber { get; set; }
    public DateTime fireDate { get; set; }
    public bool hasAction { get; set; }
    public CalendarIdentifier repeatCalendar { get; set; }
    public CalendarUnit repeatInterval { get; set; }
    public string soundName { get; set; }
    public string timeZone { get; set; }
    public IDictionary userInfo { get; set; }

    public LocalNotification();

}

}
