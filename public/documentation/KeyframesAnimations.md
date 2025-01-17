## Animations

Animations introduce 3 new functions:
- `keyframes`: `KeyframeAttribute list -> AnimationName * Css`
- `frame`:  `int -> CSSProperty list -> int * rule list`
- `frames`:  `int list -> rule list -> int list * rule list`

What this means is that keyframes is a function that takes a list of `frame` or `frames` function calls.
`frame` is used when you want to define a single keyframe and `frames` for multiple. keyframes then gives you an animation name you supply to `fss`.

```fsharp
let bounceFrames =
    keyframes [ frames [ 0; 20; 53; 80; 100 ] [
                    Transform.value [ Transform.translate3D (px 0, px 0, px 0) ]
                ]
                frames [ 40; 43 ] [
                    Transform.value [ Transform.translate3D (px 0, px -30, px 0) ]
                ]
                frame 70 [ Transform.value [ Transform.translate3D (px 0, px -15, px 0) ] ]
                frame 90 [ Transform.value [ Transform.translate3D (px 0, px -4, px 0) ] ] ]

let bounceAnimation =
    fss [ Label "Bounce Animation"
          AnimationName.value bounceFrames
          AnimationDuration.value (sec 1.0)
          AnimationTimingFunction.easeInOut
          AnimationIterationCount.infinite ]
```

<example/>

## Transforms

Just a quick note on transforms. In CSS it is easy to think that when you apply a transform CSS expects just one transform.

While it works with one, it is easier to think about transforms as accepting a list of transforms, now this list can have just one element.

This is a mistake I have seen from people who don't know CSS too well (I have made it myself when I was learning), where combining transforms can be a bit of an issue.
The following is an example of this, you might write this and be very puzzled as to why it isn't working.
```css
.myElement {
    transform: rotate(90deg);
    transform: translate(20px,0px);
}
```
When the answer is, as stated above, giving a list of arguments to the transform.
```css
.myElement {
    transform: rotate(90deg) translate(20px,0px);
}
```
Is the correct way to type this.

For these reasons in Fss when you apply transforms it **always** expects a list, but otherwise works as you would expect.
This pattern holds for all similar CSS properties in Fss.

```fsharp
Transform.value
    [
        Transform.rotate (deg 90.)
        Transform.translate (px 20, px 0)
    ]
```
