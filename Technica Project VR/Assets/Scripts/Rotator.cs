using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.5f;
    private bool rotate = true;

    // Start is called before the first frame update
    void Start()
    {
        // start rotating
        transform.Rotate(0, speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // only rotate if we're rotating
        if ( rotate )
        {
            transform.Rotate(0, speed, 0);
        }

        // change status of rotation on click
        if (Input.GetMouseButtonDown(0))
        {
            if (rotate)
            {
                rotate = false;
            }
            else
            {
                rotate = true;
            }
        }
    }

}
