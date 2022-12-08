using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.UI;

public class ScalerProfileListItem : MonoBehaviour
{
    public Text ScalerProfileName;

    public void LoadScalerProfile()
    {
        IAdaptivePerformanceSettings settings = AdaptivePerformanceGeneralSettings.Instance.Manager.activeLoader.GetSettings();
        if (settings == null)
            return;

        if (ScalerProfileName != null && ScalerProfileName.text.Length != 0)
        {
            Debug.Log($"[Scaler Profile Sample] Load Scaler profile {ScalerProfileName.text}");
            settings.LoadScalerProfile(ScalerProfileName.text);
        }
        else
            Debug.Log($"[Scaler Profile Sample] No scaler profiles availalbe to load. Please add at least 2 profiles.");
    }
}
