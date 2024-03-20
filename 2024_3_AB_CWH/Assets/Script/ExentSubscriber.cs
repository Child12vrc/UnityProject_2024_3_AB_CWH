using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExentSubscriber : MonoBehaviour
{
    public ExEventChannel eventChannel;

    void OnEventRaised() //Ȱ��ȭ �� �� �̺�Ʈ ���
    {
        Debug.Log(gameObject.name + " ���� �̺�Ʈ �߻�");
    }

    private void OnEnable() //��Ȱ��ȭ �� �� �̺�Ʈ ����
    {
        eventChannel.OnEventRaised.AddListener(OnEventRaised);
    }

    private void OnDisable()
    {
        eventChannel.OnEventRaised.RemoveListener(OnEventRaised);
    }
}
