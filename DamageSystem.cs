using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class DamageSystem : ScriptableObject
{

    /* REWORK
     if zombies touch you, you should be dead
     You can either increase the damage of the enemy
     or you can decrease the max health of the enemy
     */

    public Image healthBar;
    public float currentHealth;
    private float maxHealth = 100f;


    void Damage(float damage)
    {
        // current health = health - damage
        currentHealth -= damage;
        healthBar.fillAmount = currentHealth;
        
    }

    // player doesn't heal by themselves, needs points from enemies to do that
    public void Healing(float healPoints)
    {
        currentHealth += healPoints;
        currentHealth = Mathf.Clamp(currentHealth, 0, 100);

        healthBar.fillAmount = currentHealth / 0;
    }
}
