using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefabcubo : MonoBehaviour
{
    public GameObject prefabcubo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        GameObject tempGameObject = Instantiate<GameObject>(prefabcubo);
        Color C = new Color(Random.value, Random.value, Random.value); 
        tempGameObject.GetComponent<MeshRenderer>().material.color = C;
    }
}
