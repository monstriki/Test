using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneGoScript : MonoBehaviour
{
  
    public void GoToAr()
    {
        SceneManager.LoadScene("AR 2");
    }
     public void GoToBas()
    {
        SceneManager.LoadScene("SampleScene 1");
    }
      public void GoToMenu()
    {
        SceneManager.LoadScene("Start");
    }
}
