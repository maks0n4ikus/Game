using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManeg : MonoBehaviour
{

    void Start()
    {
        
    }

    public void SceneChange()
    {
        SceneManager.LoadScene("game");
    }

    public void SelectHome()
    {
        SceneManager.LoadScene("MiniGames");
    }

    public void SortPuzzle()
    {
        SceneManager.LoadScene("Start");
    }

    public void Eggs()
    {
        SceneManager.LoadScene("Eggs");
    }

    public void Jump()
    {
        SceneManager.LoadScene("jump");
    }


    void Update()
    {
        
    }
}
