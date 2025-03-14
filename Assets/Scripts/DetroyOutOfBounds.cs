using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverAction : UnityEngine.Events.UnityEvent{}
public class DetroyOutOfBounds : MonoBehaviour
{
    //private SpawnManager sm;                       // 첫번째 방법
    public delegate void GameOverHandler();          // 두번째 방법     
    public static event GameOverHandler OnGameOver;  // 두번째 방법
    //public static GameOverAction OnGameOver = new GameOverAction();    // 세번째 방법
    private float topBound = 30;
    private float lowerBound = -10.0f;
    void Start()
    {
        //sm = GameObject.FindGameObjectWithTag("SM").GetComponent<SpawnManager>();
        //sm = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
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
            //sm.DisPlayGameOver();         // 첫번째 방법
            //OnGameOver.Invoke();          // 세번째 방법
            OnGameOver();
            Destroy(gameObject);
        }
    }
}
