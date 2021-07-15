using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    Transform bar;
    float size = 0.23f;
    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            size=size+0.23f;
            transform.localScale = new Vector3(size, 1f,1f);
        }
    }
}
