namespace ConduitXF

open Xamarin.Forms
open Xamarin.Forms.Xaml

type MainNavigationPage() =
    inherit ContentPage()
    let _ = base.LoadFromXaml(typeof<MainNavigationPage>)
