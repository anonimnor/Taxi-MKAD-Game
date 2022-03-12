using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    public float mySpeed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var vSpeedAdd = PlayerMovesOuter.vspeed;
        transform.Translate(Vector3.forward * mySpeed * Time.deltaTime * vSpeedAdd);
        if (transform.position.y<-6.5) {
            Destroy(gameObject);
        }
    }
}
