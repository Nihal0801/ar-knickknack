using System;
using UnityEngine;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    public TextMeshPro timeText;

    void Update()
    {
        TimeZoneInfo india =
        TimeZoneInfo.FindSystemTimeZoneById("Asia/Kolkata");

        DateTime indiaTime =
        TimeZoneInfo.ConvertTime(DateTime.Now, india);

        timeText.text =
        "Agra Time\n" + indiaTime.ToString("hh:mm tt");
    }
}