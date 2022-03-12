using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    public GameObject[] cars;
    private float[] positions = { -1.83f, -0.61f, 0.72f, 1.92f };
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn() {
        while (true) {
            if (Random.Range(0, 4)!= 1)
            {
                Debug.Log("Создаём мышынку!!: ");
                Instantiate(
                    cars[Random.Range(0, cars.Length)],
                    new Vector3(positions[Random.Range(0, positions.Length)], 11, 0),
                    Quaternion.Euler(new Vector3(90, 0, -180))
                );
            }
            yield return new WaitForSeconds(0.7f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
