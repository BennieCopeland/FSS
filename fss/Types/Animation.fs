namespace Fss

namespace Fss.FssTypes

open Fss.FssTypes

// https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction
[<RequireQualifiedAccess>]
module Animation =
    type Direction =
        | Normal
        | Reverse
        | Alternate
        | AlternateReverse
        interface ICssValue with
            member this.Stringify() =
                Fss.Utilities.Helpers.toKebabCase this

    type Step = TimingFunction.Step

    type FillMode =
        | Forwards
        | Backwards
        | Both
        interface ICssValue with
            member this.Stringify() =
                this.ToString().ToLower()
        
    type IterationCount =
        | Infinite
        interface ICssValue with
            member this.Stringify() = "infinite"
        
    type PlayState =
        | Running
        | Paused
        interface ICssValue with
            member this.Stringify() =
                this.ToString().ToLower()
            
    [<RequireQualifiedAccess>]
    module AnimationClasses =
        // https://developer.mozilla.org/en-US/docs/Web/CSS/animation-delay
        // https://developer.mozilla.org/en-US/docs/Web/CSS/animation-duration
        type AnimationTime(property) =
            inherit CssRuleWithValueFunctions<Time>(property, ", ")

        // https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction
        type AnimationDirection(property) =
            inherit CssRuleWithValueFunctions<Direction>(property, ", ")

            member this.normal = (property, Normal) |> Rule
            member this.reverse = (property, Reverse) |> Rule
            member this.alternate = (property, Alternate) |> Rule
            member this.alternateReverse = (property, AlternateReverse) |> Rule

        // https://developer.mozilla.org/en-US/docs/Web/CSS/animation-fill-mode
        type AnimationFillMode(property) =
            inherit CssRuleWithValueFunctions<FillMode>(property, ", ")
            member this.none = (property, None') |> Rule
            member this.forwards = (property, Forwards) |> Rule
            member this.backwards = (property, Backwards) |> Rule
            member this.both = (property, Both) |> Rule
        // https://developer.mozilla.org/en-US/docs/Web/CSS/animation-iteration-count
        type AnimationIterationCount(property) =
            inherit CssRule(property)

            member this.value(iterationCount: float) =
                (property, iterationCount |> Float) |> Rule

            member this.infinite = (property, Infinite) |> Rule
        // https://developer.mozilla.org/en-US/docs/Web/CSS/animation-name
        type AnimationName(property) =
            inherit CssRule(property)
            member this.value(name: string) =
                (property, name |> String) |> Rule
            member this.value(names: string list) =
                let names =
                    String.concat ", " names
                (property, names |> String) |> Rule

        // https://developer.mozilla.org/en-US/docs/Web/CSS/animation-play-state
        type AnimationPlayState(property) =
            inherit CssRuleWithValueFunctions<PlayState>(property, ", ")
            member this.running = (property, Running) |> Rule
            member this.paused = (property, Paused) |> Rule

        // https://developer.mozilla.org/en-US/docs/Web/CSS/animation-timing-function
        type AnimationTimingFunction(property) =
            inherit CssRuleWithValueFunctions<TimingFunction.Timing>(property, ", ")

            member this.ease = (property, TimingFunction.Ease) |> Rule

            member this.easeIn =
                (property, TimingFunction.EaseIn) |> Rule

            member this.easeOut =
                (property, TimingFunction.EaseOut) |> Rule

            member this.easeInOut =
                (property, TimingFunction.EaseInOut) |> Rule

            member this.linear =
                (property, TimingFunction.Linear) |> Rule

            member this.stepStart =
                (property, TimingFunction.StepStart) |> Rule

            member this.stepEnd =
                (property, TimingFunction.StepEnd) |> Rule

            member this.cubicBezier(a: float, b: float, c: float, d: float) =
                (property, TimingFunction.CubicBezier(a, b, c, d))
                |> Rule

            member this.step(steps: int) =
                (property, TimingFunction.Steps steps) |> Rule

            member this.step(steps: int, stepType: TimingFunction.Step) =
                (property, TimingFunction.StepsWithTerm(steps, stepType))
                |> Rule
