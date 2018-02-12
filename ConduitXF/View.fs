namespace ConduitXF

open Xamarin.Forms
open Xamarin.Forms.Xaml

open Gjallarhorn.Bindable

open Conduit

type MainPage() as this = 
    inherit Xamarin.Forms.ContentPage()
    do
        this.LoadFromXaml(typeof<MainPage>) |> ignore
        // padding for status bar
        // tried NavigationPage trick from these links first and it didn't work:
        //   * https://forums.xamarin.com/discussion/49060/application-starting-behind-the-top-time-battery-bar-on-ios
        //   * https://gist.github.com/Easter1021/c2ed3e4f53c939bd3a2a64c400d682e9
        let topPad =
            match Device.RuntimePlatform with
            | Device.iOS -> 20.0
            | _ -> 0.0
        this.Padding <- new Thickness(0.0, topPad, 0.0, topPad)
        NavigationPage.SetHasNavigationBar(this,false)

type MainNavigationPage() =
    inherit Xamarin.Forms.NavigationPage(new MainPage())

