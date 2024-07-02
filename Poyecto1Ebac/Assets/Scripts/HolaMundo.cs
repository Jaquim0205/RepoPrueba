using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        print("algo paso");
        Debug.LogWarning("Algo puede estar mal");
        Debug.LogError("Algo esta mal");
        Debug.Log("Hola desde start");

    }

    // Update is called once per frame
    void Update()
    {

        //x = x + 1;
        //Debug.Log(x)

        Debug.Log("Hola desde Update");

    }

    private void Awake()
    {
        Debug.LogError("Hola desde Awake");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("hola desde FixedUpdate cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde lateupdate");
    }

    private void OnEnable()
    {
        Debug.LogWarning(" el objeto ha sido habilitado");
        
    }

    private void OnDisable()
    {
        Debug.LogWarning("el objeto ha sido inhablilitado");
    }
}
