using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] Text scoreField;
    public static int points = 0;

    private void Start() {
        scoreField.text = points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       scoreField.text = points.ToString();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "coin" ) {
            points = points + 1;
            Destroy(other.gameObject);
        }
    }

}
