using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Managers")]
    public SpawnManager spawnManager;

    [Space]
    public int level = 1;

    private void Start()
    {
        spawnManager.NewWave(level);
    }

    [ContextMenu("LaunchNextLevel")]
    public void LaunchNextLevel()
    {
        level++;
        spawnManager.NewWave(level);
    }
}
