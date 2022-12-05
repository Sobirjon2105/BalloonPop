using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] bool isFacingRight = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

void FixedUpdate(){

if(isFacingRight){
  transform.position = new Vector2(transform.position.x + .1f, transform.position.y);
  if(transform.position.x >= 8.26){
    Flip();
  }
}
if(!isFacingRight){
  transform.position = new Vector2(transform.position.x + -.1f, transform.position.y);
  if(transform.position.x <= -8.29){
    Flip();
}
}
}
void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }
void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            var health = GameObject.FindGameObjectWithTag("pistol").GetComponent<HealthScore>();
            if(health != null)
            {
                health.Damage(5);
            }

        }

    }
}
