using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCapsule : MonoBehaviour
{

    public GameObject prefabcapsule;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        GameObject tempGameObject = Instantiate<GameObject>(prefabcapsule);
        Color C = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = C;
    }
        
}
