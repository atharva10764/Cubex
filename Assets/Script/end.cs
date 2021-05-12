using UnityEngine;

public class end : MonoBehaviour
{
    public Gamemanager gameManager;
    void OnTriggerEnter()
    {
        gameManager.Completelevel();
    }
}