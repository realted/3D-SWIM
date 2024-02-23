using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightHand : MonoBehaviour
{
    public float Value2 { get; private set; }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         Value2 = transform.position.y;
         //Debug.Log(Value1);
    }
}
