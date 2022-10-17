using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LoadExcelEnemy : MonoBehaviour
{

    [MenuItem("Utilities/Generate Enemies")]
    public static void LoadEnemiesInfoData(){

        // Read CSV files
        List<Dictionary<string, object>> data = CSVReader.Read("EnemyInfoData");
        for (var i = 0; i < data.Count; i++)
        {
            string name = data[i]["Имя"].ToString();
            int fieldSize = int.Parse(data[i]["Размер поля"].ToString(), System.Globalization.NumberStyles.Integer);
            int diametr = int.Parse(data[i]["Диаметр"].ToString(), System.Globalization.NumberStyles.Integer);
            int laziness = int.Parse(data[i]["Лень"].ToString(), System.Globalization.NumberStyles.Integer);
            int search = int.Parse(data[i]["Обыск"].ToString(), System.Globalization.NumberStyles.Integer);
            int travelSpeed = int.Parse(data[i]["Скорость движения"].ToString(), System.Globalization.NumberStyles.Integer);
            int collection = int.Parse(data[i]["Сбор"].ToString(), System.Globalization.NumberStyles.Integer);
            int damage = int.Parse(data[i]["Урон"].ToString(), System.Globalization.NumberStyles.Integer);
            int attackFrequency = int.Parse(data[i]["Частота атаки"].ToString(), System.Globalization.NumberStyles.Integer);
            int shield = int.Parse(data[i]["Щит"].ToString(), System.Globalization.NumberStyles.Integer);
            int health = int.Parse(data[i]["Здоровье"].ToString(), System.Globalization.NumberStyles.Integer);
            int wasteland = int.Parse(data[i]["Отходняк"].ToString(), System.Globalization.NumberStyles.Integer);
            int mirage = int.Parse(data[i]["Мираж"].ToString(), System.Globalization.NumberStyles.Integer);
            int switchStatus = int.Parse(data[i]["Свич"].ToString(), System.Globalization.NumberStyles.Integer);
            int initiative = int.Parse(data[i]["Инициатива"].ToString(), System.Globalization.NumberStyles.Integer);

            Character character = ScriptableObject.CreateInstance<Character>();
            character.Name = name;
            character.FieldSize = fieldSize;
            character.Diametr = diametr;
            character.Laziness = laziness;
            character.Search = search;
            character.TravelSpeed = travelSpeed;
            character.Collection = collection;
            character.Damage = damage;
            character.AttackFrequency = attackFrequency;
            character.Shield = shield;
            character.Health = health;
            character.Wasteland = wasteland;
            character.Mirage = mirage;
            character.SwitchStatus = switchStatus;
            character.Initiative = initiative;

            AssetDatabase.CreateAsset(character, $"Assets/Resources/Enemies/{character.Name}.asset");
        }
    }

}
