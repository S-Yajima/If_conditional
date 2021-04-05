using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotate_v3 = new Vector3(0f, 0.5f, 0f);
        transform.Rotate(rotate_v3);
    }
}
