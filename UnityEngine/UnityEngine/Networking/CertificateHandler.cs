using System;
using UnityEngine;

namespace UnityEngine.Networking
{

public class CertificateHandler : IDisposable
{
    protected CertificateHandler();

    public void Dispose();
    protected bool ValidateCertificate(byte[] certificateData);

}

}
