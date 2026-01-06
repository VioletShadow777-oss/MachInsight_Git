using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeRotate : MonoBehaviour
{
    [SerializeField] Transform Blade;
    public float RotateSpeed = 30f;
    void Start()
    {
        
    }

   void Update()
    {
        Blade.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
    }
}
