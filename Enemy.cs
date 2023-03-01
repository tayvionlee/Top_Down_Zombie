using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class Enemy : ScriptableObject
{

    public Enemy Instance;
    void Awake() => Instance = this;



   [SerializeField] float damage;
   [SerializeField] Image healthBar;
   // [SerializeField] GameObject gamePrefab;
   
}