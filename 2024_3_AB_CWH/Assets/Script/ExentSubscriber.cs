using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExentSubscriber : MonoBehaviour
{
    public ExEventChannel eventChannel;

    void OnEventRaised() //활성화 될 때 이벤트 등록
    {
        Debug.Log(gameObject.name + " 에서 이벤트 발생");
    }

    private void OnEnable() //비활성화 될 때 이벤트 해제
    {
        eventChannel.OnEventRaised.AddListener(OnEventRaised);
    }

    private void OnDisable()
    {
        eventChannel.OnEventRaised.RemoveListener(OnEventRaised);
    }
}
