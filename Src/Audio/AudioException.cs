using System;

namespace Dissonance.Framework.Audio
{
	public class AudioException : Exception
	{
		public AudioException(string message) : base(message) { }
		public AudioException(string message,Exception innerException) : base(message,innerException) { }
	}
}
