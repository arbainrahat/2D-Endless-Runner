using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Previous : MonoBehaviour
{
    public PoolingManager pool;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Physics2D.IgnoreCollision(pool.poolingCollider, pool.playerGroundCollider, true);
        if (collision.CompareTag("Player"))
        {
            pool.availableEnvironment.SetActive(true);
            pool.availableEnvironment.transform.position = new Vector3(pool.curntEnvironment.transform.position.x - 65.81f, 0f, 0f);
        }
    }
}
