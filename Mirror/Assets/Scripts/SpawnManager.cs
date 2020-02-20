using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities;

public class SpawnManager : MonoBehaviour
{
    public List<Transform> spawnsList;
    private int ennemiSpawned;

    [Space]
    public GameObject prefabEnnemi;

    public void NewWave(int level)
    {
        ennemiSpawned = 0;
        Transform ennemi;
        int indexSpawn;

        for (int i = 0; i < level; i++)
        {
            if(ennemiSpawned >= spawnsList.Count)
            {
                ennemiSpawned = 0;
            }

            ennemi = Instantiate(prefabEnnemi).transform;
            indexSpawn = Aleatoire.AleatoireBetween(0, spawnsList.Count - ennemiSpawned - 1);
            ennemi.position = spawnsList[indexSpawn].position;
            PlaceToEnd(spawnsList, indexSpawn);
            ennemiSpawned++;
        }
    }

    public void PlaceToEnd(List<Transform> list, int index)
    {
        Transform temp = list[index];
        list.RemoveAt(index);
        list.Add(temp);
    }
}
