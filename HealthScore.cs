using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class HealthScore : MonoBehaviour
{
    private int maxHealth = 15;
    private int curHealth;
    [SerializeField] int level;
    [SerializeField] Text healthTxt;
    // Start is called before the first frame update
    void Start()
    {
        level = SceneManager.GetActiveScene().buildIndex;
        curHealth = maxHealth;
    }
    public void Damage(int a) {
        curHealth -= a;
        Debug.Log(curHealth);
        DisplayHeath();
        if (curHealth <= 0) {
            //SceneManager.LoadScene("SampleScene");
            SceneManager.LoadScene(level);
        }
    }
   public void DisplayHeath() {
        healthTxt.text = "Health: " + curHealth;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
