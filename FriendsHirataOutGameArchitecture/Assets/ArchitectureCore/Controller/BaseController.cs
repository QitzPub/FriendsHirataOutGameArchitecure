using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseController<T,T2> : MonoBehaviour, IController where T: IRepository where T2:BaseTransmitter
{

    protected abstract T Repository { get; }
    protected abstract T2 Transmitter { get; }

}
