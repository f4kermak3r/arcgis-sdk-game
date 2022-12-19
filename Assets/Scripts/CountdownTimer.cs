using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime = 10f;

    [SerializeField] Text countDownTextas;

    // Start is called before the first frame update
    void Start()
    {
     currentTime = startingTime;   
    }

    // Update is called once per frame
    void Update()
    {
     currentTime -= 1 * Time.deltaTime;
     countDownTextas.text = "Time left: " +currentTime.ToString("0") + " sec";

     if(currentTime < 0) {
        SceneManager.LoadScene("GameOver");
     }
    }
}
