using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Parent
{

    // Update is called once per frame
    void Update()
    {
        if (MenuManager.instance.cube)
        {
            Move();
        }
    }
    //POLYMORPHISM
    protected override void Move()
    {
        transform.Rotate(0, 0.1f, 0);
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * 0.01f);
    }
}
