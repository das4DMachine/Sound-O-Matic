using UnityEngine;
using System.Collections;

public class CategoryType {
	public string title;
	public Category[] categories;

	public CategoryType(string catTypeTitle, Category[] categoriesInType){
		title = catTypeTitle;
		categories = categoriesInType;
	}
}
