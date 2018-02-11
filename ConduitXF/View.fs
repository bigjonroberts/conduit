namespace ConduitXF

open Xamarin.Forms
open Xamarin.Forms.Xaml

open Gjallarhorn.Bindable

open Conduit

type MainPage() as this = 
    inherit Xamarin.Forms.ContentPage()
    do
        this.LoadFromXaml(typeof<MainPage>) |> ignore
