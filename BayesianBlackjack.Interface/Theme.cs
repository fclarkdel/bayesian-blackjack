using MudBlazor;

namespace BayesianBlackjack.Interface
{
	public class Theme
	{
		public static readonly MudTheme MudTheme = new()
		{
			Palette = new()
			{
				AppbarBackground = Colors.BlueGrey.Darken4,
				AppbarText = Colors.BlueGrey.Lighten5,

				Background = Colors.BlueGrey.Darken3,

				Primary = Colors.BlueGrey.Darken4,
				PrimaryContrastText = Colors.Grey.Lighten5,

				Secondary = Colors.BlueGrey.Darken2,
				SecondaryContrastText = Colors.Grey.Lighten5,

				Tertiary = Colors.BlueGrey.Default,
				TertiaryContrastText = Colors.Grey.Lighten5,
				
				TertiaryLighten = Colors.BlueGrey.Lighten5,

				Info = Colors.Orange.Accent3,
				
				Warning = Colors.Cyan.Accent3
			}
		};
	}
}
