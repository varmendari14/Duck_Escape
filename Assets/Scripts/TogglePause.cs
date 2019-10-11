using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TogglePause : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    
    void Awake() {
        canvasGroup = GetComponent<CanvasGroup>();
        if (canvasGroup == null) {
            Debug.LogError("canvasGroup component not found.");
        }
    }

    void Start() {
        canvasGroup.alpha = 0;
    }

    void Update() {
        if (Input.GetKeyUp(KeyCode.Escape)) {
            if (canvasGroup.interactable) {
                canvasGroup.interactable = false;
                canvasGroup.blocksRaycasts = false;
                canvasGroup.alpha = 0f;
                Time.timeScale = 1f;
            } else {
                canvasGroup.interactable = true;
                canvasGroup.blocksRaycasts = true;
                canvasGroup.alpha = 1f;
                Time.timeScale = 0f;
            }
        }
    }
}
