---
uid: A.TwoWayBinding
title: TwoWayBinding
---
# Blazor MDC's Two Way Binding Approach

Blazor MDC takes an unusual approach to two way binding and rendering. Most components return `ShouldRender() => false;`. This is
to resolve an inherent conflict between how Blazor re-renders components when bound parameters are updated by their consumers and
how a JavaScript framework such as [Material Components Web ("MCW")](https://github.com/material-components/material-components-web) works.

In a pure Blazor world, Blazor takes care of rendering and re-rendering for you. In doing so it overwrites the relevant part of the
DOM. In a pure Material Theme world on the other hand, you mark your page up once and then call some initiation JavaScript on your
material web components, from which point Material Theme manipulates the DOM with user interaction. Let's consider an empty text field.

This article explains how Blazor's natural rendering mechanism and MCW are in contention and what we do to manage
this gracefully.

## How MCW Manipulates the DOM

Consider an empty outlined text field before and after a user gives it focus as below. Note how the label floats up and how both it and
the border gain color:

<img src="../images/text-field-focus.png" alt="Text Field Gaining Focus"></img>

The text field's markup however has three distinct state. First what any app environment (including your app using Blazor MDC) marks
up in a page, then what this becomes once the text field has been initiated and manipulated by MCW and lastly 
how its state after receiving focus. The transition between the last two is animated by MCW.

1. Uninitiated markup
    ```html
    <label class="mdc-text-field mdc-text-field--outlined" >
        <input id="my-text-field" class="mdc-text-field__input" type="text" aria-label="Outlined Style">
        <span class="mdc-notched-outline">
            <span class="mdc-notched-outline__leading"></span>
            <span class="mdc-notched-outline__notch">
                <span class="mdc-floating-label " for="my-text-field">Outlined Style</span>
            </span>
            <span class="mdc-notched-outline__trailing"></span>
        </span>
    </label>
    ```
2. Markup post initiation - *all changes made by MCW*
    ```html
    <label class="mdc-text-field mdc-text-field--outlined">
        <input id="my-text-field" class="mdc-text-field__input" type="text" aria-label="Outlined Style">
        <span class="mdc-notched-outline mdc-notched-outline--upgraded">
            <span class="mdc-notched-outline__leading"></span>
            <span class="mdc-notched-outline__notch">
                <span class="mdc-floating-label " for="my-text-field" style>Outlined Style</span>
            </span>
            <span class="mdc-notched-outline__trailing"></span>
        </span>
    </label>
    ```
3. Markup with focus - *all changes made by MCW*
    ```html
    <label class="mdc-text-field mdc-text-field--outlined mdc-text-field--focused mdc-text-field--label-floating">
        <input id="my-text-field" class="mdc-text-field__input" type="text" aria-label="Outlined Style">
        <span class="mdc-notched-outline mdc-notched-outline--upgraded mdc-notched-outline--notched">
            <span class="mdc-notched-outline__leading"></span>
            <span class="mdc-notched-outline__notch">
                <span class="mdc-floating-label mdc-floating-label--float-above" for="my-text-field" style="width: 87.5px;">Outlined Style</span>
            </span>
            <span class="mdc-notched-outline__trailing"></span>
        </span>
    </label>
    ```

What we see from this is that if Blazor MDC were to allow Blazor to re-render, this would be with markup similar to 1. above and
MCW will then fail to manipulate the DOM correctly thereafter - we know this because we tried.

## Handling Two Way Binding

When we first identified this issue during Blazor MDC's development we realized that our Blazor code needed to first render a
new component and then immediately after initiating it step out of MCW's way by applying `ShouldRender() => false;` 
in `InputComponentFoundation`. To begin with this is all we did and so subsequent attempts by the consumer (your project) 
to update Value were ignored, which is an unacceptable result. Fortunately each MCW component has a rich 
JavaScript library that includes both the ability to set a value in the future and to be notified of that value being changed by 
the user. We make use of this in our two way binding for the `Value` parameter, and do something similar for the `Disabled` 
parameter.

The principle is like this:

<img src="../images/two-way-bind-flow.png" alt="Two Way Binding Flow"></img>

Each component inheriting from `InputComponentFoundation` implements this mechanism separately calling the JavaScript provided
by MCW for that component:

- Overrides `OnValueSet` from `InputComponentFoundation` to call the relevant MCW code via JSInterop;
- Registers a JSInterop callback with MCW for notification of value changes;
- Overrides `OnDisabledSet` from `ComponentFoundation` for to either call MCW via JSInterop to set the disabled state or to do so directly via Blazor binding as relevant; and
- *Does not* bind Value to any elements in the razor markup.

Without this careful mechanism Blazor and MCW can enter an infinite positive feedback loop of values bouncing from current to previous value.

## Debouncing

One last thing. We noticed that in some situations Blazor bounces two way bound values - this has been noted in an 
[ASP.NET GitHub Issue](https://github.com/dotnet/aspnetcore/issues/22159). We have found that before calling a component's
`OnValueSet` override, we need a 1 millisecond debounce in `InputComponentFoundation` to prevent another infinite positive 
feedback bounce loop.