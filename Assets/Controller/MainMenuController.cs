using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    //navigate to game scene
    public void playGame()
    {
        SceneManager.LoadScene("Game");
    }

    //navigate to credit scene
    public void openCredit()
    {
        SceneManager.LoadScene("Credit");
    }

    //create log
    public void openAuthor()
    {
        Debug.Log("Created by Maulidi Adi Prasetia - 149251970100-154");
    }
}
