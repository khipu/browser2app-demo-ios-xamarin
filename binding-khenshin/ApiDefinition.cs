using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace bindingkhenshin
{
//using System;
	//using Foundation;
	//using UIKit;

	//[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	//partial interface Constants
	//{
	//	// extern double engineVersionNumber;
	//	[Field("engineVersionNumber", "__Internal")]
	//	double engineVersionNumber { get; }

	//	// extern const unsigned char [] engineVersionString;
	//	[Field("engineVersionString", "__Internal")]
	//	byte[] engineVersionString { get; }
	//}

	// @interface KHResourceFilterURLProtocol : NSUrlProtocol
	[BaseType(typeof(NSUrlProtocol))]
	interface KHResourceFilterURLProtocol
	{
	}

	// @protocol ProcessHeader
    [BaseType(typeof(NSObject))]
    [Model]
	interface ProcessHeader
	{
		// @required -(void)configureWithSubject:(NSString *)subject formattedAmountAsCurrency:(NSString *)amount merchantName:(NSString *)merchantName merchantImageURL:(NSString *)merchantImageURL paymentMethod:(NSString *)paymentMethod;
		[Abstract]
		[Export("configureWithSubject:formattedAmountAsCurrency:merchantName:merchantImageURL:paymentMethod:")]
		void FormattedAmountAsCurrency(string subject, string amount, string merchantName, string merchantImageURL, string paymentMethod);
	}

	// @protocol ProcessExit

    [BaseType(typeof(NSObject))]
	[Model]

	interface ProcessExit
	{
		// @required -(void)configureWithPaymentSubject:(NSString *)subject formattedAmountAsCurrency:(NSString *)amount merchantName:(NSString *)merchantName merchantImageURL:(NSString *)merchantImageURL paymentMethod:(NSString *)paymentMethod title:(NSString *)title message:(NSString *)message finish:(void (^)(void))finish;
		[Abstract]
		[Export("configureWithPaymentSubject:formattedAmountAsCurrency:merchantName:merchantImageURL:paymentMethod:title:message:finish:")]
		void FormattedAmountAsCurrency(string subject, string amount, string merchantName, string merchantImageURL, string paymentMethod, string title, string message, Action finish);
	}

	// @interface KhenshinInterface : NSObject
	[BaseType(typeof(NSObject))]
	interface KhenshinInterface
	{
		// +(void)destroyManager;
		[Static]
		[Export("destroyManager")]
		void DestroyManager();

		// +(void)initWithNavigationBarCenteredLogo:(UIImage *)barCenteredLogo NavigationBarLeftSideLogo:(UIImage *)barLeftSideLogo automatonAPIURL:(NSUrl *)automatonAPIURL cerebroAPIURL:(NSUrl *)cerebroAPIURL processHeader:(UIView<ProcessHeader> *)processHeader processFailure:(UIViewController<ProcessExit> *)processFailure processSuccess:(UIViewController<ProcessExit> *)processSuccess processWarning:(UIViewController<ProcessExit> *)processWarning allowCredentialsSaving:(BOOL)allowCredentialsSaving mainButtonStyle:(KHMainButton)mainButtonStyle hideWebAddressInformationInForm:(BOOL)hideWebAddressInformationInForm useBarCenteredLogoInForm:(BOOL)useBarCenteredLogoInForm principalColor:(UIColor *)principalColor darkerPrincipalColor:(UIColor *)darkerPrincipalColor secondaryColor:(UIColor *)secondaryColor navigationBarTextTint:(UIColor *)navigationBarTextTint font:(UIFont *)font;
		[Static]
		[Export("initWithNavigationBarCenteredLogo:NavigationBarLeftSideLogo:automatonAPIURL:cerebroAPIURL:processHeader:processFailure:processSuccess:processWarning:allowCredentialsSaving:mainButtonStyle:hideWebAddressInformationInForm:useBarCenteredLogoInForm:principalColor:darkerPrincipalColor:secondaryColor:navigationBarTextTint:font:")]
		void InitWithNavigationBarCenteredLogo(UIImage barCenteredLogo, UIImage barLeftSideLogo, NSUrl automatonAPIURL, NSUrl cerebroAPIURL, ProcessHeader processHeader, ProcessExit processFailure, ProcessExit processSuccess, ProcessExit processWarning, bool allowCredentialsSaving, nint mainButtonStyle, bool hideWebAddressInformationInForm, bool useBarCenteredLogoInForm, UIColor principalColor, UIColor darkerPrincipalColor, UIColor secondaryColor, UIColor navigationBarTextTint, UIFont font);

		// +(void)initWithNavigationBarCenteredLogo:(UIImage *)barCenteredLogo NavigationBarLeftSideLogo:(UIImage *)barLeftSideLogo automatonAPIURL:(NSUrl *)automatonAPIURL cerebroAPIURL:(NSUrl *)cerebroAPIURL processHeader:(UIView<ProcessHeader> *)processHeader processFailure:(UIViewController<ProcessExit> *)processFailure processSuccess:(UIViewController<ProcessExit> *)processSuccess processWarning:(UIViewController<ProcessExit> *)processWarning allowCredentialsSaving:(BOOL)allowCredentialsSaving mainButtonStyle:(KHMainButton)mainButtonStyle hideWebAddressInformationInForm:(BOOL)hideWebAddressInformationInForm useBarCenteredLogoInForm:(BOOL)useBarCenteredLogoInForm principalColor:(UIColor *)principalColor darkerPrincipalColor:(UIColor *)darkerPrincipalColor secondaryColor:(UIColor *)secondaryColor navigationBarTextTint:(UIColor *)navigationBarTextTint font:(UIFont *)font skipExitPage:(BOOL)skipExitPage;
		[Static]
		[Export("initWithNavigationBarCenteredLogo:NavigationBarLeftSideLogo:automatonAPIURL:cerebroAPIURL:processHeader:processFailure:processSuccess:processWarning:allowCredentialsSaving:mainButtonStyle:hideWebAddressInformationInForm:useBarCenteredLogoInForm:principalColor:darkerPrincipalColor:secondaryColor:navigationBarTextTint:font:skipExitPage:")]
		void InitWithNavigationBarCenteredLogo(UIImage barCenteredLogo, UIImage barLeftSideLogo, NSUrl automatonAPIURL, NSUrl cerebroAPIURL, ProcessHeader processHeader, ProcessExit processFailure, ProcessExit processSuccess, ProcessExit processWarning, bool allowCredentialsSaving, nint mainButtonStyle, bool hideWebAddressInformationInForm, bool useBarCenteredLogoInForm, UIColor principalColor, UIColor darkerPrincipalColor, UIColor secondaryColor, UIColor navigationBarTextTint, UIFont font, bool skipExitPage);

		// +(BOOL)isRunningAutomaton;
		[Static]
		[Export("isRunningAutomaton")]
		// [Verify(MethodToProperty)]
		bool IsRunningAutomaton { get; }

		// +(void)isThereAnAutomatonForFingerPrint:(NSString *)fingerPrint completionHandler:(void (^)(BOOL))completionHandler;
		[Static]
		[Export("isThereAnAutomatonForFingerPrint:completionHandler:")]
		void IsThereAnAutomatonForFingerPrint(string fingerPrint, Action<bool> completionHandler);

		// +(void)removeAllCredentialsWithUser:(NSString *)userIdentifier;
		[Static]
		[Export("removeAllCredentialsWithUser:")]
		void RemoveAllCredentialsWithUser(string userIdentifier);

		// +(void)removeAllStoredCookiesForBankExternalId:(NSString *)externalId completionHandler:(void (^)())completionHandler;
		[Static]
		[Export("removeAllStoredCookiesForBankExternalId:completionHandler:")]
		void RemoveAllStoredCookiesForBankExternalId(string externalId, Action completionHandler);

		// +(void)removeCredentialsForBankExternalId:(NSString *)externalId userIdentifier:(NSString *)userIdentifier completionHandler:(void (^)())completionHandler;
		[Static]
		[Export("removeCredentialsForBankExternalId:userIdentifier:completionHandler:")]
		void RemoveCredentialsForBankExternalId(string externalId, string userIdentifier, Action completionHandler);

		// +(void)savedBanksWithCredentialsForUserIdentifier:(NSString *)userIdentifier completionHandler:(void (^)(NSArray *))completionHandler;
		[Static]
		[Export("savedBanksWithCredentialsForUserIdentifier:completionHandler:")]
		void SavedBanksWithCredentialsForUserIdentifier(string userIdentifier, Action<NSArray> completionHandler);

		// +(void)savedBanksWithCookiesForUserIdentifier:(NSString *)userIdentifier completionHandler:(void (^)(NSArray *))completionHandler;
		[Static]
		[Export("savedBanksWithCookiesForUserIdentifier:completionHandler:")]
		void SavedBanksWithCookiesForUserIdentifier(string userIdentifier, Action<NSArray> completionHandler);

		// +(void)startEngineWithPaymentExternalId:(NSString *)paymentExternalId userIdentifier:(NSString *)userIdentifier isExternalPayment:(BOOL)externalPayment success:(void (^)(NSUrl *))success failure:(void (^)(NSUrl *))failure animated:(BOOL)animated;
		[Static]
		[Export("startEngineWithPaymentExternalId:userIdentifier:isExternalPayment:success:failure:animated:")]
		void StartEngineWithPaymentExternalId(string paymentExternalId, string userIdentifier, bool externalPayment, Action<NSUrl> success, Action<NSUrl> failure, bool animated);

		// +(void)startEngineWithPaymentExternalId:(NSString *)paymentExternalId userIdentifier:(NSString *)userIdentifier isExternalPayment:(BOOL)externalPayment success:(void (^)(NSUrl *))success failure:(void (^)(NSUrl *))failure animated:(BOOL)animated navigationController:(UINavigationController *)navigationController;
		[Static]
		[Export("startEngineWithPaymentExternalId:userIdentifier:isExternalPayment:success:failure:animated:navigationController:")]
		void StartEngineWithPaymentExternalId(string paymentExternalId, string userIdentifier, bool externalPayment, Action<NSUrl> success, Action<NSUrl> failure, bool animated, UINavigationController navigationController);

		// +(void)startEngineWithPaymentNumericoCode:(NSString *)numericCode userIdentifier:(NSString *)userIdentifier isExternalPayment:(BOOL)externalPayment success:(void (^)(NSUrl *))success failure:(void (^)(NSUrl *))failure animated:(BOOL)animated;
		[Static]
		[Export("startEngineWithPaymentNumericoCode:userIdentifier:isExternalPayment:success:failure:animated:")]
		void StartEngineWithPaymentNumericoCode(string numericCode, string userIdentifier, bool externalPayment, Action<NSUrl> success, Action<NSUrl> failure, bool animated);

		// +(void)startEngineWithPaymentNumericCode:(NSString *)numericCode withPaymentExternalId:(NSString *)paymentExternalId userIdentifier:(NSString *)userIdentifier isExternalPayment:(BOOL)externalPayment success:(void (^)(NSUrl *))success failure:(void (^)(NSUrl *))failure animated:(BOOL)animated navigationController:(UINavigationController *)navigationController;
		[Static]
		[Export("startEngineWithPaymentNumericCode:withPaymentExternalId:userIdentifier:isExternalPayment:success:failure:animated:navigationController:")]
		void StartEngineWithPaymentNumericCode(string numericCode, string paymentExternalId, string userIdentifier, bool externalPayment, Action<NSUrl> success, Action<NSUrl> failure, bool animated, UINavigationController navigationController);

		// +(void)setAutomatonTimeout:(NSTimeInterval)timeout;
		[Static]
		[Export("setAutomatonTimeout:")]
		void SetAutomatonTimeout(double timeout);

		//// +(void)setGoogleTracker:(id<GAITracker>)tracker;
		//[Static]
		//[Export("setGoogleTracker:")]
		//void SetGoogleTracker(GAITracker tracker);

		// +(void)setPreferredStatusBarStyle:(UIStatusBarStyle)preferredStatusBarStyle;
		[Static]
		[Export("setPreferredStatusBarStyle:")]
		void SetPreferredStatusBarStyle(UIStatusBarStyle preferredStatusBarStyle);

		// +(void)setPrefersStatusBarHidden:(BOOL)prefersStatusBarHidden;
		[Static]
		[Export("setPrefersStatusBarHidden:")]
		void SetPrefersStatusBarHidden(bool prefersStatusBarHidden);

		// +(void)setOtherThanOwnerWillPayOnThisDevice:(BOOL)isOtherThanOwnerPayingOnThisDevice;
		[Static]
		[Export("setOtherThanOwnerWillPayOnThisDevice:")]
		void SetOtherThanOwnerWillPayOnThisDevice(bool isOtherThanOwnerPayingOnThisDevice);

		// +(void)setExitMessagesShouldUseRawValue:(BOOL)useRawValue;
		[Static]
		[Export("setExitMessagesShouldUseRawValue:")]
		void SetExitMessagesShouldUseRawValue(bool useRawValue);

		// +(void)startEngineWithAutomatonId:(NSString *)automatonId animated:(BOOL)animated parameters:(NSDictionary *)parameters userIdentifier:(NSString *)userIdentifier success:(void (^)(NSUrl *))success failure:(void (^)(NSUrl *))failure;
		[Static]
		[Export("startEngineWithAutomatonId:animated:parameters:userIdentifier:success:failure:")]
		void StartEngineWithAutomatonId(string automatonId, bool animated, NSDictionary parameters, string userIdentifier, Action<NSUrl> success, Action<NSUrl> failure);

		// +(void)startEngineWithAutomatonId:(NSString *)automatonId animated:(BOOL)animated parameters:(NSDictionary *)parameters userIdentifier:(NSString *)userIdentifier navigationController:(UINavigationController *)navigationController success:(void (^)(NSUrl *))success failure:(void (^)(NSUrl *))failure;
		[Static]
		[Export("startEngineWithAutomatonId:animated:parameters:userIdentifier:navigationController:success:failure:")]
		void StartEngineWithAutomatonId(string automatonId, bool animated, NSDictionary parameters, string userIdentifier, UINavigationController navigationController, Action<NSUrl> success, Action<NSUrl> failure);

		// +(void)startEngineWithAutomatonRequestId:(NSString *)automatonRequestId animated:(BOOL)animated userIdentifier:(NSString *)userIdentifier navigationController:(UINavigationController *)navigationController success:(void (^)(NSUrl *))success failure:(void (^)(NSUrl *))failure;
		[Static]
		[Export("startEngineWithAutomatonRequestId:animated:userIdentifier:navigationController:success:failure:")]
		void StartEngineWithAutomatonRequestId(string automatonRequestId, bool animated, string userIdentifier, UINavigationController navigationController, Action<NSUrl> success, Action<NSUrl> failure);

		// +(void)startEngineWithAutomatonByFingerPrint:(NSString *)fingerPrint animated:(BOOL)animated userIdentifier:(NSString *)userIdentifier navigationController:(UINavigationController *)navigationController success:(void (^)(NSUrl *))success failure:(void (^)(NSUrl *))failure;
		[Static]
		[Export("startEngineWithAutomatonByFingerPrint:animated:userIdentifier:navigationController:success:failure:")]
		void StartEngineWithAutomatonByFingerPrint(string fingerPrint, bool animated, string userIdentifier, UINavigationController navigationController, Action<NSUrl> success, Action<NSUrl> failure);

		// +(BOOL)validateInitialization;
		[Static]
		[Export("validateInitialization")]
		// [Verify(MethodToProperty)]
		bool ValidateInitialization { get; }
	}


}
