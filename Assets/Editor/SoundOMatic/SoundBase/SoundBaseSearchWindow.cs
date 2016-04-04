using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using SimpleJSON;
using System.Net;
using System.IO;
using System.Text;

public class SoundBaseSearchWindow : EditorWindow {
	private AudioNode targetNode;
	private string keywordSearchText = "";
	private Vector2 scrollPosition;

	private static CategoryType[] categoryTypes = new CategoryType[]{
		new CategoryType("Sound Source", new Category[]{
			new Category(2, "Ambience"), 
			new Category(3, "Animal"), 
			new Category(4, "Man-made"), 
			new Category(5, "Weather"), 
			new Category(6, "Object"), 
			new Category(9, "Nature")}), 
		new CategoryType("Clip Properties", new Category[]{
			new Category(1, "Loopable"), 
			new Category(7, "Multichannel")})
		/*, 
		new CategoryType("Tropical Climate Zone", new Category[]{
			new Category(10, "Central Africa"), 
			new Category(11, "Madagascar"), 
			new Category(12, "South America"), 
			new Category(13, "Asia")}), 
		new CategoryType("Mountain Forest Climate Zone", new Category[]{
			new Category(14, "South America"), 
			new Category(15, "Asia"), 
			new Category(16, "Australia")}), 
		new CategoryType("Desert Climate Zone", new Category[]{
			new Category(17, "North Africa"), 
			new Category(18, "Middle East"), 
			new Category(19, "North America")}), 
		new CategoryType("Mediterranean Climate Zone", new Category[]{
			new Category(20, "Australia"), 
			new Category(21, "Canary Islands"), 
			new Category(22, "Mediterranean countries"), 
			new Category(23, "South Africa")})
			*/
	};
	
	private static List<Clip> allClips = new List<Clip>();
	
	private static HashSet<int> usedClips = new HashSet<int>();
	
	private List<Clip> filteredClips = new List<Clip>();
	
	private void updateFilters(string keyword) {
		filteredClips.Clear();
		
		foreach(Clip clip in allClips) {
			bool shouldInclude = false;
			if(clip.filename.ToLower().IndexOf(keyword) != -1) {
				shouldInclude = true;
			} else if(clip.comments.ToLower().IndexOf(keyword) != -1) {
				shouldInclude = true;
			} else if(clip.tags.ToLower().IndexOf(keyword) != -1) {
				shouldInclude = true;
			}
			
			foreach(CategoryType catType in categoryTypes) {
				foreach(Category cat in catType.categories) {
					if(cat.isSelected) {
						bool found = false;
						foreach(int catId in clip.categories) {
							if(catId == cat.id) {
								found = true;
								break;
							}
						}
						shouldInclude = shouldInclude && found;
					}
				}
			}
			
			if(shouldInclude) {
				filteredClips.Add(clip);
			}
		}
	}
	
	private static string getCategoryNameFromId(int id) {
		foreach(CategoryType catType in categoryTypes) {
			foreach(Category cat in catType.categories) {
				if(cat.id == id) {
					return cat.title;
				}
			}
		}
		
		return id+":N/A";
	}
	
    private static void findUsedClips()
    {
        usedClips.Clear();
        AudioNode[] nodes = FindObjectsOfType(typeof(AudioNode)) as AudioNode[];
        foreach (AudioNode child in nodes)
        {
            usedClips.Add(child.audioIdentifier);
        }
    }
	
	private static void loadAllClips() {
        SoundOMaticClient soundOMaticClient = Object.FindObjectOfType<SoundOMaticClient>();

		string url = soundOMaticClient.soundbaseUrl+"/?cmd=getAllClips";
		CredentialCache credentialCache = new CredentialCache();
		try {
			credentialCache.Add(new System.Uri(url), "Basic", new NetworkCredential(soundOMaticClient.soundbaseUsername, soundOMaticClient.soundbasePassword));
		} catch (System.UriFormatException ex){
			Debug.Log("The URL selected for SoundOMatic does not seem to work properly, please fix it", soundOMaticClient);
			throw ex;
		}
		
		HttpWebRequest request = (HttpWebRequest)WebRequest.Create (url);
		request.Credentials = credentialCache;
		request.PreAuthenticate = true;
		HttpWebResponse response = (HttpWebResponse)request.GetResponse ();
		StreamReader readStream = new StreamReader (response.GetResponseStream(), Encoding.UTF8);
		
		string responseText = readStream.ReadToEnd();
		
		JSONArray data = JSON.Parse(responseText).AsArray;
		
		allClips.Clear();
		
		foreach(JSONNode node in data) {
			int id = node["id"].AsInt;
			int duration = node["duration"].AsInt;
			string comment = ((node["comment"]==null)?"":node["comment"]+"");
			string tags = ((node["tags"]==null)?"":node["tags"]+"");
			string filename = ((node["filename"]==null)?"":node["filename"]+"");
			JSONArray categoryArray = node["categories"].AsArray;
			List<int> categories = new List<int>();
			foreach(JSONNode cat in categoryArray) {
				categories.Add(cat.AsInt);
			}
			try {
				Clip clip = new Clip(id, duration, filename.Replace("'", ""), tags.Replace("'", ""), comment.Replace("'", ""), categories);
				allClips.Add(clip);
			} catch (System.Exception ex){
				Debug.Log("couldn't handle sample "+id+" "+(comment==null?"nuller":"notnul")+"æ"+tags+"ø"+filename+"f"+ex);
			}
		}
	}

    public static string getNameFromId(int audioIdentifier)
    {
        loadAllClips();

        foreach (Clip clip in allClips)
        {
            if (clip.id == audioIdentifier)
            {
                return clip.filename;
            }
        }

        return null;
    }

	public static void createWindow(AudioNode target){
		loadAllClips();
        findUsedClips();
		SoundBaseSearchWindow window = (SoundBaseSearchWindow)EditorWindow.GetWindow (typeof (SoundBaseSearchWindow));
		window.targetNode = target;
	}
	
	public void OnGUI() {
		// Search inputs
		keywordSearchText = EditorGUILayout.TextField("QuickSearch", keywordSearchText);
		
		updateFilters(keywordSearchText.ToLower());
		
		EditorGUILayout.HelpBox("Search for sounds in the current soundfont by typing in search keywords and/or checking corresponding checkboxes below", MessageType.Info);
		
		EditorGUILayout.BeginHorizontal ();		
		EditorGUILayout.BeginVertical (GUILayout.Width(50));		
		
		foreach(CategoryType categoryType in categoryTypes){
			showCategorySelector(categoryType.title, categoryType.categories);				
		}
		EditorGUILayout.EndVertical ();		
		EditorGUILayout.BeginVertical (GUILayout.Width(350), GUILayout.MaxWidth(3500), GUILayout.ExpandWidth(true));		
		
		// Search results
		scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, false, true);		
		GUIStyle style = GUI.skin.GetStyle ("box");
		
		EditorGUILayout.BeginHorizontal();
		EditorGUILayout.LabelField("", GUILayout.Width(50));
		//EditorGUILayout.LabelField("Id");
		EditorGUILayout.LabelField("Filename");
		EditorGUILayout.LabelField("Duration", GUILayout.Width(60));
		EditorGUILayout.LabelField("Tags");
		EditorGUILayout.LabelField("Categories");
		EditorGUILayout.LabelField("Comment");
		EditorGUILayout.EndHorizontal();
		
		foreach(Clip clip in filteredClips){
			if(targetNode.audioIdentifier == clip.id) {
				GUI.backgroundColor = Color.yellow;
			} else {
                if (usedClips.Contains(clip.id))
                {
                    GUI.backgroundColor = Color.grey;
                }
                else
                {
                    GUI.backgroundColor = Color.white;
                }
			}
			
			GUILayout.BeginHorizontal(new GUIContent("","--- Clip information ---\nFilename:\n\t"+clip.filename+"\nAudio Identifier:\n\t"+clip.id+"\nDuration:\n\t"+clip.duration+"sec\n\nTags:\n\t"+clip.tags+"\nComments:\n\t"+clip.comments), style, new GUILayoutOption[0]);		
			if(GUILayout.Button("Select", GUILayout.Width(50))){
				targetNode.audioIdentifier = clip.id;
				targetNode.audioName = clip.filename;
				EditorUtility.SetDirty(targetNode);
				Close();
			}		
			
			string categoryString = "";
			bool first = true;
			
			foreach(int catId in clip.categories) {
				if(first) {
					first = false;
				} else {
					categoryString += ", ";
				}
				categoryString += getCategoryNameFromId(catId);
			}
			
			EditorGUILayout.LabelField(clip.filename);
			EditorGUILayout.LabelField(clip.duration+"sec", GUILayout.Width(60));
			EditorGUILayout.LabelField(clip.tags);
			EditorGUILayout.LabelField(categoryString);
			EditorGUILayout.LabelField(clip.comments);
			GUILayout.EndHorizontal ();
		}
		
		EditorGUILayout.EndScrollView();
		EditorGUILayout.EndVertical ();
		EditorGUILayout.EndHorizontal ();
	}
	
	private void showCategorySelector(string title, Category[] categories){
		//EditorGUILayout.Space();
		int counter = 3;
		EditorGUILayout.BeginVertical("Box");		
		EditorGUILayout.LabelField(title);
		foreach (Category category in categories){
			if (counter == 0){
			}
			category.isSelected = EditorGUILayout.ToggleLeft(category.title, category.isSelected);
			counter --;
		}
		EditorGUILayout.EndVertical();		
	}
}
