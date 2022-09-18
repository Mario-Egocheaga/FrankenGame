using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBullet : MonoBehaviour
{
    GameObject target;
    public float speed;
    Rigidbody2D bulletRB;

    public float TimeLeft = 5;

    private void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        bulletRB.velocity = new Vector2(moveDir.x, moveDir.y);
        Destroy(this.gameObject, 2);
    }
    private void Update()
    {
        TimeLeft -= Time.deltaTime;
        if (TimeLeft < 0)
        {
            Destroy(gameObject);
        }
    }
}
