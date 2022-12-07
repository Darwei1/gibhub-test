using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddel2 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 10, 0) * Time.deltaTime;
            print("흆er upp");
        }

        if (Input.GetKey(KeyCode.DownArrow))
            print("흆er ner");

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -10, 0) * Time.deltaTime;
            print("흆er ner");
        }

        if (Input.GetKey(KeyCode.DownArrow))
            print("흆er ner");
    }
}

