using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class nextLevel2 : MonoBehaviour
{
    public Scene NextSceneName;

    void OnTriggerEnter2D(Collider2D col)

    {



        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("congrates");
        }

    }
}
