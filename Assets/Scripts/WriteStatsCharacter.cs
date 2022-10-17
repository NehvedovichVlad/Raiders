using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WriteStatsCharacter : MonoBehaviour
{
    [SerializeField] private Sprite _sprite;
    private string _name;
    [SerializeField] private int _damage;
    private int _fieldSize;
    private int _search;
    private int _travelSpeed;
    private int _collection;
    private int _attackFrequency;
    private int _shield; 
    private int _health;
    private int _wasteland;
    private int _mirage; 
    private int _switchStatus;
    private int _diametr;

    // public GameObject Prefab;


    public DatabaseCharacter databaseCharacter;

    void Start()
    {   
        StartCoroutine(WaitWriteStatsCharachter(databaseCharacter.allCharacters.Length));

    }
    
    private IEnumerator WaitWriteStatsCharachter(int length){
        
        yield return new WaitForSeconds(1f);
        // Instantiate(Prefab, new Vector2(0f, 0f), Quaternion.identity);
        for (int i = 0; i <= 1; i++)
        {
            
        _sprite = databaseCharacter.SpriteCharacters[1];
        FindObjectOfType<HelpFindSprite>().GetComponent<SpriteRenderer>().sprite = _sprite;

        _name = databaseCharacter.allCharacters[i].Name.ToString();
        GetComponent<Text>().text = "\n Имя:" + _name;

        _damage = databaseCharacter.allCharacters[i].Damage;    
        GetComponent<Text>().text += "\n Урон: " +_damage.ToString();

        _fieldSize = databaseCharacter.allCharacters[i].FieldSize;
        GetComponent<Text>().text += "\n Размер поля: " + _fieldSize.ToString();

        _travelSpeed = databaseCharacter.allCharacters[i].TravelSpeed;
        GetComponent<Text>().text += "\n Скорость движения: " + _travelSpeed.ToString();

        _collection = databaseCharacter.allCharacters[i].Collection;
        GetComponent<Text>().text += "\n Сбор: " + _collection.ToString();

        _attackFrequency = databaseCharacter.allCharacters[i].AttackFrequency;
        GetComponent<Text>().text += "\n Количество ударов \n за ход: " + _attackFrequency.ToString();

        _shield = databaseCharacter.allCharacters[i].Shield;
        GetComponent<Text>().text += "\n Щит: " + _shield.ToString();

        _health = databaseCharacter.allCharacters[i].Health;
        GetComponent<Text>().text += "\n Здоровье: " + _health.ToString();

        _wasteland = databaseCharacter.allCharacters[i].Wasteland;
        GetComponent<Text>().text += "\n Ярость: " + _wasteland.ToString();

        _mirage = databaseCharacter.allCharacters[i].Mirage;
        GetComponent<Text>().text += "\n Мираж: " + _mirage.ToString();

        _switchStatus = databaseCharacter.allCharacters[i].Diametr;
        GetComponent<Text>().text += "\n Щит: " + _switchStatus.ToString();

        _diametr = databaseCharacter.allCharacters[i].Diametr;
        GetComponent<Text>().text += "\n Поменять статус: " + _diametr.ToString();


    }
    }

    
}



