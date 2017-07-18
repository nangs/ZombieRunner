using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    public int Health { get { return health; } }

    public int damage = 10;
    public int health = 100;
    public int maxHealth = 100;
    public Image healthBar;



    // Use this for initialization
    void Start()
    {
        healthBar = transform.Find("Enemy Health Bar").Find("HealthBG").Find("Health").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void OnTriggerEnter2D()
    //{
    //    Debug.Log(name + " trigger enter");
    //}

    // Called from the animator at time of actual blow
    //public void StrikeCurrentTarget(float damage)
    //{
    //    if (currentTarget)
    //    {
    //        Health health = currentTarget.GetComponent<Health>();
    //        if (health)
    //        {
    //            health.DealDamage(damage);
    //        }
    //    }
    //}

    //public void Attack(GameObject obj)
    //{
    //    currentTarget = obj;
    //}

    public void Hit(int damage)
    {
        health -= damage;
        healthBar.fillAmount = (float)health / (float)maxHealth;
        if(health <= 0)
        {
            DestroyObject();
        }
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
