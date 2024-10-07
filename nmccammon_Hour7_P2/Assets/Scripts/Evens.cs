using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sum = 22;
        int count = 2;
        while (sum < 100)
        {
            sum = sum + count;
            print(sum);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
