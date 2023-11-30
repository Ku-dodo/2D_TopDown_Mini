using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionKeyGuide : MonoBehaviour
{
    private GameObject _PrevInteractiveObj;

    // Update is called once per frame
    void Update()
    {
        GameObject _CurrInteractiveObj = transform.GetComponent<InteractionRayCast>()._interactiveObj;
        if (_CurrInteractiveObj != null && _PrevInteractiveObj == null)
        {
            _PrevInteractiveObj = _CurrInteractiveObj;
            _PrevInteractiveObj.GetComponent<NpcInteractiveUI>().CallInteractionUITrue();
        }
        else if (_CurrInteractiveObj != null && _CurrInteractiveObj != _PrevInteractiveObj )
        {
            _PrevInteractiveObj.GetComponent<NpcInteractiveUI>().CallInteractionUIFalse();
            _PrevInteractiveObj = _CurrInteractiveObj;
            _PrevInteractiveObj.GetComponent<NpcInteractiveUI>().CallInteractionUITrue();
        }
        else if  (_CurrInteractiveObj == null && _PrevInteractiveObj != null)
        {
            _PrevInteractiveObj.GetComponent<NpcInteractiveUI>().CallInteractionUIFalse();
            _PrevInteractiveObj = null;
        }

    }
}
