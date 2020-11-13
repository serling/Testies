using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RuntimeSet<T> : ScriptableObject
{
    public List<T> Items = new List<T>();

    public void Add (T type) 
    {
        if (!Items.Contains(type)) Items.Add(type);
    }

    public void Remove (T type) 
    {
        if (Items.Contains(type)) Items.Remove(type);
    }

    public T getRandom() {
        return Items[Random.Range(0, Items.Count)];
    }

    public int Count ()
    {
        return Items.Count;
    }
}
