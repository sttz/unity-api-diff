using System;
using UnityEngine;

namespace UnityEngine
{

public class LocationService
{
    public bool isEnabledByUser { get; }
    public LocationInfo lastData { get; }
    public LocationServiceStatus status { get; }

    public LocationService();

    public void Start(float desiredAccuracyInMeters, float updateDistanceInMeters);
    public void Start(float desiredAccuracyInMeters);
    public void Start();
    public void Stop();

}

}
