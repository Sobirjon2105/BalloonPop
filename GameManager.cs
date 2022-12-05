using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixer mixer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadLevel1(){
        SceneManager.LoadScene("Level1");
    }
    public void LoadInstruction() {
        SceneManager.LoadScene("Instruction");
    }
    public void LoadSettings() {
        SceneManager.LoadScene("Settings");
    }
    public void BackSettings() {
        SceneManager.LoadScene("Beginning");
    }
    public void BackMainMenu() {
        SceneManager.LoadScene("Beginning");
    }
    public void SetVolume() {
        mixer.SetFloat("Volume", volumeSlider.value);
    }
    public void BackInstruction() {
        SceneManager.LoadScene("Beginning");
    }
}
