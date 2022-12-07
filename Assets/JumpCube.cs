using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCube : MonoBehaviour
{
   [SerializeField]
    float JumpForce = 800;
    private string name = "JumpCube";
    Rigidbody rb; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("JumpCube");
            rb.AddForce(new Vector3(0, JumpForce, 0));
        }
    }

}
