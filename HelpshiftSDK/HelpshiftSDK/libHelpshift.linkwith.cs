using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libHelpshift.a", LinkTarget.ArmV7s | LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true, 
	Frameworks = "Foundation UIKit CoreGraphics QuartzCore CoreText SystemConfiguration CoreTelephony", LinkerFlags="-lsqlite3.0 -llibz")]
