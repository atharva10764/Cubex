using UnityEngine;
using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour {

    bool Gamehasended = false;
    float restartdelay = 1f;
    public GameObject completelevelUI;
    public void Completelevel()
    {
        completelevelUI.SetActive(true);
    }
    public void Endgame()
    {
        if (Gamehasended == false)
        {
            Gamehasended = true;
            Debug.Log("GAme over");
            Invoke("Restart", restartdelay);
        }
    }
      void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    
}
