using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public float speed = 20f;
    public Transform pivot;


    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(pivot.transform.position, Vector3.up, speed*Time.deltaTime);
    }
}