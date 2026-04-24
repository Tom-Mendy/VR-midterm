using UnityEngine;

public class ClockAnalog : MonoBehaviour
{

    [SerializeField] private Transform Hour_hand;
    [SerializeField] private Transform minute_hand;
    [SerializeField] private Transform second_hand;

    // Update is called once per frame
    void FixedUpdate()
    {
        var currentTime = System.DateTime.Now;
        var currrentHour = currentTime.Hour;
        var currentMinute = currentTime.Minute;
        var currentSecond = currentTime.Second;

        var currrentHourDegree = (currrentHour / 12f) * 360f + (currentMinute / 60f) * 30f;
        var currentMinuteDegree = (currentMinute / 60f) * 360f;
        var currentSecondDegree = (currentSecond / 60f) * 360f;
        Hour_hand.localRotation = Quaternion.Euler(currrentHourDegree, 0, 0);
        minute_hand.localRotation = Quaternion.Euler(currentMinuteDegree, 0, 0);
        second_hand.localRotation = Quaternion.Euler(currentSecondDegree, 0, 0);
    }
}
