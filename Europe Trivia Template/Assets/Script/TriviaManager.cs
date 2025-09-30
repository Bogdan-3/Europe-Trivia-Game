using UnityEngine;
using System.IO;
using TMPro;

public class TriviaManager : MonoBehaviour
{
    public static TriviaManager Instance;

    [Header("UI References")]
    public GameObject questionPanel;
    public TextMeshProUGUI questionText;
    public TextMeshProUGUI WhatquestionText;

    private CountryTriviaList triviaData;

    private void Awake()
    {
        Instance = this;
        questionPanel.SetActive(false);

        LoadTriviaData();
    }

    private void LoadTriviaData()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "trivia.json");
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            triviaData = JsonUtility.FromJson<CountryTriviaList>("{\"countries\":" + json + "}");
        }
        else
        {
            Debug.LogError("Trivia JSON not found at " + path);
        }
    }

    public void ShowQuestion(string country)
    {
        if (triviaData == null) return;

        foreach (var c in triviaData.countries)
        {
            if (c.country == country)
            {
                int randomIndex = Random.Range(0, c.questions.Length);
                questionPanel.SetActive(true);
                questionText.text = c.questions[randomIndex];
                WhatquestionText.text = "Intrebare Despre " + country;
                return;
            }
        }

        questionPanel.SetActive(true);
        questionText.text = "No questions available for " + country;
        WhatquestionText.text = "Intrebare Despre " + country;
    }
}
