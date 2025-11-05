using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using TMPro;

public class health : MonoBehaviour
{
    public int hp = 100;
    public GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Die();
        }
    }
    
    void Die()
    {
        Instantiate(deathEffect,transform.position, quaternion.identity);
        Destroy(gameObject);
        GameManager.instance.AddScore(1);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
