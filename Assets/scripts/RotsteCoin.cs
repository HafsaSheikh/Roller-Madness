using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotsteCoin : MonoBehaviour
{
    public float speed = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * speed);
        
    }
}
