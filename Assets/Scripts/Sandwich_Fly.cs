using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Sandwich_Fly : MonoBehaviour
{
    [SerializeField]
    private float Speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if(transform.position.z > 20)
        {
            Destroy(gameObject);
        }
    }
}
