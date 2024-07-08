using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefabsphere : MonoBehaviour
{

    public GameObject prefabsphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject tempGameObject = Instantiate<GameObject>(prefabsphere);
        Color C = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = C;

    }
}
