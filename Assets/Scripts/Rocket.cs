using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour
{
     public float speed;
    // Use this for initialization
    void Start()
    {
        speed = 2f;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get the rocket's current position
        Vector2 position = transform.position;

        //Compute the rocket's new position
        position = new Vector2(position.x, position.y + speed * Time.deltaTime);

        //Update the rocket's position
        transform.position = position;

        //Destroys rocket when outside the camera view
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        if(transform.position.y > max.y)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //Detect collision of rocket with moon, satellite and alien
        if (col.tag == "MoonTag")
        {
            Destroy(gameObject);
        }
        if (col.tag == "SatelliteTag")
        {
            Destroy(gameObject);
        }
        if (col.tag == "AlienTag")
        {
            Destroy(gameObject);
        }
    }
}
