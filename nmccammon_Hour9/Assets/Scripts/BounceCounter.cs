using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int bounces = 0;
    void OnCollisionEnter(Collision collision)
    {
        bounces = bounces + 1;
        print("Bounces: " + bounces);
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
