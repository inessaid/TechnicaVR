using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour
{
    // private Getter getter;
    private Rotator rotator;
    private Forward forward;

    // Start is called before the first frame update
    void Start()
    {
        // moves the object forward
        forward = GetComponent<Forward>();

        // rotates the object
        rotator = GetComponent<Rotator>();
    }

}
