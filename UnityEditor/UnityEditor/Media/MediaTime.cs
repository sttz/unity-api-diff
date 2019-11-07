using System;
using UnityEngine;

namespace UnityEditor.Media
{

public struct MediaTime
{
    static public UnityEditor.Media.MediaTime Invalid;

    public long count { get; set; }
    public UnityEditor.Media.MediaRational rate { get; set; }

    public MediaTime(long seconds);
    public MediaTime(long count, uint rateNumerator, uint rateDenominator = 1);

}

}
