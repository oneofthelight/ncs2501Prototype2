using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetroyOutOfBounds : MonoBehaviour
{
    private SpawnManager sm;
    private float topBound = 30;
    private float lowerBound = -10.0f;
    void Start()
    {
        sm = GameObject.FindGameObjectWithTag("SM").GetComponent<SpawnManager>();
    }
    void Update()
    {
        if(transform.position.z > topBound )
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            //Debug.Log("Game Over!");
            sm.DisPlayGameOver();
            Destroy(gameObject);
        }
    }
}
