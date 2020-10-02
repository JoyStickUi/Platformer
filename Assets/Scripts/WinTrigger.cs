using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{
    [Header("Победная сцена")]
    public string scene;

    void OnTriggerEnter(Collider collides){       
        SceneManager.LoadScene(scene);
    }
}
