using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadKeyDown : MonoBehaviour
{
    public Object UpperworldScene;
    public Object MiddleworldScene;
    public Object LowerworldScene;
    Scene CurrentScene;

    void Start()
    {
        print("SceneLoadKeyDown script start"); // �ܼ� Ȯ�ο� ��¹� : ���� �÷����� �� � ��ũ��Ʈ�� ����Ǿ����� ��Ÿ��
        CurrentScene = gameObject.scene;
    }

    void Update()
    {
        // ���� �ִ� ������ �̵��ϴ� Ű�� ������ ��� �� ��ȯ �� �ǰ� ��
        // ����Ƽ Ű �ڵ� ���� : https://docs.unity3d.com/kr/2021.3/ScriptReference/KeyCode.html
        // ����Ű ���� : Ctrl + 1, 2, 3
        // Ű���� ���� ���� Ű, ���� �е� ���� Ű ��� ����
        // �¿� ��Ʈ�� Ű ��� ����
        if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
            && (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)))
        {
            if (CurrentScene.name != UpperworldScene.name)
            {
                print("go to Upperworld");
                SceneManager.LoadScene(UpperworldScene.name);
            }
        }
        if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
            && (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)))
        {
            if (CurrentScene.name != MiddleworldScene.name)
            {
                print("go to Middleworld");
                SceneManager.LoadScene(MiddleworldScene.name);
            }
        }
        if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
            && (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)))
        {
            if (CurrentScene.name != LowerworldScene.name)
            {
                print("go to Lowerworld");
                SceneManager.LoadScene(LowerworldScene.name);
            }
        }
    }
}
