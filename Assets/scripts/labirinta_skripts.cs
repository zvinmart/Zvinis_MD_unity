using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class labirinta_skripts : MonoBehaviour
{

    public GameObject layer;
    public GameObject player;
    public float distance = 1f;

    void Update()
    {
        
        if (player.transform.position.y < layer.transform.position.y + distance)
        {
            layer.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 0.5f);
        }
        
        else
        {
            layer.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
        }
    }
    
}
