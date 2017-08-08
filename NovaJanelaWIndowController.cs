using System;

using Foundation;
using AppKit;

namespace PrimeiroMac
{
	public partial class NovaJanelaWIndowController : NSWindow
	{
		public NovaJanelaWIndowController (IntPtr handle) : base (handle)
		{
		}

		[Export ("initWithCoder:")]
		public NovaJanelaWIndowController (NSCoder coder) : base (coder)
		{
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();
			Title = "Teste m";
		}
	}
}
