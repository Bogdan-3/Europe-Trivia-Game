[System.Serializable]
public class CountryTriviaData
{
    public string country;
    public string[] questions;
}

[System.Serializable]
public class CountryTriviaList
{
    public CountryTriviaData[] countries;
}

