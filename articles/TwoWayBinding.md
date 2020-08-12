---
uid: A.TwoWayBinding
title: TwoWayBinding
---
# Blazor MDC's Two Way Binding Approach

Blazor MDC takes an unusual approach to two way binding and rendering. Most components return `ShouldRender() => false;`. This is
to resolve an inherent conflict between how Blazor re-renders components when bound parameters are updated by their consumers and
how a JavaScript framework such as Material Theme works.

In a pure Blazor world, Blazor takes care of rendering and re-rendering for you. In doing so it overwrites the relevant part of the
DOM. In a pure Material Theme world on the other hand, you mark your page up once and then call some initiation JavaScript on your
material web components, from which point Material Theme manipulates the DOM with user interaction. Let's consider an empty text field.

##

two-way-bind-flow