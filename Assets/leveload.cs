using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoad : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject LoadingScreen;
    public Slider slider;
        public void Load(int Index)
    {
      
        StartCoroutine(loadasync(Index));
        
    }

    IEnumerator loadasync (int Index)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(Index);
        LoadingScreen.SetActive(true);
        while (!operation.isDone)
        {
              
            float f = Mathf.Clamp01(operation.progress / 0.9f);
            Debug.Log(f);
            slider.value = f;

            yield return null;
        }
    }
}
