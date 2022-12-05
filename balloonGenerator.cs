using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonGenerator : MonoBehaviour
{
    [SerializeField] GameObject balloon;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("generator", 0.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void generator() {
        Instantiate(balloon, transform.position, transform.rotation);
    }
}
