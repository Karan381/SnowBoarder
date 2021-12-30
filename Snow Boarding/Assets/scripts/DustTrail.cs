using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ParticleSystem dustTrail;

    void OnCollisionExit2D(Collision2D collision)
    {
        dustTrail.Stop();
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            dustTrail.Play(); 
        }  
    }
} 
