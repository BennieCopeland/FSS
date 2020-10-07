﻿namespace FSSTests

open Fable.Mocha
open Fable.Core.JsInterop
open Utils
open Fss

module PsuedoClasses =
    let tests =
        testList "Psuedo Classes"
            [
                testNested
                    "Active"
                    [ Active [ BackgroundColor Color.red ] ]
                    [":active" ==> "[backgroundColor,#ff0000]"]

                testNested
                    "AnyLink"
                    [ AnyLink [ FontSize (px 250) ] ]
                    [":any-link" ==> "[fontSize,250px]"]

                testNested
                    "Blank"
                    [ Blank [ BackgroundColor Color.blue ] ]
                    [":blank" ==> "[backgroundColor,#0000ff]"]

                testNested
                    "Checked"
                    [ Checked [ Width (px 25) ] ]
                    [":checked" ==> "[width,25px]"]

                testNested
                    "Disabled"
                    [ Disabled [ Width (px 25) ] ]
                    [":disabled" ==> "[width,25px]"]

                testNested
                    "Empty"
                    [ Empty [ Width (px 25) ] ]
                    [":empty" ==> "[width,25px]"]

                testNested
                    "Enabled"
                    [ Enabled [ Width (px 25) ] ]
                    [":enabled" ==> "[width,25px]"]

                testNested
                    "Hover"
                    [ Hover [ Color Color.red ] ]
                    [":hover" ==> "[color,#ff0000]"]

                testNested
                    "Focus"
                    [ Focus [ BackgroundColor Color.red ] ]
                    [":focus" ==> "[backgroundColor,#ff0000]"]

                testNested
                    "Visited"
                    [ Visited [ Color Color.orangeRed ] ]
                    [":visited" ==> "[color,#ff4500]"]
            ]