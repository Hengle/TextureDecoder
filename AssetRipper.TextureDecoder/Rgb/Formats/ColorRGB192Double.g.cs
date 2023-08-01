//This code is source generated. Do not edit manually.

using AssetRipper.TextureDecoder.Attributes;

namespace AssetRipper.TextureDecoder.Rgb.Formats
{
	[RgbaAttribute(RedChannel = true, GreenChannel = true, BlueChannel = true, AlphaChannel = false, FullyUtilizedChannels = true)]
	public partial struct ColorRGB192Double : IColor<double>
	{
		public double R { get; set; }
		
		public double G { get; set; }
		
		public double B { get; set; }
		
		public readonly double A 
		{
			get => 1d;
			set { }
		}
		
		public readonly void GetChannels(out double r, out double g, out double b, out double a)
		{
			r = R;
			g = G;
			b = B;
			a = A;
		}
		
		public void SetChannels(double r, double g, double b, double a)
		{
			R = r;
			G = g;
			B = b;
		}
		
		static bool IColor<double>.HasRedChannel => true;
		static bool IColor<double>.HasGreenChannel => true;
		static bool IColor<double>.HasBlueChannel => true;
		static bool IColor<double>.HasAlphaChannel => false;
	}
}
