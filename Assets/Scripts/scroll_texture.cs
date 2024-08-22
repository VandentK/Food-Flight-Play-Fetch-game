using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll_texture : MonoBehaviour
{
    public float speedX = 5.0f;
    public float speedY = 5.0f;
    // Update is called once per frame
    void Update()
    {
        float offsetY = Time.time * speedX;
        float offsetX = Time.time * speedY;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}
