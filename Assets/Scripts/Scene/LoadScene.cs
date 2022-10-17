using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour
{
    public string LoadLevel;

    public void Load(){
        SceneManager.LoadScene(LoadLevel);
    }
}
