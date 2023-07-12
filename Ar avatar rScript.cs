using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AravatarrScript : MonoBehaviour
{
    public Vector3 a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(a*Time.deltaTime);  
    }
}
