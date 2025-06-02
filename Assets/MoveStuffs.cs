using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStuffs : MonoBehaviour
{
    public float smoothTime = 0.3f;
    public float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(5f, 2f, 0f);
        
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime *speed);


       // Vector3 velocity = Vector3.zero;
       
        //transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        //float smootheness = 0.5f;
        //transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smootheness);
    }
}
