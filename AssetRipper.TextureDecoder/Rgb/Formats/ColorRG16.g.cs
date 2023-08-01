//This code is source generated. Do not edit manually.

using AssetRipper.TextureDecoder.Attributes;

namespace AssetRipper.TextureDecoder.Rgb.Formats
{
	[RgbaAttribute(RedChannel = true, GreenChannel = true, BlueChannel = false, AlphaChannel = false, FullyUtilizedChannels = true)]
	public partial struct ColorRG16 : IColor<byte>
	{
		public byte R { get; set; }
		
		public byte G { get; set; }
		
		public readonly byte B 
		{
			get => byte.MinValue;
			set { }
		}
		
		public readonly byte A 
		{
			get => byte.MaxValue;
			set { }
		}
		
		public readonly void GetChannels(out byte r, out byte g, out byte b, out byte a)
		{
			r = R;
			g = G;
			b = B;
			a = A;
		}
		
		public void SetChannels(byte r, byte g, byte b, byte a)
		{
			R = r;
			G = g;
		}
		
		static bool IColor<byte>.HasRedChannel => true;
		static bool IColor<byte>.HasGreenChannel => true;
		static bool IColor<byte>.HasBlueChannel => false;
		static bool IColor<byte>.HasAlphaChannel => false;
	}
}
