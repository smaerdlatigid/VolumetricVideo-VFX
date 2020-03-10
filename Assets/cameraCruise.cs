using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraCruise : MonoBehaviour
{
    public GameObject focus;
    public float radius = 1f;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            radius*Mathf.Cos(Time.time*speed),
            0,
            radius*Mathf.Sin(Time.time*speed)
        );
        transform.LookAt(focus.transform);

    }
}
