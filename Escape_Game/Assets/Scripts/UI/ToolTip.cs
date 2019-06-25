using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ToolTip : MonoBehaviour
{
    #region Singleton
    public static ToolTip instance;
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one Instance of Tooltip found");
            return;
        }
        instance = this;
		if (instance == null){
			Debug.Log("check");
		}
        gameObject.SetActive(false);
    }
    #endregion
    public void ShowTooltip(Vector3 position, IDescribable description)
    {
        gameObject.SetActive(true);
        gameObject.transform.position = position;
        gameObject.GetComponentInChildren<Text>().text = description.GetDescription();
    }

    public void HideTooltip()
    {
        gameObject.SetActive(false);
    }
}
