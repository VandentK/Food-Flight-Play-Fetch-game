using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private float Horizontal_Input;

    [SerializeField]
    private float Speed = 10.0f;
    public float Xrange = 10.0f;
    // Start is called before the first frame update

    [SerializeField]
    private GameObject sandwich;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -Xrange)
        {
            transform.position = new Vector3(-Xrange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > Xrange)
        {
            transform.position = new Vector3(Xrange, transform.position.y, transform.position.z);
        }

        Horizontal_Input = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Horizontal_Input * Time.deltaTime * Speed);

        if (Input.GetButtonDown("Jump")){
            Instantiate(sandwich, transform.position, sandwich.transform.rotation);
        }
    }

    
}
