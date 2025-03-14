using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool isIdle = true;
    // Update is called once per frame
    void Start()
    {
        
    }
    void Update()
    {
        if (isIdle)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                StartCoroutine(MakeIdle());
            }
        }
    }
    IEnumerator MakeIdle()
    {
        isIdle = false;
        yield return new WaitForSeconds(0.6f);
        isIdle = true;
    }
}
