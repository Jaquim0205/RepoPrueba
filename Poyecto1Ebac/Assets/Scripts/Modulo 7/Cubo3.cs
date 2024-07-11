using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo3 : MonoBehaviour
{
    // Start is called before the first frame update

    public Cubo1 cubo1;
    public Cubo2 cubo2;
    public bool isTrue;

    void Update()
    {
        if (cubo1.isTrue && cubo2.isTrue)
        {
            isTrue = true;
            GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {
            isTrue = false;
            GetComponent<Renderer>().material.color = Color.black;
        }
    }
    void Start()
    {
        
    }

}
