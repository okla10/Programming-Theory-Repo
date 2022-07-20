using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour
{
    protected void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    // ABSTRACTION
    protected virtual void Move()
    {
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * 0.01f);
    }
}
