using System;

namespace StartingApp.Infrastructure
{
	public static class PreConditions
	{
		public static T CheckNotNull<T>(T value, string paramName)
			where T : class
		{
			if(value == null)
			{
				throw new ArgumentNullException(paramName);
			}	
			return value;
		}
	}
}