using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Game Events")]
public class GameEvents : ScriptableObject

{
    #region Event

    // store list of objects that listen for new events
    HashSet<GameEventListener> _listeners = new HashSet<GameEventListener>();

    public void Invoke()
    {
        foreach (var globalEventListerner in _listeners)
            globalEventListerner.RaiseEvent();

    }

    // 
    public void Register(GameEventListener gameEventListener) => _listeners.Add(gameEventListener);
    public void Deregister(GameEventListener gameEventListener) => _listeners.Remove(gameEventListener);
    #endregion

}
