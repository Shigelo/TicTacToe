    using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public GameObject playButton;
    //public GameObject returnButton;
    public GameObject exitButton;
    public GameObject gameplay;
    public GameObject Title;
    public void Play()
    {
        gameplay.SetActive(true);
        //returnButton.SetActive(true);
        playButton.SetActive(false);
        exitButton.SetActive(false);
        Title.SetActive(false);

    }

    public void Return()
    {
        gameplay.SetActive(false);
        //returnButton.SetActive(false);
        playButton.SetActive(true);
        exitButton.SetActive(true);
        Title.SetActive(true);
        
    }

    public void Exit()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
