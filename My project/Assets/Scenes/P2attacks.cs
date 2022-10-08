using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P2attacks : MonoBehaviour
{
  public void LPunch2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }

  public void HPunch2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }

  public void LKick2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }

  public void HKick2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
    }

  public void Special2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
    }


}