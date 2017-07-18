using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{

    public float speed = 10f;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed);
    }

    void OnTriggerEnter (Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            collider.gameObject.GetComponent<Enemy>().Hit(10);
            Debug.Log("Hit enemy");
        }
    }
}
