using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingManager : MonoBehaviour
{
    public BoxCollider2D poolingCollider;
    public CircleCollider2D playerGroundCollider;

    public GameObject next;
    public GameObject previous;
    public GameObject curntEnvironment;
    public GameObject availableEnvironment;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Physics2D.IgnoreCollision(poolingCollider, playerGroundCollider,true);
        if (collision.CompareTag("Player"))
        {
            print("Player Enter");
            next.SetActive(true);
            previous.SetActive(true);

            curntEnvironment = gameObject;

            availableEnvironment.SetActive(false);
            availableEnvironment.GetComponent<PoolingManager>().next.SetActive(false);
            availableEnvironment.GetComponent<PoolingManager>().previous.SetActive(false);
        }
    }
}
