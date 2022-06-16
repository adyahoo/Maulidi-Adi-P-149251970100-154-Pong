using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnBackController : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    //back to main menu method
    public void backToMain()
    {
        SceneManager.LoadScene(sceneName);
    }
}
