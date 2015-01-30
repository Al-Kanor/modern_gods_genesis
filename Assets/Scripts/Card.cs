﻿using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {
    public GameObject unitPrefab;
    
    void OnMouseDown() {
        GameObject unit = (GameObject) Instantiate(unitPrefab, InputManager.MouseWorldPosition(), Quaternion.identity);
        unit.GetComponent<Unit> ().card = gameObject;
        unit.GetComponent<SphereCollider>().enabled = false;    // Pour ne pas intercepter le clic de placement
        //GameManager.instance.action = GameManager.Action.UNIT_IN_PLACEMENT;
        GameManager.instance.unitInPlacement = unit;
        gameObject.SetActive (false);
        Camera.main.GetComponent<Camera> ().orthographic = true;
    }
}