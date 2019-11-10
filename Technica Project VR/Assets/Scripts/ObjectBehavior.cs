using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour
{
    // private Getter getter;
    private Rotator rotator;

    // Start is called before the first frame update
    void Start()
    {
        // pulls the object out
        // getter = GetComponent<Getter>();

        // rotates the object
        rotator = GetComponent<Rotator>();
    }

}
