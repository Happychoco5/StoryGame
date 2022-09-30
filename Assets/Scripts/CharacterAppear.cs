using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterAppear : MonoBehaviour
{
    string myString;

    int currLine = 0;
    public TextLibrary myTextLibrary;

    public float characterTimer = 0.5f;

    public TMPro.TextMeshProUGUI textToChange;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    IEnumerator AnimateText(string completeString)
    {
        int i = 0;
        myString = "";
        while(i < completeString.Length)
        {
            myString += completeString[i++];
            textToChange.text = myString;
            yield return new WaitForSeconds(characterTimer);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Go to next text.
            Debug.Log(myTextLibrary.lines[currLine]);
            StartCoroutine(AnimateText(myTextLibrary.lines[currLine]));
            currLine++;
        }
    }
}
