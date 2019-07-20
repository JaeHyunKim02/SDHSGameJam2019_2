using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Block : MonoBehaviour
{
    public GameObject Wall;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collision.gameObject.transform.position.x >= 0)
            {
                Instantiate(Wall, new Vector3(2.5f, -3, 0), Quaternion.identity);
            }
            else
            {
                Instantiate(Wall, new Vector3(-2.5f, -3, 0), Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

//Instantiate(Bullet, transform.position, Quaternion.identity);