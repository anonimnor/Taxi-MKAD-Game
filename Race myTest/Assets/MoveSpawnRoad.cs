using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class MoveSpawnRoad : MonoBehaviour
{
    public float speed = 1.5f;
    public GameObject myRoad;
 
    // Update is called once per frame
    void Update()
    {
        var vSpeedAdd = PlayerMoves.vspeed;
        
        transform.Translate(Vector3.down * speed * Time.deltaTime * vSpeedAdd);
        if (transform.position.y < -8)
        {
            Instantiate(myRoad, new Vector3(0.11f, 7.6f, 0), Quaternion.identity);
            Destroy(gameObject);
            // EditorApplication.isPaused = true;
        }
    }
}
