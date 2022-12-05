using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon : MonoBehaviour
{
    [SerializeField] Vector3 bForce;
    [SerializeField] Sprite[] bSprites;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    //private int dir = -1;
    [SerializeField] float speed;
    private UI ui;
    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.FindGameObjectWithTag("UI").GetComponent<UI>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = bSprites[Random.Range(0,3)];
        transform.position = new Vector3(Random.Range(-8.35f, 8.39f), transform.position.y, transform.position.z);
        transform.position = new Vector3(Random.Range(-4.7f, 3.7f), transform.position.y, transform.position.z);
        int x = Random.Range(-100, 100);
        int y = Random.Range(150, 250);
        bForce = new Vector3(x, y, 0);
        rb.AddForce(bForce);
    }
    void ChangeDir() {
        float ballonPos = (Camera.main.WorldToViewportPoint(transform.position)).y;
       //Debug.Log(ballonPos);
        if (ballonPos > 1.0f) {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        ChangeDir();
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Bullet") {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            ui.AddScore();
        }
    }
}
