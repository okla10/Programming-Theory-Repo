using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Capsule : Parent
{

    // Update is called once per frame
    void Update()
    {
        if(MenuManager.instance.capsule)
        {
            Move();
        }
        

    }
}
