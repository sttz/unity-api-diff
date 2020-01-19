using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class LocationService
{
    public bool isEnabledByUser { get; }
    public LocationInfo lastData { get; }
    public LocationServiceStatus status { get; }

    public LocationService();

    public void Start();
    public void Start(float desiredAccuracyInMeters);
    public void Start(float desiredAccuracyInMeters, float updateDistanceInMeters);
    public void Stop();

}

}
