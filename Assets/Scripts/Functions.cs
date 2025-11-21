using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Functions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI dialouge;
    private void Start()
    {
        Debug.Log("Scene Change!");
    }

    public void SceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void TextChange(string text)
    {
        dialouge.text = text;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
