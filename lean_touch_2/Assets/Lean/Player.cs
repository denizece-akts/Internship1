using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject player;
    public int jumpHeight;
    private Vector2 pos;
    public int health =3;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.touchCount == 1)
            {
                rb.AddForce(0, 100f, 0);
                Debug.Log("Fingers touching" + Input.touchCount);
            }
            else if (Input.touchCount == 2){

                rb.AddForce(0, 100f, 0);
                Debug.Log("Fingers touching" + Input.touchCount);
            }
            else if (Input.touchCount == 3)
            {

                rb.AddForce(0, 100f, 0);
                Debug.Log("Fingers touching" + Input.touchCount);
            }

        }

        
    }
}
