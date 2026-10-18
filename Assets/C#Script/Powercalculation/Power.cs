using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int Powercheck(int basecore,float frequency,float maxfrequency)
    {
        float Power;
        Power=basecore*1.2f*frequency+(maxfrequency-frequency);
        return (int)Power;
    }
}
