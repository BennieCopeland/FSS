﻿namespace Fss

open Fable.Core
open Fable.Core.JsInterop

open Types
open Utilities.Helpers
open Property
open Animation
open Selector
open BackgroundImage
open Padding
open Media
open TextOverflow
open Opacity
open Position
open Cursor
open Time

[<AutoOpen>]
module Value = 
    [<Import("css", from="emotion")>]
    let private css(x) = jsNative
    let css' x = css(x) 

    type CSSProperty =
        | Selector  of Selector * CSSProperty list

        | Media    of MediaFeature list * CSSProperty list
        | MediaFor of Device * MediaFeature list * CSSProperty list

        | Label of string

        | Color of IColor

        | BackgroundColor       of IColor
        | BackgroundImage       of BackgroundImage
        | BackgroundPosition    of IBackgroundPosition
        | BackgroundPositions   of IBackgroundPosition list
        | BackgroundOrigin      of IBackgroundOrigin
        | BackgroundClip        of IBackgroundClip
        | BackgroundRepeat      of IBackgroundRepeat
        | BackgroundRepeats     of IBackgroundRepeat list
        | BackgroundSize        of IBackgroundSize
        | BackgroundSizes       of IBackgroundSize list
        | BackgroundAttachment  of IBackgroundAttachment
        | BackgroundAttachments of IBackgroundAttachment list

        | Hover of CSSProperty list

        | FontSize              of IFontSize
        | FontStyle             of IFontStyle
        | FontWeight            of IFontWeight
        | FontStretch           of IFontStretch
        | LineHeight            of ILineHeight
        | FontFamily            of IFontFamily
        | FontFamilies          of IFontFamily list
        | FontFeatureSetting    of IFontFeatureSetting
        | FontFeatureSettings   of IFontFeatureSetting list
        | FontVariantNumeric    of IFontVariantNumeric
        | FontVariantNumerics   of IFontVariantNumeric list
        | FontVariantCaps       of IFontVariantCaps
        | FontVariantEastAsian  of IFontVariantEastAsian
        | FontVariantEastAsians of IFontVariantEastAsian list
        | FontVariantLigatures  of IFontVariantLigatures

        | TextAlign               of ITextAlign
        | TextDecorationLine      of ITextDecorationLine
        | TextDecorationLines     of ITextDecorationLine list
        | TextDecorationColor     of IColor
        | TextDecorationThickness of ITextDecorationThickness
        | TextDecorationStyle     of ITextDecorationStyle
        | TextDecorationSkipInk   of ITextDecorationSkipInk
        | TextTransform           of ITextTransform
        | TextIndent              of ITextIndent
        | TextIndents             of ITextIndent list
        | TextShadow              of ITextShadow
        | TextShadows             of ITextShadow list
        | TextOverflow            of TextOverflow

        | BorderStyle       of IBorderStyle
        | BorderStyles      of IBorderStyle list
        | BorderWidth       of IBorderWidth
        | BorderWidths      of IBorderWidth list
        | BorderTopWidth    of IBorderWidth
        | BorderRightWidth  of IBorderWidth
        | BorderBottomWidth of IBorderWidth
        | BorderLeftWidth   of IBorderWidth

        | BorderRadius              of ISize
        | BorderRadiuses            of ISize list
        | BorderTopLeftRadius       of ISize
        | BorderTopLeftRadiuses     of ISize list
        | BorderTopRightRadius      of ISize
        | BorderTopRightRadiuses    of ISize list
        | BorderBottomRightRadius   of ISize
        | BorderBottomRightRadiuses of ISize list
        | BorderBottomLeftRadius    of ISize
        | BorderBottomLeftRadiuses  of ISize list

        | BorderColor       of IColor 
        | BorderColors      of IColor list
        | BorderTopColor    of IColor
        | BorderRightColor  of IColor 
        | BorderBottomColor of IColor
        | BorderLeftColor   of IColor

        | Width       of IContentSize
        | MinWidth    of IContentSize
        | MaxWidth    of IContentSize
        | Height      of IContentSize
        | MinHeight   of IContentSize
        | MaxHeight   of IContentSize

        | Perspective of ISize

        | Display        of IDisplay
        | FlexDirection  of IFlexDirection
        | FlexWrap       of IFlexWrap
        | JustifyContent of IJustifyContent
        | AlignItems     of IAlignItems
        | AlignContent   of IAlignContent
        | Order          of IOrder
        | FlexGrow       of IFlexGrow
        | FlexShrink     of IFlexShrink
        | FlexBasis      of IFlexBasis
        | AlignSelf      of IAlignSelf
        | VerticalAlign  of IVerticalAlign
        | Visibility     of IVisibility
        | Opacity        of Opacity
        | Position       of Position

        | MarginTop    of IMargin
        | MarginRight  of IMargin
        | MarginBottom of IMargin
        | MarginLeft   of IMargin
        | Margin       of IMargin 
        | Margins      of IMargin list

        | PaddingTop    of IPadding
        | PaddingRight  of IPadding
        | PaddingBottom of IPadding
        | PaddingLeft   of IPadding
        | Padding       of IPadding 
        | Paddings      of IPadding list

        | Animation                of IAnimation list  
        | Animations               of IAnimation list list
        | AnimationName            of IAnimation
        | AnimationNames           of IAnimation list
        | AnimationDuration        of Time
        | AnimationDurations       of Time list
        | AnimationTimingFunction  of Timing
        | AnimationTimingFunctions of Timing list
        | AnimationDelay           of Time
        | AnimationDelays          of Time list
        | AnimationIterationCount  of IterationCount
        | AnimationIterationCounts of IterationCount list
        | AnimationDirection       of Direction
        | AnimationDirections      of Direction list
        | AnimationFillMode        of FillMode
        | AnimationFillModes       of FillMode list
        | AnimationPlayState       of PlayState
        | AnimationPlayStates      of PlayState list

        | Transform       of ITransform
        | Transforms      of ITransform list
        | TransformOrigin of ITransformOrigin list

        | Transition               of ITransition
        | Transitions              of ITransition list
        | TransitionDelay          of Time
        | TransitionDuration       of Time
        | TransitionProperty       of Property
        | TransitionTimingFunction of Timing

        | Cursor of Cursor

    let combineAnimationNames (list: IAnimation list): string = list |> List.map string |> String.concat ", "
    let combineAnimations (list: IAnimation list list): string = combineComma list (fun a -> combineWs a Animation.value)

    let rec createCSSObject (attributeList: CSSProperty list) = 
        attributeList
        |> List.map (
            function
                | Selector (s, ss)    -> Selector.value s ==> createCSSObject ss

                | Media    (f, p)     -> sprintf "@media %s" <| Media.featureLabel f                         ==> createCSSObject p
                | MediaFor (d, f, p)  -> sprintf "@media %s %s" (Media.deviceLabel d) (Media.featureLabel f) ==> createCSSObject p

                | Label l            -> Property.value label ==> l
                
                | Color c            -> Property.value color ==> Color.value c
                
                | BackgroundColor       bc -> Property.value backgroundColor      ==> Color.value bc
                | BackgroundImage       bi -> Property.value backgroundImage      ==> BackgroundImage.value bi
                | BackgroundPosition    b  -> Property.value backgroundPosition   ==> BackgroundPosition.value b
                | BackgroundPositions   bs -> Property.value backgroundPosition   ==> combineWs bs BackgroundPosition.value
                | BackgroundOrigin      b  -> Property.value backgroundOrigin     ==> BackgroundOrigin.value b
                | BackgroundClip        b  -> Property.value backgroundClip       ==> BackgroundClip.value b
                | BackgroundRepeat      b  -> Property.value backgroundRepeat     ==> BackgroundRepeat.value b
                | BackgroundRepeats     bs -> Property.value backgroundRepeat     ==> combineWs bs BackgroundRepeat.value
                | BackgroundSize        b  -> Property.value backgroundSize       ==> BackgroundSize.value b
                | BackgroundSizes       bs -> Property.value backgroundSize       ==> combineWs bs BackgroundSize.value
                | BackgroundAttachment  b  -> Property.value backgroundAttachment ==> BackgroundAttachment.value b
                | BackgroundAttachments bs -> Property.value backgroundAttachment ==> combineWs bs BackgroundAttachment.value
                
                | Hover h -> hover |> Property.value |> toPsuedo ==> createCSSObject h
                
                | FontSize              f  -> Property.value fontSize             ==> FontSize.value f
                | FontStyle             f  -> Property.value fontStyle            ==> FontStyle.value f
                | FontStretch           f  -> Property.value fontStretch          ==> FontStretch.value f
                | FontWeight            f  -> Property.value fontWeight           ==> FontWeight.value f
                | LineHeight            l  -> Property.value lineHeight           ==> LineHeight.value l
                | FontFamily            f  -> Property.value fontFamily           ==> FontFamily.value f
                | FontFamilies          fs -> Property.value fontFamily           ==> combineWs fs FontFamily.value
                | FontFeatureSetting    f  -> Property.value fontFeatureSettings  ==> FontFeatureSetting.value f
                | FontFeatureSettings   fs -> Property.value fontFeatureSettings  ==> combineComma fs FontFeatureSetting.value
                | FontVariantNumeric    f  -> Property.value fontVariantNumeric   ==> FontVariantNumeric.value f
                | FontVariantNumerics   fs -> Property.value fontVariantNumeric   ==> combineWs fs FontVariantNumeric.value
                | FontVariantCaps       f  -> Property.value fontVariantCaps      ==> FontVariantCaps.value f
                | FontVariantEastAsian  f  -> Property.value fontVariantEastAsian ==> FontVariantEastAsian.value f
                | FontVariantEastAsians fs -> Property.value fontVariantEastAsian ==> combineWs fs FontVariantEastAsian.value
                | FontVariantLigatures  f  -> Property.value fontVariantLigatures ==> FontVariantLigatures.value f

                | TextAlign               t  -> Property.value textAlign               ==> TextAlign.value t
                | TextDecorationLine      t  -> Property.value textDecorationLine      ==> TextDecorationLine.value t
                | TextDecorationLines     ts -> Property.value textDecorationLine      ==> combineWs ts TextDecorationLine.value
                | TextDecorationColor     t  -> Property.value textDecorationColor     ==> Color.value t
                | TextDecorationThickness t  -> Property.value textDecorationThickness ==> TextDecorationThickness.value t
                | TextDecorationStyle     t  -> Property.value textDecorationStyle     ==> TextDecorationStyle.value t 
                | TextDecorationSkipInk   t  -> Property.value textDecorationSkipInk   ==> TextDecorationSkipInk.value t 
                | TextTransform           t  -> Property.value textTransform           ==> TextTransform.value t
                | TextIndent              t  -> Property.value textIndent              ==> TextIndent.value t
                | TextIndents             ts -> Property.value textIndent              ==> combineWs ts TextIndent.value
                | TextShadow              t  -> Property.value textShadow              ==> TextShadow.value t
                | TextShadows             ts -> Property.value textShadow              ==> combineComma ts TextShadow.value
                | TextOverflow            t  -> Property.value textOverflow            ==> TextOverflow.value t

                | BorderStyle  bs  -> Property.value borderStyle ==> BorderStyle.value bs
                | BorderStyles bss -> Property.value borderStyle ==> combineWs bss BorderStyle.value

                | BorderWidth       bw  -> Property.value borderWidth       ==> BorderWidth.value bw
                | BorderWidths      bws -> Property.value borderWidth       ==> combineWs bws BorderWidth.value
                | BorderTopWidth    bw  -> Property.value borderTopWidth    ==> BorderWidth.value bw
                | BorderRightWidth  bw  -> Property.value borderRightWidth  ==> BorderWidth.value bw
                | BorderBottomWidth bw  -> Property.value borderBottomWidth ==> BorderWidth.value bw
                | BorderLeftWidth   bw  -> Property.value borderLeftWidth   ==> BorderWidth.value bw
               
                | BorderRadius              br -> Property.value borderRadius            ==> Units.Size.value br
                | BorderRadiuses            br -> Property.value borderRadius            ==> combineWs br Units.Size.value
                | BorderTopLeftRadius       br -> Property.value borderTopLeftRadius     ==> Units.Size.value br
                | BorderTopLeftRadiuses     br -> Property.value borderTopLeftRadius     ==> combineWs br Units.Size.value
                | BorderTopRightRadius      br -> Property.value borderTopRightRadius    ==> Units.Size.value br
                | BorderTopRightRadiuses    br -> Property.value borderTopRightRadius    ==> combineWs br Units.Size.value
                | BorderBottomRightRadius   br -> Property.value borderBottomRightRadius ==> Units.Size.value br
                | BorderBottomRightRadiuses br -> Property.value borderBottomRightRadius ==> combineWs br Units.Size.value
                | BorderBottomLeftRadius    br -> Property.value borderBottomLeftRadius  ==> Units.Size.value br
                | BorderBottomLeftRadiuses  br -> Property.value borderBottomLeftRadius  ==> combineWs br Units.Size.value

                | BorderColor       bc  -> Property.value borderColor       ==> Color.value bc
                | BorderColors      bcs -> Property.value borderColor       ==> combineWs bcs Color.value
                | BorderTopColor    bc  -> Property.value borderTopColor    ==> Color.value bc
                | BorderRightColor  bc  -> Property.value borderRightColor  ==> Color.value bc
                | BorderBottomColor bc  -> Property.value borderBottomColor ==> Color.value bc
                | BorderLeftColor   bc  -> Property.value borderLeftColor   ==> Color.value bc

                | Width     w -> Property.value width     ==> ContentSize.value w
                | MinWidth  w -> Property.value minWidth  ==> ContentSize.value w
                | MaxWidth  w -> Property.value maxWidth  ==> ContentSize.value w
                | Height    h -> Property.value height    ==> ContentSize.value h
                | MinHeight h -> Property.value minHeight ==> ContentSize.value h
                | MaxHeight h -> Property.value maxHeight ==> ContentSize.value h

                | Perspective p -> Property.value perspective ==> Units.Size.value p

                | Display        d -> Property.value display        ==> Display.value d
                | FlexDirection  f -> Property.value flexDirection  ==> FlexDirection.value f
                | FlexWrap       f -> Property.value flexWrap       ==> FlexWrap.value f
                | FlexBasis      f -> Property.value flexBasis      ==> FlexBasis.value f
                | JustifyContent j -> Property.value justifyContent ==> JustifyContent.value j
                | AlignItems     a -> Property.value alignItems     ==> AlignItems.value a
                | AlignContent   a -> Property.value alignContent   ==> AlignContent.value a
                | Order          o -> Property.value order          ==> Order.value o
                | FlexGrow       f -> Property.value flexGrow       ==> FlexGrow.value f
                | FlexShrink     f -> Property.value flexShrink     ==> FlexShrink.value f
                | AlignSelf      a -> Property.value alignSelf      ==> AlignSelf.value a
                | VerticalAlign  v -> Property.value verticalAlign  ==> VerticalAlign.value v
                | Visibility     v -> Property.value visibility     ==> Visibility.value v
                | Opacity        o -> Property.value opacity        ==> Opacity.value o
                | Position       p -> Property.value position       ==> Position.value p

                | MarginTop    m  -> Property.value marginTop    ==> Margin.value m
                | MarginRight  m  -> Property.value marginRight  ==> Margin.value m
                | MarginBottom m  -> Property.value marginBottom ==> Margin.value m
                | MarginLeft   m  -> Property.value marginLeft   ==> Margin.value m
                | Margin       m  -> Property.value margin       ==> Margin.value m
                | Margins      ms -> Property.value margin       ==> combineWs ms Margin.value

                | PaddingTop    m  -> Property.value paddingTop    ==> Padding.value m
                | PaddingRight  m  -> Property.value paddingRight  ==> Padding.value m
                | PaddingBottom m  -> Property.value paddingBottom ==> Padding.value m
                | PaddingLeft   m  -> Property.value paddingLeft   ==> Padding.value m
                | Padding       m  -> Property.value padding       ==> Padding.value m
                | Paddings      ms -> Property.value padding       ==> combineWs ms Padding.value

                | Animation                a   -> Property.value animation               ==> combineWs a Animation.value
                | Animations               ans -> Property.value animation               ==> combineAnimations ans
                | AnimationName            n   -> Property.value animationName           ==> string n
                | AnimationNames           ns  -> Property.value animationName           ==> combineAnimationNames ns
                | AnimationDuration        d   -> Property.value animationDuration       ==> Animation.value d
                | AnimationDurations       ds  -> Property.value animationDuration       ==> combineComma ds Animation.value
                | AnimationTimingFunction  t   -> Property.value animationTimingFunction ==> Animation.value t
                | AnimationTimingFunctions ts  -> Property.value animationTimingFunction ==> combineComma ts Animation.value
                | AnimationDelay           d   -> Property.value animationDelay          ==> Animation.value d
                | AnimationDelays          ds  -> Property.value animationDelay          ==> combineComma ds Animation.value
                | AnimationIterationCount  i   -> Property.value animationIterationCount ==> Animation.value i
                | AnimationIterationCounts is  -> Property.value animationIterationCount ==> combineComma is Animation.value
                | AnimationDirection       d   -> Property.value animationDirection      ==> Animation.value d
                | AnimationDirections      ds  -> Property.value animationDirection      ==> combineComma ds Animation.value
                | AnimationFillMode        f   -> Property.value animationFillMode       ==> Animation.value f
                | AnimationFillModes       fs  -> Property.value animationFillMode       ==> combineComma fs Animation.value
                | AnimationPlayState       p   -> Property.value animationPlayState      ==> Animation.value p
                | AnimationPlayStates      ps  -> Property.value animationPlayState      ==> combineComma ps Animation.value

                | Transform       t  -> Property.value transform       ==> Transform.value t
                | Transforms      ts -> Property.value transform       ==> combineWs ts Transform.value
                | TransformOrigin ts -> Property.value transformOrigin ==> combineWs ts TransformOrigin.value

                | Transition               t  -> Property.value transition               ==> Transition.value t
                | Transitions              ts -> Property.value transition               ==> combineComma ts Transition.value
                | TransitionDelay          t  -> Property.value transitionDelay          ==> Animation.value t
                | TransitionDuration       t  -> Property.value transitionDuration       ==> Animation.value t
                | TransitionProperty       t  -> Property.value transitionProperty       ==> Property.value t
                | TransitionTimingFunction t  -> Property.value transitionTimingFunction ==> Animation.value t

                | Cursor c -> Property.value cursor ==> Cursor.value c
        )
        |> createObj