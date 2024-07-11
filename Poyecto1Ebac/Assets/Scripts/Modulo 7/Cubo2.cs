using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo2 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isTrue = false;

    void FixedUpdate()
    {
        isTrue = !isTrue;
        if (isTrue)
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
