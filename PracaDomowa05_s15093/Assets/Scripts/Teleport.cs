using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Teleport : MonoBehaviour {
    public GameObject text;
    public GameObject key;
    public void Start() {
        text.gameObject.SetActive(false);
        key.gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D col) {
        if (col.transform.tag == "Player") {
            if (PlayerMovement.isKeyTaken) {
                SceneManager.LoadScene(0);
            }
            else {
                text.gameObject.SetActive(true);
                key.gameObject.SetActive(true);
            }
        }
    }
    void OnTriggerExit2D(Collider2D col) {
        if (col.transform.tag == "Player") {

            text.gameObject.SetActive(false);
            key.gameObject.SetActive(false);

        }
    }
}
