using UnityEngine;

public class PlayerMoves : MonoBehaviour
{
    public AudioSource HitSound123;
    public AudioSource HitSound234;

    public Animator anim;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemies"))
        {
            //anim.SetTrigger("CarHit"); //??????? ???????, ?????????? ?? ?????????? ?????????, ????????...
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("enemies"))
        {
            //anim.SetTrigger("CarHit");
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        //transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);
        // Debug.Log("...MOVES!!!...");

        // !!!! IF PUBLISHED TO ANDROID, MIND Y VELOCITY - NO <UP> ARROW THERE!!

    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemies"))
        {
            if (Random.Range(0, 14) == 1)
            {
                HitSound123.Play();
            }
            else
            {
                HitSound234.Play();
            }
            anim.SetTrigger("CarHit");
            Debug.Log("...CARHIT!!!...");
            //Destroy(gameObject);
        }
    }
}
