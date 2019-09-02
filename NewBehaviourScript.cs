using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public void Multiply(int a, int b)
        {
       int c = a * b;
        Debug.Log(c);
        }
    // Start is called before the first frame update
    void Start()
    {
        Multiply(25, 8);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
