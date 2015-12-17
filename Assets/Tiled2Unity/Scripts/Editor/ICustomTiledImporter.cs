﻿using System.Collections.Generic;
using UnityEngine;

namespace Tiled2Unity
{
	interface ICustomTiledImporter
	{
		// A game object within the prefab has some custom properties assigned through Tiled that are not consumed by Tiled2Unity
		// This callback gives customized importers a chance to react to such properties.
		void HandleCustomProperties(GameObject gameObject, IDictionary<string, string> customProperties);

		// Called just before the prefab is saved to the asset database
		// A last chance opportunity to modify it through script
		void CustomizePrefab(GameObject prefab);
	}
}

// Examples
/*
[Tiled2Unity.CustomTiledImporter]
class CustomImporterAddComponent : Tiled2Unity.ICustomTiledImporter
{
    public void HandleCustomProperties(UnityEngine.GameObject gameObject,
        IDictionary<string, string> props)
    {
        // Simply add a component to our GameObject
        if (props.ContainsKey("AddComp"))
        {
            gameObject.AddComponent(props["AddComp"]);
        }
    }


    public void CustomizePrefab(GameObject prefab)
    {
        // Do nothing
    }
}
*/
