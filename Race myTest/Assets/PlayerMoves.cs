using UnityEngine;

public class PlayerMoves : MonoBehaviour
{
    public AudioSource HitSound123;
    public AudioSource HitSound234;

    public Animator anim;
    public float speed = 3f;
    public static float vspeed = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemies"))
        {
            //anim.SetTrigger("CarHit"); //функции неверны, вызывается на внутренний коллайдер, почемуто...
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

        float ver = Input.GetAxisRaw("Vertical");
        float hor = Input.GetAxisRaw("Horizontal");
        if (hor > 0) hor = 1;
        if (hor < 0) hor = -1;
        if (ver > 0)
        {
            vspeed = 1.5f;
        }
        else if (ver < 0)
        {
            vspeed = 0.5f;
        }
        else {
            vspeed = 1f;
        }
        Vector3 dir = new Vector3(hor, 0, ver/2); //было hor.normalized, это и есть +/-1 - говно, чё.
        transform.Translate(dir * Time.deltaTime * speed);
    }
    private void OnCollisionStay(Collision collision) {
        if (collision.gameObject.CompareTag("enemies")) {
            if (Random.Range(0, 14) == 1) {
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
