using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftHand : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 positionValue;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        positionValue = transform.position;
        
        //Debug.Log(positionValue);

    }
    
}
