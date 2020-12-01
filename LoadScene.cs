using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadSceneAsync(LoadingData.sceneToLoad);
        //SceneManager.LoadSceneAsync("SceneEnter"); //test purposes
    }


}