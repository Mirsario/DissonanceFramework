using System;

namespace CodeGenerator.Utilities
{
	internal static class StringUtils
	{
		public static string Capitalize(string text)
		{
			if (text.Length > 0 && char.IsLower(text[0])) {
				var chars = text.ToCharArray();

				chars[0] = char.ToUpper(chars[0]);

				return new string(chars);
			}

			return text;
		}

		public static string RemovePrefix(string text, string prefix)
		{
			if (text.StartsWith(prefix)) {
				text = text.Substring(prefix.Length);
			}

			return text;
		}

		public static string SnakeCaseToUpperCamelCase(string name)
		{
			string[] splits = name.Split('_');

			if (splits.Length > 0) {
				// Capitalize each part
				for (int i = 0; i < splits.Length; i++) {
					string split = splits[i];
					char[] chars = split.ToCharArray();

					for (int j = 0; j < chars.Length; j++) {
						chars[j] = j == 0 ? char.ToUpper(chars[j]) : char.ToLower(chars[j]);
					}

					splits[i] = new string(chars);
				}

				name = string.Join(string.Empty, splits);
			}

			return name;
		}
	}
}
