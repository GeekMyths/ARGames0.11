using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LitJson;
public class tongxin : MonoBehaviour {
	string token;
	int uid;
	List<hero> emps=new List<hero>();
	hero zgw=new hero();
	int myempid;

	void Start () {
		token = PlayerPrefs.GetString ("token");
		uid = PlayerPrefs.GetInt ("uid");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public IEnumerator GetMyEmp()
	{
		WWWForm form = new WWWForm();
		form.AddField("token", token);
		form.AddField("uid", uid);
		WWW www = new WWW("url", form);
		yield return www;
		if (www.error != null) 
		{
			print (www.error);
		} 
		else 
		{
			emps= GetMyEmps (www.text);
		} 

	}
	public IEnumerator GetEEmp()
	{
		WWWForm form = new WWWForm();
		form.AddField("token", token);
		form.AddField("uid", uid);
		form.AddField ("selectEmp", myempid);
		WWW www = new WWW("url", form);
		yield return www;
		if (www.error != null) 
		{
			print (www.error);
		} 
		else 
		{
			zgw= GetEnemyEmp (www.text);
		} 

	}





	public List<hero> GetMyEmps(string text){
		JsonData whole = JsonMapper.ToObject (text);
		JsonData Hero = whole ["value"];
		hero ceo = new hero ();
		skill skill1 = new skill ();
		List<hero> heros=new List<hero>();
		for (int i = 0; i < Hero.Count; i++) 
		{
			ceo = JsonMapper.ToObject<hero> (Hero [i].ToJson ());
			for (int j = 0; j < Hero [i] ["skills"].Count; j++) {
				skill1 = JsonMapper.ToObject<skill>(Hero [i] ["skills"][j].ToJson());
				if(Hero [i] ["skills"].Keys.Contains("functions"))
				{
					if (Hero [i] ["skills"][j] ["functions"].Count >= 2) {
						for (int k = 0; k < Hero [i] ["skills"] ["functions"].Count; k++) {
							skill1.functions [k] = JsonMapper.ToObject<Fun> (Hero [i] ["skills"][j] ["functions"] [k].ToJson ());

						}
					} else {
						skill1.functions [0] = JsonMapper.ToObject<Fun> (Hero [i] ["skills"][j]["functions"].ToJson ());
					}
				}
				ceo.skills [j] = skill1;
			}
			heros.Add (ceo);
		}
		return heros;
	}

	public hero GetEnemyEmp(string text){
		JsonData whole = JsonMapper.ToObject (text);
		JsonData Hero = whole ["value"];
		hero ceo = new hero ();
		skill skill1 = new skill ();
			ceo = JsonMapper.ToObject<hero> (Hero.ToJson ());
			for (int j = 0; j < Hero  ["skills"].Count; j++) {
				skill1 = JsonMapper.ToObject<skill>(Hero  ["skills"][j].ToJson());
				if(Hero ["skills"].Keys.Contains("functions"))
				{
					if (Hero  ["skills"][j] ["functions"].Count >= 2) {
						for (int k = 0; k < Hero ["skills"] ["functions"].Count; k++) {
							skill1.functions [k] = JsonMapper.ToObject<Fun> (Hero ["skills"][j] ["functions"] [k].ToJson ());
																					  }
																	  } 
					else {
						skill1.functions [0] = JsonMapper.ToObject<Fun> (Hero  ["skills"][j]["functions"].ToJson ());
					     }
				}
				ceo.skills [j] = skill1;
															  }
		return ceo;
	}
		
	public void SavemyEmp(string savename,Object ob)
	{
		PlayerPrefsExtend.myone = ob;
	}
	public void SaveEnemyEmp(string savename,Object ob){
		PlayerPrefsExtend.hisone = ob;
	}


}