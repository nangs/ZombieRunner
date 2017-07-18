using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attacker : MonoBehaviour
{
    //[Tooltip("Average number of seconds between appearances")]
    //public float seenEverySecond = 10f;
    public int Health { get { return health; } }

    private int health = 100;
    private int maxHealth = 100;
    private Image healthBar;
    //private GameObject currentTarget;


    // Use this for initialization
    void Start()
    {
        healthBar = transform.Find("Enemy Health Bar").Find("HealthBG").Find("Health").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        //seenEverySecond = 10f;
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

    public void Hit (int damage)
    {
        health -= damage;
        healthBar.fillAmount = (float)health / (float)maxHealth;
    }
}
