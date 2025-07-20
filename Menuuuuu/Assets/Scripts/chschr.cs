using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class chschr : MonoBehaviour
{   

    private GameObject[] characters;
    private int index;
    public string Scene;

    // Start is called before the first frame update
    void Start()
    {   
        index = PlayerPrefs.GetInt("hero");
        characters = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            characters[i]=transform.GetChild(i).gameObject;
        }

        foreach (GameObject go in characters)
        {
            go.SetActive(false);
        }
        if (characters[index])
        {
            characters[index].SetActive(true);
        }
    }

    public void SelectLeft()
    {
        characters[index].SetActive(false);
        index--;
        if (index < 0)
        {
            index = characters.Length - 1;
        }
        characters[index].SetActive(true);
        
    }
    
    
    public void SelectRight()
    {
        characters[index].SetActive(false);
        index++;
        if (index ==characters.Length)
        {
            index = 0;
        }
        characters[index].SetActive(true);
    }

    public void StartScene()
    {
        PlayerPrefs.SetInt("hero", index);
        SceneManager.LoadScene(Scene);
    }
}
