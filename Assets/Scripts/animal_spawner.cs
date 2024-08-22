using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class animal_spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] animalList;

    [SerializeField]
    private float spawnX = 15.0f;
    [SerializeField]
    private float spawnZ = 18.0f;

    [SerializeField]
    private float waitingToSpawn = 2.0f;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine("SpawnRoutine");
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            float x = Random.Range(-spawnX, spawnX);

            int randomAnimal = Random.Range(0, animalList.Length);

            Instantiate(animalList[randomAnimal], new Vector3(x, 0, spawnZ), animalList[randomAnimal].transform.rotation);
            yield return new WaitForSeconds(waitingToSpawn);

        }
    }
}
