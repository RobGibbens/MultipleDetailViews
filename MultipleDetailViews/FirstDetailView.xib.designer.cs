// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MultipleDetailViews {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("FirstDetailView")]
	public partial class FirstDetailView {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UIToolbar __mt_toolbar;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("toolbar")]
		private MonoTouch.UIKit.UIToolbar toolbar {
			get {
				this.__mt_toolbar = ((MonoTouch.UIKit.UIToolbar)(this.GetNativeField("toolbar")));
				return this.__mt_toolbar;
			}
			set {
				this.__mt_toolbar = value;
				this.SetNativeField("toolbar", value);
			}
		}
	}
}
