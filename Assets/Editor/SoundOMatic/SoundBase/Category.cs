using UnityEngine;
using System.Collections;

public class Category {
	public int id;
	public string title;
	public bool isSelected;

	public Category(int catID, string catText){
		id = catID;
		title = catText;
		isSelected = false;
	}
}
