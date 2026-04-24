using UnityEngine;
using TMPro;

public class ActualTime : MonoBehaviour
{
    private TMP_Text timeText;

    private void Start()
    {
        timeText = GetComponent<TMP_Text>();
    }

    private void FixedUpdate()
    {
        int totalSeconds = Mathf.FloorToInt(Time.time);
        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        timeText.text = $"{minutes:00}:{seconds:00}";
    }
}