using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    public GameObject enemy;
    public float spawnTime = 3f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("spawnEnemy", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnEnemy()
    {
        var newBall = GameObject.Instantiate(enemy);
    }
}
