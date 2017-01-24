using UnityEngine;
using System.Collections;

public class MoonRotation : MonoBehaviour
{
    public Transform center;
    public float radius = 5;
    public float angle = 0;
    public float speed = 6f;

    public GameObject ExplosionBig; //Explosion prefab

    // Update is called once per frame
    void Update()
    {
        angle += speed * Time.deltaTime;
        float x = Mathf.Cos(angle) * radius + center.transform.position.x; //x=cos(angle)*R+a;
        float y = Mathf.Sin(angle) * radius + center.transform.position.y; //y=sin(angle)*R+b;
        this.gameObject.transform.position = new Vector2(x, y);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //Detect the collision with moon and rocket
        if (col.tag == "RocketTag")
        {
            PlayExplosion();
            transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f); //increase the size of the ball
            //Destroy(gameObject); //Destroy moon
        }
    }
    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionBig);
        explosion.transform.position = transform.position;
    }
}
