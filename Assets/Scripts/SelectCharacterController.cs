using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacterController : MonoBehaviour
{
    [Serializable]
    public struct Characters
    {
        public GameObject character;
    }
    public Characters[] characters;

    //private List<int> numberOfCharacters = new List<int>(); 
    [SerializeField] private int idActiveCharacter;

    private void Start()
    {
        //numberOfCharacters.Add(characters.Length);

        for (int i = 0; i < characters.Length; i++)
        {
            if (characters[i].character.activeSelf) PlayerPrefs.SetInt("idActiveCharacter", i);
        }

        idActiveCharacter = PlayerPrefs.GetInt("idActiveCharacter");
        Debug.Log("Выбран персонаж: " + PlayerPrefs.GetInt("idActiveCharacter"));
        Debug.Log("Всего персонажей: " + characters.Length);
    }

    public void SelectRight()
    {
        if (idActiveCharacter < characters.Length)
        {
            for (int i = 0; i < characters.Length; i++)
            {
                if (i == idActiveCharacter)
                {
                    idActiveCharacter =+ 1;
                    characters[i].character.SetActive(false);
                    characters[idActiveCharacter].character.SetActive(true);
                    PlayerPrefs.SetInt("idActiveCharacter", idActiveCharacter);
                    Debug.Log("Выбран персонаж: " + PlayerPrefs.GetInt("idActiveCharacter"));
                }
            }
        }
    }

    public void SelectLeft()
    {
        if (idActiveCharacter > 0)
        {
            for (int i = 0; i < characters.Length; i++)
            {
                if (i == idActiveCharacter)
                {
                    idActiveCharacter --;
                    characters[i].character.SetActive(false);
                    characters[idActiveCharacter].character.SetActive(true);
                    PlayerPrefs.SetInt("idActiveCharacter", idActiveCharacter);
                    Debug.Log("Выбран персонаж: " + PlayerPrefs.GetInt("idActiveCharacter"));
                }
            }
        }

    }
}
