using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadingScenes : MonoBehaviour
{
    public GameObject loadingScreen;
    public string sceneToLoad;
    public CanvasGroup canvasGroup;
    
    Text percentLoaded;
    Slider slider;

    //"£$"$$£^$%^23423423424543534 DELETE? - YES ////////////////////
    //public void Start()
    //{
    //    DontDestroyOnLoad(gameObject);
    //}

    public void StartGame()
    {
        StartCoroutine(StartLoad());
        
    }

    IEnumerator StartLoad()
    {
        sceneToLoad = LoadingData.sceneToLoad;
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneToLoad);
        
        loadingScreen.SetActive(true);
        yield return StartCoroutine(FadeLoadingScreen(1.0f, 1.0f));

        
        while (!operation.isDone)
        {
            //printing on Screen
            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);
            Debug.Log(progressValue);
            slider.value = progressValue;
            percentLoaded.text = Mathf.Round(progressValue * 100) + "%";
            Debug.Log(percentLoaded.text);
            yield return null;
        }
        
        yield return StartCoroutine(FadeLoadingScreen(0.0f, 1.0f));

        loadingScreen.SetActive(false);
    }

    IEnumerator FadeLoadingScreen(float targetValue, float duration)
    {
        float startValue = canvasGroup.alpha;
        
        float time = 0;

        while (time < duration)
        {
            canvasGroup.alpha = Mathf.Lerp(startValue, targetValue, time / duration);
            time += Time.deltaTime;

            yield return null;
        }
        canvasGroup.alpha = targetValue;
    }
}