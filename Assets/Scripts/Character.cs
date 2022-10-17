using UnityEngine;

[CreateAssetMenu(fileName ="New Character", menuName = "Assets/New Character")]
public class Character : ScriptableObject
{
    public string Name;

    [Tooltip("Поле состоит из плиточек. Вертикальное.")]
    public int FieldSize;

    [Tooltip("Определяющий размер круга внутри которого происходит действие в плиточках.")]
    public int Diametr;

    [Tooltip("Сколько минимально плиточек за раз персонаж готов обыскивать.")]
    public int Laziness;

    [Tooltip("Сколько приточек персонаж открывает за один ход.")]
    public int Search;

    [Tooltip("Сколько плиток персонаж проходит за ход.")]
    public int TravelSpeed;
    
    [Tooltip("Сколько Миража персонаж собирает за один ход.")]
    public int Collection;

    [Tooltip("Сколько урона за одну атаку Персонаж может выдать.")]
    public int Damage;

    [Tooltip("Сколько раз за один ход Персонаж может ударить (пока не понимаю, надо ли).")]
    public int AttackFrequency;

    [Tooltip("Сколько урона поглощается перед тем как урон вычитается из Здоровья.")]
    public int Shield; 

    [Tooltip("Сколько надо получить урона чтобы персонаж погиб.")]
    public int Health;

    [Tooltip("Сколько ходов персонаж находится в боевом состоянии после того как внутри диаметра исчезли все противники в боевом состоянии.")]
    public int Wasteland;

    [Tooltip("Ресурс который собирают персонажи. Мне кажется нужен такой расчёт: все 8 персонажей за 6 ходов могут выбрать весь Мираж.")]
    public int Mirage; 

    [Tooltip("Сколько раз за сессию игрок может поменять статус персонажей.")]
    public int SwitchStatus;

    [Tooltip("Определяет очерёдность действий.")]
    public int Initiative;

    // public Sprite anysprite = null;

}
