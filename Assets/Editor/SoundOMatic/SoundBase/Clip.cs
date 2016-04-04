using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Clip {
	public int id;
	public int duration;
	public string filename;
	public string tags;
	public string comments;
	
	public List<int> categories;

	public Clip(int dbclipID, int duration, string thefilename, string tagList, string commentsMaybe, List<int> categories){
		this.categories = new List<int>();
		this.categories.AddRange(categories);
		id = dbclipID;
		this.duration = duration;
		filename = thefilename;
		tags = tagList;
		comments = commentsMaybe;
	}
}
