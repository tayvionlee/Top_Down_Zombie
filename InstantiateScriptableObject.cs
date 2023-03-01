using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InstantiateScriptableObject : MonoBehaviour
{
    public Enemy _enemySpawned;

    public InstantiateScriptableObject _Instance;
    void Awake() => _Instance = this;

    Enemy enemy = ScriptableObject.CreateInstance<Enemy>();


    void Start()
    {
        // casting the enemy 
        _enemySpawned = (Enemy)ScriptableObject.CreateInstance(typeof(Enemy));
        ScriptableObject.Destroy(_enemySpawned, 0);
        Debug.Log("");
    }


    void DoSomething()
    {
        Enemy.CreateInstance(typeof(Enemy));
        
    }

    void OnMove(InputAction.CallbackContext context)
    {

    }

}
