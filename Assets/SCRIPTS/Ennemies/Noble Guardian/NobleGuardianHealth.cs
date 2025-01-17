using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NobleGuardianHealth : MonoBehaviour
{
    //public event Action OnDeath;

    ////////// * Variables publiques * \\\\\\\\\\

    public GameObject nobleGuardian;

    public SpriteRenderer graphics;

    public BaseEnemy baseEnemy;

    public int maxHealth = 100, currentHealth;

    public bool isInvicible = false, isAlive = true;

    ////////// * Variables priv�es * \\\\\\\\\\

    //private BasicGuardian basicGuardian;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        //healthBar.SetMaxHealth(maxhealth);
    }

    private void Update()
    {
        if (NobleGuardianAttack.instance != null)
        {
            NobleGuardianAttack.instance.UpdateStats();
        }
    }

    public void TakeDamages(int _damage)
    {
        if (isAlive)
        {
            currentHealth -= _damage;
        }

        if (currentHealth <= 0)
        {
            isAlive = false;
            Die();
        }
    }

    public void Die()
    {
        baseEnemy.TriggerOnDeath();
        nobleGuardian.SetActive(false); // Assuming you want to deactivate the enemy
    }

}
