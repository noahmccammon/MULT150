using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sum = 0;
        while (sum < 31)
        {
            sum = sum + 1;
            if (sum == 13)
            {
                print("It's my birthday!");
            }
            else
            {
                print(sum);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
