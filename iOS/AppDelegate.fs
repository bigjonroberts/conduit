namespace Conduit.iOS

open System
open UIKit
open Foundation
open Xamarin.Forms
open Xamarin.Forms.Platform.iOS
open Gjallarhorn.XamarinForms
open ConduitXF


[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit FormsApplicationDelegate ()

    override this.FinishedLaunching (app, options) =

        Forms.Init()
        let info = 
            new MainNavigationPage()
            |> Framework.createApplicationInfo Conduit.Program.applicationCore
        let xformsApp = info.CreateApp()
        
        this.LoadApplication (xformsApp)
        base.FinishedLaunching(app, options)

module Main =
    [<EntryPoint>]
    let main args =
        UIApplication.Main(args, null, "AppDelegate")
        0
