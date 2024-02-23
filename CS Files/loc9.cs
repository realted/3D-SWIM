using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loc9 : MonoBehaviour
{
    public leftHand leftHandScript; // Reference to the leftHand script
    public bool LED9;
    Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

        // Find and store the leftHand script attached to a GameObject in the scene
        leftHandScript = FindObjectOfType<leftHand>();
        // transform.rotation = new Vector3(45F, 45F, 45F);
    }

    // Update is called once per frame
    void Update() //fdg
    {
        if (leftHandScript != null)
        {
            // Set the position of the cylinder to the positionValue of the leftHand script
            // transform.position = leftHandScript.positionValue  + leftHandScript.transform.rotation.eule * 1;
            int cube_num = 10;
            float distance_between_cubes = 0.15F;
            float comp_length = Mathf.Sqrt(Mathf.Pow(cube_num * distance_between_cubes, 2) / 3);
            transform.position = leftHandScript.positionValue + Quaternion.Euler(leftHandScript.transform.eulerAngles) * Quaternion.Euler(90, 0, 45) * new Vector3(comp_length, comp_length, 0);
            transform.rotation = leftHandScript.transform.rotation * Quaternion.Euler(90, 0, 0);
            //Debug.Log(transform.position); //transform.rotation.
            // Debug.LogError(transform.rotation);
        }
        else
        {
            Debug.LogError("LeftHand script not found.");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        LED9 = true;
        Material new_material = Resources.Load("collide_color", typeof(Material)) as Material;
        gameObject.GetComponent<Renderer>().material = new_material;
    }
    void OnTriggerExit(Collider other)
    {
        LED9 = false;
        Material new_material = Resources.Load("basic", typeof(Material)) as Material;
        gameObject.GetComponent<Renderer>().material = new_material;
    }
}


