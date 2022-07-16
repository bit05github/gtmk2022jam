using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectcollector : MonoBehaviour
{
    

    public SpriteRenderer sprtRend;

    // Start is called before the first frame update
    void Start()
    {
        sprtRend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "player") {
            Collected();
        }

    }

    void Collected() {
        sprtRend.enabled = false;
    }
}
