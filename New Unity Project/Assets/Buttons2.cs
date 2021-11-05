using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons2 : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("game");
    }

    void OnMouseUp()
    {
        
    }
}
