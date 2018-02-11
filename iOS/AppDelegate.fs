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
            let page = new MainPage()
            Framework.createApplicationInfo Conduit.Program.applicationCore page
        let app = info.CreateApp()
        
        this.LoadApplication (app)
        base.FinishedLaunching(app, options)

module Main =
    [<EntryPoint>]
    let main args =
        UIApplication.Main(args, null, "AppDelegate")
        0
