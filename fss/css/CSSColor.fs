
namespace Fss

[<AutoOpen>]
module CSSColor =
   type CSSColor =
    | CSSColor of string
    interface ITextDecorationColor
    interface ITextEmphasisColor
    interface IBorderColor
    interface IOutlineColor
    interface IColorStop
    interface IColumnRuleColor
    interface ICaretColor
    static member black = Utilities.Color.hex "000000" |> CSSColor
    static member silver = Utilities.Color.hex "c0c0c0" |> CSSColor
    static member gray = Utilities.Color.hex "808080" |> CSSColor
    static member white = Utilities.Color.hex "ffffff" |> CSSColor
    static member maroon = Utilities.Color.hex "800000" |> CSSColor
    static member red = Utilities.Color.hex "ff0000" |> CSSColor
    static member purple = Utilities.Color.hex "800080" |> CSSColor
    static member fuchsia = Utilities.Color.hex "ff00ff" |> CSSColor
    static member green = Utilities.Color.hex "008000" |> CSSColor
    static member lime = Utilities.Color.hex "00ff00" |> CSSColor
    static member olive = Utilities.Color.hex "808000" |> CSSColor
    static member yellow = Utilities.Color.hex "ffff00" |> CSSColor
    static member navy = Utilities.Color.hex "000080" |> CSSColor
    static member blue = Utilities.Color.hex "0000ff" |> CSSColor
    static member teal = Utilities.Color.hex "008080" |> CSSColor
    static member aqua = Utilities.Color.hex "00ffff" |> CSSColor
    static member orange = Utilities.Color.hex "ffa500" |> CSSColor
    static member aliceBlue = Utilities.Color.hex "f0f8ff" |> CSSColor
    static member antiqueWhite = Utilities.Color.hex "faebd7" |> CSSColor
    static member aquaMarine = Utilities.Color.hex "7fffd4" |> CSSColor
    static member azure = Utilities.Color.hex "f0ffff" |> CSSColor
    static member beige = Utilities.Color.hex "f5f5dc" |> CSSColor
    static member bisque = Utilities.Color.hex "ffe4c4" |> CSSColor
    static member blanchedAlmond = Utilities.Color.hex "ffebcd" |> CSSColor
    static member blueViolet = Utilities.Color.hex "8a2be2" |> CSSColor
    static member brown = Utilities.Color.hex "a52a2a" |> CSSColor
    static member burlywood = Utilities.Color.hex "deb887" |> CSSColor
    static member cadetBlue = Utilities.Color.hex "5f9ea0" |> CSSColor
    static member chartreuse = Utilities.Color.hex "7fff00" |> CSSColor
    static member chocolate = Utilities.Color.hex "d2691e" |> CSSColor
    static member coral = Utilities.Color.hex "ff7f50" |> CSSColor
    static member cornflowerBlue = Utilities.Color.hex "6495ed" |> CSSColor
    static member cornsilk = Utilities.Color.hex "fff8dc" |> CSSColor
    static member crimson = Utilities.Color.hex "dc143c" |> CSSColor
    static member cyan = Utilities.Color.hex "00ffff" |> CSSColor
    static member darkBlue = Utilities.Color.hex "00008b" |> CSSColor
    static member darkCyan = Utilities.Color.hex "008b8b" |> CSSColor
    static member darkGoldenrod = Utilities.Color.hex "b8860b" |> CSSColor
    static member darkGray = Utilities.Color.hex "a9a9a9" |> CSSColor
    static member darkGreen = Utilities.Color.hex "006400" |> CSSColor
    static member darkKhaki = Utilities.Color.hex "bdb76b" |> CSSColor
    static member darkMagenta = Utilities.Color.hex "8b008b" |> CSSColor
    static member darkOliveGreen = Utilities.Color.hex "556b2f" |> CSSColor
    static member darkOrange = Utilities.Color.hex "ff8c00" |> CSSColor
    static member darkOrchid = Utilities.Color.hex "9932cc" |> CSSColor
    static member darkRed = Utilities.Color.hex "8b0000" |> CSSColor
    static member darkSalmon = Utilities.Color.hex "e9967a" |> CSSColor
    static member darkSeaGreen = Utilities.Color.hex "8fbc8f" |> CSSColor
    static member darkSlateBlue = Utilities.Color.hex "483d8b" |> CSSColor
    static member darkSlateGray = Utilities.Color.hex "2f4f4f" |> CSSColor
    static member darkTurquoise = Utilities.Color.hex "00ced1" |> CSSColor
    static member darkViolet = Utilities.Color.hex "9400d3" |> CSSColor
    static member deepPink = Utilities.Color.hex "ff1493" |> CSSColor
    static member deepSkyBlue = Utilities.Color.hex "00bfff" |> CSSColor
    static member dimGrey = Utilities.Color.hex "696969" |> CSSColor
    static member dodgerBlue = Utilities.Color.hex "1e90ff" |> CSSColor
    static member fireBrick = Utilities.Color.hex "b22222" |> CSSColor
    static member floralWhite = Utilities.Color.hex "fffaf0" |> CSSColor
    static member forestGreen = Utilities.Color.hex "228b22" |> CSSColor
    static member gainsboro = Utilities.Color.hex "dcdcdc" |> CSSColor
    static member ghostWhite = Utilities.Color.hex "f8f8ff" |> CSSColor
    static member gold = Utilities.Color.hex "ffd700" |> CSSColor
    static member goldenrod = Utilities.Color.hex "daa520" |> CSSColor
    static member greenYellow = Utilities.Color.hex "adff2f" |> CSSColor
    static member grey = Utilities.Color.hex "808080" |> CSSColor
    static member honeydew = Utilities.Color.hex "f0fff0" |> CSSColor
    static member hotPink = Utilities.Color.hex "ff69b4" |> CSSColor
    static member indianRed = Utilities.Color.hex "cd5c5c" |> CSSColor
    static member indigo = Utilities.Color.hex "4b0082" |> CSSColor
    static member ivory = Utilities.Color.hex "fffff0" |> CSSColor
    static member khaki = Utilities.Color.hex "f0e68c" |> CSSColor
    static member lavender = Utilities.Color.hex "e6e6fa" |> CSSColor
    static member lavenderBlush = Utilities.Color.hex "fff0f5" |> CSSColor
    static member lawnGreen = Utilities.Color.hex "7cfc00" |> CSSColor
    static member lemonChiffon = Utilities.Color.hex "fffacd" |> CSSColor
    static member lightBlue = Utilities.Color.hex "add8e6" |> CSSColor
    static member lightCoral = Utilities.Color.hex "f08080" |> CSSColor
    static member lightCyan = Utilities.Color.hex "e0ffff" |> CSSColor
    static member lightGoldenrodYellow = Utilities.Color.hex "fafad2" |> CSSColor
    static member lightGray = Utilities.Color.hex "d3d3d3" |> CSSColor
    static member lightGreen = Utilities.Color.hex "90ee90" |> CSSColor
    static member lightGrey = Utilities.Color.hex "d3d3d3" |> CSSColor
    static member lightPink = Utilities.Color.hex "ffb6c1" |> CSSColor
    static member lightSalmon = Utilities.Color.hex "ffa07a" |> CSSColor
    static member lightSeaGreen = Utilities.Color.hex "20b2aa" |> CSSColor
    static member lightSkyBlue = Utilities.Color.hex "87cefa" |> CSSColor
    static member lightSlateGrey = Utilities.Color.hex "778899" |> CSSColor
    static member lightSteelBlue = Utilities.Color.hex "b0c4de" |> CSSColor
    static member lightYellow = Utilities.Color.hex "ffffe0" |> CSSColor
    static member limeGreen = Utilities.Color.hex "32cd32" |> CSSColor
    static member linen = Utilities.Color.hex "faf0e6" |> CSSColor
    static member magenta = Utilities.Color.hex "ff00ff" |> CSSColor
    static member mediumAquamarine = Utilities.Color.hex "66cdaa" |> CSSColor
    static member mediumBlue = Utilities.Color.hex "0000cd" |> CSSColor
    static member mediumOrchid = Utilities.Color.hex "ba55d3" |> CSSColor
    static member mediumPurple = Utilities.Color.hex "9370db" |> CSSColor
    static member mediumSeaGreen = Utilities.Color.hex "3cb371" |> CSSColor
    static member mediumSlateBlue = Utilities.Color.hex "7b68ee" |> CSSColor
    static member mediumSpringGreen = Utilities.Color.hex "00fa9a" |> CSSColor
    static member mediumTurquoise = Utilities.Color.hex "48d1cc" |> CSSColor
    static member mediumVioletRed = Utilities.Color.hex "c71585" |> CSSColor
    static member midnightBlue = Utilities.Color.hex "191970" |> CSSColor
    static member mintCream = Utilities.Color.hex "f5fffa" |> CSSColor
    static member mistyRose = Utilities.Color.hex "ffe4e1" |> CSSColor
    static member moccasin = Utilities.Color.hex "ffe4b5" |> CSSColor
    static member navajoWhite = Utilities.Color.hex "ffdead" |> CSSColor
    static member oldLace = Utilities.Color.hex "fdf5e6" |> CSSColor
    static member olivedrab = Utilities.Color.hex "6b8e23" |> CSSColor
    static member orangeRed = Utilities.Color.hex "ff4500" |> CSSColor
    static member orchid = Utilities.Color.hex "da70d6" |> CSSColor
    static member paleGoldenrod = Utilities.Color.hex "eee8aa" |> CSSColor
    static member paleGreen = Utilities.Color.hex "98fb98" |> CSSColor
    static member paleTurquoise = Utilities.Color.hex "afeeee" |> CSSColor
    static member paleVioletred = Utilities.Color.hex "db7093" |> CSSColor
    static member papayaWhip = Utilities.Color.hex "ffefd5" |> CSSColor
    static member peachpuff = Utilities.Color.hex "ffdab9" |> CSSColor
    static member peru = Utilities.Color.hex "cd853f" |> CSSColor
    static member pink = Utilities.Color.hex "ffc0cb" |> CSSColor
    static member plum = Utilities.Color.hex "dda0dd" |> CSSColor
    static member powderBlue = Utilities.Color.hex "b0e0e6" |> CSSColor
    static member rosyBrown = Utilities.Color.hex "bc8f8f" |> CSSColor
    static member royalBlue = Utilities.Color.hex "4169e1" |> CSSColor
    static member saddleBrown = Utilities.Color.hex "8b4513" |> CSSColor
    static member salmon = Utilities.Color.hex "fa8072" |> CSSColor
    static member sandyBrown = Utilities.Color.hex "f4a460" |> CSSColor
    static member seaGreen = Utilities.Color.hex "2e8b57" |> CSSColor
    static member seaShell = Utilities.Color.hex "fff5ee" |> CSSColor
    static member sienna = Utilities.Color.hex "a0522d" |> CSSColor
    static member skyBlue = Utilities.Color.hex "87ceeb" |> CSSColor
    static member slateBlue = Utilities.Color.hex "6a5acd" |> CSSColor
    static member slateGray = Utilities.Color.hex "708090" |> CSSColor
    static member snow = Utilities.Color.hex "fffafa" |> CSSColor
    static member springGreen = Utilities.Color.hex "00ff7f" |> CSSColor
    static member steelBlue = Utilities.Color.hex "4682b4" |> CSSColor
    static member tan = Utilities.Color.hex "d2b48c" |> CSSColor
    static member thistle = Utilities.Color.hex "d8bfd8" |> CSSColor
    static member tomato = Utilities.Color.hex "ff6347" |> CSSColor
    static member turquoise = Utilities.Color.hex "40e0d0" |> CSSColor
    static member violet = Utilities.Color.hex "ee82ee" |> CSSColor
    static member wheat = Utilities.Color.hex "f5deb3" |> CSSColor
    static member whiteSmoke = Utilities.Color.hex "f5f5f5" |> CSSColor
    static member yellowGreen = Utilities.Color.hex "9acd32" |> CSSColor
    static member rebeccaPurple = Utilities.Color.hex "663399" |> CSSColor
    static member transparent = Utilities.Color.rgba 0 0 0 0.0 |> CSSColor
    static member currentColor = "currentColor" |> CSSColor
    static member Rgb (r: int, g: int, b: int) = Utilities.Color.rgb r g b |> CSSColor
    static member Rgba (r: int, g: int, b: int, a: float) = Utilities.Color.rgba r g b a |> CSSColor
    static member Hex (value: string) = Utilities.Color.hex value |> CSSColor
    static member Hsl (h: int, s: float, l: float) = Utilities.Color.hsl h s l |> CSSColor
    static member Hsla (h: int, s: float, l: float, a: float) = Utilities.Color.hsla h s l a |> CSSColor

module CSSColorValue =
    open CSSColor
    let color (CSSColor c) = c