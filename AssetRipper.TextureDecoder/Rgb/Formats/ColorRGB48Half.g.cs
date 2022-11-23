//This code is source generated. Do not edit manually.

using AssetRipper.TextureDecoder.Attributes;

namespace AssetRipper.TextureDecoder.Rgb.Formats
{
	[RgbaAttribute(RedChannel = true, GreenChannel = true, BlueChannel = true, AlphaChannel = false, FullyUtilizedChannels = true)]
	public partial struct ColorRGB48Half : IColor<Half>
	{
		public Half R { get; set; }
		
		public Half G { get; set; }
		
		public Half B { get; set; }
		
		public Half A 
		{
			get => HalfConstants.One;
			set { }
		}
		
		public void GetChannels(out Half r, out Half g, out Half b, out Half a)
		{
			r = R;
			g = G;
			b = B;
			a = A;
		}
		
		public void SetChannels(Half r, Half g, Half b, Half a)
		{
			R = r;
			G = g;
			B = b;
		}
	}
}
