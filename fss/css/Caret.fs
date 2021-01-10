namespace Fss

open Fss

[<AutoOpen>]
module Caret =
    let private caretColorToString (caretColor: ICaretColor) =
        match caretColor with
        | :? CssColor as c -> CSSColorValue.color c
        | :? Auto -> GlobalValue.auto
        | _ -> "Unknown caret color"

    // https://developer.mozilla.org/en-US/docs/Web/CSS/caret-color
    let private caretColorValue value = PropertyValue.cssValue Property.CaretColor value
    let private caretColorValue' value =
        value
        |> caretColorToString
        |> caretColorValue
    type CaretColor =
        static member Value (color: ICaretColor) = color |> caretColorValue'
        static member black = CssColor.black |> caretColorValue'
        static member silver = CssColor.silver |> caretColorValue'
        static member gray = CssColor.gray |> caretColorValue'
        static member white = CssColor.white |> caretColorValue'
        static member maroon = CssColor.maroon |> caretColorValue'
        static member red = CssColor.red |> caretColorValue'
        static member purple = CssColor.purple |> caretColorValue'
        static member fuchsia = CssColor.fuchsia |> caretColorValue'
        static member green = CssColor.green |> caretColorValue'
        static member lime = CssColor.lime |> caretColorValue'
        static member olive = CssColor.olive |> caretColorValue'
        static member yellow = CssColor.yellow |> caretColorValue'
        static member navy = CssColor.navy |> caretColorValue'
        static member blue = CssColor.blue |> caretColorValue'
        static member teal = CssColor.teal |> caretColorValue'
        static member aqua = CssColor.aqua |> caretColorValue'
        static member orange = CssColor.orange |> caretColorValue'
        static member aliceBlue = CssColor.aliceBlue |> caretColorValue'
        static member antiqueWhite = CssColor.antiqueWhite |> caretColorValue'
        static member aquaMarine = CssColor.aquaMarine |> caretColorValue'
        static member azure = CssColor.azure |> caretColorValue'
        static member beige = CssColor.beige |> caretColorValue'
        static member bisque = CssColor.bisque |> caretColorValue'
        static member blanchedAlmond = CssColor.blanchedAlmond |> caretColorValue'
        static member blueViolet = CssColor.blueViolet |> caretColorValue'
        static member brown = CssColor.brown |> caretColorValue'
        static member burlywood = CssColor.burlywood |> caretColorValue'
        static member cadetBlue = CssColor.cadetBlue |> caretColorValue'
        static member chartreuse = CssColor.chartreuse |> caretColorValue'
        static member chocolate = CssColor.chocolate |> caretColorValue'
        static member coral = CssColor.coral |> caretColorValue'
        static member cornflowerBlue = CssColor.cornflowerBlue |> caretColorValue'
        static member cornsilk = CssColor.cornsilk |> caretColorValue'
        static member crimson = CssColor.crimson |> caretColorValue'
        static member cyan = CssColor.cyan |> caretColorValue'
        static member darkBlue = CssColor.darkBlue |> caretColorValue'
        static member darkCyan = CssColor.darkCyan |> caretColorValue'
        static member darkGoldenrod = CssColor.darkGoldenrod |> caretColorValue'
        static member darkGray = CssColor.darkGray |> caretColorValue'
        static member darkGreen = CssColor.darkGreen |> caretColorValue'
        static member darkKhaki = CssColor.darkKhaki |> caretColorValue'
        static member darkMagenta = CssColor.darkMagenta |> caretColorValue'
        static member darkOliveGreen = CssColor.darkOliveGreen |> caretColorValue'
        static member darkOrange = CssColor.darkOrange |> caretColorValue'
        static member darkOrchid = CssColor.darkOrchid |> caretColorValue'
        static member darkRed = CssColor.darkRed |> caretColorValue'
        static member darkSalmon = CssColor.darkSalmon |> caretColorValue'
        static member darkSeaGreen = CssColor.darkSeaGreen |> caretColorValue'
        static member darkSlateBlue = CssColor.darkSlateBlue |> caretColorValue'
        static member darkSlateGray = CssColor.darkSlateGray |> caretColorValue'
        static member darkTurquoise = CssColor.darkTurquoise |> caretColorValue'
        static member darkViolet = CssColor.darkViolet |> caretColorValue'
        static member deepPink = CssColor.deepPink |> caretColorValue'
        static member deepSkyBlue = CssColor.deepSkyBlue |> caretColorValue'
        static member dimGrey = CssColor.dimGrey |> caretColorValue'
        static member dodgerBlue = CssColor.dodgerBlue |> caretColorValue'
        static member fireBrick = CssColor.fireBrick |> caretColorValue'
        static member floralWhite = CssColor.floralWhite |> caretColorValue'
        static member forestGreen = CssColor.forestGreen |> caretColorValue'
        static member gainsboro = CssColor.gainsboro |> caretColorValue'
        static member ghostWhite = CssColor.ghostWhite |> caretColorValue'
        static member gold = CssColor.gold |> caretColorValue'
        static member goldenrod = CssColor.goldenrod |> caretColorValue'
        static member greenYellow = CssColor.greenYellow |> caretColorValue'
        static member grey = CssColor.grey |> caretColorValue'
        static member honeydew = CssColor.honeydew |> caretColorValue'
        static member hotPink = CssColor.hotPink |> caretColorValue'
        static member indianRed = CssColor.indianRed |> caretColorValue'
        static member indigo = CssColor.indigo |> caretColorValue'
        static member ivory = CssColor.ivory |> caretColorValue'
        static member khaki = CssColor.khaki |> caretColorValue'
        static member lavender = CssColor.lavender |> caretColorValue'
        static member lavenderBlush = CssColor.lavenderBlush |> caretColorValue'
        static member lawnGreen = CssColor.lawnGreen |> caretColorValue'
        static member lemonChiffon = CssColor.lemonChiffon |> caretColorValue'
        static member lightBlue = CssColor.lightBlue |> caretColorValue'
        static member lightCoral = CssColor.lightCoral |> caretColorValue'
        static member lightCyan = CssColor.lightCyan |> caretColorValue'
        static member lightGoldenrodYellow = CssColor.lightGoldenrodYellow |> caretColorValue'
        static member lightGray = CssColor.lightGray |> caretColorValue'
        static member lightGreen = CssColor.lightGreen |> caretColorValue'
        static member lightGrey = CssColor.lightGrey |> caretColorValue'
        static member lightPink = CssColor.lightPink |> caretColorValue'
        static member lightSalmon = CssColor.lightSalmon |> caretColorValue'
        static member lightSeaGreen = CssColor.lightSeaGreen |> caretColorValue'
        static member lightSkyBlue = CssColor.lightSkyBlue |> caretColorValue'
        static member lightSlateGrey = CssColor.lightSlateGrey |> caretColorValue'
        static member lightSteelBlue = CssColor.lightSteelBlue |> caretColorValue'
        static member lightYellow = CssColor.lightYellow |> caretColorValue'
        static member limeGreen = CssColor.limeGreen |> caretColorValue'
        static member linen = CssColor.linen |> caretColorValue'
        static member magenta = CssColor.magenta |> caretColorValue'
        static member mediumAquamarine = CssColor.mediumAquamarine |> caretColorValue'
        static member mediumBlue = CssColor.mediumBlue |> caretColorValue'
        static member mediumOrchid = CssColor.mediumOrchid |> caretColorValue'
        static member mediumPurple = CssColor.mediumPurple |> caretColorValue'
        static member mediumSeaGreen = CssColor.mediumSeaGreen |> caretColorValue'
        static member mediumSlateBlue = CssColor.mediumSlateBlue |> caretColorValue'
        static member mediumSpringGreen = CssColor.mediumSpringGreen |> caretColorValue'
        static member mediumTurquoise = CssColor.mediumTurquoise |> caretColorValue'
        static member mediumVioletRed = CssColor.mediumVioletRed |> caretColorValue'
        static member midnightBlue = CssColor.midnightBlue |> caretColorValue'
        static member mintCream = CssColor.mintCream |> caretColorValue'
        static member mistyRose = CssColor.mistyRose |> caretColorValue'
        static member moccasin = CssColor.moccasin |> caretColorValue'
        static member navajoWhite = CssColor.navajoWhite |> caretColorValue'
        static member oldLace = CssColor.oldLace |> caretColorValue'
        static member olivedrab = CssColor.olivedrab |> caretColorValue'
        static member orangeRed = CssColor.orangeRed |> caretColorValue'
        static member orchid = CssColor.orchid |> caretColorValue'
        static member paleGoldenrod = CssColor.paleGoldenrod |> caretColorValue'
        static member paleGreen = CssColor.paleGreen |> caretColorValue'
        static member paleTurquoise = CssColor.paleTurquoise |> caretColorValue'
        static member paleVioletred = CssColor.paleVioletred |> caretColorValue'
        static member papayaWhip = CssColor.papayaWhip |> caretColorValue'
        static member peachpuff = CssColor.peachpuff |> caretColorValue'
        static member peru = CssColor.peru |> caretColorValue'
        static member pink = CssColor.pink |> caretColorValue'
        static member plum = CssColor.plum |> caretColorValue'
        static member powderBlue = CssColor.powderBlue |> caretColorValue'
        static member rosyBrown = CssColor.rosyBrown |> caretColorValue'
        static member royalBlue = CssColor.royalBlue |> caretColorValue'
        static member saddleBrown = CssColor.saddleBrown |> caretColorValue'
        static member salmon = CssColor.salmon |> caretColorValue'
        static member sandyBrown = CssColor.sandyBrown |> caretColorValue'
        static member seaGreen = CssColor.seaGreen |> caretColorValue'
        static member seaShell = CssColor.seaShell |> caretColorValue'
        static member sienna = CssColor.sienna |> caretColorValue'
        static member skyBlue = CssColor.skyBlue |> caretColorValue'
        static member slateBlue = CssColor.slateBlue |> caretColorValue'
        static member slateGray = CssColor.slateGray |> caretColorValue'
        static member snow = CssColor.snow |> caretColorValue'
        static member springGreen = CssColor.springGreen |> caretColorValue'
        static member steelBlue = CssColor.steelBlue |> caretColorValue'
        static member tan = CssColor.tan |> caretColorValue'
        static member thistle = CssColor.thistle |> caretColorValue'
        static member tomato = CssColor.tomato |> caretColorValue'
        static member turquoise = CssColor.turquoise |> caretColorValue'
        static member violet = CssColor.violet |> caretColorValue'
        static member wheat = CssColor.wheat |> caretColorValue'
        static member whiteSmoke = CssColor.whiteSmoke |> caretColorValue'
        static member yellowGreen = CssColor.yellowGreen |> caretColorValue'
        static member rebeccaPurple = CssColor.rebeccaPurple |> caretColorValue'
        static member Rgb r g b = CssColor.Rgb(r, g, b) |> caretColorValue'
        static member Rgba r g b a = CssColor.Rgba(r, g, b, a) |> caretColorValue'
        static member Hex value = CssColor.Hex value |> caretColorValue'
        static member Hsl h s l = CssColor.Hsl(h, s, l) |> caretColorValue'
        static member Hsla h s l a  = CssColor.Hsla (h, s, l, a) |> caretColorValue'
        static member transparent = CssColor.transparent |> caretColorValue'
        static member currentColor = CssColor.currentColor |> caretColorValue'

        static member Auto = Auto |> caretColorValue'

    let CaretColor' (caretColor: ICaretColor) = CaretColor.Value caretColor