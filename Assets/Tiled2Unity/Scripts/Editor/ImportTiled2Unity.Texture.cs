﻿using UnityEditor;
using UnityEngine;

namespace Tiled2Unity
{
	// Handled a texture being imported
	partial class ImportTiled2Unity
	{
		public void TextureImported(string texturePath)
		{
			// This is fix up method due to materials and textures, under some conditions, being imported out of order
			Texture2D texture2d = AssetDatabase.LoadAssetAtPath(texturePath, typeof(Texture2D)) as Texture2D;
			Material material = AssetDatabase.LoadAssetAtPath(GetMaterialAssetPath(texturePath), typeof(Material)) as Material;
			material.SetTexture("_MainTex", texture2d);
		}
	}
}