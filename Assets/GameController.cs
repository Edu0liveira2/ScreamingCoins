using UnityEngine;

public static class GameController
{
    private static int collectableCount;

    public static bool gameOver
    {
        get { return collectableCount <= 0; }
    }

    public static void Init()
    {
        collectableCount = GameObject.FindGameObjectsWithTag("coletavel").Length;
    }

    public static void Collect()
    {
        collectableCount--;
        Debug.Log("Restam: " + collectableCount);
    }
}