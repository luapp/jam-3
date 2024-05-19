using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gm : MonoBehaviour
{
    public void EndGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Done()
    {
        SceneManager.LoadScene("over");
    }
}