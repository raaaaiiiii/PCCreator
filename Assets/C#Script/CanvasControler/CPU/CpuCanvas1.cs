using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CpuCanvas1 : MonoBehaviour
{
    public Canvas beforecanvas;
    public Canvas canvas;
    public Canvas nextcanvas;
    public int core;
    public float frequency;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BottonBefore()
    {
        beforecanvas.gameObject.SetActive(true);
        canvas.gameObject.SetActive(false);
    }
    public void BottonNext()
    {
        nextcanvas.gameObject.SetActive(true);
        canvas.gameObject.SetActive(false);
    }
}
