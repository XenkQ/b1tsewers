using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class PressAnyKeyToStart : MonoBehaviour
{
    public static bool displayPressAnyKeyTextOnStart = true;
    private TMP_Text pressAnyKeyToStartText;
    [SerializeField] private Timer timer;

    private void Awake()
    {
        pressAnyKeyToStartText = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        DisplayPressAnyKeyTextOnlyOneTimeOnStart();
        StartGameIfUserPressAnyKey();
    }

    private void DisplayPressAnyKeyTextOnlyOneTimeOnStart()
    {
        if (displayPressAnyKeyTextOnStart)
        {
            pressAnyKeyToStartText.text = "PRESS ANY KEY TO START";
            GameTimeManager.PauseGameTime();
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    private void StartGameIfUserPressAnyKey()
    {
        if (Input.anyKey)
        {
            displayPressAnyKeyTextOnStart = false;
            GameTimeManager.UnpauseGameTime();
            gameObject.SetActive(false);
        }
    }
}
