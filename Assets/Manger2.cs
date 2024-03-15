using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManger : MonoBehaviour
{
    public float globalVolume;
    public Slider volumeSlider;
    public int x;
    public TextMeshProUGUI dd;
    // Start is called before the first frame update
    public GameObject Canvas;
    

    void Start()
    {
        //globalVolume = 1;
    }

    // Update is called once per frame
    void Update()
    {
        AudioListener.volume = globalVolume;

        //volumeSlider.value = globalVolume;

        globalVolume= volumeSlider.value;
        x = PlayerPrefs.GetInt("HighScore");

        dd.text = x.ToString();
    }

    public void Run()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void Destroy()
    {
        Destroy(Canvas);
    }


    public void Delete()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("HighScore", 1);
    }
}
