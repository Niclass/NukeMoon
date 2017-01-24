using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public GameObject Rocket; // Rocket prefab
    public GameObject RocketPosition;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Fire rocket's when the spacebar is pressed
        if (Input.GetKeyDown("space"))
        {
            GameObject rocket = (GameObject)Instantiate(Rocket);
            rocket.transform.position = RocketPosition.transform.position;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //om jorden ska gå sönder
        //Detect collision of the earth with an alien
        if(col.tag == "AlienTag")
        {
            Destroy(gameObject);
        }
    }
}
