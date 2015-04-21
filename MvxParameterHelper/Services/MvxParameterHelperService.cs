using System;
using System.Collections.Generic;

namespace NobleMuffins.MvxParameterHelper
{
	public class MvxParameterHelperService: IMvxParameterHelperService
	{
		private readonly IDictionary<int,object> pool = new Dictionary<int, object>();

		#region IMvxParameterHelperService implementation

		public int Put (object o)
		{
			int key;
			for (key = 0; key < int.MaxValue && pool.ContainsKey (key); key++);
			pool [key] = o;
			return key;
		}

		public object Pull (int key)
		{
			if (pool.ContainsKey (key)) {
				var o = pool [key];
				pool.Remove (key);
				return o;
			} else {
				throw new ArgumentException ();
			}
		}

		#endregion
	}
}

