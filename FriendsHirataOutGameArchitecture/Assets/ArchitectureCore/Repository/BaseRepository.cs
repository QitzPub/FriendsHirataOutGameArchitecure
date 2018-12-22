using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRepository
{
}

public abstract class BaseRepository<T> : MonoBehaviour, IRepository where T:BaseDataStore
{
    protected abstract T DataStore { get; }
}
