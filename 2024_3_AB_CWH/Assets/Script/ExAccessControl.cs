using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExAccessControl : MonoBehaviour
{
    //public으로 선언된 변수는 다른 스크립트에서 직접 접근 가능
    public int publicValue;

    private int privateValue;

    protected int protectedValue;

    internal int interanlValue;

}
