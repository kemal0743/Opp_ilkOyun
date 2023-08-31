using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    public static GameManeger instance { get; set; }


    private void Awake()
    {
        SingletonThisGameObject(); // singleton desing pattern kullandýk 
    }
    private void SingletonThisGameObject() 
    {

        if (instance == null)
        {


            instance = this;
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {

            Destroy(this.gameObject);

        }

    }

    public void RestartGame()
    {
       StartCoroutine(RestartGameAsync());
    }
    private IEnumerator RestartGameAsync() 
    {

        yield return SceneManager.LoadSceneAsync("Game");
    }
}
