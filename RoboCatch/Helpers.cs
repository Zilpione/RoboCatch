using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboCatch
{
	public static class Helpers
	{
		public static int? SetValue(this TextBox textBox, int defaultValue, object value)
		{
			if (Int32.TryParse(textBox.Text	, out var number))
			{
				if (defaultValue == number) return null;
				return number;
			}
			else
			{
				textBox.Text = defaultValue.ToString();
			}
			return null;
		}
	}
}
