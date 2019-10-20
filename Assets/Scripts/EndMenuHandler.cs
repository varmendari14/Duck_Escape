using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenuHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Quit()
    {
        Debug.Log("Quit Button Pressed");
        Application.Quit();
    }

    public void RestartOrNext()
    {
        Debug.Log("Next Button Pressed");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
        // TODO: Add behavior for going to the next level when we have more than one
    }
}
