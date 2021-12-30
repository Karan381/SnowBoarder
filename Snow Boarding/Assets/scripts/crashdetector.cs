using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crashdetector : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float delay = 1f;
    [SerializeField] ParticleSystem crasheffect;
    bool isDead = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "ground")
        {
            
            FindObjectOfType<playercontroller>().DisableControls();

            if (!isDead)
            {
                crasheffect.Play();
                GetComponent<AudioSource>().Play();
                isDead = true;
            }
            Invoke("ReloadScene", delay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
