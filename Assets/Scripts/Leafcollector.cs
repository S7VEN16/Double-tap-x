using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Leafcollector : MonoBehaviour
{



private int Leaf = 0;



public TextMeshProUGUI LeafText;



private void OnTriggerEnter(Collider other)
{

    if(other.transform.tag == "leaf")
    {
        Leaf++;
        LeafText.text = "Leaf: "  + Leaf.ToString();
        Debug.Log(Leaf);
        Destroy(other.gameObject);
    }
}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
