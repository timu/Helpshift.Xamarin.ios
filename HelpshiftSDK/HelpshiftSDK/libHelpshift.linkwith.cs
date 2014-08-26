using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libHelpshift.a", LinkTarget.ArmV7s | LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true, 
	Frameworks = "Foundation CoreGraphics QuartzCore CoreText SystemConfiguration CoreTelephony UIKit", LinkerFlags="-lsqlite3.0 -lz")]
