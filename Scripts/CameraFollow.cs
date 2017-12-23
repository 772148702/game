using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5f;
    Vector3 offset;
    // Use this for initializationC
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v1 = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, v1, smoothing * Time.deltaTime);
    }
}
