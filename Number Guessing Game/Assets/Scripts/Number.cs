using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
   public int guess; 
   public int minValue = 1; 
   public int maxValue = 10;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to our Numbah Guessing Game.");
        Debug.Log("The number range is from " + minValue + "and" + maxValue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
