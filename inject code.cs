/* Лоадер
using System;
using UnityEngine;

public class Loader
{
	public static void InitCheats()
	{
		GameObject gameObject = new GameObject();
		gameObject.AddComponent<HackManager>();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
	}
}

{ Эта хуйня идет в безымянное пространство с МОНОБИХУЕВЕР
                   #имя библиотеки    #Путь               #метод
	Assembly.Load("hack.dll").GetType("Loader").GetMethod("InitCheats", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.CreateInstance).Invoke(null, new object[0]);
}
ещё один
		GameObject gameObject = new GameObject();
		gameObject.AddComponent<HackManager>();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
*/

