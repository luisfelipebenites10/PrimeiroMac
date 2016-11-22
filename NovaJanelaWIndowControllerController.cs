using System;

using Foundation;
using AppKit;

namespace PrimeiroMac
{
	public partial class NovaJanelaWIndowControllerController : NSWindowController
	{
		public NovaJanelaWIndowControllerController (IntPtr handle) : base (handle)
		{
		}

		[Export ("initWithCoder:")]
		public NovaJanelaWIndowControllerController (NSCoder coder) : base (coder)
		{
		}

		public NovaJanelaWIndowControllerController () : base ("NovaJanelaWIndowController")
		{
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();
		}

		public new NovaJanelaWIndowController Window {
			get { return (NovaJanelaWIndowController)base.Window; }
		}
	}
}
