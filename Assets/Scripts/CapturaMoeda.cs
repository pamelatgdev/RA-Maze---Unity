using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapturaMoeda : MonoBehaviour
{
    // Start is called before the first frame update
    public static int pontos = 0;
    public AudioClip somMoeda;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, Time.deltaTime * 100);
    }

    private void OnTriggerEnter(Collider other)
    {
            pontos++;
            AudioSource.PlayClipAtPoint(somMoeda, GameObject.Find("ARCamera").transform.position);
            Destroy(gameObject);
        
    }
}
