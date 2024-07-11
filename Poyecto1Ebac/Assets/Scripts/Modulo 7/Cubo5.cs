using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo5 : MonoBehaviour
{
    // Start is called before the first frame update

    public Cubo3 cubo3;
    public Cubo4 cubo4;
    public bool isTrue;

    void Update()
    {
        bool result = cubo3.isTrue || cubo4.isTrue; 

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
