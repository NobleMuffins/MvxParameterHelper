using System;

namespace NobleMuffins.MvxParameterHelper
{
	public interface IMvxParameterHelperService
	{
		int Put(object o);
		object Pull(int key);
	}
}

