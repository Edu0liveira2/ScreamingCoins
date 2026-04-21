using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject endGamePanel;

    void Start()
    {
        endGamePanel.SetActive(false);
        GameController.Init();
    }

    void Update()
    {
        if (GameController.gameOver)
        {
            endGamePanel.SetActive(true);
        }
    }
}