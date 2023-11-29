using System;
using UnityEngine;

public class AddChildPrefab : MonoBehaviour
{
    private event Action PrefabAdd;

    public GameObject _knightPrefab;
    public GameObject _wizardPrefab;
    // Start is called before the first frame update
    private void Awake()
    {
        instanceJobPrefab();
        PrefabAdd = instanceJobPrefab;
    }

    public void CallPrefabAdd()
    {
        PrefabAdd?.Invoke();
    }
    public void instanceJobPrefab()
    {

        Destroy(GameObject.Find(_knightPrefab.name + "(Clone)"));
        Destroy(GameObject.Find(_wizardPrefab.name + "(Clone)"));

        string JobKey = PlayerPrefs.GetString("JobName");
        if (JobKey == "KnightBtn")
        {
            Instantiate(_knightPrefab);
        }
        else if (JobKey == "WizardBtn")
        {
            Instantiate(_wizardPrefab);
        }
    }
    
}
