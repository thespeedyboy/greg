using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalmovment : MonoBehaviour
{
    [Header("Horizontal Movment")]
    public float Speed;
    private float horizontalInput;
    void Update()
    {
        //Horizontal Movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * Speed * Time.deltaTime * horizontalInput);
    }
}
