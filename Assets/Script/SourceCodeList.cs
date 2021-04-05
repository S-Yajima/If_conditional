using System.Collections.Generic;

public class SourceCodeList
{
    private List<string> messageList = new List<string>();

    public SourceCodeList()
    {
        // ◆ paint関数のみ（白）
        messageList.Add("bool paint(GameObject obj) {\n    obj.GetComponent<Renderer>().material.color = Color.HSVToRGB(1.0f, 1.0f, 1.0f);\n    return true;\n}\n\n");
        // ◆ paint関数とStart（）でpaint順次実行（水色/下線）
        messageList.Add("bool paint(GameObject obj) {\n    obj.GetComponent<Renderer>().material.color = Color.HSVToRGB(1.0f, 1.0f, 1.0f);\n    return true;\n}\n\nvoid Start() {\n    <u><#00FFFF>bool b1 = paint(cube1);</color></u>\n    <u><#00FFFF>bool b2 = paint(cube2);</color></u>\n    <u><#00FFFF>bool b3 = paint(cube3);</color></u>");
        // ◆ paint関数とStart（）でif()文（条件1,条件2,条件3 黄色）
        messageList.Add("bool paint(GameObject obj) {\n    obj.GetComponent<Renderer>().material.color = Color.HSVToRGB(1.0f, 1.0f, 1.0f);\n    return true;\n}\n\nvoid Start() {\n    if(<#FFFF00>paint(cube1)==true</color> && <#FFFF00>paint(cube2)==true</color> && <#FFFF00>paint(cube3)==true</color>){\n        // 適当な処理\n    }\n");
        //◆ paint関数とStart（）でif()文 ( || 黄色 ）
        messageList.Add("bool paint(GameObject obj) {\n    obj.GetComponent<Renderer>().material.color = Color.HSVToRGB(1.0f, 1.0f, 1.0f);\n    return true;\n}\n\nvoid Start() {\n    if(paint(cube1)==true <#FFFF00>||</color> paint(cube2)==true <#FFFF00>||</color> paint(cube3)==true){\n        // 適当な処理\n    }\n");
        //◆ paint関数とStart（）でif()文（条件1 黄色 ||）
        messageList.Add("bool paint(GameObject obj) {\n    obj.GetComponent<Renderer>().material.color = Color.HSVToRGB(1.0f, 1.0f, 1.0f);\n    return true;\n}\n\nvoid Start() {\n    if(<#FFFF00>paint(cube1)==true</color> || paint(cube2)==true || paint(cube3)==true){\n        // 適当な処理\n    }\n");
        //◆ paint関数とStart（）でif()文（条件2,3 水色 ||）
        messageList.Add("bool paint(GameObject obj) {\n    obj.GetComponent<Renderer>().material.color = Color.HSVToRGB(1.0f, 1.0f, 1.0f);\n    return true;\n}\n\nvoid Start() {\n    if(paint(cube1)==true || <#00FFFF>paint(cube2)==true</color> || <#00FFFF>paint(cube3)==true</color>){\n        // 適当な処理\n    }\n");
    }

    public string getMessage(int index)
    {
        if (messageList.Count == 0 || messageList.Count <= index) return "";

        return messageList[index];
    }

}
