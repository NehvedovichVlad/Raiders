using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    [SerializeField] private GameObject _heartText;
    void Start()
    {
        // HeartText.SetActive(false);
        StartCoroutine(EndText());
    }

    public void OnMouseOver()
    {
        _heartText.SetActive(true);
    }

    public void OnMouseExit()
    {
        _heartText.SetActive(false);
    }

    private IEnumerator EndText(){
        
        yield return new WaitForSeconds(1.1f);
        _heartText.SetActive(false);}
}