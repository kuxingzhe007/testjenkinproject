using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class JenkinsAdapter
{
	[MenuItem("Jenkins/JenkinsBuild")]
	public static void Build()
	{
		EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);

		List<string> sceneList = new List<string>();
		EditorBuildSettingsScene[] temp = EditorBuildSettings.scenes;
		for (int i = 0, iMax = temp.Length; i < iMax; ++i)
			sceneList.Add(temp[i].path);

		BuildPipeline.BuildPlayer(sceneList.ToArray(), "./android.apk", BuildTarget.Android, BuildOptions.None);
	}

	private void TestUpdateCommit(){

	}

    public static void DebugTest()
    {
        Debug.Log("打印日志");
        Debug.LogWarning("打印日志11");
        Debug.LogError("打印日志2");
    }
}