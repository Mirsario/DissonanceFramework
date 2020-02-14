using System;

namespace Dissonance.Framework
{
	public class AudioException : Exception
	{
		public AudioException(string message) : base(message) { }
		public AudioException(string message,Exception innerException) : base(message,innerException) { }
	}
}
