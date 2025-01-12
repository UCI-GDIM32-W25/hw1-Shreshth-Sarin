using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        if (_plantedText != null && _remainingText != null)
        {
            _plantedText.text = $"{seedsPlanted}";
            _remainingText.text = $"{seedsLeft}";
        }
        else
        {
            Debug.LogError("PointsText reference is missing!");
        }
    }
}