using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class SpawnManager : MonoBehaviour
{
    public GameObject PanelGameOver;
    public GameObject[] animalPrefabs;
    //public int animalIndex;
    private float spawnRangeX = 15.0f;
    private float spawnPosZ = 20.0f;
    private float startDelay = 2.0f;
    private float spawmInterval = 1.5f;
    private void OnEnable()
    {
        DetroyOutOfBounds.OnGameOver += DisPlayGameOver;
    }
    private void OnDisable()
    {
        DetroyOutOfBounds.OnGameOver -= DisPlayGameOver;
    }
    void Start()
    {
        //DetroyOutOfBounds.OnGameOver.AddListener(DisPlayGameOver);       // 세번째 방법
        PanelGameOver.SetActive(false);
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawmInterval);
    }
    void Update()
    {

    }
    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos,
        animalPrefabs[animalIndex].transform.rotation);
    }
    public void DisPlayGameOver()
    {
        PanelGameOver.SetActive(true);
        CancelInvoke("SpawnRandomAnimal");
    }
}
