using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    [SerializeField] GameObject post;
    [SerializeField] Vector3 bulletForce;
    [SerializeField] Sound sound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            shoot();
        }
        ChangeDir();
    }
    private void FixedUpdate() {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        direction.Normalize();
        float rotateAmount = Vector3.Cross(direction, transform.right).z;
        rb.angularVelocity = -rotateAmount * speed * Time.deltaTime;
    }
    void shoot() {
        sound.SoundPlay();
        GameObject bullet = Instantiate(post, transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody2D>().AddRelativeForce(bulletForce);
        Destroy(bullet, 4f);
    }   
    void ChangeDir() {
        float bulletPos = (Camera.main.WorldToViewportPoint(transform.position)).y;
        if (bulletPos > 1.0f) {
            Destroy(this.gameObject);
        }
    }
}
