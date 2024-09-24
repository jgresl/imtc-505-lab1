using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public float Speed;
    public Transform Target;

    // Update is called once per frame
    void Update()
    {
        Debug.Log("updating earth position");
        transform.RotateAround(Target.position, Vector3.up, Speed * Time.deltaTime);
    }
}