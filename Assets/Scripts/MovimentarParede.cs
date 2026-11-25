using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentarParede : MonoBehaviour
{
    public Vector3 ponto1;
    public Vector3 ponto2;
    private float i = 0;
    private bool inverter = false;

   
    void Start()
    {
        ponto1 = transform.localPosition;
    }

    void Update()
    {
        if (inverter)
            i -= Time.deltaTime / 5;
        else
            i += Time.deltaTime / 5;
        transform.localPosition = Vector3.Lerp(ponto1, ponto2, i);
        if (Vector3.Distance(transform.localPosition, ponto2) < 0.001)
        {
            inverter = true;
        }
        else if (Vector3.Distance(transform.localPosition, ponto1) < 0.001)
        {
            inverter = false;
        }
    }
}