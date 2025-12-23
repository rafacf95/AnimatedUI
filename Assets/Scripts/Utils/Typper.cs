using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class Typper : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public float timeBetweenLetters = .1f;
    public string phrase;

    void Start()
    {
        textMesh.text = "";
    }

    [NaughtyAttributes.Button]
    public void StartType()
    {
        if (!EditorApplication.isPlaying) return;
        StartCoroutine(Type(phrase));
    }

    IEnumerator Type(string s)
    {
        textMesh.text = "";
        foreach (char l in s.ToCharArray())
        {
            textMesh.text += l;
            yield return new WaitForSeconds(timeBetweenLetters);
        }
    }
}
