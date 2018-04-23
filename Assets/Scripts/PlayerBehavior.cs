using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehavior : MonoBehaviour {

    int health;
    // Use this for initialization
    void Start()
    {
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {

        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemies")
            health--;
            Destroy(collision.gameObject);
        }
    }
}
