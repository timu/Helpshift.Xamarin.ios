using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace HelpshiftSDK {

	[BaseType (typeof(NSObject))]
	public partial interface Helpshift : IUIAlertViewDelegate {

		[Export ("delegate", ArgumentSemantic.Retain)]
		HelpshiftDelegate Delegate { get; set; }

		[Static, Export ("installForApiKey:domainName:appID:")]
		void InstallForApiKey (string apiKey, string domainName, string appID);

		[Static, Export ("installForApiKey:domainName:appID:withOptions:")]
		void InstallForApiKey (string apiKey, string domainName, string appID, NSDictionary optionsDictionary);

		[Static, Export ("sharedInstance")]
		Helpshift SharedInstance { get; }

		[Static, Export ("pauseDisplayOfInAppNotification:")]
		void PauseDisplayOfInAppNotification (bool pauseInApp);

		[Export ("showConversation:withOptions:")]
		void ShowConversation (UIViewController viewController, NSDictionary optionsDictionary);

		[Export ("showFAQs:withOptions:")]
		void ShowFAQs (UIViewController viewController, NSDictionary optionsDictionary);

		[Export ("showFAQSection:withController:withOptions:")]
		void ShowFAQSection (string faqSectionPublishID, UIViewController viewController, NSDictionary optionsDictionary);

		[Export ("showSingleFAQ:withController:withOptions:")]
		void ShowSingleFAQ (string faqPublishID, UIViewController viewController, NSDictionary optionsDictionary);

		//[Static, Export ("showAlertToRateAppWithURL:withCompletionBlock:")]
		//void ShowAlertToRateAppWithURL (string url, AppRatingAlertViewCompletionBlock completionBlock);

		[Static, Export ("userIdentifier")]
		string UserIdentifier { set; }

		[Static, Export ("setName:andEmail:")]
		void SetName (string name, string email);

		[Static, Export ("leaveBreadCrumb:")]
		void LeaveBreadCrumb (string breadCrumbString);

		//[Static, Export ("metadataBlock")]
		//metadataBlock MetadataBlock { set; }

		[Export ("getNotificationCountFromRemote:")]
		int GetNotificationCountFromRemote (bool isRemote);

		[Export ("registerDeviceToken:")]
		void RegisterDeviceToken (NSData deviceToken);

		[Export ("handleRemoteNotification:withController:")]
		void HandleRemoteNotification (NSDictionary notification, UIViewController viewController);

		[Export ("handleLocalNotification:withController:")]
		void HandleLocalNotification (UILocalNotification notification, UIViewController viewController);

		[Export ("clearBreadCrumbs")]
		void ClearBreadCrumbs ();

		[Static, Export ("installForAppID:domainName:apiKey:")]
		void InstallForAppID (string appID, string domainName, string apiKey);

		[Static, Export ("installForAppID:domainName:apiKey:withOptions:")]
		void InstallForAppID (string appID, string domainName, string apiKey, NSDictionary optionsDictionary);

		[Export ("showSupport:withOptions:")]
		void ShowSupport (UIViewController viewController, NSDictionary optionsDictionary);

		[Export ("showSupport:")]
		void ShowSupport (UIViewController viewController);

		[Export ("showFAQs:")]
		void ShowFAQs (UIViewController viewController);

		[Export ("reportIssue:")]
		void ReportIssue (UIViewController viewController);

		[Export ("reportIssue:withOptions:")]
		void ReportIssue (UIViewController viewController, NSDictionary optionsDictionary);

		[Export ("showFAQSection:withController:")]
		void ShowFAQSection (string faqSectionPublishID, UIViewController viewController);

		[Export ("showFAQ:withController:")]
		void ShowFAQ (string faqPublishID, UIViewController viewController);

		[Export ("showInbox:")]
		void ShowInbox (UIViewController viewController);

		[Export ("notificationCountAsync:")]
		int NotificationCountAsync (bool isAsync);

		[Export ("handleNotification:withController:")]
		void HandleNotification (NSDictionary notification, UIViewController viewController);
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface HelpshiftDelegate {

		[Export ("didReceiveNotificationCount:")]
		void DidReceiveNotificationCount(int count);

		[Export ("helpshiftSessionHasEnded")]
		void HelpshiftSessionHasEnded ();

		[Export ("didReceiveInAppNotificationWithMessageCount:")]
		void DidReceiveInAppNotificationWithMessageCount(int count);
	}
}
