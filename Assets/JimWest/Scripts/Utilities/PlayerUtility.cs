using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Utility
{
	public class PlayerUtility {
	
		public static GameObject GetPlayer() {
			return GameObject.FindWithTag("Player");
		}
	}
	
}