## Fss.Core

## Installation

```
# nuget
dotnet add package Fss.Core
```

## Usage

This library is ment to be a building block you can use to create framework or project specific CSS functions with.
The core library was designed to provide the functionality you need to generate any type of CSS.

`Fss.Core` provides these functions:

- `CreateFss: Rule list -> ClassName * (ClassName * Css) list`
    
  - This is the function you want to use most of the time.
      It takes a list of Rules and produces a tuple with two elements.
      The first being the classname you want to give to your HTML element.
      The second is a list of classname and CSS tuples, where each element in the list is the
      classname itself and the CSS it corresponds to. This list is what you want to inject into the dom.

- `CreateGlobal: Rule list -> (ClassName * Css) list`
  - A helper function that returns a classname and CSS which is made as a global style.
  Inject this into the dom.

- `CreateCounterStyle: CounterRule list -> CounterName * CounterStyle`
  - Creates counter styles. Takes a different type as input than the normal createFss function so
  they cannot conflict. Returns a tuple containing the name of the counter and the styles themselves.
  These should be injected into the dom. The counter name should also be returned so it can be used.

- `CreateAnimation: Keyframes list -> AnimationName * Css`
    - Creates an animation. Takes a list of keyframes as inputs. Each keyframe takes a list of Rules. 
      Returns a tuple containing the name of the animation and the styles themselves.
      These should be injected into the dom. The animation name should also be returned so it can be used.

- `CreateFontFace: string -> FontFaceRule list -> FontName * FontFaceStyle`
  - Creates a single font face. Takes a different type than the normal createFss function so the
    cannot conflict. Returns a tuple containing the name of the font face and the styles themselves.
    These should be injected into the dom. The font name should also be returned so it can be used.

- `CreateFontFaces: string -> FontFaceRule list list -> FontName * FontFaceStyle`
  - The same as the `CreateFontFace` function only you can use it to specify several font faces under the same name.

All of the above functions, apart from font face, also have a sibling function where you can supply a specific classname.
This can be useful, but I recommend using the main create function instead unless you really need
to specify your own names.