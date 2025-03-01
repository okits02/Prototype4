using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody EnemyRg;
    private GameObject player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        EnemyRg = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 loolDrirection = (player.transform.position - transform.position).normalized;
        EnemyRg.AddForce(loolDrirection * speed);
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
