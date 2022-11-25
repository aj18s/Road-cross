using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public GameObject GameOverPanel;

    public int Score;
    public Text ScoreText;
    public bool StartScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(StartScene == false)
        ScoreText.text = "Score: " + Score;    
    }

    public void OverPanel()
    {
        GameOverPanel.SetActive(true);
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
