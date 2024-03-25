using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    public string nextLevel;
    private void OnTriggerEnter2D(Collider2D collsion)
    {
        if (collsion.CompareTag("Circle"))
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
