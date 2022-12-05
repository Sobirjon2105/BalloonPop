using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UI : MonoBehaviour
{
    int score = 0;
    [SerializeField] TextMeshProUGUI scoreTxt;
    [SerializeField] int level;

    Image timeBar;
    public float maxTime = 10f;
    float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        level = SceneManager.GetActiveScene().buildIndex;
        timeBar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0) {
            timeLeft -= Time.deltaTime;
            timeBar.fillAmount = timeLeft / maxTime;
        } else {
            SceneManager.LoadScene(level+1);
        }
    }
    public void AddScore() {
        score++;
        scoreTxt.text = score.ToString();
       /* if (score > 10) {
            SceneManager.LoadScene(level+1);
        }*/
    }
}
