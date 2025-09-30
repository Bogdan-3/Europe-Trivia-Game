using UnityEngine;
using UnityEngine.UI;

public class TeamButton : MonoBehaviour
{
    GameObject CountryCurent;
    public void GetCountry(GameObject Country)
    {
        CountryCurent = Country;
    }
    public void TeamChange1()
    {
        CountryCurent.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
    }
    public void TeamChange2()
    {
        CountryCurent.GetComponent<Image>().color = new Color32(0,0,255,255);
    }
}
