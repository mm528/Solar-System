using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsidePlanet : MonoBehaviour
{
    public float z = 36.7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private Vector3 target = new Vector3(5.4f, -1.5f, -50.5f);
    // Update is called once per frame
    void Update()
    {
    
        transform.Rotate(new Vector3(0, z, 0)); //applying rotation
     
    }
}
