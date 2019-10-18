using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {
    [System.Serializable]
    public struct ButtonPlayerPrefs {
        public GameObject gameObject;
        public string playerPrefKey;
    }

    private void Start() {
        for (int i = 0; i < buttons.Length; i++) {
            int score = PlayerPrefs.GetInt(buttons[i].playerPrefKey, 0);
            
            for (int starIdx = 1; starIdx <= 3; starIdx++) {
                Transform star = buttons[i].gameObject.transform.Find("star" + starIdx);

                if (starIdx <= score) {
                    star.gameObject.SetActive(true);
                } else {
                  star.gameObject.SetActive(false);  
                }
            }
        }

        
    }

    public ButtonPlayerPrefs[] buttons;

    public void OnButtonPress(string levelName) {
        SceneManager.LoadScene(levelName);
    }
}