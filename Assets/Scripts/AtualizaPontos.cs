using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AtualizaPontos : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = CapturaMoeda.pontos.ToString();
    }
}
