using UnityEngine;

public class ImageChanger : MonoBehaviour
{
[SerializeField] private SpriteRenderer _original;
[SerializeField] Sprite [] _listTerrain = new Sprite[12];
private int _indexTerrain = 1;

public void NewImage(){
    _original.sprite = _listTerrain[_indexTerrain];
    _indexTerrain += 1;
    if(_indexTerrain >= 12){
        _indexTerrain = 0;
    }
}
}