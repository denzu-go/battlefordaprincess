using UnityEngine;
using UnityEngine.SceneManagement;
public class Timer: MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading =2f;
    [SerializeField]
    private string sceneNameToLoad;

    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}