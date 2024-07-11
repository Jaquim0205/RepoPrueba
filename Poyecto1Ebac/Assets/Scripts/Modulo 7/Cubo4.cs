using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo4 : MonoBehaviour
{
    // Start is called before the first frame update

    public Cubo1 cubo1;
    public Cubo2 cubo2;
    public bool isTrue;

    void Update()
    {
        bool result = cubo1.isTrue || cubo2.isTrue;

        switch (result)
        {
            case true:
                isTrue = true;
                GetComponent<Renderer>().material.color = Color.white;
                break;
            case false:
                isTrue = false;
                GetComponent<Renderer>().material.color = Color.black;
                break;
        }
    }
    void Start()
    {
        
    }

}
