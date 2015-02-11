namespace Hello



// open Conversions
open System
open System.Drawing

open UIKit
open Foundation
open CoreGraphics

[<Register ("HelloViewController")>]
type HelloViewController () =
    inherit UIViewController ()

    // Release any cached data, images, etc that aren't in use.
    override this.DidReceiveMemoryWarning () =
        base.DidReceiveMemoryWarning ()

    // Perform any additional setup after loading the view, typically from a nib.
    override this.ViewDidLoad () =
        base.ViewDidLoad ()
        let rect = new CGRect (nfloat 2.f, nfloat 2.f, nfloat 100.f, nfloat 100.f)
        let label = new UILabel(rect)
        label.Text <- "Hello"
        label.BackgroundColor <- UIColor.Yellow
        //label
        this.View.AddSubview(label)

    // Return true for supported orientations
    override this.ShouldAutorotateToInterfaceOrientation (orientation) =
        orientation <> UIInterfaceOrientation.PortraitUpsideDown

