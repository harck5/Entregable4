using UnityEngine;
using TMPro;

public class EventsUI : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private TextMeshProUGUI distanceText;
    private string defaultText = "Distance to Enemy";

    #endregion
    void OnEnable()
    {
        EventsGameManager.OnEnterKeyPressed += InitializeText;

        EventsGameManager.OnEscapeKeyPressed += UpdateText;
    }


    void OnDisable()
    {
        EventsGameManager.OnEnterKeyPressed -= InitializeText;

        EventsGameManager.OnEscapeKeyPressed -= UpdateText;
    }

    private void Awake()
    {
        InitializeText();
    }

    private void InitializeText()
    {
        distanceText.text = defaultText;
    }

    private void UpdateText()
    {
        float distance = EventsPlayerController.Instance.DistanceToEnemy();
        distanceText.text = distance.ToString("F2");
    }
}
