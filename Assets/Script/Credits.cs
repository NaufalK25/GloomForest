using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitingChangeScene());
    }

    // Update is called once per frame
    IEnumerator waitingChangeScene()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(0);
    }
}