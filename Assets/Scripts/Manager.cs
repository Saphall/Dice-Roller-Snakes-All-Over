
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void restart()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void ladderClimb()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

}
