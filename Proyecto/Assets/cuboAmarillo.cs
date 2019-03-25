using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboAmarillo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
               
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
            transform.localScale += new Vector3(0.05F, 0.05F, 0.05F);
        if (Input.GetKey(KeyCode.X))
            transform.localScale += new Vector3(-0.05F, -0.05F, -0.05F);


    }
}
