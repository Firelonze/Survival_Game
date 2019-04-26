using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 0;
    public GameObject player;
    public GameObject SuperGuy;
    //private EnemyBehaviours currentBehaviour;
    private Vector3 startPos;
    //private bool run;
    //private float timer;

    // Start is called before the first frame update
    void Start()
    {
        //run = false;
        //timer = 0f;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            if (player.name == "Player")
            {
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
            }
        }
        if (!player)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime) * -2;
        }
        
        /*if (player.transform.position.x > transform.position.x)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (player.transform.position.x < transform.position.x)
        {
            transform.position += -Vector3.right * speed * Time.deltaTime;
        }
        if (player.transform.position.z > transform.position.z)
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (player.transform.position.z < transform.position.z)
        {
            transform.position += -Vector3.forward * speed * Time.deltaTime;
        }*/
    }
   /* public void Setrun(bool aStatus)
    {
        run = aStatus;
    }*/
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            transform.position = startPos;
        }
    }
}

