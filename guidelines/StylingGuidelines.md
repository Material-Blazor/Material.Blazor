---
uid: G.StylingGuidelines
title: StylingGuidelines
---
# Styling Guidelines

# Razor files

- Arguments to Material.Blazor components broadly to be placed on separate lines in alphabetical order, except:
  - The `@ref` argument have high importance due to their role tying a tag or component to JSInterop, so these are placed first
  - The `@attributes` argument splats generated and unmatched attributes on to tags. Blazor applies attributes on a right to left basis, prioritising the first that it encounters (i.e. the rightmost attribute). As a result the `@attributes` parameter is always VERY CAREFULY PLACED and should never be moved - assume that its placement was considered very carefully.