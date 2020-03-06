using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGetirici : MonoBehaviour
{
    private const float mesafe = 200f;

    [SerializeField] private Transform basLevel;
    [SerializeField] private List<Transform> platformListesi;
    [SerializeField] private GameObject oyuncu;

    private Vector3 sonKonum;

    private void Awake()
    {
        sonKonum = basLevel.Find("sonNokta").position;

        int olusturulacakPlatformSayisi =1;
        for (int i = 0; i < olusturulacakPlatformSayisi; i++)
        {
            SpawnLevelPart();
        }
    }

    private void Update()
    {
        if (Vector3.Distance(oyuncu.transform.position, sonKonum) < mesafe)
        {
            // Spawn another level part
            SpawnLevelPart();
        }
    }

    private void SpawnLevelPart()
    {
        Transform chosenLevelPart = platformListesi[Random.Range(0, platformListesi.Count)];
        Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, sonKonum);
        sonKonum = lastLevelPartTransform.Find("sonNokta").position;
    }

    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition + new Vector3(15.0f, 0), Quaternion.identity);
        return levelPartTransform;
    }

}
