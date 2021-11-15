using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int speed;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Cube"))
        {
            other.GetComponent<Player>().health -= 1;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

    }
}
