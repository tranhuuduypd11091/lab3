using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class TimeManager : MonoBehaviour
{
    public Text timeText;
    private float currentTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        UpdateTimeDisplay();
    }
    void UpdateTimeDisplay()
    {
        int minites = Mathf.FloorToInt(currentTime / 60F);
        int seconds = Mathf.FloorToInt(currentTime - minites * 60);
        string timeString = string.Format("{0:0} :{1:00}",minites, seconds);
        timeText.text = "thoi gian da choi: " + timeString;

    }
}
