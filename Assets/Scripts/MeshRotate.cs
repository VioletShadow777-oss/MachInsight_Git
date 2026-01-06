using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRotate : MonoBehaviour
{
    [SerializeField] Transform Mesh;
    public float RotateSpeed = 20f;

    private float InitialRotateSpeed = 0f;
    private void Update()
    {
        Rotate_func();
    }
    private void Rotate_func()
    {
        InitialRotateSpeed = RotateSpeed * SimpleInput.GetAxis("Horizontal");
        Mesh.Rotate(Vector3.up * InitialRotateSpeed*-1 * Time.deltaTime);
    }
}
