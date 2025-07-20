using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawncharacter : MonoBehaviour
{

    public List<GameObject> character;
    public Vector3 position;

    private int characterId;
    void Awake()
    {
        characterId = PlayerPrefs.GetInt("hero");
        character[characterId].SetActive(true);
    }


}
