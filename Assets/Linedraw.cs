using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linedraw : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pointA = new Vector3(0, 0, 0);
        Vector3 pointB = new Vector3(1, 0, 0);
        Debug.DrawLine(transform.position + pointA, transform.position + pointB, Color.magenta);

        
    }
}
