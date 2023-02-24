using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemys;

    [SerializeField] private float timeSpawn;

    [SerializeField] private Transform spawnPos;

    private void Start()
    {
        Instantiate(enemys[Random.Range(0, enemys.Length)], spawnPos.transform.position, Quaternion.identity);
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(timeSpawn);

        Instantiate(enemys[Random.Range(0, enemys.Length)], spawnPos.transform.position, Quaternion.identity);

        StartCoroutine(Spawn());
    }
}
