using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spheree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Material new_material = Resources.Load("alpha", typeof(Material)) as Material;
        gameObject.GetComponent<Renderer>().material = new_material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
