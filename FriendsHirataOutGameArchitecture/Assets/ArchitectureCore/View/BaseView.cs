using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseView : MonoBehaviour,IView
{
    public abstract void Initialize(IVO ivo = null);
}
