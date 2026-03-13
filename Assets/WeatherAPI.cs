using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;

public class WeatherAPI : MonoBehaviour
{
    public TextMeshPro weatherText;

    string apiKey = "72be0373480286567bb6dab25e05fd09";
    string city = "Agra";

    void Start()
    {
        StartCoroutine(GetWeather());
    }

    IEnumerator GetWeather()
    {
        string url = "https://api.openweathermap.org/data/2.5/weather?q=" 
                     + city + "&units=imperial&appid=" + apiKey;

        UnityWebRequest www = UnityWebRequest.Get(url);

        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.Success)
        {
            string json = www.downloadHandler.text;

            WeatherData data = JsonUtility.FromJson<WeatherData>(json);

            weatherText.text =
                "Weather\n" +
                data.main.temp + "°F\n" +
                data.weather[0].main;
        }
    }
}

[System.Serializable]
public class WeatherData
{
    public Main main;
    public Weather[] weather;
}

[System.Serializable]
public class Main
{
    public float temp;
}

[System.Serializable]
public class Weather
{
    public string main;
}