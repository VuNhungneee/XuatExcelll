﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraCSDL
{
	internal class Prompt
	{
		public static string ShowDialog(string text, string caption)
		{
			Form prompt = new Form()
			{
				Width = 400,
				Height = 150,
				Text = caption
			};
			Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
			TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 300 };
			Button confirmation = new Button() { Text = "OK", Left = 250, Width = 100, Top = 70, DialogResult = DialogResult.OK };
			confirmation.Click += (sender, e) => { prompt.Close(); };
			prompt.Controls.Add(textLabel);
			prompt.Controls.Add(textBox);
			prompt.Controls.Add(confirmation);
			prompt.AcceptButton = confirmation;

			return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
		}
	}
}
