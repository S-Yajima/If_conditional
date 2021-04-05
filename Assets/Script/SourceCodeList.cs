using System.Collections.Generic;

public class SourceCodeList
{
    private List<string> messageList = new List<string>();

    public SourceCodeList()
    {
        // �� paint�֐��̂݁i���j
        messageList.Add("bool paint(GameObject obj) {\n    obj.GetComponent<Renderer>().material.color = Color.HSVToRGB(1.0f, 1.0f, 1.0f);\n    return true;\n}\n\n");
        // �� paint�֐���Start�i�j��paint�������s�i���F/�����j
        messageList.Add("bool paint(GameObject obj) {\n    obj.GetComponent<Renderer>().material.color = Color.HSVToRGB(1.0f, 1.0f, 1.0f);\n    return true;\n}\n\nvoid Start() {\n    <u><#00FFFF>bool b1 = paint(cube1);</color></u>\n    <u><#00FFFF>bool b2 = paint(cube2);</color></u>\n    <u><#00FFFF>bool b3 = paint(cube3);</color></u>");
        // �� paint�֐���Start�i�j��if()���i����1,����2,����3 ���F�j
        messageList.Add("bool paint(GameObject obj) {\n    obj.GetComponent<Renderer>().material.color = Color.HSVToRGB(1.0f, 1.0f, 1.0f);\n    return true;\n}\n\nvoid Start() {\n    if(<#FFFF00>paint(cube1)==true</color> && <#FFFF00>paint(cube2)==true</color> && <#FFFF00>paint(cube3)==true</color>){\n        // �K���ȏ���\n    }\n");
        //�� paint�֐���Start�i�j��if()�� ( || ���F �j
        messageList.Add("bool paint(GameObject obj) {\n    obj.GetComponent<Renderer>().material.color = Color.HSVToRGB(1.0f, 1.0f, 1.0f);\n    return true;\n}\n\nvoid Start() {\n    if(paint(cube1)==true <#FFFF00>||</color> paint(cube2)==true <#FFFF00>||</color> paint(cube3)==true){\n        // �K���ȏ���\n    }\n");
        //�� paint�֐���Start�i�j��if()���i����1 ���F ||�j
        messageList.Add("bool paint(GameObject obj) {\n    obj.GetComponent<Renderer>().material.color = Color.HSVToRGB(1.0f, 1.0f, 1.0f);\n    return true;\n}\n\nvoid Start() {\n    if(<#FFFF00>paint(cube1)==true</color> || paint(cube2)==true || paint(cube3)==true){\n        // �K���ȏ���\n    }\n");
        //�� paint�֐���Start�i�j��if()���i����2,3 ���F ||�j
        messageList.Add("bool paint(GameObject obj) {\n    obj.GetComponent<Renderer>().material.color = Color.HSVToRGB(1.0f, 1.0f, 1.0f);\n    return true;\n}\n\nvoid Start() {\n    if(paint(cube1)==true || <#00FFFF>paint(cube2)==true</color> || <#00FFFF>paint(cube3)==true</color>){\n        // �K���ȏ���\n    }\n");
    }

    public string getMessage(int index)
    {
        if (messageList.Count == 0 || messageList.Count <= index) return "";

        return messageList[index];
    }

}
