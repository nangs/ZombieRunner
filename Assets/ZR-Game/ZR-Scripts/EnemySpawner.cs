//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class EnemySpawner : MonoBehaviour
//{

//    public GameObject[] attackerPrefabArray;
//    [Tooltip("Average number of seconds between appearances")]
//    public float seenEverySeconds;
//    public Attacker attacker;

//    // Update is called once per frame
//    void Update()
//    {
//        foreach (GameObject thisAttacker in attackerPrefabArray)
//        {
//            if (IsTimeToSpawn(thisAttacker))
//            {
//                Spawn(thisAttacker);
//            }
//        }
//    }

//    void Spawn(GameObject myGameObject)
//    {
//        GameObject myAttacker = Instantiate(myGameObject) as GameObject;
//        myAttacker.transform.parent = transform;
//        myAttacker.transform.position = transform.position;
//    }

//    bool IsTimeToSpawn(GameObject attackerGameObject)
//    {
//        Attacker attacker = attackerGameObject.GetComponent<Attacker>();

//        float meanSpawnDelay = attacker.seenEverySecond;
//        float spawnsPerSecond = 1 / meanSpawnDelay;

//        if (Time.deltaTime > meanSpawnDelay)
//        {
//            Debug.LogWarning("Spwan rate capped by frame rate");
//        }

//        float threshold = spawnsPerSecond * Time.deltaTime / 5;

//        if (Random.value < threshold)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//}
