using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public bool isDelayed=false;
    void Update()
    {
        if (!isDelayed)
        {
        StartCoroutine(DelayCoroutine());
        }
        else if (Input.anyKey)
        {
            LoadNextLevel();
        }
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
     IEnumerator DelayCoroutine()
    {
        yield return new WaitForSeconds(1);
        isDelayed=true;

    }
}
