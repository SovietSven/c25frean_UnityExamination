using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Functions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI dialouge;
    private int gem = 0;
    public TextMeshProUGUI gemCounter;
    public float volume;
    public Slider slider;
    public AudioSource music;
    public AudioSource sound;
    public void Start()
    {
        gemCounter.text = "Gems:0";
    }

    public void SceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void TextChange(string text)
    {
        dialouge.text = text;
    }

    public void Gate()
    {
        if (gem >= 3)
        {
            SceneChange("Scene2");
        }
        else
        {
            dialouge.text = "Collect 3 gems to pay the toll";
        }
    }
    public void CollectGem()
    {
        gem++;
        gemCounter.text = "Gems: " + gem;
    }
        
    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "StartMenu")
        {
            volume = slider.value;
            dialouge.text = volume*100 + "%";
            music.volume = volume;
            sound.volume = volume;
        }
    }
}
