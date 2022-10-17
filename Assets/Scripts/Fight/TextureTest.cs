using UnityEngine;

public class TextureTest : MonoBehaviour
{
    [Range(2, 512)]
    [SerializeField] private int _textureSize = 128;
    [SerializeField] private TextureWrapMode _textureWrapMode;
    [SerializeField] private FilterMode _filterMode;
    [SerializeField] private Texture2D _texture;
    [SerializeField] private Material _material;


    void OnValidate() {
        if (_texture == null) {
            _texture = new Texture2D(_textureSize, _textureSize);
        }
        if (_texture.width != _textureSize) {
            _texture.Reinitialize(_textureSize, _textureSize);
        }
        _texture.wrapMode = _textureWrapMode;
        _texture.filterMode = _filterMode;
        _material.mainTexture = _texture;
        _texture.Apply();
    }
    
}
