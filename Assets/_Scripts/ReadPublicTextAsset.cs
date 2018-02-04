using UnityEngine;
using UnityEngine.UI;

public class ReadPublicTextAsset : MonoBehaviour 
{
	public TextAsset dataTextFile;
	
	private void Start() {
		string textFromFile = dataTextFile.text;

        Text textOnScreen = GetComponent<Text>();
        textOnScreen.text = textFromFile;
	}
}
