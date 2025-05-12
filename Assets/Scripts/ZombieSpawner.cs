using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject ZombiePrefab;
    public List<GameObject> zombieList;

    public void SpawnZombies(int zombieCount)
    {
        for (int i = 0; i < zombieCount; i++)
        {
            var ZombieGameObject = Instantiate(ZombiePrefab, transform.position, Quaternion.identity);
            zombieList.Add(ZombieGameObject);
            ZombieGameObject.GetComponent<Zombie>().target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
}
