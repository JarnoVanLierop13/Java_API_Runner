using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScript : MonoBehaviour {

    public void Quit() {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
                         Application.OpenURL(webplayerQuitURL);
#else
                         Application.Quit();
#endif
    }

    public void NextScene()
	{
		SceneManager.LoadScene("Game");
	}
}
