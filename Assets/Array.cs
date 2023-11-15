using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Array : MonoBehaviour
{
    // Start is called before the first frame update
    int[] test = new int[3];
    void Start()
    {
        test[0] = 5;
        test[1] = 5;
        test[2] = 5;
        SumArray(test);  
        print(SumArray(test));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int SumArray(int[]numArray)
    {
        int tempSum = 0;
        for(int i  = 0; i < numArray.Length; i++)
            {
            tempSum = tempSum + numArray[i];
            }
        return tempSum;
    }
}
