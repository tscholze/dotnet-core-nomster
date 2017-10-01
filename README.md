# .net Nomster

**tl;dr**
Is an active, experimental playground for myself to play around with the new .net (Core 2.0) ecosystem and build an UI once, and use it everywhere.

**The long version**
Is a active, experimental playground for myself to play around with the new .net (Core 2.0) ecosystem and build an UI once, and use it everywhere. The solution contains not only two Xamarin projects for iOS and Android but also a macOS and a asp.net Core web project. An Azure connection is in deveopment but it's too confusing for my at the moment.

Due to the "let me try this" development process, the respository is really not designed to work in any other scenario.

## Software's usecase
In general, Nomster is designed to help collegues to manage their daily "what are we going to eat, today?" problem. That's why Nomster is planned to work on personal devices like mobile phones and large screens for hallways that displays a web page or an AppleTV app.

## Content

* `Nomster.Core`: Shared .net Core project that contains all view related files for Xamarin.Form projects and all (Azure / mocked) data aggregation logic
* `Nomster.Droid`: Xamarin.Forms Android project
* `Nomster.iOS`: Xamarin.Forms iOS project 
* `Nomster.Console`: Read only .net Core multiplatform console app 
* `Nomster.macOS`: Early preview of Xamarin.Forms for Mac macOS app
* `Nomster.tvOS`: Unfished experiment to use a .net Core 2.0 shared project with a Xamarin tvOS project.
* `Nomster.Web`: Readonly asp.net Core web app

**Planned content:**
* `Nomster.watchOS`: Xamarin native watchOS App that works with the shared project. 
* `Nomster.UWP`: UWP development is still not supported with a .net Core 2.0 Core

## Screenshots

**iOS, Android**

![iOS App](https://github.com/tscholze/.net-core-nomster/blob/master/docs/ios.png "iOS App")
![Droid App](https://github.com/tscholze/.net-core-nomster/blob/master/docs/droid.png "Droid App")

**macOS**

![macOS App](https://github.com/tscholze/.net-core-nomster/blob/master/docs/macOS.png "macOS App")

**Web**

![Website](https://github.com/tscholze/.net-core-nomster/blob/master/docs/web.png "Website")

**Console**

![Console](https://github.com/tscholze/.net-core-nomster/blob/master/docs/console.png "Console program")

### Prerequisites

Some projects have specific prerequisites

**General**
* Visual Studio Community 2017 / Visual Studio for Mac (7.1.5 or later) ([Download](https://www.visualstudio.com/))
* An installed .net Core 2.0 SDK ([Download](https://github.com/dotnet/core/blob/master/release-notes/download-archives/2.0.0-download.md))
* Reliable internet connection to download missing NuGet packages

**macOS, iOS, tvOS**
* macOS as Host
* Installed Xcode 8/9

**iOS**
* Installed simulators for iOS 10 / 11

**Droid**
* SDK for Android 6
* Emulator for Android 6 (real Device recommended)

### Run it

**For non macOS hosts**
If you are running this on a non-macOS host, please unload the projects for macOS, iOS and tvOS from the solution. Nevertheless for iOS you are able to use a via network connected mac as build and run machine.

1. Clone or download zip
2. Open the solution file (`*.sln`) in Visual Studio
3. Check if all run-able (see above) projects are successfully loaded
4. Nomster -> Right click -> Restore NuGet Packages
5. Nomster -> Right click -> Rebuild solution
6. Select your  project and deployment target in the toolbar
7. Click play
8. Cross fingers and that everything works
9. See the app, web page, console with the related content
10. Applaus.

There is no support for not working projects. Simple reason, I'm still happy if my development environment works, too.


## Built With

* [.net Core 2.0](https://github.com/dotnet/core) - One shared code basis for everything
* [asp.net Core 2.0](https://blogs.msdn.microsoft.com/webdev/2017/08/14/announcing-asp-net-core-2-0/) - Slim-lined web development approach by Microsoft
* [Xamarin](https://www.xamarin.com) -  C# and XAML development for iOS and Android
* [Office Fabrics](https://developer.microsoft.com/en-us/fabric) - html styles made by the Office team
* [limlecarl's Hamster](https://openclipart.org/detail/183600/hamster) - App icons hamster image

## Contributing

If you want to help me to improve my skills in C#, Azure or Xamarin, please tweet me at [@tobonaut](http://twitter.com/tobonaut) on Twitter.

## Versioning

If Nomster is going to be a real project in some days or not, I would  use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

Just me, [Tobi]([https://tscholze.github.io).

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
Dependencies or assets maybe licensed differently.

## Acknowledgments

* Robin Manuel Thiel [@robinmanuelt](https://robinmanuelt) for giving me a short but effective introduction to Xamarin
* [Xamarin Slack Community](https://xamarinchat.herokuapp.com) for helping beginners, too.
