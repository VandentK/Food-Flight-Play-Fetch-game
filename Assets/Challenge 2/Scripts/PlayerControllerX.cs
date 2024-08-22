using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timer = 3f;
            }
        }
        else
        {
            Debug.Log("Not Ready yet");
        }
    }

}
