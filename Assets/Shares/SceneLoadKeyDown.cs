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
        CurrentScene = gameObject.scene;
    }

    void Update()
    {
        // ���� �ִ� ������ �̵��ϴ� Ű�� ������ ��� �� ��ȯ �� �ǰ� ��
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (CurrentScene.name != UpperworldScene.name)
            {
                print("go to Upperworld");
                SceneManager.LoadScene(UpperworldScene.name);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (CurrentScene.name != MiddleworldScene.name)
            {
                print("go to Middleworld");
                SceneManager.LoadScene(MiddleworldScene.name);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (CurrentScene.name != LowerworldScene.name)
            {
                print("go to Lowerworld");
                SceneManager.LoadScene(LowerworldScene.name);
            }
        }
    }
}
