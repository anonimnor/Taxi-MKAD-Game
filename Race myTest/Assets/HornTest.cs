using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HornTest : MonoBehaviour
{
    public AudioSource HornSound;
    public AudioSource HornSound2;
    public AudioSource HornSound3;
    public AudioSource HornSound4;

    
    // Start is called before the first frame update
    void Start()
    {
       // SoundTrack.PlaySound(testSound);
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("...HORN234!!!...");
        if (Random.Range(0, 2) == 1)
        {
            if (Random.Range(0, 4) == 1)
            {
                HornSound2.Play();
            }
            else
            {
                if (Random.Range(0, 3) == 1)
                {
                    HornSound3.Play();
                }
                else
                {
                    if (Random.Range(0, 2) == 1)
                    {
                        HornSound4.Play();
                    }
                    else
                    {
                        HornSound.Play();
                    }
                }

            }
        }
        
    }
    /*private void OnCollisionStay(Collision collision)
    {
        Debug.Log("...NOHORN!!!...");
        if (collision.gameObject.CompareTag("enemies"))
        {
            Debug.Log("...HORN!!!...");
            HornSound.Play();
        }
    }*/
}
