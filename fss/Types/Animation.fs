namespace Fss

namespace Fss.Types
    // https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction
    [<RequireQualifiedAccess>]
    module Animation =
        type Direction =
            | Reverse
            | Alternate
            | AlternateReverse
            interface IAnimationDirection
        type FillMode =
            | Forwards
            | Backwards
            | Both
            interface IAnimationFillMode

        type IterationCount =
            | Infinite
            interface IAnimationIterationCount

        type PlayState =
            | Running
            | Paused
            interface IAnimationPlayState

    [<AutoOpen>]
    module animationHelpers =
        let internal iterationCountToString (iterationCount: IAnimationIterationCount) =
            match iterationCount with
            | :? Animation.IterationCount as i -> "infinite"
            | :? CssInt as i -> IntToString i
            | _ -> "Unknown animation iteration count"