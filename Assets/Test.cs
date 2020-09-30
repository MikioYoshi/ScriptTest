using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num = 2;
        int val = (num == 1) ? -100 : 100;

        Debug.Log(val);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
