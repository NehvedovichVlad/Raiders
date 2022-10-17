using System.Collections.Generic;
using UnityEngine;

public class DatabaseCharacter : MonoBehaviour
{
    public Character[] allCharacters;

    public Sprite [] SpriteCharacters;
    public Dictionary<Sprite, Sprite> LoadSpriteCharacters = new Dictionary<Sprite, Sprite>();

    void Start()
    {   
        SpriteCharacters =  Resources.LoadAll<Sprite>("SpriteCharacters");

        for (int i = 0; i < SpriteCharacters.Length; i++)
        {
            LoadSpriteCharacters.Add(SpriteCharacters[i], SpriteCharacters[i]);
        }


        allCharacters = Resources.LoadAll<Character>("Characters");
        


    }

}
