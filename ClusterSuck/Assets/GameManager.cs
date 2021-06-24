
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject levelCompleteUI;
    bool hasGameEnded=false;
    public float delay=1f;
    public void EndGame()
    {
        if (!hasGameEnded)
        {
            hasGameEnded=true;
            Invoke("Restart",delay);
        }
    }
    public void CompleteLevel()
    {
        levelCompleteUI.SetActive(true);

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
