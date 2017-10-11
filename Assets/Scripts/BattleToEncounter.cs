﻿using UnityEngine;
using UnityEngine.UI;

public class BattleToEncounter : MonoBehaviour {

    private Button button;
    // Use this for initialization
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(SceneTransition);
    }

    private void SceneTransition()
    {
        Application.LoadLevel("EncounterView");
    }
}
