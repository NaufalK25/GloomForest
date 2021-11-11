using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Prologue : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI[] prologueTexts;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(changePrologue());
    }

    IEnumerator changePrologue()
    {
        foreach (var prologueText in prologueTexts)
        {
            prologueText.gameObject.SetActive(true);
            yield return new WaitForSeconds(6);
            prologueText.gameObject.SetActive(false);
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}