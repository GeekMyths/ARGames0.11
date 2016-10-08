using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class getText : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void getUser()
    {
        string user = GameObject.Find("Ip_username").GetComponent<InputField>().text;
        print(user);
        string password = GameObject.Find("Ip_password").GetComponent<InputField>().text;
        print(password);
        Connect(user, password);


    }
    IEnumerator Connect(string account,string pwd)
    {
        WWWForm form = new WWWForm();
        form.AddField("account", account);
        form.AddField("pwd", pwd);
 
        WWW www = new WWW("218.75.123.165:8080/game1/s/login", form);
        yield return www;
        if (www.error != null)
        {
            print(www.error);
        }
        else
        {
            print(www.text);
        }
    }

}
