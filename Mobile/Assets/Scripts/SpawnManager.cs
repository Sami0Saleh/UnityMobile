using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public string SnialPrefabName;

    private GameObject currentEnemyPrefab;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Spawn(SnialPrefabName);
        }
    }

    void Spawn(string prefabPath)
    {
        if (currentEnemyPrefab == null)
            currentEnemyPrefab = Resources.Load<GameObject>(prefabPath);
        if (currentEnemyPrefab != null)
        {
            Debug.Log("Loaded");
            Instantiate(currentEnemyPrefab, Vector3.zero, Quaternion.identity);
        }
        else
            Debug.LogError("Failed");
    }
}
