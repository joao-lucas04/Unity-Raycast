using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visao : MonoBehaviour
{
    float sensiblidade = 1f;
    float mouseX = 0f;
    float mouseY = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * sensiblidade;
        mouseY -= Input.GetAxis("Mouse Y") * sensiblidade;

        transform.eulerAngles = new Vector3(mouseY,mouseX,0);
    }
}
