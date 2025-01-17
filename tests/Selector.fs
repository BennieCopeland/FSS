namespace FSSTests

open Fet
open Utils
open Fss

module SelectorTests =
    let createSelector (ruleList: Fss.Types.Rule list) =
        let className, fss = (createFss ruleList)
        let selector, css =
            fss
            |> List.rev
            |> List.head
        className, $"{selector} {css}"
     
    let tests =
       testList "Selector"
           [
               let className, actual = createSelector [ !+ Fss.Types.Html.All [ Color.blue ] ]
               testEqual
                   "Adjacent sibling 1"
                   actual
                   $".{className} + * {{ color: blue; }}"
               let className, actual = createSelector [ Color.red; !+ Fss.Types.Html.All [ Color.blue ];  ]
               testEqual
                   "Adjacent sibling 2"
                   actual
                   $".{className} + * {{ color: blue; }}"
                   
               let className, actual = createSelector [ !~ Fss.Types.Html.All [ Color.blue ] ]
               testEqual
                   "General sibling 1"
                   actual
                   $".{className} ~ * {{ color: blue; }}"
               let className, actual = createSelector [ Color.red; !~ Fss.Types.Html.All [ Color.blue ];  ]
               testEqual
                   "General sibling 2"
                   actual
                   $".{className} ~ * {{ color: blue; }}"
                   
               let className, actual = createSelector [ !> Fss.Types.Html.All [ Color.blue ] ]
               testEqual
                   "Child 1"
                   actual
                   $".{className} > * {{ color: blue; }}"
               let className, actual = createSelector [ Color.red; !> Fss.Types.Html.All [ Color.blue ];  ]
               testEqual
                   "Child 2"
                   actual
                   $".{className} > * {{ color: blue; }}"
                   
               let className, actual = createSelector [ !  Fss.Types.Html.All [ Color.blue ] ]
               testEqual
                   "Descendant 1"
                   actual
                   $".{className} * {{ color: blue; }}"
               let className, actual = createSelector [ Color.red; !  Fss.Types.Html.All [ Color.blue ]]
               testEqual
                   "Descendant 2" 
                   actual
                   $".{className} * {{ color: blue; }}"
                   
               let className, actual = createSelector [ Color.red; !+ Fss.Types.Html.All [ Hover [ BackgroundColor.aqua ] ]]
               testEqual
                   "Adjacent sibling with pseudo" 
                   actual
                   $".{className} + *:hover {{ background-color: aqua; }}"
               let className, actual = createSelector [ Color.red; !~ Fss.Types.Html.All [ Hover [ BackgroundColor.aqua ] ]]
               testEqual
                   "General sibling with pseudo" 
                   actual
                   $".{className} ~ *:hover {{ background-color: aqua; }}"
               let className, actual = createSelector [ Color.red; !>  Fss.Types.Html.All [ Hover [ BackgroundColor.aqua ] ]]
               testEqual
                   "Child with pseudo" 
                   actual
                   $".{className} > *:hover {{ background-color: aqua; }}"
               let className, actual = createSelector [ Color.red; !  Fss.Types.Html.All [ Hover [ BackgroundColor.aqua ] ]]
               testEqual
                   "Descendant with pseudo" 
                   actual
                   $".{className} *:hover {{ background-color: aqua; }}"
               let className, actual =
                   createSelector [ ! Fss.Types.Html.All [ !> Fss.Types.Html.All [ !+ Fss.Types.Html.All [ !~ Fss.Types.Html.A [ Visited [ Color.white ] ] ] ] ] ]
               testEqual
                   "Descendant with nested selectors" 
                   actual
                   $".{className} * > * + * ~ a:visited {{ color: white; }}"
                   
               let className, actual =
                  createFss [ !+ Fss.Types.Html.All [ BorderColor.green
                                                      Hover [ BorderColor.red ]
                                                      Media.query
                                                         [ Fss.Types.Media.MaxHeight (em 2) ]
                                                         [ Content.value "Query in pseudo" ]
                                      ]]
                  
               let actual =
                  actual
                  |> List.map (fun (x,y) -> $"{x} {y}")
                  |> String.concat ""
                  
              testEqual
                  "adjacent sibling with nested selectors"
                  actual
                  $""".{className} + * {{ border-color: green; }}.{className} + *:hover {{ border-color: red; }}@media (max-height: 2em) {{ .{className} + * {{ content: "Query in pseudo"; }} }}"""
              
           ]