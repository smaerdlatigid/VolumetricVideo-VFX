using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleTextures : MonoBehaviour
{
    Material mat;
    float cyclePeriod = 5f; 

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
