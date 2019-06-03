using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scenario001 : MonoBehaviour
{
    public void SCENE001()
    {
        SceneManager.LoadScene("Prison");
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
